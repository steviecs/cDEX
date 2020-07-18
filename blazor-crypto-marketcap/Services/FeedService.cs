using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace blazor_crypto_marketcap.Data
{
    public class FeedService
    {
        public static IEnumerable<Item> GetFeed()
        {
            CultureInfo culture = new CultureInfo("en-US");
            try
            {
                XDocument doc = XDocument.Load("https://cointelegraph.com/rss");
                var entries = from item in doc.Root.Descendants().First(i => i.Name.LocalName == "channel").Elements().Where(i => i.Name.LocalName == "item")
                              select new Item
                              {
                                  Title = item.Elements().First(i => i.Name.LocalName == "title").Value,
                                  Link2 = item.Elements().First(i => i.Name.LocalName == "link").Value,
                                  PubDate = Convert.ToDateTime(item.Elements().First(i => i.Name.LocalName == "pubDate").Value, culture).ToString("dd-MMM-yyyy"),
                              };

                var sortedEntries = entries.OrderByDescending(o => o.PubDate);
                return sortedEntries;
            }
            catch  
            {  
                List<Item> feeds = new List<Item>();
                Item feed = new Item();
                feeds.Add(feed);

                XmlSerializer serializer = new XmlSerializer(typeof(IEnumerable<Item>));
                StringReader rdr = new StringReader(feeds.ToString());
                IEnumerable<Item> resultingMessage = (IEnumerable<Item>)serializer.Deserialize(rdr);
                return resultingMessage;
            }
        }
    }

}
