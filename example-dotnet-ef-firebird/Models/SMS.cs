using System;
using System.Collections.Generic;
using System.Text;

namespace example_dotnet_ef_firebird.Models
{
    public class SMS
    {
        public int id { get; set; }
        public String Origem { get; set; }
        public String Fone { get; set; }
    }
}
