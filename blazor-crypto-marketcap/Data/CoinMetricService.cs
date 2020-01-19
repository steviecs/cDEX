using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using Json.Net;
using Newtonsoft.Json;

namespace blazor_crypto_marketcap.Data
{
    public class CoinMetricService
    {
        private static string API_KEY = "1dd4128e-cdd1-418d-8907-a547d44d9996";

        public Task<RootObject> GetTopOneHundredCoinsByMarketCap(string sortType = null)
        {
            var URL = new UriBuilder("https://pro-api.coinmarketcap.com/v1/cryptocurrency/listings/latest");

            var queryString = HttpUtility.ParseQueryString(string.Empty);
            queryString["start"] = "1";
            queryString["limit"] = "100";
            if(sortType != null)
            {
                queryString["sort"] = sortType; 
            }

            URL.Query = queryString.ToString();

            var client = new WebClient();
            client.Headers.Add("X-CMC_PRO_API_KEY", API_KEY);
            client.Headers.Add("Accepts", "application/json");

            return Task.FromResult(JsonConvert.DeserializeObject<RootObject>(client.DownloadString(URL.ToString())));
        }
    }
}
