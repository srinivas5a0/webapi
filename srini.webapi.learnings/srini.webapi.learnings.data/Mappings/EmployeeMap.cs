using srini.webapi.learnings.domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srini.webapi.learnings.data.Mappings
{
    public class EmployeeMap: EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            //key
            HasKey(t => t.ID);
            //properties
            Property(t => t.firstName).IsRequired();
            Property(t => t.lastName).IsRequired();
            Property(t => t.email).IsRequired();
            Property(t => t.dateOfBirth).IsRequired();
            Property(t => t.age).IsRequired();
            Property(t => t.salary).IsRequired();
            //table
            ToTable("tblEmployee");
        }
    }
}
