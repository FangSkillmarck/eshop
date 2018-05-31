using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Apoteket.UppgiftBE.Web.Controllers;
using Apoteket.UppgiftBE.Web.Models;

namespace Apoteket.UppgiftBE.Web.Context
{
    public class ProductDbContext : DbContext, IrealtimeContext
    {
        public ProductDbContext()
        {
        }

        //public static ProductDbContext Create()
        //{
        //    return new ProductDbContext();
        //}
        public IDbSet<Product> Products { get; set; }
        public IDbSet<Basket>  Baskets { get; set; }
     }

    public interface IrealtimeContext
    {
         IDbSet<Product> Products { get; set; }
         IDbSet<Basket> Baskets { get; set; }
        int SaveChanges();
    }
}