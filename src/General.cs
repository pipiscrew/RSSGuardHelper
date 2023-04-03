using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace RSSGuardHelper
{
    public static class General
    {
        internal static List<PRJsettings> db;
        internal static string loadedFilename = string.Empty;

        internal static DialogResult Mes(string descr, MessageBoxIcon icon = MessageBoxIcon.Information, MessageBoxButtons butt = MessageBoxButtons.OK)
        {
            if (descr.Length > 0)
                return MessageBox.Show(descr, Application.ProductName, butt, icon);
            else
                return DialogResult.OK;
        }

        internal static void LoadFile(string filename)
        {
            try
            {
                General.loadedFilename = filename;
                General.db.AddRange(JsonSerializer.Deserialize<List<PRJsettings>>(File.ReadAllText(filename, Encoding.UTF8)));
            }
            catch (Exception x)
            {
                General.loadedFilename = string.Empty;
                General.Mes(x.Message, MessageBoxIcon.Error);
                General.db = new List<PRJsettings>();
            }
        }

        internal static RSSItem ParseFeeds()
        {
            RSSItem x = new RSSItem();
            x.home_page_url = "";
            x.feed_url = "";
            x.icon = "";
            x.title = "sample";
            x.version = "";

            x.items = new List<Item>();

            foreach (PRJsettings item in General.db.Where(q => q.URLactive))
            {
                if (item.isMono)
                {
                    x.items.Add(Parser.RunMonoParser(item));
                }
                else
                {
                    x.items.AddRange(Parser.RunListParser(item));
                }
            }

            return x;
        }

        internal static bool ValidateItemExistance()
        {
            if (General.db == null || General.db.Count == 0)
            {
                General.Mes("This function can be used once there is item(s) on the list");
                return false;
            }
            else
                return true;
        }
    }


}
