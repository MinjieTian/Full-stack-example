﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Dto
{
    public class ProductOut
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public float price { get; set; }
    }
}
