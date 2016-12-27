// <Template>
//   <SolutionTemplate></SolutionTemplate>
//   <Version>20150126.0020</Version>
//   <Update>uiModel.ModuleNamespace</Update>
// </Template>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MBK.Time.BR;
using System.Web.Script.Serialization;
using MBK.Time.Web.Mvc.Models;
using MBK.Time.Web.Mvc.Resources;
using BO = MBK.Time.BusinessObjects;
using SFSdotNet.Framework.Web.Mvc.Security;
using SFSdotNet.Framework.Web.Mvc;
using SFSdotNet.Framework.Web.Mvc.Models;
using SFSdotNet.Framework.Web.Mvc.Resources;
using SFSdotNet.Framework.Web.Mvc.Controllers;
using MvcSiteMapProvider;
using System.Web.Routing;
using System.Collections;

using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using SFSdotNet.Framework.My;

using MBK.Time.BusinessObjects;

namespace MBK.Time.Web.Mvc.Controllers
{
	using MBK.Time.Web.Mvc.Models.timeTasks;

    public partial class timeTasksController : MBK.Time.Web.Mvc.ControllerBase<Models.timeTasks.timeTaskModel>
    {

       


	#region partial methods
        ControllerEventArgs<Models.timeTasks.timeTaskModel> e = null;
        partial void OnValidating(object sender, ControllerEventArgs<Models.timeTasks.timeTaskModel> e);
        partial void OnGettingExtraData(object sender, MyEventArgs<UIModel<Models.timeTasks.timeTaskModel>> e);
        partial void OnCreating(object sender, ControllerEventArgs<Models.timeTasks.timeTaskModel> e);
        partial void OnCreated(object sender, ControllerEventArgs<Models.timeTasks.timeTaskModel> e);
        partial void OnEditing(object sender, ControllerEventArgs<Models.timeTasks.timeTaskModel> e);
        partial void OnEdited(object sender, ControllerEventArgs<Models.timeTasks.timeTaskModel> e);
        partial void OnDeleting(object sender, ControllerEventArgs<Models.timeTasks.timeTaskModel> e);
        partial void OnDeleted(object sender, ControllerEventArgs<Models.timeTasks.timeTaskModel> e);
    	partial void OnShowing(object sender, MyEventArgs<UIModel<Models.timeTasks.timeTaskModel>> e);
    	partial void OnGettingByKey(object sender, ControllerEventArgs<Models.timeTasks.timeTaskModel> e);
        partial void OnTaken(object sender, ControllerEventArgs<Models.timeTasks.timeTaskModel> e);
       	partial void OnCreateShowing(object sender, ControllerEventArgs<Models.timeTasks.timeTaskModel> e);
		partial void OnEditShowing(object sender, ControllerEventArgs<Models.timeTasks.timeTaskModel> e);
		partial void OnDetailsShowing(object sender, ControllerEventArgs<Models.timeTasks.timeTaskModel> e);
 		partial void OnActionsCreated(object sender, MyEventArgs<UIModel<Models.timeTasks.timeTaskModel >> e);
		partial void OnCustomActionExecuting(object sender, MyEventArgs<ContextActionModel<Models.timeTasks.timeTaskModel>> e);
		partial void OnCustomActionExecutingBackground(object sender, MyEventArgs<ContextActionModel<Models.timeTasks.timeTaskModel>> e);
        partial void OnDownloading(object sender, MyEventArgs<ContextActionModel<Models.timeTasks.timeTaskModel>> e);
      	partial void OnAuthorization(object sender, AuthorizationContext context);
		 partial void OnFilterShowing(object sender, MyEventArgs<UIModel<Models.timeTasks.timeTaskModel >> e);
         partial void OnSummaryOperationShowing(object sender, MyEventArgs<UIModel<Models.timeTasks.timeTaskModel>> e);

        partial void OnExportActionsCreated(object sender, MyEventArgs<UIModel<Models.timeTasks.timeTaskModel>> e);


		protected override void OnVirtualFilterShowing(object sender, MyEventArgs<UIModel<timeTaskModel>> e)
        {
            OnFilterShowing(sender, e);
        }
		 public override void OnVirtualExportActionsCreated(object sender, MyEventArgs<UIModel<timeTaskModel>> e)
        {
            OnExportActionsCreated(sender, e);
        }
        public override void OnVirtualDownloading(object sender, MyEventArgs<ContextActionModel<timeTaskModel>> e)
        {
            OnDownloading(sender, e);
        }
        public override void OnVirtualShowing(object sender, MyEventArgs<UIModel<timeTaskModel>> e)
        {
            OnShowing(sender, e);
        }

	#endregion
	#region API
	 public override ActionResult ApiCreateGen(timeTaskModel model, ContextRequest contextRequest)
        {
            return CreateGen(model, contextRequest);
        }

              public override ActionResult ApiGetByJson(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest, object[] extraParams)
        {
            return GetByJson(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);
        }
        public override ActionResult ApiGetByKeyJson(string id, ContextRequest contextRequest)
        {
            return  GetByKeyJson(id, contextRequest, true);
        }
      
