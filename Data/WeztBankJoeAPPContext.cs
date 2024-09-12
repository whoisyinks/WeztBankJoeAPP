using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WeztBankJoeAPP.Models;

namespace WeztBankJoeAPP.Data
{
    public class WeztBankJoeAPPContext : DbContext
    {
        public WeztBankJoeAPPContext (DbContextOptions<WeztBankJoeAPPContext> options)
            : base(options)
        {
        }

        public DbSet<WeztBankJoeAPP.Models.Country> Country { get; set; } = default!;
    }
}
