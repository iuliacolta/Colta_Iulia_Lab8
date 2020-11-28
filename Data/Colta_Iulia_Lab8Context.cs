using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Colta_Iulia_Lab8.Models;

namespace Colta_Iulia_Lab8.Data
{
    public class Colta_Iulia_Lab8Context : DbContext
    {
        public Colta_Iulia_Lab8Context (DbContextOptions<Colta_Iulia_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Colta_Iulia_Lab8.Models.Book> Book { get; set; }

        public DbSet<Colta_Iulia_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Colta_Iulia_Lab8.Models.Category> Category { get; set; }
    }
}
