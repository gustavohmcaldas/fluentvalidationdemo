using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentValidationDemo.entities
{
    public class Job
    {
        public int JobId { get; set; }
        public string Title { get; set; }
        public double Salary { get; set; }
    }
}
