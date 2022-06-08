using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace KanyeREST
{
    public class QuoteGenerator
    {

        public static void KanyeQuote()
        {
            //helps us make a request to the internet
            var client = new HttpClient();

            var kanyeURL = "https://api.kanye.rest"; //Kanye's API's URL

            //GetStringAsync method sends a GET (aka Read) request to the specificed url, returns the response body as a string, and stores it in this variable
            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

            //static method JArray.Parse (JArray is class name)
            //Parses through our JSON responses to get the values we are interested in (get value associated w/ the "quote" NAME)
            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            Console.WriteLine($"-----------------------");
            Console.WriteLine($"Kanye: \"{kanyeQuote}\"");

        }

        public static void RonQuote()
        { 
            var client = new HttpClient();

            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes"; //Ron's API's URL

            //GetStringAsync method sends a GET (aka Read) request to the specificed url, returns the response body as a string, and stores it in this variable
            var ronResponse = client.GetStringAsync(ronURL).Result;

            //static method JArray.Parse (JArray is class name)
            //Parses through our JSON responses to get the values we are interested in (get value associated w/ the "quote" NAME)
            //use JArray since this API sends back an array containing the quote
            //We replace brackets with nothing, and then trim the rest.
            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            Console.WriteLine($"Ron: {ronQuote}");

        }
    }
}
