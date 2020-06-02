using CommonLayer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer
{
    /// <summary>
    /// Class For DBContext.
    /// </summary>
    public class QuantityDBContext : DbContext
    {
        /// <summary>
        /// Parameter Constructor.
        /// </summary>
        /// <param name="options"></param>
        public QuantityDBContext(DbContextOptions<QuantityDBContext> options) : base(options)
        { 
        
        }

        /// <summary>
        /// DbSet Property For QuantityModel.
        /// </summary>
        public DbSet<QuantityModel> Quantities { get; set; }

        /// <summary>
        /// DbSetProperty For ComparisonModel.
        /// </summary>
        public DbSet<ComparisonModel> Comparisons { get; set; }
    }
}
