using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dictionary works");
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("ULH", "Universal Logistics Holdings");
            stocks.Add("NSS", "Nashville Software School");
            stocks.Add("CFA", "Chick-Fil-A");

            string GM = stocks["GM"];

            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();

            purchases.Add((ticker: "GM", shares: 345, price: 13.21));
            purchases.Add((ticker: "CAT", shares: 123, price: 23.21));
            purchases.Add((ticker: "ULH", shares: 16, price: 3.21));
            purchases.Add((ticker: "NSS", shares: 46, price: 77.87));
            purchases.Add((ticker: "CFA", shares: 80, price: 19.02));
            purchases.Add((ticker: "GM", shares: 45, price: 12.21));

            /* 
                Define a new Dictionary to hold the aggregated purchase information.
                - The key should be a string that is the full company name.
                - The value will be the valuation of each stock (price*amount)

                {
                    "General Electric": 35900,
                    ...
                }
            */

            Dictionary<string, double> valuations = new Dictionary<string, double>();

            foreach ((string ticker, int shares, double price) purchase in purchases) {
                string companyName = stocks[purchase.ticker];
                Console.WriteLine($"company name in val loop {companyName}");
                if (valuations.ContainsKey(companyName)) {
                    // add the value to the existing value
                    valuations[companyName] += (purchase.shares * purchase.price);
                }
                else {
                    // add the new key and set its value
                    valuations.Add(companyName, (purchase.shares * purchase.price));
                }
            }

            foreach (KeyValuePair<string, double> valuePair in valuations)
                {
                    Console.WriteLine(valuePair);
                }

        }
    }
}