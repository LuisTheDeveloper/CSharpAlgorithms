using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Prime numprime = new Prime();
            Automate smartOne = new Automate();

            /*
            Console.WriteLine("Type Minimum: ");
            var MinN = Console.ReadLine();
            int MinNum = Int32.Parse(MinN);
            Console.WriteLine("Type Maximum: ");
            var MaxN = Console.ReadLine();
            int MaxNum = Int32.Parse(MaxN);
            numprime.CalculatePrime(MinNum,MaxNum);*/

            //numprime.ElementsList();
            //smartOne.DoStreaming();
            smartOne.SearchString();
        }
    }
}
