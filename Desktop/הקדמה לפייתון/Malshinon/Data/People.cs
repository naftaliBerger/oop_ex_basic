﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Malshinon.Data
{
    internal class People
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string secret_code { get; set; }
        public string type { get; set; }
        public int num_reports { get; set; }
        public int num_mentions { get; set; }
    }
}
