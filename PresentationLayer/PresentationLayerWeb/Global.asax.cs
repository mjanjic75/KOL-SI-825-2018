using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using BusinessLayer;
using DataLayer;
using Unity;
using Shared.Interfaces.Business;
using Shared.Interfaces.Repository;
using Microsoft.AspNet.WebFormsDependencyInjection.Unity;

namespace PresentationLayerWeb {
	public class Global : HttpApplication {
		void Application_Start(object sender, EventArgs e) {
			var container = this.AddUnity();

			container.RegisterType<IStudentRepository, StudentRepository>();
			container.RegisterType<IStudentBusiness, StudentBusiness>();

			// Code that runs on application startup
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);
		}
	}
}