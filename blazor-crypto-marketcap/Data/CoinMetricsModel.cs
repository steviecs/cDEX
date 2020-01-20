using System;
using System.Collections.Generic;

namespace blazor_crypto_marketcap.Data
{
    public class USD
    {
        public decimal? Price { get; set; }
        public decimal? Volume_24h { get; set; }
        public decimal? Percent_Change_1h { get; set; }
        public decimal? Percent_Change_24h { get; set; }
        public decimal? Percent_Change_7d { get; set; }
        public decimal? Market_Cap { get; set; }
        public DateTime Last_Updated { get; set; }
    }

    public class BTC
    {
        public int Price { get; set; }
        public int Volume_24h { get; set; }
        public int Percent_Change_1h { get; set; }
        public int Percent_Change_24h { get; set; }
        public int Percent_Change_7d { get; set; }
        public int Market_Cap { get; set; }
        public DateTime Last_Updated { get; set; }
    }

    public class Quote
    {
        public USD USD { get; set; }
        public BTC BTC { get; set; }
    }

    public class Datum
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string Slug { get; set; }
        public int? Cmc_Rank { get; set; }
        public int? Num_Market_Pairs { get; set; }
        public decimal? Circulating_Supply { get; set; }
        public decimal? Total_Supply { get; set; }
        public decimal? Max_Supply { get; set; }
        public DateTime Last_Updated { get; set; }
        public DateTime Date_Added { get; set; }
        public List<string> Tags { get; set; }
        public object Platform { get; set; }
        public Quote Quote { get; set; }
    }

    public class Status
    {
        public DateTime Timestamp { get; set; }
        public int Error_Code { get; set; }
        public string Error_Message { get; set; }
        public int Elapsed { get; set; }
        public int Credit_Count { get; set; }
    }

    public class RootObject
    {
        public List<Datum> Data { get; set; }
        public Status Status { get; set; }
    }
}
