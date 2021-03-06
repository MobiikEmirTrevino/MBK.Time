﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using MvcContrib;
using SFSdotNet.Framework.My;
using SFSdotNet.Framework.Web.Mvc;
using SFSdotNet.Framework.Web.Mvc.Models;

namespace MBK.Time.Web.Mvc
{
    public partial class ControllerBase<T> : SFSdotNet.Framework.Web.Mvc.ControllerBase<T> where T : class
    {
        public void LayoutSettings(object sender, MyEventArgs<UIModel<T>> e)
        {
            OnLayoutSettings(sender, e);
        }
        protected override void OnVirtualLayoutSettings(object sender, MyEventArgs<UIModel<T>> e)
        {
            OnLayoutSettings(sender, e);
        }

        partial void OnLayoutSettings(object sender, MyEventArgs<UIModel<T>> e);

        partial void OnLayoutSettings(object sender, MyEventArgs<UIModel<T>> e)
        {
            e.UIModel.NewUILayoutTool = true;
            e.UIModel.UILayoutFile = "~/Views/Templates/AdminLTE.cshtml";
            e.UIModel.UIVersion = 2;
            ViewBag.IsAdmin = true;
            //if (Request != null && ( Request.Url.ToString().Contains("Home/Public") || Request.Url.ToString().Contains("cmeMeetings/OpenedMeeting") ))
            //{
            //    ViewBag.IsAdmin = false;
            //    e.UIModel.DisableNavigationMenu = true;
            //    ViewData["class-body"] = "cme start sidebar-collapse sidebar-mini";

            //}
            ////ViewData["class-body"] = "layout-boxed layout-top-nav";
            //if (ViewBag.IsAdmin == false)
            //{
            //    string headerStriptText = SFSdotNet.Framework.Resources.Content.GetContent("MBKTime", "Views/HeaderScripts.html", GetContextRequest());
            //    string logoTopText = SFSdotNet.Framework.Resources.Content.GetContent("MBKTime", "Views/LogoTop.cshtml", GetContextRequest());
            //    string footer = SFSdotNet.Framework.Resources.Content.GetContent("MBKTime", "Views/Footer.cshtml", GetContextRequest());

            //    headerStriptText = headerStriptText.Replace("{APP_PATH}", VirtualPathUtility.ToAbsolute("~/"));
            //    logoTopText = logoTopText.Replace("{APP_PATH}", VirtualPathUtility.ToAbsolute("~/"));
            //    footer = footer.Replace("{LOGO_TOP}", "$(\".sidebar-toggle\").after('" + logoTopText + "')");
                
            //    ViewData["HeaderScript"] = headerStriptText;
            //    ViewData["FooterScript"] = footer;
            //}
            e.UIModel.ViewData = ViewData;
        }

    }
    public partial class MBKTimeWebMvcRegistration
    {
        partial void OnBusinessAppInfoRequest(object sender, BusinessModuleApp e)
        {
            
            e.UseOwnLayout = true;
            e.DefaultOwnLayout = "~/Views/Templates/AdminLTE.cshtml";
        }

        private static string CSSFile(string path)
        {
            return string.Format("<link href='{0}' rel='stylesheet' type='text/css' />", VirtualPathUtility.ToAbsolute(path));
        }
        private static string JScriptFile(string path)
        {
            return string.Format("<script src='{0}' type='text/javascript'></script>", VirtualPathUtility.ToAbsolute(path));
        }

        public static string GetAllScriptsAndCss()
        {
            string path = "MBKTime";


            StringBuilder sb = new StringBuilder();
            sb.Append(CSSFile("~/" + path + "/Content/Themes/Default/css/bootstrap.css"));
            sb.Append(CSSFile("~/" + path + "/Content/Themes/Default/css/bootstrap-responsive.min.css"));
            sb.Append(CSSFile("~/Content/jquery.qtip.min.css"));
            sb.Append(CSSFile("~/Content/pagination.css"));
            sb.Append(JScriptFile("~/Scripts/jquery.js"));
            sb.Append(JScriptFile("~/Scripts/jquery.qtip.min.js"));
            sb.Append(JScriptFile("~/Scripts/hoverIntent.js"));
            sb.Append(JScriptFile("~/Content/bootstrap/js/bootstrap.js"));
            //sb.Append(JScriptFile("~/Content/bootstrap/js/bootstrap-dropdown.js"));
            sb.Append(CSSFile("~/Content/Themes/Default/_styles.css"));
            sb.Append(CSSFile("~/" + path + "/Content/Themes/Default/_styles.css"));
            sb.Append(CSSFile("~/Content/jquery-ui.min.css"));

            sb.Append(JScriptFile("~/Scripts/jqueryui/jquery-ui.min.js"));
            sb.Append(JScriptFile("~/Scripts/jquery.ui.autocomplete.min.js"));
            sb.Append(JScriptFile("~/Scripts/MicrosoftAjax.debug.js"));
            sb.Append(JScriptFile("~/Scripts/MicrosoftMvcAjax.debug.js"));
            sb.Append(JScriptFile("~/Scripts/jquery.validate.js"));
            sb.Append(JScriptFile("~/Scripts/jquery.validate.unobtrusive.js"));
            sb.Append(JScriptFile("~/Scripts/jquery.unobtrusive-ajax.min.js"));
            sb.Append(JScriptFile("~/Scripts/jquery.qtip.min.js"));
            sb.Append(JScriptFile("~/Scripts/Jquery.Numeric.js"));
            sb.Append(JScriptFile("~/Scripts/jquery.maskedinput.js"));
            sb.Append(JScriptFile("~/Scripts/jquery.pagination.js"));
            sb.Append(JScriptFile("~/Scripts/jsrender.js"));
            sb.Append(JScriptFile("~/Scripts/timeago.js"));
            sb.Append(JScriptFile("~/Scripts/jquery.tablehover.min.js"));
            sb.Append(JScriptFile("~/Scripts/SFS.Web.Mvc.js"));

            return sb.ToString();
        }
        //
        partial void OnAreaRegistration(object sender, EventArgs e)
        {
            // especificar el masterpage y el dominio

        }
    }
}