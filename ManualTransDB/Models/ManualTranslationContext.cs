using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ManualTransDB.Models
{
    public class ManualTranslationContext : DbContext
    {
        public ManualTranslationContext() : base()
        {
        }

        public ManualTranslationContext(DbContextOptions<ManualTranslationContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=.;Database=AC4UserManual;Integrated Security=True;TrustServerCertificate=True;");
            }
        }
    }
}