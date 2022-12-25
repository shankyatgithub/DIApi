using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DIApi.DataServices;

namespace DIApi.Data
{
    public class NoSqlDataRepo : IDataRepo
    {
        private readonly IDataService _dataService;
        public NoSqlDataRepo(IDataService dataService)
        {
            _dataService = dataService;

        }
        public string GetData()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--> getting data from no sql server");
            Console.ResetColor();

            return ("Data from No SQL DB");
        }

        public string ReturnData()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--> getting data from no sql server");
            Console.ResetColor();

            return (_dataService.GetProductData("https://test.com/api"));
        }

    }
}