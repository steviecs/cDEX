using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazor_crypto_marketcap.Data
{
    public class CoinHistoricalData
    {
        public class RateLimit
        {
        }

        public class Datum
        {
            public int time { get; set; }
            public double high { get; set; }
            public double low { get; set; }
            public double open { get; set; }
            public double volumefrom { get; set; }
            public double volumeto { get; set; }
            public double close { get; set; }
            public string conversionType { get; set; }
            public string conversionSymbol { get; set; }
        }

        public class Data
        {
            public bool Aggregated { get; set; }
            public int TimeFrom { get; set; }
            public int TimeTo { get; set; }
            public List<Datum> Datum { get; set; }
        }

        public class CCRootObject
        {
            public string Response { get; set; }
            public string Message { get; set; }
            public bool HasWarning { get; set; }
            public int Type { get; set; }
            public RateLimit RateLimit { get; set; }
            public Data Data { get; set; }
        }
    }
}
