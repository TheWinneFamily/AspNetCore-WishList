using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using WishList.Models;

namespace WishList.Data
{
    class ApplicationDbContext : DbContext
    {
        public DbSet<Item> Items { get; set; }

        public ApplicationDbContext( DbContextOptions options) : base(options)
        {
        }
    }
}
