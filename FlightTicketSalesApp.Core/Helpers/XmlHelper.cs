using System.Xml;
using System.Xml.Serialization;

namespace FlightTicketSalesApp.Core.Helpers
{
    public class XmlHelper
    {
        public static TEntity DeserializeXml<TEntity>(string xmlString) where TEntity : class, new()
        {
            //Xml load
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(xmlString);

            xmlDocument.InnerXml = xmlDocument.InnerXml.Replace("<rss xmlns:g=\"http://base.google.com/ns/1.0\" version=\"2.0\">", "").Replace("</rss>", "");

            // Deserialize XML string to object
            var serializer = new XmlSerializer(typeof(TEntity));
            using (TextReader reader = new StringReader(xmlDocument.InnerXml))
            {
                var xmlDealerEtkin = (TEntity)serializer.Deserialize(reader);
                return xmlDealerEtkin;
            }
        }
    }
}
