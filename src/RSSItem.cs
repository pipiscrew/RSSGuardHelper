using System.Collections.Generic;

namespace RSSGuardHelper
{
    //https://www.jsonfeed.org/
    public class Item
    {
        public string id { get; set; }
        public string title { get; set; }
        public string content_html { get; set; }
        public string date_published { get; set; } //DateTime
        public string url { get; set; }
        public Author author { get; set; }
    }

    public class Author
    {
        public string name { get; set; }
    }

    public class RSSItem
    {
        public string version = "https://jsonfeed.org/version/1";
        public string title { get; set; }
        public string icon { get; set; }
        public string home_page_url { get; set; }
        public string feed_url { get; set; }
        public List<Item> items { get; set; }
    }

 
}
