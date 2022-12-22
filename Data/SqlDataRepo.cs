using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIApi.Data
{
    public class SqlDataRepo : IDataRepo
    {
        public string ReturnData()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("--> getting data from sql server");
            Console.ResetColor();

            return ("Data from SQL DB");
        }
    }
}