using ASP_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ASP_api.Controllers
{
    public class BaseController : ApiController
    {
        public bool Verify(string token) {
            using (var db=new APIProyectEntities())
            {
                var lst = db.User.Where(a => a.token == token && a.status == 1);
                if (lst.Count() > 0)
                    return true;
            }
            return false;
        }
    }
}
