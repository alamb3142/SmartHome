using Microsoft.EntityFrameworkCore;
using Switchables.Domain.Switches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switchables.Infrastructure.Database
{
    public class SwitchablesContext : DbContext
    {
        public DbSet<Switch> Switches { get; set; }
    }
}
