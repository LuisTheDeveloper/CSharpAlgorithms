using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Net;


namespace Algorithms
{
    public class Automate
    {
        public void DoStreaming()
        {
            string myPath = @"c:\temp\Lines.txt";

            using(StreamReader sr = File.OpenText(myPath))
            {
                List<String> lines2 = new List<string>();

                String s = null;
                while((s = sr.ReadLine()) != null)
                {
                    lines2.Add(s);
                    
                }
                foreach(String strLine in lines2)
                {
                    Console.WriteLine(strLine);
                }
            }
        }

        public void SearchString()
        {
            Console.WriteLine("Type the all string");
            String sline = Console.ReadLine();
            Console.WriteLine("Type the string to search for:");
            string sword = Console.ReadLine();
            // Copying a List to another list
            List<String> Lista = new List<string>(this.NaiveSearch(sword, sline));

            foreach (String strLine in Lista)
            {
                Console.WriteLine(strLine);
            }

        }

        // This method returns a List object
        private List<String> NaiveSearch(string strToSearchFor, string strWhereToSearch)
        {
            List<String> myList = new List<string>();

            int pos = 0;
            int j = strToSearchFor.Length;
            string sFound;

            for(int i = 0; i < strWhereToSearch.Length; i++)
            {
                pos = i + 1;

                if(strToSearchFor == strWhereToSearch.Substring(i, j).ToString())
                {
                    sFound = $"string '{strToSearchFor}' found at position {pos}";
                    myList.Add(sFound);
                    break;
                }
            }
            return myList; 
        }

        // Insertion Sort with a List
        public List<int> InsertSort(List<int> userList)
        {
            int key, i;

            for(int j=1; j< userList.Count;j++)
            {
                key = userList[j];
                i = j - 1;
                while (i>0 && userList[i] > key)
                {
                    userList[i + 1] = userList[i];
                    i -= 1;
                }
                userList[i + 1] = key;
            }

            return userList;
        }

        // This function converts a decimal number to binary
        public int BinaryConv(int N)
        {
            int[] binArr = new int[32];
            int i;
            string binaryNum = "";

            for (i = 0; N > 0; i++)
            {
                binArr[i] = N % 2;
                N /= 2;
            }

            Console.WriteLine("Binary is: ");
            for (i -= 1; i >= 0; i--)
            {
                Console.Write(binArr[i]);
                binaryNum += binArr[i].ToString();
            }
            Console.WriteLine("");
            Console.WriteLine("The binary to String is:");
            Console.WriteLine(binaryNum);

            return this.BinaryGap(ulong.Parse(binaryNum));

        }

        /* This function checks the largest binary gap of a binary number
         Binary gap is the number of zeros surrounded by 1
         e.g. 100 is 01100100, the binary gap is 2 zeros.
         */
        private int BinaryGap(ulong N)
        {
            string binNum = N.ToString();
            int i, tot = 0;
            int j = 0;

            bool foundStart1 = false;
            bool foundEnd1 = false;
            bool found0 = false;

            for(i=0; i < binNum.Length;i++)
            {
                if (binNum.Substring(i, 1) == "1")
                {
                    if (foundStart1 == true)
                    {
                        if (found0 == true)
                        {
                            foundStart1 = false;
                            found0 = false;
                            foundEnd1 = true;
                            if (j > tot)
                                tot = j;
                            j = 0;
                        }
                    }
                    else
                    {
                        if (foundEnd1 == true)
                        {
                            foundEnd1 = false;
                            foundStart1 = true;
                        }
                        else
                            foundStart1 = true;
                    }
                        
                }
                else
                {
                    if (foundStart1 == true)
                    {
                        j += 1;
                        found0 = true;
                    }
                    else if(foundEnd1 == true)
                    {
                        foundEnd1 = false;
                        foundStart1 = true;
                        j += 1;
                        found0 = true;
                    }
                }
                        
            }
            return tot;
        }
        
        public int[] CyclicRotation(int[] userArr, int userK)
        {
            int i = 0;
            int k = userArr.Length - 1;

            int[] mirrorArr = new int[userArr.Length];

            while (i < userK)
            {
                for(int j = 0; j <= k; j++)
                {

                    if(j==0)
                        mirrorArr[j] = userArr[k];
                    else
                    {
                        mirrorArr[j] = userArr[j-1];
                    }
                    
                }
                i += 1;
                Array.Copy(mirrorArr, 0, userArr, 0, k + 1);
            }
            return mirrorArr;
        }

    }
}
