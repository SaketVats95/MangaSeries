using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MangaSeries.Common
{
    public class MangaURL
    {
        private readonly string URL;
        private XmlDocument xmlDocument;

        //public string MyProperty { get; set; }
        public MangaURL(string URL)
        {
            this.URL = URL; 
        }
        public string GetWebContent() {
            HtmlWeb htmlWeb = new HtmlWeb();
            HtmlDocument htmlDocument = htmlWeb.Load(URL);
            return htmlDocument.DocumentNode.OuterHtml;
        }

        public bool CheckXMLContent(string webResult)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(webResult);
                xmlDocument = xmlDoc;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
           
        }

    }
}
