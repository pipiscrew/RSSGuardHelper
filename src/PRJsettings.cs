
namespace RSSGuardHelper
{
    public class PRJsettings
    {
        //general
        public string URL { get; set; }
        public bool URLactive { get; set; }
        public string author { get; set; }
        public int elementType { get; set; }

        //condition        
        public string monoElementSelector { get; set; }

        //list
        public string parentElementSelector { get; set; }
        public string titleElementSelector { get; set; }
        public string linkElementSelector { get; set; }
    }
}
