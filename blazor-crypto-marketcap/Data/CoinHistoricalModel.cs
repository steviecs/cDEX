using System.Collections.Generic;

namespace blazor_crypto_marketcap.Data
{
    public class CoinHistoricalData
    {
        public class RateLimit
        {
        }

        public class Datum
        {
            public int Time { get; set; }
            public double High { get; set; }
            public double Low { get; set; }
            public double Open { get; set; }
            public double VolumeFrom { get; set; }
            public double VolumeTo { get; set; }
            public double Close { get; set; }
            public string ConversionType { get; set; }
            public string ConversionSymbol { get; set; }
        }

        public class Data
        {
            public Data(List<Datum> datum)
            {
                data = datum;
            }

            public Data()
            {

            }

            public bool Aggregated { get; set; }
            public int TimeFrom { get; set; }
            public int TimeTo { get; set; }
            public List<Datum> data { get; set; }
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
