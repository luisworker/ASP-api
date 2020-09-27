using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ASP_api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de API web

            // Rutas de API web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            //Para enviar todos los controladores en json serializados
            //var formatoControler = GlobalConfiguration.Configuration.Formatters.JsonFormatter;
            //formatoControler.SerializerSettings.ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver();
        }
    }
}
