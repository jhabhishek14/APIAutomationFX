using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAPIProject
{
    internal class Model
    {
        public class BpiCurrency
        {
            public string Code { get; set; }
            public string Description { get; set; }
        }

        public class Bpi
        {
            public BpiCurrency USD { get; set; }
            public BpiCurrency GBP { get; set; }
            public BpiCurrency EUR { get; set; }
        }

        public class CoinResponse
        {
            public Bpi Bpi { get; set; }
        }

        public class EUR
        {
            public string code { get; set; }
            public string symbol { get; set; }
            public string rate { get; set; }
            public string description { get; set; }
            public double rate_float { get; set; }
        }

        public class GBP
        {
            public string code { get; set; }
            public string symbol { get; set; }
            public string rate { get; set; }
            public string description { get; set; }
            public double rate_float { get; set; }
        }

        public class Root
        {
            public Time time { get; set; }
            public string disclaimer { get; set; }
            public string chartName { get; set; }
            public Bpi bpi { get; set; }
        }

        public class Time
        {
            public string updated { get; set; }
            public DateTime updatedISO { get; set; }
            public string updateduk { get; set; }
        }

        public class USD
        {
            public string code { get; set; }
            public string symbol { get; set; }
            public string rate { get; set; }
            public string description { get; set; }
            public double rate_float { get; set; }
        }
    }
}
