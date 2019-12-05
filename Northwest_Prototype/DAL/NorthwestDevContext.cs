using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Northwest_Prototype.Models;

namespace Northwest_Prototype.DAL
{
    public class NorthwestDevContext : DbContext
    {
        public NorthwestDevContext() : base("NorthwestDevContext") 
        {

        }

        public DbSet<Assay> assays { get; set; }
        public DbSet<AssayTests> assayTests { get; set; }
        public DbSet<Compound> compounds { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Position> positions { get; set; }
        public DbSet<Results> results { get; set; }
        public DbSet<Roles> roles { get; set; }
        public DbSet<Tests> tests { get; set; }
        public DbSet<Users> users { get; set; }
        public DbSet<WorkOrders> workOrders { get; set; }
        public DbSet<WorkOrders_Tests> workOrders_Tests { get; set; }
        public DbSet<OrderStatus> orderStatuses { get; set; }
        public DbSet<AssayToTest> assayToTests { get; set; }

    }
}