using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;


namespace Algorithms
{
    public class Automate
    {
        public void DoStreaming()
        {
            string myPath = @"c:\temp\Lines.txt";
            int n = 0, i = 0;
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

        public void DoLinkedLists()
        {

        }
    }
}
