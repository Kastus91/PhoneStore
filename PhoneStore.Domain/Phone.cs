﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore.Domain
{
    public class Phone
    {
        public int PhoneId { get; set; }
        public string Name { get; set; }
        public string Produce { get; set; }
        public int Price { get; set; }
    }
}
