using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using Apoteket.UppgiftBE.Web.Controllers;
using Apoteket.UppgiftBE.Web.Models;

namespace Apoteket.UppgiftBE.Web.Data
{
	public interface IProductList
	{
		IReadOnlyList<Product> Get();
	}

	public class ProductList : IProductList
	{
		IReadOnlyList<Product> _products;

		public ProductList()
		{
            // Hämta produktlistan med hjälp av RestSharp och lagra i Products
            // Observera att listan ändras en gång per timme
		    //HttpHeaders headers = response.Headers;
		    //IEnumerable<string> values;
		    //if (headers.TryGetValues("X-BB-SESSION", out values))
		    //{
		    //    string session = values.First();
		    //}
      //      _products = new List<Product>();
		}

		public IReadOnlyList<Product> Get() => _products;
	}
}