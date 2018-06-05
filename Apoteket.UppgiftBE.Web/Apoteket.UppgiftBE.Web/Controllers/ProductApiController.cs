using System.Collections.Generic;
using System.Web.Http;
using Apoteket.UppgiftBE.Web.Context;
using Apoteket.UppgiftBE.Web.Models;

namespace Apoteket.UppgiftBE.Web.Controllers
{
    public class ProductApiController :ApiController
    {
        private ProductDbContext db = new ProductDbContext();

        public List<Product> _Products = new List<Product>();

        protected ProductApiController(List<Product> Products)
        {
            this._Products = Products;
        }

        // GET: api/Api
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Api/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Api
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Api/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Api/5
        public void Delete(int id)
        {
        }
    }
}
