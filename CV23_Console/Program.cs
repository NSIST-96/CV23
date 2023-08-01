using System;
using System.Net;
using System.Net.Http;

namespace CV23_Console
{
    internal class Program
    {
        private const string data_url = @"https://raw.githubusercontent.com/CSSEGISandData/COVID-19/master/csse_covid_19_data/csse_covid_19_time_series/time_series_covid19_confirmed_global.csv";
        static void Main(string[] args)
        {
            var client = new HttpClient();

            var responce = client.GetAsync(data_url).Result;
            var csv_str = responce.Content.ReadAsStringAsync().Result;


            Console.ReadLine();
        }
    }
}