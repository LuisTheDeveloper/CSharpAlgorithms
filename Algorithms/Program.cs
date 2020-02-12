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
            Console.WriteLine("1-PrimeNumbers | 2-Binary Gap | 3-FileStream | 4-StringSearch | 5-WebAPI | 6-InsertSort | 7- Arrays");
            Console.WriteLine("Please, choose the algorithm option:");
            int userInput = Int32.Parse(Console.ReadLine());

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
                    Console.Clear();
                    Console.WriteLine($"The binary gap is {smartOne.BinaryConv(userInput)}");
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
                case 7:
                    Console.Clear();
                    Console.WriteLine("Type in the numbers separated by a comma:");
                    string strUser = Console.ReadLine();
                    string[] tokens = strUser.Split(",");
                    int[] userArray = new int[tokens.Length];
                    int[] userArray2 = new int[tokens.Length];
                    int i = 0;
                    foreach (string s in tokens)
                    {
                        userArray[i] = Int32.Parse(s);
                        i += 1;
                    }
                    Console.WriteLine("Type in the cycle times:");
                    int intUser = Int32.Parse(Console.ReadLine());
                    Array.Copy(smartOne.CyclicRotation(userArray, intUser), 0, userArray2, 0, userArray.Length);

                    foreach(int number in userArray2)
                    {
                        Console.WriteLine(number);
                    }
                    
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
