using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleProject.Core;

namespace SampleProject.Core.Data
{
    public class Employee : BaseEntity
    {
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
    }
}
