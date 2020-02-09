using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using System.Web;
using System.Net;
using System.Linq;
using System.IO;

namespace Algorithms
{
    class webAPIs
    {

        public void SearchForMovies(string MovieName)
        {
            string APIKey = "6a07c858";
            string BaseURL = $"http://www.omdbapi.com/?apikey={APIKey}";
            BaseURL = BaseURL + "&s=" + MovieName;

            var request = WebRequest.Create(BaseURL.ToString());
            request.Timeout = 2000;
            request.Method = "GET";
            request.ContentType = "application/JSON";

            string webRes = string.Empty;

            Stream objStream = request.GetResponse().GetResponseStream();
            StreamReader objReader = new StreamReader(objStream);

            //webRes = objReader.ReadToEnd();
            string sLine = objReader.ReadLine();
            JObject movie1 = JObject.Parse(sLine);
            JToken ojut = movie1;

            int x;

            JArray items = (JArray)movie1["Search"];
            x = items.Count;
            Console.WriteLine($"count of items: {x}");

            if (x > 0)
            {
                string str1 = (string)movie1["Search"][0]["imdbID"];
                string url1 = "http://www.omdbapi.com/?plot=full&apikey=6a07c858&i=" + str1;
                WebRequest wrGETURL = WebRequest.Create(url1);
                Stream objStream1 = wrGETURL.GetResponse().GetResponseStream();
                StreamReader objReader1 = new StreamReader(objStream1);
                string sLine1 = objReader1.ReadLine();
                JObject Movie2 = JObject.Parse(sLine1);

                string output = "";

                output += "< div class='row'>";
                output += "<div class='col -md-4'>";
                output += " class='thumbnail'>";
                output += "</div>";
                output += "< div class='col -md-8'>";
                output += "<h2>${movie.Title}";
                output += "</h2>";
                output += "</div>";
            }



            //        LinkedList<String> myLinkList = new LinkedList<String>();

        }

        public class MoviesInfo
        {
            public IList<string> Search { get; set; }
            public string totalResults { get; set; }
            public string Response { get; set; }
        }

    }
}
