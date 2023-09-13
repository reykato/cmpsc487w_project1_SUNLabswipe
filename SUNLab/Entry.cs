using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.Types;

namespace SUNLab
{
    internal class Entry
    {
        public int id { get; set; }
        public DateTime timestamp { get; set; }

        public string name { get; set; }

        public string role { get; set; }
    }
}
