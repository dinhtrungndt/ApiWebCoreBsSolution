using ApiWebCoreBs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiWebCoreBs.Controllers
{
    public class ProductController : ApiController
    {
        List<Product> products = new List<Product>()
        {
            new Product {ProductID = 1, Name = "TV", Price = 60000},
            new Product {ProductID = 2, Name = "Washing Machine", Price = 40000},
            new Product {ProductID = 3, Name = "Fridge", Price = 100000},

        };

        public HttpResponseMessage GetAll()
        {
            // string[] products = { "TV", "Washing Machine", "Fridge", "Microwave" };
            return Request.CreateResponse(HttpStatusCode.OK, products);
        }

        public HttpResponseMessage GetProduct(int id)
        {
            // string[] products = { "TV", "Washing Machine", "Fridge", "Microwave" };
            if (id >= 0 && id <= 3)
            {
                return Request.CreateResponse(HttpStatusCode.OK, products[id]);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Invalid ID");
            }
        }

        public IHttpActionResult PostMessage(String name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                return Ok("Hello " + name);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
