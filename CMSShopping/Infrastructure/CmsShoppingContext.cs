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
    }
}
