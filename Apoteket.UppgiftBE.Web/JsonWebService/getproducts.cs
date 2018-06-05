using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using JsonWebService.productsTableAdapters;
using Newtonsoft.Json;

namespace JsonWebService
{
    public class getproducts : IHttpHandler
    {
        private productsTableAdapters.ProductsTableAdapter taProducts;
        private products.ProductsDataTable dtProducts;

        public void ProcessRequest(HttpContext context)
        {
            try
            {
                switch (context.Request.HttpMethod)
                {
                    case "POST":

                       break;

                    case "GET":
                        taProducts = new productsTableAdapters.ProductsTableAdapter();
                        dtProducts = taProducts.GetProductsName();

                        string json = string.Empty;
                        json = JsonConvert.SerializeObject(dtProducts); //the datatable
                        HttpContext.Current.Response.Write(json);;  // response back
                        break;
                    default:

                        break;
                }
            }
            catch (Exception e)
            {
                HttpContext.Current.Response.Write("Error in Web Service");
                throw;
            }
            
        }

        public bool IsReusable
        {
            get
            {
                return true;
            }
        }
    }
}
