using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV23.Models
{
    internal class PlaceInfo
    {
        public string Name { get; set; }

        public string Location { get; set; }

        public IEnumerable<ConfirmedCount> Counts { get; set; }
    }
}
