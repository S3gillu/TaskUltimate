﻿using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Http;
using Data_table.App_Start;
using System.Web.Optimization;
using AutoMapper;
using TaskUltimate.App_Start;

namespace TaskUltimate
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
          
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Mapper.Initialize(c => c.AddProfile<MappingProfile>());
            BundleTable.EnableOptimizations = true;
        }
    }
}