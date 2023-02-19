using HtmlAgilityPackEx;
using System;
using System.Collections.Generic;

namespace RSSGuardHelper
{
    public static class Parser
    {
        internal static string pageSourceAll;

        internal static Item RunMonoParser(PRJsettings record)
        {
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPackEx.HtmlDocument doc;

            web.UsingCache = false;

            doc = web.Load(record.URL);

            if (Parser.pageSourceAll != null) //catch only on form
                Parser.pageSourceAll += string.Format("##{0}##\r\n{1}\r\n\r\n", record.URL, doc.Text);

            HtmlNode val = doc.DocumentNode.QuerySelector(record.monoElementSelector);

            string pageValue = string.Empty;

            if (val == null)
            {
                pageValue = "Cannot find element" + Convert.ToInt32((DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds).ToString();
            }
            else
            {
                pageValue = val.InnerText;
            }

            return new Item()
            {
                content_html = "",
                date_published = "",
                id = "",
                title = pageValue,
                url = record.URL,
                author = new Author() { name = record.author }
            };

        }


        internal static List<Item> RunListParser(PRJsettings record)
        {
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPackEx.HtmlDocument doc;

            web.UsingCache = false;

            doc = web.Load(record.URL);

            if (Parser.pageSourceAll != null) //catch only on form
                Parser.pageSourceAll += string.Format("##{0}##\r\n{1}\r\n\r\n", record.URL, doc.Text);

            List<Item> x = new List<Item>();
            foreach (HtmlNode row in doc.DocumentNode.QuerySelectorAll(record.parentElementSelector))
            {
                string titleTXT = string.Empty;
                string itemLinkTXT = string.Empty;

                //title
                HtmlNode title = row.QuerySelector(record.titleElementSelector);

                if (title == null)
                    titleTXT = "title not found";
                else
                    titleTXT = title.InnerText;

                //link
                HtmlNode itemLink = row.QuerySelector(record.linkElementSelector);

                if (itemLink == null)
                    itemLinkTXT = "link not found";
                else
                    itemLinkTXT = itemLink.Attributes["href"].Value;

                //HtmlNode descr = row.QuerySelector(record.dede);
                string descrTXT = "";
                //if (descr != null)
                //    descrTXT = descr.InnerText;


                x.Add(new Item()
                {
                    content_html = descrTXT,
                    date_published = "",
                    id = "",
                    title = titleTXT,
                    url = itemLinkTXT,
                    author = new Author() { name = record.author }
                });
            }


            return x;
        }
    }
}
