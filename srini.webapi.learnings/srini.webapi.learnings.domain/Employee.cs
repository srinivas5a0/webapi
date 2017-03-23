using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srini.webapi.learnings.domain
{
    public class Employee : BaseEntity
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string dateOfBirth { get; set; }
        public int age { get; set; }
        public int salary { get; set; }
    }
}
