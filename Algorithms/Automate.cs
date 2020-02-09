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

            using(StreamReader sr = File.OpenText(myPath))
            {
                String s = "";
                while((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
