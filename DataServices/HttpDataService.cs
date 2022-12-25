using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIApi.DataServices
{
    public class HttpDataService : IDataService
    {
        public string GetProductData(string url)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("--> Getting Product data..");
            Console.ResetColor();

            return "Some Product data...";
        }
    }
}