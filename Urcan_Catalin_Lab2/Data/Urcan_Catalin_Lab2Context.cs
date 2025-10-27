using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Urcan_Catalin_Lab2.Models;

namespace Urcan_Catalin_Lab2.Data
{
    public class Urcan_Catalin_Lab2Context : DbContext
    {
        public Urcan_Catalin_Lab2Context (DbContextOptions<Urcan_Catalin_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Urcan_Catalin_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Urcan_Catalin_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    }
}
