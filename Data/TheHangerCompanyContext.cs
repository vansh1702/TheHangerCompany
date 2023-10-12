using Microsoft.EntityFrameworkCore;
using TheHangerCompany.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheHangerCompany.Data
{
    public class TheHangerCompanyContext : DbContext
    {
        public TheHangerCompanyContext(DbContextOptions<TheHangerCompanyContext> options)
            : base(options)
        {
        }

        public DbSet<Hanger> Hanger { get; set; }
    }
}
