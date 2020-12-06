using System;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using blazor_crypto_marketcap.Pages;
using Newtonsoft.Json;
using static blazor_crypto_marketcap.Data.CoinHistoricalData;

namespace blazor_crypto_marketcap.Data
{
    public class CoinMetricService
    {
        private static string API_KEY = "1dd4128e-cdd1-418d-8907-a547d44d9996";
        private static string API_KEY2 = "8df36f303ab2e288d965f0492f9d79c36e53d2f90603e9035434ec9c426212ea";

        public Task<Coins> GetTopOneHundredCoinsByMarketCap(string sortType = null)
        {
            var URL = new UriBuilder("https://pro-api.coinmarketcap.com/v1/cryptocurrency/listings/latest");

            var queryString = HttpUtility.ParseQueryString(string.Empty);
            queryString["start"] = "1";
            queryString["limit"] = "100";
            if (sortType != null)
            {
                queryString["sort"] = sortType;
                if (Table.CurrentCount % 2 == 0)
                {
                    queryString["sort_dir"] = "asc";
                }
                else
                {
                    queryString["sort_dir"] = "desc";
                }
            }

            URL.Query = queryString.ToString();

            using (var client = new WebClient())
            {
                client.Headers.Add("X-CMC_PRO_API_KEY", API_KEY);
                client.Headers.Add("Accepts", "application/json");

                return Task.FromResult(JsonConvert.DeserializeObject<Coins>(client.DownloadString(URL.ToString())));
            }
        }

        public Task<CoinData> GetHistoricalChartData(string symbol)
        {
            var URL = new UriBuilder("https://min-api.cryptocompare.com/data/v2/histoday");

            var queryString = HttpUtility.ParseQueryString(string.Empty);
            queryString["fsym"] = symbol;
            queryString["tsym"] = "USD";
            queryString["limit"] = "100";
            queryString["aggregate"] = "1";
            queryString["aggregatePredictableTimePeriods"] = "true";
            // queryString["allData"] = "true";

            URL.Query = queryString.ToString();

            var client = new WebClient();
            client.Headers.Add("Apikey", API_KEY2);
            client.Headers.Add("Accepts", "application/json");

            return Task.FromResult(JsonConvert.DeserializeObject<CoinData>(client.DownloadString(URL.ToString())));
        }
    }
}
