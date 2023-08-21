using Microsoft.EntityFrameworkCore;
using Practice.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class MachineDBContext : DbContext
    {
        public MachineDBContext(DbContextOptions<MachineDBContext> options) : base(options) { }

        public DbSet<Car> cars{ get; set; }
    }
}
