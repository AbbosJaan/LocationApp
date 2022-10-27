using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform.Models
{
    public class RegionResponse : RegionCr
    {
        public int Id { get; set; }
        public string Country { get; set; }
    }
}
