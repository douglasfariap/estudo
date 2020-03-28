using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebVendor.Models.Entities;

namespace WebVendor.Models
{
    public class WebVendorContext : DbContext
    {
        public WebVendorContext (DbContextOptions<WebVendorContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
        public DbSet<Seller> Seller { get; set; }
    }
}
