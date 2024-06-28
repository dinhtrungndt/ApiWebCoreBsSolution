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
        public HttpResponseMessage GetAll()
        {
            string[] producs = { "TV", "Washing Machine", "Fridge", "Microwave" };
            return Request.CreateResponse(HttpStatusCode.OK, producs);
        }

        public HttpResponseMessage GetProduct(int id)
        {
            string[] producs = { "TV", "Washing Machine", "Fridge", "Microwave" };
            if(id >= 0 && id <= 3)
            {
                return Request.CreateResponse(HttpStatusCode.OK, producs[id]);
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
