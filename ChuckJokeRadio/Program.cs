using System;
using System.Net.Http;
using System.Runtime.CompilerServices;

namespace ChuckJokeRadio
{
    class Program
    {
        //TODO plocka även ut och visa datumet för när skämtet skapades/senast uppdaterades
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();

            while (true)
            {
                string url = @"https://api.chucknorris.io/jokes/random";
                string json = client.GetStringAsync(url).Result;

                string startTag = "\"value\":\"";
                int start = json.IndexOf(startTag) + startTag.Length;
                int end = json.IndexOf("\"}", start);

                string joke = json.Substring(start, end - start);
                
                string startDate = "\"created_at\":\"";
                int startDateValue = json.IndexOf(startDate) + startDate.Length;
                int endDateValue = json.IndexOf("\",\"", startDateValue);
                
                string dateValue = json.Substring(startDateValue, endDateValue - startDateValue);

                DateTime jokeDate = DateTime.Parse(dateValue);

                
                Console.WriteLine(joke);
               // Console.WriteLine("\n This Joke was added : " + date);
               Console.WriteLine(jokeDate.ToString("yyyy '-' MM '-' dd" +" " + "HH:mm:ss"));

                Console.WriteLine();
                Console.Write("Press enter for another joke");
                Console.ReadLine();

                Console.Clear();
            }
        }
    }
}
