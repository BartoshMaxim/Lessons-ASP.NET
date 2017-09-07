using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Lesson5
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //Вызов метода AreaRegistration.RegisterAllAreas(), производимый внутри метода Application_Start(), настраивает связанное средство, называемое областями
            AreaRegistration.RegisterAllAreas();
            //вызывается лежащей в основе платформой ASP.NET, когда приложение MVC запускается в первый раз, что приводит к вызову метода RouteConfig.RegisterRoutes(). 
            //Параметром этого метода является значение статического свойства RouteTable.Routes, представляющее собой экземпляр класса RouteCollection
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