		 public override int ApiGetByCount(string filter, ContextRequest contextRequest)
        {
            return GetByCount(filter, contextRequest);
        }
         protected override ActionResult ApiDeleteGen(List<timeTaskModel> models, ContextRequest contextRequest)
        {
            List<timeTask> objs = new List<timeTask>();
            foreach (var model in models)
            {
                objs.Add(model.GetBusinessObject());
            }
            try
            {
                BR.timeTasksBR.Instance.DeleteBulk(objs, contextRequest);
                return Json("ok", JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(ex.ToString(), JsonRequestBehavior.AllowGet);
            }
        }
        protected override ActionResult ApiUpdateGen(List<timeTaskModel> models, ContextRequest contextRequest)
        {
            List<timeTask> objs = new List<timeTask>();
            foreach (var model in models)
            {
                objs.Add(model.GetBusinessObject());
            }
            try
            {
                foreach (var obj in objs)
                {
                    BR.timeTasksBR.Instance.Update(obj, contextRequest);

                }
                return Json("ok", JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(ex.ToString(), JsonRequestBehavior.AllowGet);
            }
        }


	#endregion
#region Validation methods	
	    private void Validations(timeTaskModel model) { 
            #region Remote validations

            #endregion
		}

#endregion
		
 		public AuthorizationContext Authorization(AuthorizationContext context)
        {
            OnAuthorization(this,  context );
            return context ;
        }
		public List<timeTaskModel> GetAll() {
            			var bos = BR.timeTasksBR.Instance.GetBy("",
					new SFSdotNet.Framework.My.ContextRequest()
					{
						CustomQuery = new SFSdotNet.Framework.My.CustomQuery()
						{
							OrderBy = "Name",
							SortDirection = SFSdotNet.Framework.Data.SortDirection.Ascending
						}
					});
            			List<timeTaskModel> results = new List<timeTaskModel>();
            timeTaskModel model = null;
            foreach (var bo in bos)
            {
                model = new timeTaskModel();
                model.Bind(bo);
                results.Add(model);
            }
            return results;

        }
        //
        // GET: /timeTasks/
		[MyAuthorize("r", "timeTask", "MBKTime", typeof(timeTasksController))]
		public ActionResult Index()
        {
    		var uiModel = GetContextModel(UIModelContextTypes.ListForm, null);
			ViewBag.UIModel = uiModel;
			uiModel.FilterStart = (string)ViewData["startFilter"];
                    MyEventArgs<UIModel<timeTaskModel>> me = null;

            OnActionsCreated(this, me = new MyEventArgs<UIModel<timeTaskModel>>() { Object = uiModel });

			OnExportActionsCreated(this, (me != null ? me : me = new MyEventArgs<UIModel<timeTaskModel>>() { Object = uiModel }));

            if (me != null)
            {
                uiModel = me.Object;
            }
            if (me == null)
                me = new MyEventArgs<UIModel<timeTaskModel>>() { Object = uiModel };
           
            Showing(ref uiModel);
            ViewData["startFilter"] = uiModel.FilterStart;


            //return View("ListGen");
			return ResolveView(uiModel);
        }
		[MyAuthorize("r", "timeTask", "MBKTime", typeof(timeTasksController))]
		public ActionResult ListViewGen(string idTab, string fk , string fkValue, string startFilter, ListModes  listmode  = ListModes.SimpleList, PropertyDefinition parentRelationProperty = null, object parentRelationPropertyValue = null )
        {
			ViewData["idTab"] = System.Web.HttpContext.Current.Request.QueryString["idTab"]; 
		 	ViewData["detpop"] = true; // details in popup
            if (!string.IsNullOrEmpty(System.Web.HttpContext.Current.Request.QueryString["fk"])) {
                ViewData["fk"] = System.Web.HttpContext.Current.Request.QueryString["fk"]; 
            }
			if (!string.IsNullOrEmpty(System.Web.HttpContext.Current.Request.QueryString["fkValue"]))
            {
                ViewData["fkValue"] = System.Web.HttpContext.Current.Request.QueryString["fkValue"];
            }
			if (!string.IsNullOrEmpty(System.Web.HttpContext.Current.Request.QueryString["startFilter"]))
            {
                ViewData["startFilter"] = Request.QueryString["startFilter"];
            }
			
			UIModel<timeTaskModel> uiModel = GetContextModel(UIModelContextTypes.ListForm, null);

            MyEventArgs<UIModel<timeTaskModel>> me = null;

            OnActionsCreated(this, me = new MyEventArgs<UIModel<timeTaskModel>>() { Object = uiModel });
            if (me == null)
                me = new MyEventArgs<UIModel<timeTaskModel>>() { Object = uiModel };
            uiModel.Properties = GetProperties(uiModel);
            uiModel.ContextType = UIModelContextTypes.ListForm;
             uiModel.FilterStart = (string)ViewData["startFilter"];
            Showing(ref uiModel);
            ViewData["startFilter"] = uiModel.FilterStart;
			 if (listmode == ListModes.SimpleList)
                return ResolveView(uiModel);
            else
            {
                ViewData["parentRelationProperty"] = parentRelationProperty;
                ViewData["parentRelationPropertyValue"] = parentRelationPropertyValue;
                return PartialView("ListForTagSelectView");
            }
            return ResolveView(uiModel);
        }
		List<PropertyDefinition> _properties = null;

		 protected override List<PropertyDefinition> GetProperties(UIModel uiModel,  params string[] specificProperties)
        { 
            return GetProperties(uiModel, false, null, specificProperties);
        }

		protected override List<PropertyDefinition> GetProperties(UIModel uiModel, bool decripted, Guid? id, params string[] specificProperties)
            {

			bool allProperties = true;    
                if (specificProperties != null && specificProperties.Length > 0)
                {
                    allProperties = false;
                }


			List<CustomProperty> customProperties = new List<CustomProperty>();
			if (_properties == null)
                {
                List<PropertyDefinition> results = new List<PropertyDefinition>();

			string idtimeTask = GetRouteDataOrQueryParam("id");
			if (idtimeTask != null)
			{
				if (!decripted)
                {
					idtimeTask = SFSdotNet.Framework.Entities.Utils.GetPropertyKey(idtimeTask.Replace("-","/"), "GuidTask");
				}else{
					if (id != null )
						idtimeTask = id.Value.ToString();                

				}
			}

			bool visibleProperty = true;	
			 bool conditionalshow =false;
                if (uiModel.ContextType == UIModelContextTypes.EditForm || uiModel.ContextType == UIModelContextTypes.DisplayForm ||  uiModel.ContextType == UIModelContextTypes.GenericForm )
                    conditionalshow = true;
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("GuidTask"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "GuidTask")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 100,
																	
					CustomProperties = customProperties,

                    PropertyName = "GuidTask",

					 MaxLength = 0,
					IsRequired = true ,
					IsHidden = true,
                    SystemProperty =  SystemProperties.Identifier ,
					IsDefaultProperty = false,
                    SortBy = "GuidTask",
					
	
                    TypeName = "Guid",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "MBKTime/"
                    /*,PropertyDisplayName = Resources.timeTaskResources.GUIDTASK*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("Name"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "Name")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 101,
																	
					CustomProperties = customProperties,

                    PropertyName = "Name",

					 MaxLength = 255,
					 Nullable = true,
					IsDefaultProperty = true,
                    SortBy = "Name",
					
	
                    TypeName = "String",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "MBKTime/"
                    /*,PropertyDisplayName = Resources.timeTaskResources.NAME*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("Hours"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "Hours")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 102,
																	
					CustomProperties = customProperties,

                    PropertyName = "Hours",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "Hours",
					
	
                    TypeName = "Int32",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "MBKTime/"
                    /*,PropertyDisplayName = Resources.timeTaskResources.HOURS*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("HoursWorked"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "HoursWorked")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 103,
																	
					CustomProperties = customProperties,

                    PropertyName = "HoursWorked",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "HoursWorked",
					
	
                    TypeName = "Int64",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "MBKTime/"
                    /*,PropertyDisplayName = Resources.timeTaskResources.HOURSWORKED*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("StartDate"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "StartDate")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 104,
																	
					CustomProperties = customProperties,

                    PropertyName = "StartDate",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "StartDate",
					
	
                    TypeName = "DateTime",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "MBKTime/"
                    /*,PropertyDisplayName = Resources.timeTaskResources.STARTDATE*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("EndDate"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "EndDate")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 105,
																	
					CustomProperties = customProperties,

                    PropertyName = "EndDate",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "EndDate",
					
	
                    TypeName = "DateTime",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "MBKTime/"
                    /*,PropertyDisplayName = Resources.timeTaskResources.ENDDATE*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("CreatedDate"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "CreatedDate")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 106,
																	
					CustomProperties = customProperties,

                    PropertyName = "CreatedDate",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "CreatedDate",
					
	
				SystemProperty = SystemProperties.CreatedDate ,
                    TypeName = "DateTime",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "MBKTime/"
                    /*,PropertyDisplayName = Resources.timeTaskResources.CREATEDDATE*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("UpdatedDate"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "UpdatedDate")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 120,
																	
					CustomProperties = customProperties,

                    PropertyName = "UpdatedDate",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "UpdatedDate",
					
	
					IsUpdatedDate = true,
					SystemProperty = SystemProperties.UpdatedDate ,
	
                    TypeName = "DateTime",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "MBKTime/"
                    ,PropertyDisplayName = SFSdotNet.Framework.Web.Mvc.Resources.GlobalMessages.UPDATED

                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("CreatedBy"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "CreatedBy")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 108,
																	
					CustomProperties = customProperties,

                    PropertyName = "CreatedBy",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "CreatedBy",
					
	
				SystemProperty = SystemProperties.CreatedUser,
                    TypeName = "Guid",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "MBKTime/"
                    /*,PropertyDisplayName = Resources.timeTaskResources.CREATEDBY*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("UpdatedBy"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "UpdatedBy")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 109,
																	
					CustomProperties = customProperties,

                    PropertyName = "UpdatedBy",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "UpdatedBy",
					
	
				SystemProperty = SystemProperties.UpdatedUser,
                    TypeName = "Guid",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "MBKTime/"
                    /*,PropertyDisplayName = Resources.timeTaskResources.UPDATEDBY*/
                });
		//	}
	
	}
visibleProperty =allProperties;
if (visibleProperty || specificProperties.Contains("Bytes"))
{				
    customProperties = new List<CustomProperty>();

        
	
	//Null
		//if (this.Request.QueryString["fk"] != "Bytes")
        //	{
				results.Add(new PropertyDefinition()
                {
					Order = 110,
																	
					CustomProperties = customProperties,

                    PropertyName = "Bytes",

					 MaxLength = 0,
					 Nullable = true,
					IsDefaultProperty = false,
                    SortBy = "Bytes",
					
	
				SystemProperty = SystemProperties.SizeBytes,
                    TypeName = "Int32",
                    IsNavigationProperty = false,
					IsNavigationPropertyMany = false,
                    PathName = "MBKTime/"
                    /*,PropertyDisplayName = Resources.timeTaskResources.BYTES*/
                });
		//	}
	
	}
	
				
                    _properties = results;
                    return _properties;
                }
                else {
                    return _properties;
                }
            }

