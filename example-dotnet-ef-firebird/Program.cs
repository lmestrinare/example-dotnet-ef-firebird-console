using example_dotnet_ef_firebird.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace example_dotnet_ef_firebird
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new AppDbContext();
            List<SMS> SMSItem = db.SMS.ToList();
            foreach (SMS p in SMSItem)
            {
                Console.WriteLine("{0} {1}", p.id, p.Fone);
            }
        }
    }
}
