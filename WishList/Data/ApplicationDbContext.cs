using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using WishList.Models;

namespace WishList.Data
{
    class ApplicationDbContext : DbContext
    {
        public DBSet<Item> Item { get; set; }

        public ApplicationDbContext( DbContextOptions options) : base(options)
        {
        }
    }
}
