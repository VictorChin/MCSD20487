using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using NorthwindModels;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;
namespace WebAPIOdata
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            ODataModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<Customer>("Customers");
            builder.EntitySet<Category>("Categories");
            builder.EntitySet<Product>("Products");
            config.MapODataServiceRoute(
                routeName: "ODataRoute",
                routePrefix: "odata",
                model: builder.GetEdmModel());
            // Web API configuration and services

            // Web API routes
       
        }
    }
}
