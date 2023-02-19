using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace RSSGuardHelper
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //enable TLS *also* TLS v1.2
            System.Net.ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12;

            General.db = new List<PRJsettings>();

            if (args.Length == 1)
            {
                //enable UTF8 to console
                Console.OutputEncoding = Encoding.UTF8;

                try
                {
                    General.LoadFile(args[0]);

                    RSSItem x = General.ParseFeeds();

                    if (x.items.Count > 0)
                    {
                        Console.WriteLine(x.Serialize());

                        System.Environment.Exit(0);
                    }
                    else
                    {
                        throw new ArgumentException("no records found");
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    System.Environment.Exit(-1);
                }
            }
            else
            {
                //show GUI
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmConstructor());
            }
        }
    }
}
