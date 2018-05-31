﻿using System.Linq;
using System.Web.Mvc;
using Apoteket.UppgiftBE.Web.Context;
using Apoteket.UppgiftBE.Web.Data;

namespace Apoteket.UppgiftBE.Web.Controllers
{
        public class HomeController : Controller
	{
	    private ProductDbContext db = new ProductDbContext();
 
		public ActionResult Index()
		{
		    var products = db.Products.ToList();
		    var totalPrice = db.Products.Sum(p => p.Price);

		    return View(products);
   
		}
	} //          public HomeController(IProductList productList)
		//{
		//	_productList = productList;
		//}

}//         // Lista de produkter som finns i _productList
   //         var headercoll = Request.Headers;
   //         string[] array = headercoll.AllKeys;
   //         for (int i = 0; i < array.Length; i++)
   //         {
   //             //get vaules under the key for collections
   //             string[] values = headercoll.GetValues(array[i]);
   //         }
			
			//return View();