using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentValidationDemo.entities
{
    public class Location
    {
        public int LocationId { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
    }
}