		protected override  UIModel<timeTaskModel> GetByForShow(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest, params  object[] extraParams)
        {
			if (Request != null )
				if (!string.IsNullOrEmpty(Request.QueryString["q"]))
					filter = filter + HttpUtility.UrlDecode(Request.QueryString["q"]);
 if (contextRequest == null)
            {
                contextRequest = new ContextRequest();
                contextRequest.CurrentContext = SFSdotNet.Framework.My.Context.CurrentContext;
            }
            var bos = BR.timeTasksBR.Instance.GetBy(HttpUtility.UrlDecode(filter), pageSize, page, orderBy, orderDir, GetUseMode(), contextRequest, extraParams);
			//var bos = BR.timeTasksBR.Instance.GetBy(HttpUtility.UrlDecode(filter), pageSize, page, orderBy, orderDir, GetUseMode(), context, extraParams);
            timeTaskModel model = null;
            List<timeTaskModel> results = new List<timeTaskModel>();
            foreach (var item in bos)
            {
                model = new timeTaskModel();
				model.Bind(item);
				results.Add(model);
            }
            //return results;
			UIModel<timeTaskModel> uiModel = GetContextModel(UIModelContextTypes.Items, null);
            uiModel.Items = results;
			if (Request != null){
				if (SFSdotNet.Framework.Web.Utils.GetRouteDataOrQueryParam(Request.RequestContext, "action") == "Download")
				{
					uiModel.ContextType = UIModelContextTypes.ExportDownload;
				}
			}
            Showing(ref uiModel);
            return uiModel;
		}			
		
		//public List<timeTaskModel> GetBy(string filter, int? pageSize, int? page, string orderBy, string orderDir,  params  object[] extraParams)
        //{
		//	var uiModel = GetByForShow(filter, pageSize, page, orderBy, orderDir, null, extraParams);
        public override List<timeTaskModel> GetBy(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest,  params  object[] extraParams)
        {
            var uiModel = GetByForShow(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);
           
            return uiModel.Items;
		
        }
		/*
        [MyAuthorize("r", "timeTask", "MBKTime", typeof(timeTasksController))]
		public ContentResult GetByJson(string filter, int? pageSize, int? page, string orderBy, string orderDir)
        {
			 return GetByJsonBase(filter, pageSize, page, orderBy, orderDir);
        }*/

		  [MyAuthorize("r", "timeTask", "MBKTime", typeof(timeTasksController))]
		public ContentResult GetByJson(string filter, int? pageSize, int? page, string orderBy, string orderDir,ContextRequest contextRequest,  object[] extraParams)
        {
			 return GetByJsonBase(filter, pageSize, page, orderBy, orderDir,contextRequest, extraParams);
        }
/*		  [MyAuthorize("r", "timeTask", "MBKTime", typeof(timeTasksController))]
       public ContentResult GetByJson(string filter, int? pageSize, int? page, string orderBy, string orderDir, ContextRequest contextRequest, object[] extraParams)
        {
            return GetByJsonBase(filter, pageSize, page, orderBy, orderDir, contextRequest, extraParams);
        }*/
		[MyAuthorize()]
		public int GetByCount(string filter, ContextRequest contextRequest) {
			if (contextRequest == null || contextRequest.Company == null || contextRequest.User == null )
            {
                contextRequest = GetContextRequest();
            }
            return BR.timeTasksBR.Instance.GetCount(HttpUtility.UrlDecode(filter), GetUseMode(), contextRequest);
        }
		[MyAuthorize("r", "timeTask", "MBKTime", typeof(timeTasksController))]
		public ActionResult GetByKeyJson(string id, bool dec = false)
        {
            return Json(GetByKey(id,null,null,  dec), JsonRequestBehavior.AllowGet);
        }
		[MyAuthorize("r", "timeTask", "MBKTime", typeof(timeTasksController))]
        public ActionResult GetByKeyJson(string id, ContextRequest contextRequest,  bool dec = false)
        {
            return Json(GetByKey(id, null, contextRequest, dec), JsonRequestBehavior.AllowGet);
        }
		public timeTaskModel GetByKey(string id) {
			return GetByKey(id, null,null, false);
       	}
		    public timeTaskModel GetByKey(string id, string includes)
        {
            return GetByKey(id, includes, false);
        }
		 public  timeTaskModel GetByKey(string id, string includes, ContextRequest contextRequest)
        {
            return GetByKey(id, includes, contextRequest, false);
        }
		/*
		  public ActionResult ShowField(string fieldName, string idField) {
		   string safePropertyName = fieldName;
              if (fieldName.StartsWith("Fk"))
              {
                  safePropertyName = fieldName.Substring(2, fieldName.Length - 2);
              }

             timeTaskModel model = new  timeTaskModel();

            UIModel uiModel = GetUIModel(model, new string[] { "NoField-" });
			
				uiModel.Properties = GetProperties(uiModel, safePropertyName);
		uiModel.Properties.ForEach(p=> p.ContextType = uiModel.ContextType );
            uiModel.ContextType = UIModelContextTypes.FilterFields;
            uiModel.OverrideApp = GetOverrideApp();
            uiModel.UseMode = GetUseMode();

            ViewData["uiModel"] = uiModel;
			var prop = uiModel.Properties.FirstOrDefault(p=>p.PropertyName == safePropertyName);
            //if (prop.IsNavigationProperty && prop.IsNavigationPropertyMany == false)
            //{
            //    ViewData["currentProperty"] = uiModel.Properties.FirstOrDefault(p => p.PropertyName != fieldName + "Text");
            //}else if (prop.IsNavigationProperty == false){
                ViewData["currentProperty"] = prop;
           // }
            ((PropertyDefinition)ViewData["currentProperty"]).RemoveLayout = true;
			ViewData["withContainer"] = false;


            return PartialView("GenericField", model);


        }
      */
	public timeTaskModel GetByKey(string id, ContextRequest contextRequest, bool dec)
        {
            return GetByKey(id, null, contextRequest, dec);
        }
        public timeTaskModel GetByKey(string id, string  includes, bool dec)
        {
            return GetByKey(id, includes, null, dec);
        }

