using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DavesCardsProjekt.Models
{
    public class ShopModel : DbContext
    {
        public ShopModel()
        {
            Database.EnsureCreated();  
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source = davescards.db");
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Card> Cards { get; set; }

    }
}
