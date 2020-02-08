using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;

namespace Algorithms
{
    public class Prime
    {
        public void CalculatePrime(int minNum, int maxNum)
        {
            var PrimeList = new List<int>();
            var NonPrime = new List<int>();

            for (int i = minNum; i <= maxNum; i++)
            {
                for(int j = 2; j <= i; j++)
                {
                    var res = i % j;
                    if (i != j)
                    {
                        if (res != 0)
                        {
                            if (!NonPrime.Contains(i) && !PrimeList.Contains(i))
                            {
                                PrimeList.Add(i);
                            }
                        }
                        else
                        {
                            if (PrimeList.Contains(i))
                                PrimeList.Remove(i);
                            NonPrime.Add(i);
                        }
                    }
                    else
                    {
                        if (res == 0 && !NonPrime.Contains(i) && !PrimeList.Contains(i))
                        {
                            PrimeList.Add(i);
                            break;
                        }
                    }
                }
            }

            foreach(int num in PrimeList)
            {
                Console.WriteLine(num);
            }

        }

        public void ElementsList()
        {
            int[] numList = { 2, 38, 15, 38, 5, 14, 21, 99, 21 };

            List<int> list2 = new List<int>();
            List<int> list3 = new List<int>();
            List<int> list4 = new List<int>();
            List<int> list5 = new List<int>(numList);

            bool FoundTwice = false;

            foreach (int num in numList)
            {
                if (!list2.Contains(num))
                {
                    list2.Add(num);
                }
                else
                {
                    list3.Add(num);
                }
            }

            Console.WriteLine("First Method:");
            list3.Sort();
            for (int i = 0; i < list3.Count(); i++)
            {
                Console.WriteLine(list3[i]);
            }

            Console.WriteLine("Second Method:");
            foreach (int num in numList)
            {
                FoundTwice = false;
                foreach (int element in numList)
                {
                    if (element == num && FoundTwice == false)
                        FoundTwice = true;
                    else if (element == num && FoundTwice == true)
                    {
                        if (!list4.Contains(element))
                        {
                            list4.Add(element);
                            break;
                        }
                    }
                }

            }
            for (int i = 0; i < list4.Count(); i++)
            {
                Console.WriteLine(list4[i]);
            }
            list5.Sort();
            Console.WriteLine("Third Method:");
            List<int> distinctList = list5.Distinct().ToList();
            foreach (int value in distinctList)
            {
                Console.WriteLine($"Value: {value}");
            }
        }
         
    }
}
