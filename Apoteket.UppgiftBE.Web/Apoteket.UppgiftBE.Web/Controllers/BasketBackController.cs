using System.Linq;
using System.Web.Mvc;
using Apoteket.UppgiftBE.Web.Context;
using Apoteket.UppgiftBE.Web.Data;

namespace Apoteket.UppgiftBE.Web.Controllers
{
	public class BasketController : Controller
	{
		readonly IBasket _basket;

	    private ProductDbContext db = new ProductDbContext();


        public BasketController(IBasket basket)
		{
			_basket = basket;
		}

		public ActionResult Index()
		{
		    var Products = db.Products.ToList();
			return View();
		}

		public ActionResult Add(int id)
		{
			// Add item to basket
			return RedirectToAction("Index", "Home");
		}

		public ActionResult Remove(int id)
		{
			// Remove item from basket
			return RedirectToAction("Index", "Home");
		}

		public ActionResult Checkout()
		{
			// Checka ut korgen och visa erhållet ordernummer
			throw new System.NotImplementedException();
		}
	}
}