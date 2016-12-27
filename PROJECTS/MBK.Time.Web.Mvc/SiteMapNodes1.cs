
 
 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcSiteMapProvider;
using MBK.Time.Web.Mvc.Resources;
using SFSdotNet.Framework.Web.Mvc.Resources;


namespace MBK.Time.Web.Mvc
{
    public partial class DynamicNodeProvider : DynamicNodeProviderBase
    {
        partial void OnCreatingNodes(object sender, ref List<DynamicNode> nodes);
        partial void OnCreatedNodes(object sender, ref List<DynamicNode> nodes);
   
       public override IEnumerable<DynamicNode> GetDynamicNodeCollection(ISiteMapNode startNode)
        {
            List<DynamicNode> nodes = new List<DynamicNode>();
            DynamicNode node = null;
             SFSdotNet.Framework.Globalization.TextUI textUI = new SFSdotNet.Framework.Globalization.TextUI("MBKTime", null);

			node = new DynamicNode();
            node.Title = ModuleResources.MODULE_NAME;
			
            node.Controller = "Navigation";
            node.Area = "";
            node.Action = "Index";
            node.Key = "MBKTime";
			node.RouteValues.Add("id", node.Key);
			node.RouteValues.Add("overrideModule", "MBKTime");

 			node.Attributes.Add("moduleKey", "MBKTime");
            node.Attributes.Add("permissionKey", "r");    
 
 
			textUI.SetTextTo(node, "Title", typeof(ModuleResources), "MODULE_NAME");
                   
            nodes.Add(node);

			
            node = new DynamicNode();
            node.Title = ModuleResources.CATALOGS;
			  
            node.Controller = "Navigation";
            node.Area = "";
            node.Action = "Index";
            node.Key = "MBKTime_Catalogs";
			node.RouteValues.Add("id", node.Key);
			node.RouteValues.Add("overrideModule", "MBKTime");

			node.Attributes.Add("moduleKey", "MBKTime");
			node.ParentKey = "MBKTime";
			 textUI.SetTextTo(node, "Title", typeof(ModuleResources), "CATALOGS");
         
            nodes.Add(node);
			
			
          /*  node = new DynamicNode();
            node.Title = ModuleResources.all_catalogs;
			 
            node.Controller = "Navigation";
            node.Area = "";
            node.Action = "Index";
            node.Key = "MBKTime_all_catalogs";
			node.RouteValues.Add("id", node.Key);
			node.Attributes.Add("moduleKey", "MBKTime");
			node.RouteValues.Add("overrideModule", "MBKTime");

			node.ParentKey = "MBKTime_Catalogs";
			 textUI.SetTextTo(node, "Title", typeof(ModuleResources), "all_catalogs");
          
            nodes.Add(node);*/


            node = new DynamicNode();
            //node.Title = SFSdotNet.Framework.Web.Mvc.Resources.GlobalMessages.USERS_AND_ROLES ;
            node.Controller = "secBusinessObjects";
            node.Area = "SFSdotNetFrameworkSecurity";
            node.Action = "Index";
            node.Key = "MBKTime_all_catalogs";
            node.ParentKey = "MBKTime_Catalogs";
            node.Attributes.Add("moduleKey", "SFSdotNetFrameworkSecurity");
            node.RouteValues.Add("overrideModule", "MBKTime");
            node.RouteValues.Add("usemode", "all-catalogs");

            //node.Attributes.Add("permissionKey", "admin");
            textUI.SetTextTo(node, "Title", typeof(SFSdotNet.Framework.Web.Mvc.Resources.GlobalMessages), "ALL_CATALOGS");

            nodes.Add(node);

            
			//node for contents
			node = new DynamicNode();
            node.Title = ModuleResources.MODULE_NAME;
		  
            node.Controller = "Home";
            node.Area = "";
            node.Action = "App";
            node.Key = "MBKTime_home_app_c";
            node.RouteValues.Add("id", "MBKTime");
			node.Attributes.Add("moduleKey", "MBKTime");
			node.RouteValues.Add("overrideModule", "MBKTime");

            node.ParentKey = "allapps";
				 textUI.SetTextTo(node, "Title", typeof(ModuleResources), "MODULE_NAME");
         
            nodes.Add(node);

			
		    OnCreatingNodes(this, ref nodes);

           List<SFSdotNet.Framework.Globalization.UITexts> entityTexts =   textUI.GetItems("en");
           string single = "";
           string plural = "";
           SFSdotNet.Framework.Globalization.UITexts entityText = null ;
	

			#region timeTask
			  plural = "";
            single = "";
            entityText = entityTexts.FirstOrDefault(p => p.EntityKey == "timeTask");
            if (entityText != null)
            {
                plural = entityText.PluralName;
                single = entityText.Name;
            }

            node = new DynamicNode();
            node.Title = !string.IsNullOrEmpty(plural) ? plural : "timeTasks";
		
		       node.Controller = "timeTasks";
            node.Area = "MBKTime";
            node.Action = "Index";
            node.Key = "MBKTime_timeTask_List";
			//node.CacheResolvedUrl = true;
			node.ParentKey = "MBKTime_all_catalogs";
 			node.Attributes.Add("moduleKey", "MBKTime");
            node.Attributes.Add("businessObjectKey", "timeTask");
            node.Attributes.Add("permissionKey", "r");            
			nodes.Add(node);

			
			// Create
			node = new DynamicNode();
            node.Title =GlobalMessages.ADD_NEW;
            node.Controller = "timeTasks";
            node.Area = "MBKTime";
            node.Action = "CreateGen";
            node.Key = "MBKTime_timeTask_Create";
			node.ParentKey = "MBKTime_timeTask_List";
			node.Attributes.Add("moduleKey", "MBKTime");
            node.Attributes.Add("businessObjectKey", "timeTask");
			node.Attributes.Add("visiblemenu", "false");
			
			
            nodes.Add(node);

			// Edit
			//node = new DynamicNode();
            //node.Title = timeTaskResources.TIMETASKS_EDIT;
            //node.Controller = "timeTasks";
            //node.Area = "MBKTime";
            //node.Action = "EditGen";
            //node.Key = "MBKTime_timeTask_Edit";
			//node.ParentKey = "MBKTime_timeTask_List";
			//node.Attributes.Add("visible", "false");
			//node.Attributes.Add("dynamicParameters", "id");
			//node.Attributes.Add("isDynamic", "true");
            //nodes.Add(node);

			// Details
			node = new DynamicNode();
           //node.Title = !string.IsNullOrEmpty(single) ? single : "timeTask";
            node.Controller = "timeTasks";
            node.Area = "MBKTime";
            node.Action = "DetailsGen";
            node.Key = "MBKTime_timeTask_Details";
			node.ParentKey = "MBKTime_timeTask_List";
			node.Attributes.Add("visible", "false");
			node.Attributes.Add("dynamicParameters", "id");
			node.Attributes.Add("isDynamic", "true");
			node.Attributes.Add("moduleKey", "MBKTime");
            node.Attributes.Add("businessObjectKey", "timeTask");
			node.PreservedRouteParameters.Add("id");
            nodes.Add(node); 

			#endregion

 			OnCreatedNodes(this, ref nodes);
			
			node = new DynamicNode();
            //node.Title = SFSdotNet.Framework.Web.Mvc.Resources.GlobalMessages.SYSTEM;
            node.Controller = "Navigation";
            node.Area = "";
            node.Action = "Index";
            node.Key = "MBKTime_System_override";
            node.RouteValues.Add("id", node.Key);
            node.RouteValues.Add("overrideModule", "MBKTime");
            
			node.ParentKey = "MBKTime";
			node.Attributes.Add("moduleKey", "MBKTime");
			 node.Attributes.Add("permissionKey", "admin");
			 textUI.SetTextTo(node, "Title", typeof(SFSdotNet.Framework.Web.Mvc.Resources.GlobalMessages), "SYSTEM");

            nodes.Add(node);



			  node = new DynamicNode();
            //node.Title = SFSdotNet.Framework.Web.Mvc.Resources.GlobalMessages.USERS_AND_ROLES ;
            node.Controller = "secRoles";
            node.Area = "SFSdotNetFrameworkSecurity";
            node.Action = "Index";
            node.Key = "SFSdotNetFrameworkSecurity_MBKTime_roles";
            node.ParentKey = "MBKTime_System_override";
            node.Attributes.Add("moduleKey", "MBKTime");
                      node.RouteValues.Add("overrideModule", "MBKTime");
            node.Attributes.Add("permissionKey", "admin");
            textUI.SetTextTo(node, "Title", typeof(SFSdotNet.Framework.Web.Mvc.Resources.GlobalMessages), "ROLES");

            nodes.Add(node);




			 node = new DynamicNode();
            //node.Title = SFSdotNet.Framework.Web.Mvc.Resources.GlobalMessages.USERS_AND_ROLES ;
            node.Controller = "secUserCompanies";
            node.Area = "SFSdotNetFrameworkSecurity";
            node.Action = "Index";
            node.Key = "SFSdotNetFrameworkSecurity_MBKTime_user_companies";
            node.ParentKey = "MBKTime_System_override";
            node.Attributes.Add("moduleKey", "MBKTime");
            node.RouteValues.Add("overrideModule", "MBKTime");
            node.Attributes.Add("permissionKey", "admin");
			textUI.SetTextTo(node, "Title", typeof(SFSdotNet.Framework.Web.Mvc.Resources.GlobalMessages), "USERS_AND_ROLES");

            nodes.Add(node);

			
			 node = new DynamicNode();
            node.Controller = "secCompanies";
            node.Area = "SFSdotNetFrameworkSecurity";
            node.Action = "Index";
            node.Key = "SFSdotNetFrameworkSecurity_MBKTime_child_companies";
            node.ParentKey = "MBKTime_System_override";
            node.Attributes.Add("moduleKey", "MBKTime");
            node.RouteValues.Add("overrideModule", "MBKTime");
			node.RouteValues.Add("usemode", "children");
            node.Attributes.Add("permissionKey", "admin");
			textUI.SetTextTo(node, "Title", typeof(SFSdotNet.Framework.Web.Mvc.Resources.GlobalMessages), "COMPANIES_CHILDS");

            nodes.Add(node);
			 node = new DynamicNode();
            //node.Title = SFSdotNet.Framework.Web.Mvc.Resources.GlobalMessages.EVENT_LOG;
            node.Controller = "secEventLogs";
            node.Area = "SFSdotNetFrameworkSecurity";
            node.Action = "Index";
            node.Key = "SFSdotNetFrameworkSecurity_MBKTime_EventLogs";
            node.ParentKey = "MBKTime_System_override";
            node.Attributes.Add("moduleKey", "MBKTime");

            node.RouteValues.Add("overrideModule", "MBKTime");

			
            node.Attributes.Add("permissionKey", "admin");
			textUI.SetTextTo(node, "Title", typeof(SFSdotNet.Framework.Web.Mvc.Resources.GlobalMessages), "EVENT_LOG");

            nodes.Add(node);
			 node = new DynamicNode();
            //node.Title = SFSdotNet.Framework.Web.Mvc.Resources.GlobalMessages.EVENT_LOG;
            node.Controller = "Dashboard";
            node.Area = "SFSdotNetFrameworkSecurity";
            node.Action = "Statics";
            node.Key = "SFSdotNetFrameworkSecurity_MBKTime_Statics";
            node.ParentKey = "MBKTime_System_override";
            node.Attributes.Add("moduleKey", "MBKTime");

            node.RouteValues.Add("overrideModule", "MBKTime");
            node.Attributes.Add("permissionKey", "admin");
            textUI.SetTextTo(node, "Title", typeof(SFSdotNet.Framework.Web.Mvc.Resources.GlobalMessages), "SERVICE_USE_STATICS");

            nodes.Add(node);


			 node = new DynamicNode();
           // node.Title = SFSdotNet.Framework.Web.Mvc.Resources.GlobalMessages.CHANGE_AUDITING;
            node.Controller = "secAudits";
            node.Area = "SFSdotNetFrameworkSecurity";
            node.Action = "Index";
            node.Key = "SFSdotNetFrameworkSecurity_MBKTime_ChangeAutiting";
            node.ParentKey = "MBKTime_System_override";
            node.Attributes.Add("moduleKey", "MBKTime");
            node.RouteValues.Add("overrideModule", "MBKTime");
            node.Attributes.Add("permissionKey", "admin");
			 textUI.SetTextTo(node, "Title", typeof(SFSdotNet.Framework.Web.Mvc.Resources.GlobalMessages), "CHANGE_AUDITING");

            nodes.Add(node);




            return nodes;
        }
    }
}
