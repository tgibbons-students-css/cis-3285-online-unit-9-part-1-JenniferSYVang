using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var tradeStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("SingleResponsibilityPrinciple.trades4.txt");

            var tradeProcessor = new TradeProcessor();
            //tradeProcessor.ProcessTrades(tradeStream);  // this calls our method that takes in a stream
            tradeProcessor.ProcessTrades("http://faculty.css.edu/tgibbons/trades4.txt"); // this calls our method that takes in a string

            Console.ReadKey();
        }
    }
}
