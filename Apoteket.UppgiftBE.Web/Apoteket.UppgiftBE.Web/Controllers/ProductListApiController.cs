using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Apoteket.UppgiftBE.Web.Controllers
{
    public class ProductListApiController : ApiController
    {
        // GET: api/ProductListApi
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/ProductListApi/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ProductListApi
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ProductListApi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ProductListApi/5
        public void Delete(int id)
        {
        }
    }
}
