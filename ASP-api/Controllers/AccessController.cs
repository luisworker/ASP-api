using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ASP_api.Models;
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
        [HttpPost]
        public Reply Login([FromBody]VMLoguin login) {
            var reply = new Reply();
            reply.Ok = false;
            try
            {
                using (APIProyectEntities db=new APIProyectEntities())
                {
                    var lst = db.User.Where(d=>d.email==login.Email && d.pass==login.Password&&d.status==1);
                    if (lst.Count()>0)
                    {
                        reply.Ok = true;
                        var guid = Guid.NewGuid().ToString();
                        reply.Datos = guid;
                        lst.First().token = guid;
                        db.SaveChanges();
                        reply.Message = "OKOK";
                    }
                    else
                    {
                        reply.Message = "Datos Incorrectos";
                    }
                }
               
            }
            catch (Exception ex)
            {
                reply.Ok = false;
                reply.Message = "Error En autentificacion: "+ex.Message;
            }
            return reply;
        }
    }
}
