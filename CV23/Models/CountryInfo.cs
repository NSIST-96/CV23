﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV23.Models
{
    internal class CountryInfo : PlaceInfo
    {
        public IEnumerable<ConfirmedCount> ProvinceCounts { get; set; }
    }
}
