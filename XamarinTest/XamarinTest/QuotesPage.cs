using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinTest
{
    public class QuotesPage
    {
        private int number;
        private string[] quotes;
        private Random random;

        public QuotesPage()
        {
            random = new Random();
            quotes = new string[] 
            {
                "Do not take life too seriously - you will never get out of it alive!",
                "Everything is funny, as long as it's happening to someone else.",
                "Weather forecast for tonight: Dark.",
                "Electricity is really just organised lightning.",
                "I would never die for my beliefs because I might be wrong."
            };
        }

        public string GenerateQuote()
        {
            number = random.Next(1,5);
            return quotes[number];
        }
    }
}
