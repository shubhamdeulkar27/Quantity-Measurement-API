using CommonLayer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer
{
    public class QuantityDBContext : DbContext
    {
        public QuantityDBContext(DbContextOptions<QuantityDBContext> options) : base(options)
        { 
        
        }

        public DbSet<QuantityModel> Quantities { get; set; }
    }
}