        public timeTaskModel GetByKey(string id, string includes, ContextRequest contextRequest, bool dec) {
		             timeTaskModel model = null;
            ControllerEventArgs<timeTaskModel> e = null;
			string objectKey = id.Replace("-","/");
             OnGettingByKey(this, e=  new ControllerEventArgs<timeTaskModel>() { Id = objectKey  });
             bool cancel = false;
             timeTaskModel eItem = null;
             if (e != null)
             {
                 cancel = e.Cancel;
                 eItem = e.Item;
             }
			if (cancel == false && eItem == null)
             {
			Guid guidTask = Guid.Empty; //new Guid(SFSdotNet.Framework.Entities.Utils.GetPropertyKey(objectKey, "GuidTask"));
			if (dec)
                 {
                     guidTask = new Guid(id);
                 }
                 else
                 {
                     guidTask = new Guid(SFSdotNet.Framework.Entities.Utils.GetPropertyKey(objectKey, null));
                 }
			
            
				model = new timeTaskModel();
                  if (contextRequest == null)
                {
                    contextRequest = GetContextRequest();
                }
				var bo = BR.timeTasksBR.Instance.GetByKey(guidTask, GetUseMode(), contextRequest,  includes);
				 if (bo != null)
                    model.Bind(bo);
                else
                    return null;
			}
             else {
                 model = eItem;
             }
			model.IsNew = false;

            return model;
        }
        // GET: /timeTasks/DetailsGen/5
		[MyAuthorize("r", "timeTask", "MBKTime", typeof(timeTasksController))]
        public ActionResult DetailsGen(string id)
        {
			//if (System.Web.SiteMap.CurrentNode != null)
			//	System.Web.SiteMap.CurrentNode.Title = timeTaskResources.ENTITY_PLURAL;
			 #region implementaci�n de m�todo parcial

            bool cancel = false; bool replaceResult = false;
            OnDetailsShowing(this, e = new ControllerEventArgs<timeTaskModel>() { Id = id });
            if (e != null)
            {
                if (e.Cancel && e.ActionResult != null)
                    return e.ActionResult;
                else if (e.Cancel == true)
                    cancel = true;
                else if (e.ActionResult != null)
                   return e.ActionResult;
            }
            #endregion



			 bool decripted = false;
            Guid? guidId = null;
            if (System.Web.HttpContext.Current != null && System.Web.HttpContext.Current.Request != null) {
                if (System.Web.HttpContext.Current.Request.QueryString["dec"] == "true") {
                    decripted = true;
                    guidId = Guid.Parse(id);
                }
            }
			//UIModel<timeTaskModel> uiModel = GetContextModel(UIModelContextTypes.DisplayForm, GetByKey(id, null, decripted), decripted, guidId);
			var item = GetByKey(id, null, null, decripted);
			if (item == null)
            {
                 RouteValueDictionary rv = new RouteValueDictionary();
                string usemode = SFSdotNet.Framework.Web.Mvc.Utils.GetRouteDataOrQueryParam(this.Request.RequestContext,"usemode");
                string overrideModule = SFSdotNet.Framework.Web.Mvc.Utils.GetRouteDataOrQueryParam(this.Request.RequestContext, "overrideModule");
                string area = SFSdotNet.Framework.Web.Mvc.Utils.GetRouteDataOrQueryParam(this.Request.RequestContext, "area");

                if(!string.IsNullOrEmpty(usemode)){
                    rv.Add("usemode", usemode);
                }
                if(!string.IsNullOrEmpty(overrideModule)){
                    rv.Add("overrideModule", overrideModule);
                }
                if (!string.IsNullOrEmpty(area))
                {
                    rv.Add("area", area);
                }

                return RedirectToAction("Index", rv);
            }
            //
            UIModel<timeTaskModel> uiModel = null;
                uiModel = GetContextModel(UIModelContextTypes.DisplayForm, item, decripted, guidId);



            MyEventArgs<UIModel<timeTaskModel>> me = null;

            OnActionsCreated(this, me = new MyEventArgs<UIModel<timeTaskModel>>() { Object = uiModel });

            if (me != null) {
                uiModel = me.Object;
            }
			
            Showing(ref uiModel);
            if(!string.IsNullOrEmpty(System.Web.HttpContext.Current.Request.QueryString["popup"]))
                ViewData["ispopup"] = true;
			
            //return View("DisplayGen", uiModel.Items[0]);
			return ResolveView(uiModel, uiModel.Items[0]);

        }
		[MyAuthorize("r", "timeTask", "MBKTime", typeof(timeTasksController))]
		public ActionResult DetailsViewGen(string id)
        {

		 bool cancel = false; bool replaceResult = false;
            OnDetailsShowing(this, e = new ControllerEventArgs<timeTaskModel>() { Id = id });
            if (e != null)
            {
                if (e.Cancel && e.ActionResult != null)
                    return e.ActionResult;
                else if (e.Cancel == true)
                    cancel = true;
                else if (e.ActionResult != null)
                   return e.ActionResult;
            }
           
			if(!string.IsNullOrEmpty(System.Web.HttpContext.Current.Request.QueryString["popup"]))
                ViewData["ispopup"] = true;
 			if (!string.IsNullOrEmpty(System.Web.HttpContext.Current.Request.QueryString["fk"]))
                ViewData["fk"] = System.Web.HttpContext.Current.Request.QueryString["fk"];
            if (!string.IsNullOrEmpty(System.Web.HttpContext.Current.Request.QueryString["fkValue"]))
                ViewData["fkValue"] = System.Web.HttpContext.Current.Request.QueryString["fkValue"];
           
        	 //var uiModel = GetContextModel(UIModelContextTypes.DisplayForm, GetByKey(id));
			 
            bool decripted = false;
            Guid? guidId = null;
            if (System.Web.HttpContext.Current != null && System.Web.HttpContext.Current.Request != null)
            {
                if (System.Web.HttpContext.Current.Request.QueryString["dec"] == "true")
                {
                    decripted = true;
                    guidId = Guid.Parse(id);
                }
            }
            UIModel<timeTaskModel> uiModel = GetContextModel(UIModelContextTypes.DisplayForm, GetByKey(id, null, null, decripted), decripted, guidId);
			

            MyEventArgs<UIModel<timeTaskModel>> me = null;

            OnActionsCreated(this, me = new MyEventArgs<UIModel<timeTaskModel>>() { Object = uiModel });

            if (me != null)
            {
                uiModel = me.Object;
            }
            
            Showing(ref uiModel);
            return ResolveView(uiModel, uiModel.Items[0]);
        
        }
        //
        // GET: /timeTasks/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        //
        // GET: /timeTasks/CreateGen
		[MyAuthorize("c", "timeTask", "MBKTime", typeof(timeTasksController))]
        public ActionResult CreateGen()
        {
			timeTaskModel model = new timeTaskModel();
            model.IsNew = true;
			 var me = GetContextModel(UIModelContextTypes.EditForm, model);

			OnCreateShowing(this, e = new ControllerEventArgs<timeTaskModel>() { Item = model });
   			if (e != null)
            {
                model = e.Item;
                if (e.ActionResult != null)
                    return e.ActionResult;
            }

             if (!string.IsNullOrEmpty(System.Web.HttpContext.Current.Request.QueryString["popup"]))
                 ViewData["ispopup"] = true;
             if (!string.IsNullOrEmpty(System.Web.HttpContext.Current.Request.QueryString["fk"]))
                 ViewData["fk"] = System.Web.HttpContext.Current.Request.QueryString["fk"];
             if (!string.IsNullOrEmpty(System.Web.HttpContext.Current.Request.QueryString["fkValue"]))
                 ViewData["fkValue"] = System.Web.HttpContext.Current.Request.QueryString["fkValue"];

            Showing(ref me);

			return ResolveView(me, me.Items[0]);
        } 
			
		protected override UIModel<timeTaskModel> GetContextModel(UIModelContextTypes formMode, timeTaskModel model)
        {
            return GetContextModel(formMode, model, false, null);
        }
			
