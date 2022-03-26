using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MedtechDbContext : DbContext
    {
        public MedtechDbContext(DbContextOptions<MedtechDbContext> options)
           : base(options)
        {

        }
        public DbSet<Introduction> Introductions { get; set; }
    }

}
