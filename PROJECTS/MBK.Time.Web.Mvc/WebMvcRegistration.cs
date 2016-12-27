using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcContrib.PortableAreas;
using System.Web.Mvc;
using System.Configuration;
using System.Web.Routing;
using SFSdotNet.Framework.My;
using SFSdotNet.Framework.Web.Mvc;

namespace MBK.Time.Web.Mvc
{
    public partial class MBKTimeWebMvcRegistration : PortableAreaRegistration, IRegistrationModuleWithInfo
    {

        public override void RegisterArea(System.Web.Mvc.AreaRegistrationContext context, IApplicationBus bus)
        {
            #region MBKTime/Views/Shared/
            context.MapRoute("MBKTime_Views_Shared", "MBKTime/Views/Shared/{resourceName}",
                new { controller = "EmbeddedResource", action = "Index", resourcePath = "Views/Shared" },
                new string[] { "MvcContrib.PortableAreas" });
            #endregion

            #region MBKTime/Content/Themes/Default/
            context.MapRoute("MBKTime_ResourceRoute_theme", "MBKTime/Content/Themes/Default/{resourceName}",
                new { controller = "EmbeddedResource", action = "Index", resourcePath = "Content/Themes/Default" },
                new string[] { "MvcContrib.PortableAreas" });
            #endregion
            #region MBKTime/Content/Themes/Default/css/
            context.MapRoute("MBKTime_ResourceRoute_theme_css", "MBKTime/Content/Themes/Default/css/{resourceName}",
    new { controller = "EmbeddedResource", action = "Index", resourcePath = "Content/Themes/Default/css" },
    new string[] { "MvcContrib.PortableAreas" });
#endregion
            #region MBKTime/Content/Themes/Default/img/
            context.MapRoute("MBKTime_ResourceRoute_theme_img", "MBKTime/Content/Themes/Default/img/{resourceName}",
    new { controller = "EmbeddedResource", action = "Index", resourcePath = "Content/Themes/Default/img" },
    new string[] { "MvcContrib.PortableAreas" });
            #endregion
            #region MBKTime/Content/img/
            context.MapRoute("MBKTime_ResourceRoute_img", "MBKTime/Content/img/{resourceName}",
new { controller = "EmbeddedResource", action = "Index", resourcePath = "Content/img" },
new string[] { "MvcContrib.PortableAreas" });
            #endregion

            context.MapRoute("MBKTime_ResourceImageRoute", "MBKTime/images/{resourceName}",
                new { controller = "EmbeddedResource", action = "Index", resourcePath = "images" },
                new string[] { "MvcContrib.PortableAreas" });

            context.MapRoute("MBKTime_Default", 
                "MBKTime/{controller}/{action}",
                new { controller = "Home", 
                    action = "index" },
                new string[] { "MBK.Time.Web.Mvc.Controllers" 
                });

            context.MapRoute(
              "MBKTime_Id", // Route name
              "MBKTime/{controller}/{action}/{id}", // URL with parameters
              new { controller = "Home", 
                  action = "Index", 
                  id = UrlParameter.Optional }, 
                  new[] { "MBK.Time.Web.Mvc.Controllers" 
                  });

            //context.MapRoute(
            // "MBKTime_usemode_Id", // Route name
            // "MBKTime/{controller}/usemode/{usemode}/{action}/{id}", // URL with parameters
            // new
            // {
            //     controller = "Home",
            //     action = "Index",
            //     id = UrlParameter.Optional
            // },
            //     new[] { "MBK.Time.Web.Mvc.Controllers" 
            //      });
          

            
        
            //ControllerBuilder.Current.DefaultNamespaces.Add("MBK.Time.Web.Mvc.Controllers");

            this.RegisterAreaEmbeddedResources();
            if (Convert.ToBoolean(System.Configuration.ConfigurationManager.AppSettings["AutoInjectPermissionsOnStartup"]))
                SecuritySettings.PermissionsInitialization();

            OnAreaRegistration(this, new EventArgs());
        }
        public  SFSdotNet.Framework.My.BusinessModuleApp GetModuleInfo()
        {
            SFSdotNet.Framework.My.BusinessModuleApp result = new SFSdotNet.Framework.My.BusinessModuleApp();
            result.BusinessModulePath = "MBKTime";
            //result.DefaultOwnLayout = VirtualPathUtility.ToAbsolute("~/") + "Areas/" + result.BusinessModulePath + "/Views/Shared/_Layout.cshtml";
            result.UseOwnLayout = false;
            OnBusinessAppInfoRequest(this, result );
            return result;
        }
        partial void OnBusinessAppInfoRequest(object sender, BusinessModuleApp e);
        partial void OnAreaRegistration(object sender, EventArgs e);

        public override string AreaName
        {
            get
            {
                return "MBKTime";
            }
        }
    }
}
