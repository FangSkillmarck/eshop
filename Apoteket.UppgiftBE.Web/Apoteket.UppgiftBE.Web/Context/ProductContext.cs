using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Apoteket.UppgiftBE.Web.Controllers;
using Apoteket.UppgiftBE.Web.Models;

namespace Apoteket.UppgiftBE.Web.Context
{
    public class ProductDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Basket>  Baskets { get; set; }
     }
}