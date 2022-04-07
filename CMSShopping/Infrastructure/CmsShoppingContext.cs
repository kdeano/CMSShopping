using CMSShopping.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMSShopping.Infrastructure
{
    public class CmsShoppingContext : DbContext
    {
        public CmsShoppingContext(DbContextOptions<CmsShoppingContext> options) : base(options)
        {

        }

        public DbSet<Page> Pages { get; set; }
    }
}
