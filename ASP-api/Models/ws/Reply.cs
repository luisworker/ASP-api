using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_api.Models.ws
{
    public class Reply
    {
        public bool Ok { get; set; }
        public object Datos { get; set; }
        public string Message { get; set; }
    }
}