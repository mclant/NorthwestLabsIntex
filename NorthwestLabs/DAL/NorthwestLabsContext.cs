using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using NorthwestLabs.Models;

namespace NorthwestLabs.DAL
{
    public class NorthwestLabsContext : DbContext
    {
        public NorthwestLabsContext() :
            base("NorthwestLabsContext")
        {

        }

        public DbSet<AssayInstances> AssayInstance { get; set; }
        public DbSet<AssayTypes> AssayType { get; set; }
        public DbSet<CompanyInfo> CompanyInfos { get; set; }
        public DbSet<Compounds> Compound { get; set; }
        public DbSet<Customers> Customer { get; set; }
        public DbSet<EmployeePositions> EmployeePosition { get; set; }
        public DbSet<Employees> Employee { get; set; }
        public DbSet<HourlyWages> HourlyWage { get; set; }
        public DbSet<Invoices> Invoice { get; set; }
        public DbSet<Locations> Location { get; set; }
        public DbSet<Logins> Login { get; set; }
        public DbSet<Materials> Material { get; set; }
        public DbSet<OrderComments> OrderComment { get; set; }
        public DbSet<OrderDetails> OrderDetail { get; set; }
        public DbSet<Orders> Order { get; set; }
        public DbSet<OrderStatuses> OrderStatus { get; set; }
        public DbSet<PaymentAccounts> PaymentAccount { get; set; }
        public DbSet<SampleAppearances> SampleAppearance { get; set; }
        public DbSet<Samples> Sample { get; set; }
        public DbSet<SampleTests> SampleTest { get; set; }
        public DbSet<TestHours> TestHour { get; set; }
        public DbSet<TestMaterials> TestMaterial { get; set; }
        public DbSet<TestTypes> TestType { get; set; }

    }
}