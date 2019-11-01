using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft;
using FCTAssignment.Models;

namespace FCTAssignment.Data
{
 
    public class FCTAssignmentContext : DbContext
    {
        public FCTAssignmentContext(DbContextOptions<FCTAssignmentContext> options)
            : base(options)
        {
        }

        public DbSet<FCTAssignment.Models.Customer> Customer { get; set; }

        public DbSet<FCTAssignment.Models.Product> Product { get; set; }

        public DbSet<FCTAssignment.Models.Purchase> Purchase { get; set; }

    }
}