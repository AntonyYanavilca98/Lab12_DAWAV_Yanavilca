using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DOMAIN;

namespace INFRAESTRUCTURE
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("name = MyContextDB")
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}
