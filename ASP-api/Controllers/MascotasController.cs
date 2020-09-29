using ASP_api.Models;
using ASP_api.Models.ws;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ASP_api.Controllers
{
    public class MascotasController : BaseController
    {
        [HttpGet]
        public Reply Get(VMSecurity Token)
        {
            Reply reply = new Reply();
            reply.Ok = false;
            if (!Verify(Token.token))
            {
                reply.Message = "Error de autenticacion";
                return reply;
            }
            try
                {
                    using (var db=new APIProyectEntities())
                    {
                        var lst = db.Mascotas.ToList();
                        reply.Ok = true;
                        reply.Datos = lst;
                        reply.Message = "okok";
                    }
                }
                catch (Exception ex)
                {
                    reply.Message = "Error: "+ex.Message;
                }
            
            return reply;
        }
    }
}
