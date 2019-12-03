using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Kafe
{
    public class ProjectContext : DbContext
    {
        public ProjectContext()
            : base("Connection")
        {
            
        }
        public virtual DbSet<Food> Foods { get; set; }
    }
}
