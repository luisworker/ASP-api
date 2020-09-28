using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ASP_api.Models.ws;
namespace ASP_api.Controllers
{
    public class AccessController : ApiController
    {
        [HttpGet]
        public Reply Hello()
        {
            Reply reply = new Reply();
            reply.Ok = true;
            reply.Message = "hola mundo";
            //string  serjson=JsonConvert.SerializeObject(reply);
            //return serjson;
            return reply;
        }
    }
}
