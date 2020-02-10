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
            webAPIs smartWeb = new webAPIs();

            Console.WriteLine("Algorithm Options Available");
            Console.WriteLine("1-PrimeNumbers | 2-List | 3-FileStream | 4-StringSearch | 5-WebAPI | 6-InsertSort");
            Console.WriteLine("Please, choose the algorithm option:");
            int userInput = Int32.Parse(Console.ReadLine());
            int i;

            switch (userInput)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Define a number range for prime numbers calculation.");
                    Console.WriteLine("Minimum number: ");
                    var MinN = Console.ReadLine();
                    int MinNum = Int32.Parse(MinN);
                    Console.WriteLine("Maximum number: ");
                    var MaxN = Console.ReadLine();
                    int MaxNum = Int32.Parse(MaxN);
                    Console.Clear();
                    numprime.CalculatePrime(MinNum, MaxNum);
                    break;
                case 2:
                    Console.WriteLine("Type decimal number to convert:");
                    userInput = Int32.Parse(Console.ReadLine());
                    smartOne.BinaryGap(userInput);
                    break;
                case 3:
                    Console.WriteLine("3");
                    break;
                case 4:
                    Console.WriteLine("4");
                    break;
                case 5:
                    Console.WriteLine("5");
                    break;
                case 6:
                    Console.Clear();
                    String userInp = Console.ReadLine();/*
                    while (i < userInp.Length)
                    {
                        //Try to implement the following:
                        /*
                        Console.Write("Please enter a bunch of digits separated by a space: ");
                        var allDigits = Console.ReadLine().Split(' ');
                        Double[] digits = allDigits.Select(d => Covert.ToDouble(d)).ToArray();
                        
                    }
                    char[] myArray = new char[userInp.Length];
                    userInp.CopyTo(0, myArray, 0, userInp.Length);
                    List<string> List1 = new List<string>(myArray);

                    smartOne.InsertSort() */
                    break;
                default:
                    Console.WriteLine("Wrong value type. Any key to exit...");
                    Environment.Exit(0);
                    break;
            }



            /*
            numprime.ElementsList();
            smartOne.DoStreaming();
            smartOne.SearchString();
            smartWeb.SearchForMovies("Twins");*/

        }
    }
}
