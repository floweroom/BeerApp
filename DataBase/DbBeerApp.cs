using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beer.DataBase
{
    internal class DbBeerApp: DbContext
    {
        public DbSet<Agreement> Objs { get; set; }
        public DbBeerApp(DbContextOptions opt) : base(opt)
        {

        }
    }
}
