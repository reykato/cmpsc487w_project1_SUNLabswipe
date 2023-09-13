using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.Types;

namespace SUNLab
{
    internal class User
    {
        public int id { get; set; }

        public string? name { get; set; }

        public string? role { get; set; }

        public bool has_access { get; set; }

        public string password { get; set; }
    }
}

