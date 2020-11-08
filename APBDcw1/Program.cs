﻿using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace APBDcw1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var url = "https://www.pja.edu.pl";
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(url);

            if(response.IsSuccessStatusCode)
            {
                var html = await response.Content.ReadAsStringAsync();
                var regex = new Regex("[a-z0-9]+@[a-z.]+");

                MatchCollection matches = regex.Matches(html);
                foreach (var i in matches)
                    Console.WriteLine(i);
            }
        
        }
    }
}
