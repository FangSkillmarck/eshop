using System.Collections.Generic;
using Apoteket.UppgiftBE.Web.Controllers;
using Apoteket.UppgiftBE.Web.Models;

namespace Apoteket.UppgiftBE.Web.Data
{
	public interface IBasket
	{
		IReadOnlyList<Product> GetProducts();
		void AddProduct(string itemId);
		void RemoveProduct(string itemId);
		string Checkout();
	}

	public class Basket : IBasket
	{
		public IReadOnlyList<Product> GetProducts()
		{
			// Hämta från DB med hjälp av linq2db (https://github.com/linq2db/linq2db)
			return new List<Product>();
		}

		public void AddProduct(string productId)
		{
			// Spara till DB med hjälp av linq2db (https://github.com/linq2db/linq2db)
		}

		public void RemoveProduct(string productId)
		{
			// Spara till DB med hjälp av linq2db (https://github.com/linq2db/linq2db)
		}

		public string Checkout()
		{
			// Checkout the basket and return the id provided by order service
			return "";
		}
	}
}