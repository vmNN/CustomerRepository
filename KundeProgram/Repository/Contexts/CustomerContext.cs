using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Contexts;

public class CustomerContext : DbContext
{
    public DbSet<Models.Customer> Customers { get; set; }
    public DbSet<Models.Address> Addresses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=entityframeworktest;User Id=ucl;Password=ucl1234;TrustServerCertificate=true;");
    }

}