		 private UIModel<timeTaskModel> GetContextModel(UIModelContextTypes formMode, timeTaskModel model, bool decript, Guid ? id) {
            UIModel<timeTaskModel> me = new UIModel<timeTaskModel>(true, "timeTasks");
			me.UseMode = GetUseMode();
			me.Controller = this;
			me.OverrideApp = GetOverrideApp();
			me.ContextType = formMode ;
			me.Id = "timeTask";
			
            me.ModuleKey = "MBKTime";

			me.ModuleNamespace = "MBK.Time";
            me.EntityKey = "timeTask";
            me.EntitySetName = "timeTasks";

			me.AreaAction = "MBKTime";
            me.ControllerAction = "timeTasks";
            me.PropertyKeyName = "GuidTask";

            me.Properties = GetProperties(me, decript, id);

			me.SortBy = "UpdatedDate";
			me.SortDirection = UIModelSortDirection.DESC;

 			
			if (Request != null)
            {
                string actionName = SFSdotNet.Framework.Web.Mvc.Utils.GetRouteDataOrQueryParam( Request.RequestContext, "action");
                if(actionName != null && actionName.ToLower().Contains("create") ){
                    me.IsNew = true;
                }
            }
			 #region Buttons
			 if (Request != null ){
             if (formMode == UIModelContextTypes.DisplayForm || formMode == UIModelContextTypes.EditForm || formMode == UIModelContextTypes.ListForm)
				me.ActionButtons = GetActionButtons(formMode,model != null ?(Request.QueryString["dec"] == "true" ? model.Id : model.SafeKey)  : null, "MBKTime", "timeTasks", "timeTask", me.IsNew);

            //me.ActionButtons.Add(new ActionModel() { ActionKey = "return", Title = GlobalMessages.RETURN, Url = System.Web.VirtualPathUtility.ToAbsolute("~/") + "MBKTime/timeTasks" });
			if (this.HttpContext != null &&  !this.HttpContext.SkipAuthorization){
				//antes this.HttpContext
				me.SetAction("u", (new SFSdotNet.Framework.Globals.Security.Permission()).IsAllowed("u", "timeTask", "MBKTime"));
				me.SetAction("c", (new SFSdotNet.Framework.Globals.Security.Permission()).IsAllowed("c", "timeTask", "MBKTime"));
				me.SetAction("d", (new SFSdotNet.Framework.Globals.Security.Permission()).IsAllowed("d", "timeTask", "MBKTime"));
			
			}else{
				me.SetAction("u", true);
				me.SetAction("c", true);
				me.SetAction("d", true);

			}
            #endregion              
         
            switch (formMode)
            {
                case UIModelContextTypes.DisplayForm:
					//me.TitleForm = timeTaskResources.TIMETASKS_DETAILS;
                    me.ActionButtons.First(p => p.ActionKey == "u").Title = GlobalMessages.MODIFY_DATA;
					 me.Properties.Where(p=>p.PropertyName  != "Id" && p.IsForeignKey == false).ToList().ForEach(p => p.IsHidden = false);

					 me.Properties.Where(p => (p.SystemProperty != null && p.SystemProperty != SystemProperties.Identifier) ).ToList().ForEach(p=> me.SetHide(p.PropertyName));

                    break;
                case UIModelContextTypes.EditForm:
				  me.Properties.Where(p=>p.SystemProperty != SystemProperties.Identifier && p.IsForeignKey == false && p.PropertyName != "Id").ToList().ForEach(p => p.IsHidden = false);

					if (model != null)
                    {
						

                        me.ActionButtons.First(p => p.ActionKey == "u").Title = GlobalMessages.SAVE_DATA;                        
                        me.ActionButtons.First(p => p.ActionKey == "c").Title = GlobalMessages.SAVE_DATA;
						if (model.IsNew ){
							//me.TitleForm = timeTaskResources.TIMETASKS_ADD_NEW;
							me.ActionName = "CreateGen";
							me.Properties.RemoveAll(p => p.SystemProperty != null || (p.IsNavigationPropertyMany && p.NavigationPropertyType != NavigationPropertyTypes.Tags));
						}else{
							
							me.ActionName = "EditGen";

							//me.TitleForm = timeTaskResources.TIMETASKS_EDIT;
							me.Properties.RemoveAll(p => p.SystemProperty != null && p.SystemProperty != SystemProperties.Identifier || (p.IsNavigationPropertyMany && p.NavigationPropertyType != NavigationPropertyTypes.Tags));	
						}
						//me.Properties.Remove(me.Properties.Find(p => p.PropertyName == "UpdatedDate"));
					
					}
                    break;
                case UIModelContextTypes.FilterFields:
                    break;
                case UIModelContextTypes.GenericForm:
                    break;
                case UIModelContextTypes.Items:
				//if (Request.QueryString["allFields"] != "1"){
					 if (me.Properties.Find(p => p.PropertyName == "Name") != null){
						me.Properties.Find(p => p.PropertyName == "Name").IsHidden = false;
					 }
					 
                    
					
					 if (me.Properties.Find(p => p.PropertyName == "UpdatedDate") != null){
						me.Properties.Find(p => p.PropertyName == "UpdatedDate").IsHidden = false;
					 }
					 
                    
					

						 if (me.Properties.Find(p => p.PropertyName == "GuidTask") != null){
						me.Properties.Find(p => p.PropertyName == "GuidTask").IsHidden = false;
					 }
					 
                    
					


                  


					//}
                    break;
                case UIModelContextTypes.ListForm:
					PropertyDefinition propFinded = null;
					//if (Request.QueryString["allFields"] != "1"){
					 if (me.Properties.Find(p => p.PropertyName == "Name") != null){
						me.Properties.Find(p => p.PropertyName == "Name").IsHidden = false;
					 }
					
					 if (me.Properties.Find(p => p.PropertyName == "UpdatedDate") != null){
						me.Properties.Find(p => p.PropertyName == "UpdatedDate").IsHidden = false;
					 }
					
					me.PrincipalActionName = "GetByJson";
					//}
					//me.TitleForm = timeTaskResources.TIMETASKS_LIST;
                    break;
                default:
                    break;
            }
            
			}
			if (model != null )
            	me.Items.Add(model);
            return me;
        }
		// GET: /timeTasks/CreateViewGen
		[MyAuthorize("c", "timeTask", "MBKTime", typeof(timeTasksController))]
        public ActionResult CreateViewGen()
        {
				timeTaskModel model = new timeTaskModel();
            model.IsNew = true;
			e= null;
			OnCreateShowing(this, e = new ControllerEventArgs<timeTaskModel>() { Item = model });
   			if (e != null)
            {
                model = e.Item;
                if (e.ActionResult != null)
                    return e.ActionResult;
            }
			
            var me = GetContextModel(UIModelContextTypes.EditForm, model);

			me.IsPartialView = true;	
            if(!string.IsNullOrEmpty(System.Web.HttpContext.Current.Request.QueryString["popup"]))
                ViewData["ispopup"] = true;
            if (!string.IsNullOrEmpty(System.Web.HttpContext.Current.Request.QueryString["fk"]))
            {
                ViewData["fk"] = System.Web.HttpContext.Current.Request.QueryString["fk"];
                me.Properties.Find(p => p.PropertyName == ViewData["fk"].ToString()).IsReadOnly = true;
            }
			if (!string.IsNullOrEmpty(System.Web.HttpContext.Current.Request.QueryString["fkValue"]))
                ViewData["fkValue"] = System.Web.HttpContext.Current.Request.QueryString["fkValue"];
			
      
            //me.Items.Add(model);
            Showing(ref me);
            return ResolveView(me, me.Items[0]);
        }
		protected override  void GettingExtraData(ref UIModel<timeTaskModel> uiModel)
        {

            MyEventArgs<UIModel<timeTaskModel>> me = null;
            OnGettingExtraData(this, me = new MyEventArgs<UIModel<timeTaskModel>>() { Object = uiModel });
            //bool maybeAnyReplaced = false; 
            if (me != null)
            {
                uiModel = me.Object;
                //maybeAnyReplaced = true;
            }
           
			bool canFill = false;
			 string query = null ;
            bool isFK = false;
			PropertyDefinition prop =null;
			var contextRequest = this.GetContextRequest();
            contextRequest.CustomParams.Add(new CustomParam() { Name="ui", Value= timeTask.EntityName });

                        

        }
		private void Showing(ref UIModel<timeTaskModel> uiModel) {
          	
			MyEventArgs<UIModel<timeTaskModel>> me = new MyEventArgs<UIModel<timeTaskModel>>() { Object = uiModel };
			 OnVirtualLayoutSettings(this, me);


            OnShowing(this, me);

			
			if ((Request != null && Request.QueryString["allFields"] == "1") || Request == null )
			{
				me.Object.Properties.ForEach(p=> p.IsHidden = false);
            }
            if (me != null)
            {
                uiModel = me.Object;
            }
          


			 if (uiModel.ContextType == UIModelContextTypes.EditForm)
			    GettingExtraData(ref uiModel);
            ViewData["UIModel"] = uiModel;

        }
        //
        // POST: /timeTasks/Create
		[MyAuthorize("c", "timeTask", "MBKTime", typeof(timeTasksController))]
        [HttpPost]
		[ValidateInput(false)] 
        public ActionResult CreateGen(timeTaskModel  model,  ContextRequest contextRequest)
        {
			bool isPopUp = false;
            if (!string.IsNullOrEmpty(System.Web.HttpContext.Current.Request.Form["popup"]) || !string.IsNullOrEmpty(System.Web.HttpContext.Current.Request.QueryString["popup"]))
            {
                isPopUp = true;
            }
		 	e = null;
			this.Validations(model);

            OnValidating(this, e = new ControllerEventArgs<timeTaskModel>() { Item = model });
           
		  	if (!ModelState.IsValid) {
				model.IsNew = true;
				var me = GetContextModel(UIModelContextTypes.EditForm, model);
                Showing(ref me);
                 if (!string.IsNullOrEmpty(System.Web.HttpContext.Current.Request.QueryString["popup"]))
                {
                    if (!string.IsNullOrEmpty(System.Web.HttpContext.Current.Request.QueryString["popup"]))
                        ViewData["ispopup"] = true;
                    if (!string.IsNullOrEmpty(System.Web.HttpContext.Current.Request.QueryString["fk"]))
                        ViewData["fk"] = System.Web.HttpContext.Current.Request.QueryString["fk"];
                    if (!string.IsNullOrEmpty(System.Web.HttpContext.Current.Request.QueryString["fkValue"]))
                        ViewData["fkValue"] = System.Web.HttpContext.Current.Request.QueryString["fkValue"];

                    return ResolveView(me, model);
                }
                else
                    return ResolveView(me, model);
            }
            try
            {
				if (model.GuidTask == null || model.GuidTask.ToString().Contains("000000000"))
				model.GuidTask = Guid.NewGuid();
	
				// habilitando m�todo parcial
                #region implementaci�n de m�todo parcial
               
                bool cancel = false; bool replaceResult = false;
                OnCreating(this, e = new ControllerEventArgs<timeTaskModel>() { Item = model });
                if (e != null) {
                   if (e.Cancel && e.RedirectValues.Count > 0){
                        RouteValueDictionary rv = new RouteValueDictionary();
                        if (e.RedirectValues["area"] != null ){
                            rv.Add("area", e.RedirectValues["area"].ToString());
                        }
                        foreach (var item in e.RedirectValues.Where(p=>p.Key != "area" && p.Key != "controller" &&  p.Key != "action" ))
	                    {
		                    rv.Add(item.Key, item.Value);
	                    }

                        //if (e.RedirectValues["action"] != null && e.RedirectValues["controller"] != null && e.RedirectValues["area"] != null )
                        return RedirectToAction(e.RedirectValues["action"].ToString(), e.RedirectValues["controller"].ToString(), rv );


                        
                    }else if (e.Cancel && e.ActionResult != null )
                        return e.ActionResult;  
                    else if (e.Cancel == true)
                        cancel = true;
                    else if (e.ActionResult != null)
                        replaceResult = true;
                }
                #endregion
                // si fue implementado el m�todo parcial y no se ha decidido suspender la acci�n
				if (contextRequest == null || contextRequest.Company == null){
					contextRequest = GetContextRequest();
					
				}
                if (!cancel)
                	model.Bind(timeTasksBR.Instance.Create(model.GetBusinessObject(), contextRequest ));
				OnCreated(this, e = new ControllerEventArgs<timeTaskModel>() { Item = model });
                 if (e != null )
					if (e.ActionResult != null)
                    	replaceResult = true;		
				if (!replaceResult)
                {
                    if (!string.IsNullOrEmpty(System.Web.HttpContext.Current.Request.Form["__continue"]))
                    {
                        ViewData["__continue"] = true;
                    }
					if (!string.IsNullOrEmpty(System.Web.HttpContext.Current.Request.Form["__continue_details"]) &&  string.IsNullOrEmpty(System.Web.HttpContext.Current.Request.QueryString["ReturnAfter"]))
                    {
                        var popupextra = GetRouteData();
                        popupextra.Add("id", model.SafeKey);
                        string actionDetails = "DetailsGen";
                        if (this.IsPopup())
                       {
                            popupextra.Add("saved", "true");
                            actionDetails = "DetailsViewGen";
                        }
                            popupextra.Add("area", SFSdotNet.Framework.Web.Mvc.Utils.GetRouteDataOrQueryParam(this.Request.RequestContext,"area"));
                            popupextra.Add("controller", SFSdotNet.Framework.Web.Mvc.Utils.GetRouteDataOrQueryParam(this.Request.RequestContext, "controller"));
                            popupextra.Add("action", actionDetails);
                       if (popupextra.ContainsKey("usemode"))
                        {

                            return RedirectToRoute("area_usemode", popupextra);
                        }
                        else
                        {
                            return RedirectToAction(actionDetails, popupextra);
                        }
                    }
                    if (!string.IsNullOrEmpty(System.Web.HttpContext.Current.Request.QueryString["popup"]) || !string.IsNullOrEmpty(System.Web.HttpContext.Current.Request.Form["popup"]))
                    {
                        if (!string.IsNullOrEmpty(System.Web.HttpContext.Current.Request.Form["__continue"]))

                        {
                            var popupextra = GetRouteData();
                            popupextra.Add("id", model.SafeKey);
                            return RedirectToAction("EditViewGen", popupextra);
                        }
                        else
                        {
                            return PartialView("ResultMessageView", (new MessageModel()).GetDone(GlobalMessages.ADD_DONE));
                        }
                    }        			if (!string.IsNullOrEmpty(System.Web.HttpContext.Current.Request.QueryString["ReturnAfter"]))
                        return Redirect(System.Web.HttpContext.Current.Request.QueryString["ReturnAfter"]);
                    else{

							var popupextra = GetRouteData();
							if (Request != null && string.IsNullOrEmpty(Request.QueryString["rok"])){
                             string area = SFSdotNet.Framework.Web.Mvc.Utils.GetRouteDataOrQueryParam(this.Request.RequestContext, "area");
                            if (!string.IsNullOrEmpty(area))
                                popupextra.Add("area", area);
                            
                            if (!string.IsNullOrEmpty(System.Web.HttpContext.Current.Request.Form["__continue"])) {
								popupextra.Add("id", model.SafeKey);
                                return RedirectToAction("EditGen", popupextra);

                            }else{
								
                            return RedirectToAction("Index", popupextra);
							}
							}else{
								return Json("ok", JsonRequestBehavior.AllowGet);
							}
                        }
						 }
                else {
                    return e.ActionResult;
                    }
				}
            catch(Exception ex)
            {
					if (!string.IsNullOrEmpty(Request.QueryString["rok"]))
                {
                    throw  ex;
                }
				SFSdotNet.Framework.My.EventLog.Exception(ex, GetContextRequest());
			    
                SFSdotNet.Framework.My.Context.CurrentContext.AddMessage(ex.Message, SFSdotNet.Framework.My.MessageResultTypes.Error);
                model.IsNew = true;
                var me = GetContextModel(UIModelContextTypes.EditForm, model, true, model.GuidTask);
                Showing(ref me);
                if (isPopUp)
                {
                    
                        ViewData["ispopup"] = isPopUp;
                    if (!string.IsNullOrEmpty(System.Web.HttpContext.Current.Request.QueryString["fk"]))
                        ViewData["fk"] = System.Web.HttpContext.Current.Request.QueryString["fk"];
                    if (!string.IsNullOrEmpty(System.Web.HttpContext.Current.Request.QueryString["fkValue"]))
                        ViewData["fkValue"] = System.Web.HttpContext.Current.Request.QueryString["fkValue"];

                    return ResolveView(me, model);
                }
                else
					if (Request != null)
						return ResolveView(me, model);
					else
						return Content("ok");
            }
        }        
        //
        // GET: /timeTasks/Edit/5 
        public ActionResult Edit(int id)
        {
            return View();
        }
			
		
		[MyAuthorize("u", "timeTask", "MBKTime", typeof(timeTasksController))]
		[MvcSiteMapNode(Area="MBKTime", Title="sss", Clickable=false, ParentKey = "MBKTime_timeTask_List")]
		public ActionResult EditGen(string id)
        {
			//if (System.Web.SiteMap.CurrentNode != null)
			//	System.Web.SiteMap.CurrentNode.Title = timeTaskResources.ENTITY_SINGLE;		 	
  // habilitando m�todo parcial
            #region implementaci�n de m�todo parcial

            bool cancel = false; bool replaceResult = false;
            OnEditShowing(this, e = new ControllerEventArgs<timeTaskModel>() { Id= id });
            if (e != null)
            {
                if (e.Cancel && e.ActionResult != null)
                    return e.ActionResult;
                else if (e.Cancel == true)
                    cancel = true;
                else if (e.ActionResult != null)
                    replaceResult = true;
            }
            #endregion
            timeTaskModel model = null;
            // si fue implementado el m�todo parcial y no se ha decidido suspender la acci�n
			bool dec = false;
            Guid ? idGuidDecripted = null ;
            if (Request != null && Request.QueryString["dec"] == "true")
            {
                dec = true;
                idGuidDecripted = Guid.Parse(id);
            }

            if (!cancel)
                model = GetByKey(id, null, null, dec);
            else
                model = e.Item;
			 var me = GetContextModel(UIModelContextTypes.EditForm, model,dec,idGuidDecripted);
            Showing(ref me);


            if (!replaceResult)
            {
                 //return View("EditGen", me.Items[0]);
				 return ResolveView(me, me.Items[0]);
            }
            else {
                return e.ActionResult;
            }
        }
			[MyAuthorize("u", "timeTask","MBKTime", typeof(timeTasksController))]
		public ActionResult EditViewGen(string id)
        {
            if (!string.IsNullOrEmpty(System.Web.HttpContext.Current.Request.QueryString["popup"]))
                ViewData["ispopup"] = true;
			  if (!string.IsNullOrEmpty(System.Web.HttpContext.Current.Request.QueryString["fk"]))
                ViewData["fk"] = System.Web.HttpContext.Current.Request.QueryString["fk"];
            if (!string.IsNullOrEmpty(System.Web.HttpContext.Current.Request.QueryString["fkValue"]))
                ViewData["fkValue"] = System.Web.HttpContext.Current.Request.QueryString["fkValue"];

					  // habilitando m�todo parcial
            #region implementaci�n de m�todo parcial

            bool cancel = false; bool replaceResult = false;
            OnEditShowing(this, e = new ControllerEventArgs<timeTaskModel>() { Id= id });
            if (e != null)
            {
                if (e.Cancel && e.ActionResult != null)
                    return e.ActionResult;
                else if (e.Cancel == true)
                    cancel = true;
                else if (e.ActionResult != null)
                    replaceResult = true;
            }
            #endregion
			
            timeTaskModel model = null;
			 bool dec = false;
            Guid? guidId = null ;

            if (System.Web.HttpContext.Current != null && System.Web.HttpContext.Current.Request != null && System.Web.HttpContext.Current.Request.QueryString["dec"] == "true") {
                dec = true;
                guidId = Guid.Parse(id);
            }
            // si fue implementado el método parcial y no se ha decidido suspender la acción
            if (!cancel)
                model = GetByKey(id, null, null, dec);
            else
                model = e.Item;
            var me = GetContextModel(UIModelContextTypes.EditForm, model, dec, guidId);
            Showing(ref me);

            return ResolveView(me, model);
        }
		[MyAuthorize("u", "timeTask",  "MBKTime", typeof(timeTasksController))]
		[HttpPost]
		[ValidateInput(false)] 
		        public ActionResult EditGen(timeTaskModel model)
        {
			bool isPopUp = false;
            if (!string.IsNullOrEmpty(System.Web.HttpContext.Current.Request.Form["popup"]) || !string.IsNullOrEmpty(System.Web.HttpContext.Current.Request.QueryString["popup"]))
            {
                isPopUp = true;
            }
			e = null;
			this.Validations(model);

            OnValidating(this, e = new ControllerEventArgs<timeTaskModel>() { Item = model });
           
            if (!ModelState.IsValid)
            {
			   	var me = GetContextModel(UIModelContextTypes.EditForm, model);
                Showing(ref me);
			
				if (!string.IsNullOrEmpty(System.Web.HttpContext.Current.Request.Form["popup"])){
                	ViewData["ispopup"] = true;
					return ResolveView(me, model);
				}
				else
					return ResolveView(me, model);
            }
            try
            {
			
				// habilitando m�todo parcial
                #region implementaci�n de m�todo parcial
               
                bool cancel = false; bool replaceResult = false;
                OnEditing(this, e = new ControllerEventArgs<timeTaskModel>() { Item = model });
                if (e != null) {
                    if (e.Cancel && e.ActionResult != null)
                        return e.ActionResult;
                    else if (e.Cancel == true)
                        cancel = true;
                    else if (e.ActionResult != null)
                        replaceResult = true;
                }
                #endregion
                // si fue implementado el m�todo parcial y no se ha decidido suspender la acci�n
				ContextRequest context = new ContextRequest();
                context.CurrentContext = SFSdotNet.Framework.My.Context.CurrentContext;

                timeTask resultObj = null;
			    if (!cancel)
                	resultObj = timeTasksBR.Instance.Update(model.GetBusinessObject(), GetContextRequest());
				
				OnEdited(this, e = new ControllerEventArgs<timeTaskModel>() { Item =   new timeTaskModel(resultObj) });
				if (e != null && e.ActionResult != null) replaceResult = true; 

                if (!string.IsNullOrEmpty(System.Web.HttpContext.Current.Request.QueryString["autosave"]))
                {
                    return Json("ok", JsonRequestBehavior.AllowGet);
                }
                else
                {
				if (!replaceResult)
                {
					if (!string.IsNullOrEmpty(System.Web.HttpContext.Current.Request.Form["__continue_details"])  && string.IsNullOrEmpty(System.Web.HttpContext.Current.Request.QueryString["ReturnAfter"]))
                    {
                        var popupextra = GetRouteData();
						 if (Request != null && Request.QueryString["dec"] == "true")
                        {
                            popupextra.Add("id", model.Id);
                        }
                        else
                        {
							popupextra.Add("id", model.SafeKey);

							
                        }
                        string actionDetails = "DetailsGen";
                        if (this.IsPopup())
                        {
                            popupextra.Add("saved", "true");
                            actionDetails = "DetailsViewGen";
                        }
                        popupextra.Add("area", SFSdotNet.Framework.Web.Mvc.Utils.GetRouteDataOrQueryParam(this.Request.RequestContext, "area"));
                        popupextra.Add("controller", SFSdotNet.Framework.Web.Mvc.Utils.GetRouteDataOrQueryParam(this.Request.RequestContext, "controller"));
                        popupextra.Add("action", actionDetails);
                        if (popupextra.ContainsKey("usemode"))
                        {

                            return RedirectToRoute("area_usemode", popupextra);
                        }
                        else
                        {
                            return RedirectToAction(actionDetails, popupextra);
                        }
                    }
					if (isPopUp)
						return PartialView("ResultMessageView", (new MessageModel()).GetDone(GlobalMessages.UPDATE_DONE));
        			    string returnUrl = null;
                    if (!string.IsNullOrEmpty(System.Web.HttpContext.Current.Request.Form["ReturnAfter"]) || !string.IsNullOrEmpty(System.Web.HttpContext.Current.Request.QueryString["ReturnAfter"])) {
                        if (!string.IsNullOrEmpty(System.Web.HttpContext.Current.Request.Form["ReturnAfter"]))
                            returnUrl = System.Web.HttpContext.Current.Request.Form["ReturnAfter"];
                        else if (!string.IsNullOrEmpty(System.Web.HttpContext.Current.Request.QueryString["ReturnAfter"]))
                            returnUrl = System.Web.HttpContext.Current.Request.QueryString["ReturnAfter"];
                    }
                    if (!string.IsNullOrEmpty(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    else{
						if (Request != null)
                        {
							var popupextra = GetRouteData();
							string area = SFSdotNet.Framework.Web.Mvc.Utils.GetRouteDataOrQueryParam(this.Request.RequestContext, "area");
							if (!string.IsNullOrEmpty(area))
								popupextra.Add("area", area);

							return RedirectToAction("Index", popupextra);
						}else{
							return Content("ok");
						}
						}
				 }
                else {
                    return e.ActionResult;
				}
                }		
            }
          catch(Exception ex)
            {
				SFSdotNet.Framework.My.EventLog.Exception(ex, GetContextRequest());
			    
			    if (isPopUp)
                {
                    return PartialView("ResultMessageView", (new MessageModel()).GetException(ex.Message));
                    
                }
                else
                {
                    SFSdotNet.Framework.My.Context.CurrentContext.AddMessage(ex.Message, SFSdotNet.Framework.My.MessageResultTypes.Error);
                    
                if (!string.IsNullOrEmpty(System.Web.HttpContext.Current.Request.QueryString["autosave"]))
                {
                    return Json("error", JsonRequestBehavior.AllowGet);
                }
                else {
						  if (!string.IsNullOrEmpty(System.Web.HttpContext.Current.Request.QueryString["popup"]))
							ViewData["ispopup"] = true;
						if (!string.IsNullOrEmpty(System.Web.HttpContext.Current.Request.QueryString["fk"]))
							ViewData["fk"] = System.Web.HttpContext.Current.Request.QueryString["fk"];
						if (!string.IsNullOrEmpty(System.Web.HttpContext.Current.Request.QueryString["fkValue"]))
							ViewData["fkValue"] = System.Web.HttpContext.Current.Request.QueryString["fkValue"];

						var me = GetContextModel(UIModelContextTypes.EditForm, model);
						Showing(ref me);

						if (!string.IsNullOrEmpty(System.Web.HttpContext.Current.Request.Form["popup"]))
						{
							ViewData["ispopup"] = true;
							return ResolveView(me, model);
						}
						else
							return ResolveView(me, model);

						
					}
				}
            }
        }
        //
        // POST: /timeTasks/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                //  Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /timeTasks/Delete/5
        
		[MyAuthorize("d", "timeTask", "MBKTime", typeof(timeTasksController))]
		[HttpDelete]
        public ActionResult DeleteGen(string objectKey, string extraParams)
        {
            try
            {
					
			
				Guid guidTask = new Guid(SFSdotNet.Framework.Entities.Utils.GetPropertyKey(objectKey.Replace("-", "/"), "GuidTask")); 
                BO.timeTask entity = new BO.timeTask() { GuidTask = guidTask };

                BR.timeTasksBR.Instance.Delete(entity, GetContextRequest());               
                return PartialView("ResultMessageView", (new MessageModel()).GetDone(GlobalMessages.DELETE_DONE));

            }
            catch(Exception ex)
            {
				SFSdotNet.Framework.My.EventLog.Exception(ex, GetContextRequest());
			    
                if (Request != null && Request.IsAjaxRequest())
                {
                    string message = GlobalMessages.ERROR_TRY_LATER;
                    if (ex.Data["usermessage"] != null)
                    {
                        message = ex.Data["usermessage"].ToString();
                    }

                    return PartialView("ResultMessageView", (new MessageModel()).GetException(message));
                }
                else
                {
                    return View();
                }
            }
        }
		/*[MyAuthorize()]
		public FileMediaResult Download(string query, bool? allSelected = false,  string selected = null , string orderBy = null , string direction = null , string format = null , string actionKey=null )
        {
			
            List<Guid> keysSelected1 = new List<Guid>();
            if (!string.IsNullOrEmpty(selected)) {
                foreach (var keyString in selected.Split(char.Parse("|")))
                {
				
                    keysSelected1.Add(Guid.Parse(keyString));
                }
            }
				
            query = SFSdotNet.Framework.Web.Mvc.Lists.GetQuery(query, allSelected.Value, selected, "GuidTask");
            MyEventArgs<ContextActionModel<timeTaskModel>> eArgs = null;
            List<timeTaskModel> results = GetBy(query, null, null, orderBy, direction, GetContextRequest(), keysSelected1);
            OnDownloading(this, eArgs = new MyEventArgs<ContextActionModel<timeTaskModel>>() { Object = new ContextActionModel<timeTaskModel>() { Query = query, SelectedItems = results, Selected=selected, SelectAll = allSelected.Value, Direction = direction , OrderBy = orderBy, ActionKey=actionKey  } });

            if (eArgs != null)
            {
                if (eArgs.Object.Result != null)
                    return (FileMediaResult)eArgs.Object.Result;
            }
            

            return (new FeaturesController()).ExportDownload(typeof(timeTaskModel), results, format, this.GetUIPluralText("MBKTime", "timeTask"));
            
        }
			*/
		
		[HttpPost]
        public ActionResult CustomActionExecute(ContextActionModel model) {
		 try
            {
			//List<Guid> keysSelected1 = new List<Guid>();
			List<object> keysSelected1 = new List<object>();
            if (!string.IsNullOrEmpty(model.Selected))
            {
                foreach (var keyString in model.Selected.Split(char.Parse(",")))
                {
				
				keysSelected1.Add(Guid.Parse(keyString.Split(char.Parse("|"))[0]));
                        
                    

			
                }
            }
			DataAction dataAction = DataAction.GetDataAction(Request);
			 model.Selected = dataAction.Selected;

            model.Query = SFSdotNet.Framework.Web.Mvc.Lists.GetQuery(dataAction.Query, dataAction.AllSelected, dataAction.Selected, "GuidTask");
           
            
			
			#region implementaci�n de m�todo parcial
            bool replaceResult = false;
            MyEventArgs<ContextActionModel<timeTaskModel>> actionEventArgs = null;
           
			if (model.ActionKey != "deletemany" && model.ActionKey != "deleterelmany" && model.ActionKey != "updateRel" &&  model.ActionKey != "delete-relation-fk" && model.ActionKey != "restore" )
			{
				ContextRequest context = SFSdotNet.Framework.My.Context.BuildContextRequestSafe(System.Web.HttpContext.Current);
				context.UseMode = dataAction.Usemode;

				if (model.IsBackground)
				{
					System.Threading.Tasks.Task.Run(() => 
						OnCustomActionExecutingBackground(this, actionEventArgs = new MyEventArgs<ContextActionModel<timeTaskModel>>() { Object = new ContextActionModel<timeTaskModel>() { DataAction = dataAction, ContextRequest = context, AllSelected = model.AllSelected, SelectAll = model.AllSelected, IsBackground = model.IsBackground, ActionKey = model.ActionKey, Direction = model.Direction, OrderBy = model.OrderBy, /*SelectedItems = results,*/ SelectedKeys = dataAction.SelectedGuids.Cast<Object>().ToList(), Query = model.Query } })
					);
				}
				else
				{
					OnCustomActionExecuting(this, actionEventArgs = new MyEventArgs<ContextActionModel<timeTaskModel>>() {  Object = new ContextActionModel<timeTaskModel>() { DataAction = dataAction, ContextRequest = context, AllSelected = model.AllSelected, SelectAll = model.AllSelected, IsBackground = model.IsBackground, ActionKey = model.ActionKey, Direction = model.Direction, OrderBy = model.OrderBy, /*SelectedItems = results,*/ SelectedKeys = dataAction.SelectedGuids.Cast<Object>().ToList(), Query = model.Query } });
				}
			}
            List<timeTaskModel> results = null;
	
			if (model.ActionKey == "deletemany") { 
				
				BR.timeTasksBR.Instance.Delete(model.Query, dataAction.SelectedGuids.ToArray(), GetContextRequest());

            }
	
			else if (model.ActionKey == "restore") {
                    BR.timeTasksBR.Instance.UnDelete(model.Query, dataAction.SelectedGuids.ToArray(), GetContextRequest());

                }
            else if (model.ActionKey == "updateRel" || model.ActionKey == "delete-relation-fk" || model.ActionKey == "updateRel-proxyMany")
            {
               try {
                   string valueForUpdate = null;
				   string propForUpdate = null;
				   if (!string.IsNullOrEmpty(Request.Params["propertyForUpdate"])){
						propForUpdate = Request.Params["propertyForUpdate"];
				   }
				    if (string.IsNullOrEmpty(propForUpdate) && !string.IsNullOrEmpty(Request.QueryString["propertyForUpdate"]))
                   {
                       propForUpdate = Request.QueryString["propertyForUpdate"];
                   }
                    if (model.ActionKey != "delete-relation-fk")
                    {
                        valueForUpdate = Request.QueryString["valueForUpdate"];
                    }
                    BR.timeTasksBR.Instance.UpdateAssociation(propForUpdate, valueForUpdate, model.Query, dataAction.SelectedGuids.ToArray(), GetContextRequest());
					
                    if (model.ActionKey == "delete-relation-fk")
                    {
                        MessageModel message = (new MessageModel()).GetDone(GlobalMessages.DONE, Request.Form["lastActionName"]);

                        return PartialView("ResultMessageView", message);
                    }
                    else
                    {
                        return Json("ok", JsonRequestBehavior.AllowGet);
                    }
       
          
                }
                catch (Exception ex)
                {
				        SFSdotNet.Framework.My.EventLog.Exception(ex, GetContextRequest());
           
                }
            
            }
		
                if (actionEventArgs == null && !model.IsBackground)
                {
                    //if (model.ActionKey != "deletemany"  && model.ActionKey != "deleterelmany")
                    //{
                     //   throw new NotImplementedException("");
                    //}
                }
                else
                {
					if (model.IsBackground == false )
						 replaceResult = actionEventArgs.Object.Result is ActionResult /*actionEventArgs.Object.ReplaceResult*/;
                }
                #endregion
                if (!replaceResult)
                {
                    if (Request != null && Request.IsAjaxRequest())
                    {
						MessageModel message = (new MessageModel()).GetDone(GlobalMessages.DONE, Request.Form["lastActionName"]) ;
                        if (model.IsBackground )
                            message.Message = GlobalMessages.THE_PROCESS_HAS_BEEN_STARTED;
                        
                        return PartialView("ResultMessageView", message);                    
					}
                    else
                    {
                        return View();
                    }
                }
                else
                {
                    return (ActionResult)actionEventArgs.Object.Result;
                }
            }
            catch (Exception ex)
            {
				SFSdotNet.Framework.My.EventLog.Exception(ex, GetContextRequest());
			    
                if (Request != null && Request.IsAjaxRequest())
                {
                    string message = GlobalMessages.ERROR_TRY_LATER;
                    if (ex.Data["usermessage"] != null) {
                        message = ex.Data["usermessage"].ToString();
                    }
					 SFSdotNet.Framework.My.EventLog.Exception(ex, GetContextRequest());
                    return PartialView("ResultMessageView", (new MessageModel()).GetException(message));
                }
                else
                {
                    return View();
                }

            }
        }
        //
        // POST: /timeTasks/Delete/5
        
			
	
    }
}
