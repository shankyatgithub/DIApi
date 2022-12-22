using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIApi.Data
{
    public class NoSqlDataRepo : IDataRepo
    {
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

            return ("Data from No SQL DB");
        }

    }
}