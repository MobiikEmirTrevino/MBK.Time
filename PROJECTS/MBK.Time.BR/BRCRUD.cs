 
 
 
// <Template>
//   <SolutionTemplate>EF POCO 1</SolutionTemplate>
//   <Version>20140213.2136</Version>
//   <Update>mas de contextRequest</Update>
// </Template>
#region using
using System;
using System.Collections.Generic;
using System.Text;
using SFSdotNet.Framework.BR;
using System.Linq.Dynamic;
using System.Collections;
using System.Linq;
using LinqKit;
using SFSdotNet.Framework.Entities;
using SFSdotNet.Framework.Linq;
using System.Linq.Expressions;
using System.Data;
using SFSdotNet.Framework;
using SFSdotNet.Framework.My;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Entity.Core.Objects;
using MBK.Time.BusinessObjects;
//using MBK.Time.BusinessObjects.EFPocoAdapter;
//using EFPocoAdapter;
using SFSdotNet.Framework.Entities.Trackable;

using System.Data.Entity;


#endregion
namespace MBK.Time.BR
{
public class SinglentonContext
    {
        private static EFContext context = null;
        public static EFContext Instance {
            get {
               if (context == null)
                    context = new EFContext();
                return context;
            }
        }
        /// <summary>
    /// Re-new the singlenton instance
    /// </summary>
    /// <returns></returns>
        public static EFContext RenewInstance() {
            context = new EFContext();
            return context;
        }
    /// <summary>
    /// Get a new instance
    /// </summary>
        public static EFContext NewInstance {
            get {
                return new EFContext();
            }
        }
    }
	
	
		public partial class timeTasksBR:BRBase<timeTask>{
	 	
           
		 #region Partial methods

           partial void OnUpdating(object sender, BusinessRulesEventArgs<timeTask> e);

            partial void OnUpdated(object sender, BusinessRulesEventArgs<timeTask> e);
			partial void OnUpdatedAgile(object sender, BusinessRulesEventArgs<timeTask> e);

            partial void OnCreating(object sender, BusinessRulesEventArgs<timeTask> e);
            partial void OnCreated(object sender, BusinessRulesEventArgs<timeTask> e);

            partial void OnDeleting(object sender, BusinessRulesEventArgs<timeTask> e);
            partial void OnDeleted(object sender, BusinessRulesEventArgs<timeTask> e);

            partial void OnGetting(object sender, BusinessRulesEventArgs<timeTask> e);
            protected override void OnVirtualGetting(object sender, BusinessRulesEventArgs<timeTask> e)
            {
                OnGetting(sender, e);
            }
			protected override void OnVirtualCounting(object sender, BusinessRulesEventArgs<timeTask> e)
            {
                OnCounting(sender, e);
            }
			partial void OnTaken(object sender, BusinessRulesEventArgs<timeTask> e);
			protected override void OnVirtualTaken(object sender, BusinessRulesEventArgs<timeTask> e)
            {
                OnTaken(sender, e);
            }

            partial void OnCounting(object sender, BusinessRulesEventArgs<timeTask> e);
 
			partial void OnQuerySettings(object sender, BusinessRulesEventArgs<timeTask> e);
          
            #endregion
			
		private static timeTasksBR singlenton =null;
				public static timeTasksBR NewInstance(){
					return  new timeTasksBR();
					
				}
		public static timeTasksBR Instance{
			get{
				if (singlenton == null)
					singlenton = new timeTasksBR();
				return singlenton;
			}
		}
		//private bool preventSecurityRestrictions = false;
		 public bool PreventAuditTrail { get; set;  }
		#region Fields
        EFContext context = null;
        #endregion
        #region Constructor
        public timeTasksBR()
        {
            context = new EFContext();
        }
		 public timeTasksBR(bool preventSecurity)
            {
                this.preventSecurityRestrictions = preventSecurity;
				context = new EFContext();
            }
        #endregion
		
		#region Get

 		public IQueryable<timeTask> Get()
        {
            using (EFContext con = new EFContext())
            {
				
				var query = con.timeTasks.AsQueryable();
                con.Configuration.ProxyCreationEnabled = false;

                //query = ContextQueryBuilder<Nutrient>.ApplyContextQuery(query, contextRequest);

                return query;




            }

        }
		


 	
		public List<timeTask> GetAll()
        {
            return this.GetBy(p => true);
        }
        public List<timeTask> GetAll(string includes)
        {
            return this.GetBy(p => true, includes);
        }
        public timeTask GetByKey(Guid guidTask)
        {
            return GetByKey(guidTask, true);
        }
        public timeTask GetByKey(Guid guidTask, bool loadIncludes)
        {
            timeTask item = null;
			var query = PredicateBuilder.True<timeTask>();
                    
			string strWhere = @"GuidTask = Guid(""" + guidTask.ToString()+@""")";
            Expression<Func<timeTask, bool>> predicate = null;
            //if (!string.IsNullOrEmpty(strWhere))
            //    predicate = System.Linq.Dynamic.DynamicExpression.ParseLambda<timeTask, bool>(strWhere.Replace("*extraFreeText*", "").Replace("()",""));
			
			 ContextRequest contextRequest = new ContextRequest();
            contextRequest.CustomQuery = new CustomQuery();
            contextRequest.CustomQuery.FilterExpressionString = strWhere;

			//item = GetBy(predicate, loadIncludes, contextRequest).FirstOrDefault();
			item = GetBy(strWhere,loadIncludes,contextRequest).FirstOrDefault();
            return item;
        }
         public List<timeTask> GetBy(string strWhere, bool loadRelations, ContextRequest contextRequest)
        {
            if (!loadRelations)
                return GetBy(strWhere, contextRequest);
            else
                return GetBy(strWhere, contextRequest, "");

        }
		  public List<timeTask> GetBy(string strWhere, bool loadRelations)
        {
              if (!loadRelations)
                return GetBy(strWhere, new ContextRequest());
            else
                return GetBy(strWhere, new ContextRequest(), "");

        }
		         public timeTask GetByKey(Guid guidTask, params Expression<Func<timeTask, object>>[] includes)
        {
            timeTask item = null;
			string strWhere = @"GuidTask = Guid(""" + guidTask.ToString()+@""")";
          Expression<Func<timeTask, bool>> predicate = p=> p.GuidTask == guidTask;
           // if (!string.IsNullOrEmpty(strWhere))
           //     predicate = System.Linq.Dynamic.DynamicExpression.ParseLambda<timeTask, bool>(strWhere.Replace("*extraFreeText*", "").Replace("()",""));
			
        item = GetBy(predicate, includes).FirstOrDefault();
         ////   item = GetBy(strWhere,includes).FirstOrDefault();
			return item;

        }
        public timeTask GetByKey(Guid guidTask, string includes)
        {
            timeTask item = null;
			string strWhere = @"GuidTask = Guid(""" + guidTask.ToString()+@""")";
            
			
            item = GetBy(strWhere, includes).FirstOrDefault();
            return item;

        }
		 public timeTask GetByKey(Guid guidTask, string usemode, string includes)
		{
			return GetByKey(guidTask, usemode, null, includes);

		 }
		 public timeTask GetByKey(Guid guidTask, string usemode, ContextRequest context,  string includes)
        {
            timeTask item = null;
			string strWhere = @"GuidTask = Guid(""" + guidTask.ToString()+@""")";
			if (context == null){
				context = new ContextRequest();
				context.CustomQuery = new CustomQuery();
				context.CustomQuery.IsByKey = true;
				context.CustomQuery.FilterExpressionString = strWhere;
				context.UseMode = usemode;
			}
            item = GetBy(strWhere,context , includes).FirstOrDefault();
            return item;

        }

        #region Dynamic Predicate
        public List<timeTask> GetBy(Expression<Func<timeTask, bool>> predicate, int? pageSize, int? page)
        {
            return this.GetBy(predicate, pageSize, page, null, null);
        }
        public List<timeTask> GetBy(Expression<Func<timeTask, bool>> predicate, ContextRequest contextRequest)
        {

            return GetBy(predicate, contextRequest,"");
        }
        
        public List<timeTask> GetBy(Expression<Func<timeTask, bool>> predicate, ContextRequest contextRequest, params Expression<Func<timeTask, object>>[] includes)
        {
            StringBuilder sb = new StringBuilder();
           if (includes != null)
            {
                foreach (var path in includes)
                {

						if (sb.Length > 0) sb.Append(",");
						sb.Append(SFSdotNet.Framework.Linq.Utils.IncludeToString<timeTask>(path));

               }
            }
            return GetBy(predicate, contextRequest, sb.ToString());
        }
        
        
        public List<timeTask> GetBy(Expression<Func<timeTask, bool>> predicate, string includes)
        {
			ContextRequest context = new ContextRequest();
            context.CustomQuery = new CustomQuery();
            context.CustomQuery.FilterExpressionString = "";

            return GetBy(predicate, context, includes);
        }

        public List<timeTask> GetBy(Expression<Func<timeTask, bool>> predicate, params Expression<Func<timeTask, object>>[] includes)
        {
			if (System.Web.HttpContext.Current == null || System.Web.HttpContext.Current.Session == null)
            {
                throw new Exception("Please, specific the contextRequest parameter in the method: GetBy");
            }
			ContextRequest context = new ContextRequest();
			            context.User = SFSdotNet.Framework.My.Context.CurrentContext.User;
            context.Company = SFSdotNet.Framework.My.Context.CurrentContext.Company;

            context.CustomQuery = new CustomQuery();
            context.CustomQuery.FilterExpressionString = "";
            return GetBy(predicate, context, includes);
        }

      
		public bool DisableCache { get; set; }
		public List<timeTask> GetBy(Expression<Func<timeTask, bool>> predicate, ContextRequest contextRequest, string includes)
		{
            using (EFContext con = new EFContext()) {
				
				string fkIncludes = "";
                List<string> multilangProperties = new List<string>();
				if (predicate == null) predicate = PredicateBuilder.True<timeTask>();
				string isDeletedField = null;
				Expression<Func<timeTask,bool>> notDeletedExpression = null;
	
					bool sharedAndMultiTenant = false;
					Expression<Func<timeTask,bool>> multitenantExpression  = null;
					if (contextRequest != null && contextRequest.Company != null)	                        	
						multitenantExpression = predicate.And(p => p.GuidCompany == contextRequest.Company.GuidCompany); //todo: multiempresa
					 									
					string multiTenantField = "GuidCompany";

                
                return GetBy(con, predicate, contextRequest, includes, fkIncludes, multilangProperties, multiTenantField, isDeletedField, sharedAndMultiTenant, notDeletedExpression, multitenantExpression);

#region Old code
/*
				List<timeTask> result = null;
               BusinessRulesEventArgs<timeTask>  e = null;
	
				OnGetting(con, e = new BusinessRulesEventArgs<timeTask>() {  FilterExpression = predicate, ContextRequest = contextRequest, FilterExpressionString = (contextRequest != null ? (contextRequest.CustomQuery != null ? contextRequest.CustomQuery.FilterExpressionString : null) : null) });

               // OnGetting(con,e = new BusinessRulesEventArgs<timeTask>() { FilterExpression = predicate, ContextRequest = contextRequest, FilterExpressionString = contextRequest.CustomQuery.FilterExpressionString});
				   if (e != null) {
				    predicate = e.FilterExpression;
						if (e.Cancel)
						{
							context = null;
							 if (e.Items == null) e.Items = new List<timeTask>();
							return e.Items;

						}
						if (!string.IsNullOrEmpty(e.StringIncludes))
                            includes = e.StringIncludes;
					}
				con.Configuration.ProxyCreationEnabled = false;
                con.Configuration.AutoDetectChangesEnabled = false;
                con.Configuration.ValidateOnSaveEnabled = false;

                if (predicate == null) predicate = PredicateBuilder.True<timeTask>();
                
                //var es = _repository.Queryable;

                IQueryable<timeTask> query =  con.timeTasks.AsQueryable();

                                if (!string.IsNullOrEmpty(includes))
                {
                    foreach (string include in includes.Split(char.Parse(",")))
                    {
						if (!string.IsNullOrEmpty(include))
                            query = query.Include(include);
                    }
                }
					 	if (!preventSecurityRestrictions)
						{
							if (contextRequest != null )
		                    	if (contextRequest.User !=null )
		                        	if (contextRequest.Company != null){
		                        	
										predicate = predicate.And(p => p.GuidCompany == contextRequest.Company.GuidCompany); //todo: multiempresa
 									
									}
						}
						if (preventSecurityRestrictions) preventSecurityRestrictions= false;
				query =query.AsExpandable().Where(predicate);
                query = ContextQueryBuilder<timeTask>.ApplyContextQuery(query, contextRequest);

                result = query.AsNoTracking().ToList<timeTask>();
				  
                if (e != null)
                {
                    e.Items = result;
                }
				//if (contextRequest != null ){
				//	 contextRequest = SFSdotNet.Framework.My.Context.BuildContextRequestCopySafe(contextRequest);
					contextRequest.CustomQuery = new CustomQuery();

				//}
				OnTaken(this, e == null ? e =  new BusinessRulesEventArgs<timeTask>() { Items= result, IncludingComputedLinq = false, ContextRequest = contextRequest,  FilterExpression = predicate } :  e);
  
			

                if (e != null) {
                    //if (e.ReplaceResult)
                        result = e.Items;
                }
                return result;
				*/
#endregion
            }
        }
		public void UpdateAgile(timeTask item, params string[] fields)
         {
			UpdateAgile(item, null, fields);
        }
		public void UpdateAgile(timeTask item, ContextRequest contextRequest, params string[] fields)
         {
            
             ContextRequest contextNew = null;
             if (contextRequest != null)
             {
                 contextNew = SFSdotNet.Framework.My.Context.BuildContextRequestCopySafe(contextRequest);
                 if (fields != null && fields.Length > 0)
                 {
                     contextNew.CustomQuery.SpecificProperties  = fields.ToList();
                 }
                 else if(contextRequest.CustomQuery.SpecificProperties.Count > 0)
                 {
                     fields = contextRequest.CustomQuery.SpecificProperties.ToArray();
                 }
             }
             List<timeTask> list = new List<timeTask>();
             list.Add(item);
             this.UpdateBulk(list, fields);
			OnUpdatedAgile(this, new BusinessRulesEventArgs<timeTask>() { Item = item, ContextRequest = contextNew  });

         }
		public void UpdateBulk(List<timeTask>  items, params string[] fields)
         {
             SFSdotNet.Framework.My.ContextRequest req = new SFSdotNet.Framework.My.ContextRequest();
             req.CustomQuery = new SFSdotNet.Framework.My.CustomQuery();
             foreach (var field in fields)
             {
                 req.CustomQuery.SpecificProperties.Add(field);
             }
             UpdateBulk(items, req);

         }

		 public void DeleteBulk(List<timeTask> entities, ContextRequest contextRequest = null)
        {

            using (EFContext con = new EFContext())
            {
                foreach (var entity in entities)
                {
					var entityProxy = new timeTask() { GuidTask = entity.GuidTask };

                    con.Entry<timeTask>(entityProxy).State = EntityState.Deleted;

                }

                int result = con.SaveChanges();
                if (result != entities.Count)
                {
                    SFSdotNet.Framework.My.EventLog.Error("Has been changed " + result.ToString() + " items but the expected value is: " + entities.Count.ToString());
                }
            }

        }

        public void UpdateBulk(List<timeTask> items, ContextRequest req)
        {
            using (EFContext con = new EFContext())
            {



                foreach (var item in items)
                {
				  List<string> propForCopy = new List<string>();

                    propForCopy.AddRange(req.CustomQuery.SpecificProperties);
                    
					  
					if (!propForCopy.Contains("GuidTask"))
						propForCopy.Add("GuidTask");

					var itemForUpdate = SFSdotNet.Framework.BR.Utils.GetConverted<timeTask,timeTask>(item, propForCopy.ToArray());
					 itemForUpdate.GuidTask = item.GuidTask;
                  var setT = con.Set<timeTask>().Attach(itemForUpdate);

					if (req.CustomQuery.SpecificProperties.Count > 0)
					  {
						  item.ModifiedProperties = req.CustomQuery.SpecificProperties;
					  }
                    foreach (var property in item.ModifiedProperties)
					{						
                        if (property != "GuidTask")
                             con.Entry(setT).Property(property).IsModified = true;

                    }

                }
                 int result = con.SaveChanges();
               if (result != items.Count)
               {
                   SFSdotNet.Framework.My.EventLog.Error("Has been changed " + result.ToString() + " items but the expected value is: " + items.Count.ToString());
               }


            }
        }

		/*public int Update(List<timeTask> items, ContextRequest contextRequest)
            {
                int result = 0;
                using (EFContext con = new EFContext())
                {
                   
                

                    foreach (var item in items)
                    {
                        //secMessageToUser messageToUser = new secMessageToUser();
                        foreach (var prop in contextRequest.CustomQuery.SpecificProperties)
                        {
                            item.GetType().GetProperty(prop).SetValue(item, item.GetType().GetProperty(prop).GetValue(item));
                        }
                        //messageToUser.GuidMessageToUser = (Guid)item.GetType().GetProperty("GuidMessageToUser").GetValue(item);

                        var setObject = con.CreateObjectSet<timeTask>("timeTasks");
                        //messageToUser.Readed = DateTime.UtcNow;
                        setObject.Attach(item);
                        foreach (var prop in contextRequest.CustomQuery.SpecificProperties)
                        {
                            con.ObjectStateManager.GetObjectStateEntry(item).SetModifiedProperty(prop);
                        }
                       
                    }
                    result = con.SaveChanges();

                    


                }
                return result;
            }
           */
		

        public List<timeTask> GetBy(string predicateString, ContextRequest contextRequest, string includes)
        {
            using (EFContext con = new EFContext(contextRequest))
            {
				


				string computedFields = "";
				string fkIncludes = "";
                List<string> multilangProperties = new List<string>();
				//if (predicate == null) predicate = PredicateBuilder.True<timeTask>();
				string isDeletedField = null;
				string notDeletedExpression = null;
	
					bool sharedAndMultiTenant = false;	  
					string multitenantExpression = null;
					//if (contextRequest != null && contextRequest.Company != null)                      	
					//	 multitenantExpression = @"(GuidCompany = Guid(""" + contextRequest.Company.GuidCompany + @"""))";
				if (contextRequest != null && contextRequest.Company != null)
				 {
                    multitenantExpression = @"(GuidCompany = @GuidCompanyMultiTenant)";
                    contextRequest.CustomQuery.SetParam("GuidCompanyMultiTenant", new Nullable<Guid>(contextRequest.Company.GuidCompany));
                }
					 									
					string multiTenantField = "GuidCompany";

                
                return GetBy(con, predicateString, contextRequest, includes, fkIncludes, multilangProperties, multiTenantField, isDeletedField, sharedAndMultiTenant, notDeletedExpression, multitenantExpression,computedFields);


	#region Old Code
	/*
				BusinessRulesEventArgs<timeTask> e = null;

				Filter filter = new Filter();
                if (predicateString.Contains("|"))
                {
                    string ft = GetSpecificFilter(predicateString, contextRequest);
                    if (!string.IsNullOrEmpty(ft))
                        filter.SetFilterPart("ft", ft);
                   
                    contextRequest.FreeText = predicateString.Split(char.Parse("|"))[1];
                    var q1 = predicateString.Split(char.Parse("|"))[0];
                    if (!string.IsNullOrEmpty(q1))
                    {
                        filter.ProcessText(q1);
                    }
                }
                else {
                    filter.ProcessText(predicateString);
                }
				 var includesList = (new List<string>());
                 if (!string.IsNullOrEmpty(includes))
                 {
                     includesList = includes.Split(char.Parse(",")).ToList();
                 }

				List<timeTask> result = new List<timeTask>();
         
			QueryBuild(predicateString, filter, con, contextRequest, "getby", includesList);
			 if (e != null)
                {
                    contextRequest = e.ContextRequest;
                }
				
				
					OnGetting(con, e == null ? e = new BusinessRulesEventArgs<timeTask>() { Filter = filter, ContextRequest = contextRequest  } : e );

                  //OnGetting(con,e = new BusinessRulesEventArgs<timeTask>() {  ContextRequest = contextRequest, FilterExpressionString = predicateString });
			   	if (e != null) {
				    //predicateString = e.GetQueryString();
						if (e.Cancel)
						{
							context = null;
							return e.Items;

						}
						if (!string.IsNullOrEmpty(e.StringIncludes))
                            includes = e.StringIncludes;
					}
				//	 else {
                //      predicateString = predicateString.Replace("*extraFreeText*", "").Replace("()","");
                //  }
				//con.EnableChangeTrackingUsingProxies = false;
				con.Configuration.ProxyCreationEnabled = false;
                con.Configuration.AutoDetectChangesEnabled = false;
                con.Configuration.ValidateOnSaveEnabled = false;

                //if (predicate == null) predicate = PredicateBuilder.True<timeTask>();
                
                //var es = _repository.Queryable;
				IQueryable<timeTask> query = con.timeTasks.AsQueryable();
		
				// include relations FK
				if(string.IsNullOrEmpty(includes) ){
					includes ="";
				}
				StringBuilder sbQuerySystem = new StringBuilder();
					if (!preventSecurityRestrictions)
						{
						if (contextRequest != null )
	                    	if (contextRequest.User !=null )
	                        	if (contextRequest.Company != null ){
	                        		//if (sbQuerySystem.Length > 0)
	                        		//	    			sbQuerySystem.Append( " And ");	
									//sbQuerySystem.Append(@" (GuidCompany = Guid(""" + contextRequest.Company.GuidCompany + @""")) "); //todo: multiempresa

									filter.SetFilterPart("co",@"(GuidCompany = Guid(""" + contextRequest.Company.GuidCompany + @"""))");

								}
						}	
						if (preventSecurityRestrictions) preventSecurityRestrictions= false;
				//string predicateString = predicate.ToDynamicLinq<timeTask>();
				//predicateString += sbQuerySystem.ToString();
				filter.CleanAndProcess("");

				string predicateWithFKAndComputed = filter.GetFilterParentAndCoumputed(); //SFSdotNet.Framework.Linq.Utils.ExtractSpecificProperties("", ref predicateString );               
                string predicateWithManyRelations = filter.GetFilterChildren(); //SFSdotNet.Framework.Linq.Utils.CleanPartExpression(predicateString);

                //QueryUtils.BreakeQuery1(predicateString, ref predicateWithManyRelations, ref predicateWithFKAndComputed);
                var _queryable = query.AsQueryable();
				bool includeAll = true; 
                if (!string.IsNullOrEmpty(predicateWithManyRelations))
                    _queryable = _queryable.Where(predicateWithManyRelations, contextRequest.CustomQuery.ExtraParams);
				if (contextRequest.CustomQuery.SpecificProperties.Count > 0)
                {

				includeAll = false; 
                }

				StringBuilder sbSelect = new StringBuilder();
                sbSelect.Append("new (");
                bool existPrev = false;
                foreach (var selected in contextRequest.CustomQuery.SelectedFields.Where(p=> !string.IsNullOrEmpty(p.Linq)))
                {
                    if (existPrev) sbSelect.Append(", ");
                    if (!selected.Linq.Contains(".") && !selected.Linq.StartsWith("it."))
                        sbSelect.Append("it." + selected.Linq);
                    else
                        sbSelect.Append(selected.Linq);
                    existPrev = true;
                }
                sbSelect.Append(")");
                var queryable = _queryable.Select(sbSelect.ToString());                    


     				
                 if (!string.IsNullOrEmpty(predicateWithFKAndComputed))
                    queryable = queryable.Where(predicateWithFKAndComputed, contextRequest.CustomQuery.ExtraParams);

				QueryComplementOptions queryOps = ContextQueryBuilder.ApplyContextQuery(contextRequest);
            	if (!string.IsNullOrEmpty(queryOps.OrderByAndSort)){
					if (queryOps.OrderBy.Contains(".") && !queryOps.OrderBy.StartsWith("it.")) queryOps.OrderBy = "it." + queryOps.OrderBy;
					queryable = queryable.OrderBy(queryOps.OrderByAndSort);
					}
               	if (queryOps.Skip != null)
                {
                    queryable = queryable.Skip(queryOps.Skip.Value);
                }
                if (queryOps.PageSize != null)
                {
                    queryable = queryable.Take (queryOps.PageSize.Value);
                }


                var resultTemp = queryable.AsQueryable().ToListAsync().Result;
                foreach (var item in resultTemp)
                {

				   result.Add(SFSdotNet.Framework.BR.Utils.GetConverted<timeTask,dynamic>(item, contextRequest.CustomQuery.SelectedFields.Select(p=>p.Name).ToArray()));
                }

			 if (e != null)
                {
                    e.Items = result;
                }
				 contextRequest.CustomQuery = new CustomQuery();
				OnTaken(this, e == null ? e = new BusinessRulesEventArgs<timeTask>() { Items= result, IncludingComputedLinq = true, ContextRequest = contextRequest, FilterExpressionString  = predicateString } :  e);
  
			
  
                if (e != null) {
                    //if (e.ReplaceResult)
                        result = e.Items;
                }
                return result;
	
	*/
	#endregion

            }
        }
		public timeTask GetFromOperation(string function, string filterString, string usemode, string fields, ContextRequest contextRequest)
        {
            using (EFContext con = new EFContext(contextRequest))
            {
                string computedFields = "";
               // string fkIncludes = "accContpaqiClassification,accProjectConcept,accProjectType,accProxyUser";
                List<string> multilangProperties = new List<string>();
				string isDeletedField = null;
				string notDeletedExpression = null;
	
					bool sharedAndMultiTenant = false;	  
					string multitenantExpression = null;
					if (contextRequest != null && contextRequest.Company != null)
					{
						multitenantExpression = @"(GuidCompany = @GuidCompanyMultiTenant)";
						contextRequest.CustomQuery.SetParam("GuidCompanyMultiTenant", new Nullable<Guid>(contextRequest.Company.GuidCompany));
					}
					 									
					string multiTenantField = "GuidCompany";


                return GetSummaryOperation(con, new timeTask(), function, filterString, usemode, multiTenantField, isDeletedField, sharedAndMultiTenant, notDeletedExpression, multitenantExpression, computedFields, contextRequest, fields.Split(char.Parse(",")).ToArray());
            }
        }

   protected override void QueryBuild(string predicate, Filter filter, DbContext efContext, ContextRequest contextRequest, string method, List<string> includesList)
      	{
				if (contextRequest.CustomQuery.SpecificProperties.Count == 0)
                {
					contextRequest.CustomQuery.SpecificProperties.Add(timeTask.PropertyNames.Name);
					contextRequest.CustomQuery.SpecificProperties.Add(timeTask.PropertyNames.Hours);
					contextRequest.CustomQuery.SpecificProperties.Add(timeTask.PropertyNames.HoursWorked);
					contextRequest.CustomQuery.SpecificProperties.Add(timeTask.PropertyNames.StartDate);
					contextRequest.CustomQuery.SpecificProperties.Add(timeTask.PropertyNames.EndDate);
					contextRequest.CustomQuery.SpecificProperties.Add(timeTask.PropertyNames.GuidCompany);
					contextRequest.CustomQuery.SpecificProperties.Add(timeTask.PropertyNames.CreatedDate);
					contextRequest.CustomQuery.SpecificProperties.Add(timeTask.PropertyNames.UpdatedDate);
					contextRequest.CustomQuery.SpecificProperties.Add(timeTask.PropertyNames.CreatedBy);
					contextRequest.CustomQuery.SpecificProperties.Add(timeTask.PropertyNames.UpdatedBy);
					contextRequest.CustomQuery.SpecificProperties.Add(timeTask.PropertyNames.Bytes);
					contextRequest.CustomQuery.SpecificProperties.Add(timeTask.PropertyNames.IsDeleted);
                    
				}

				if (method == "getby" || method == "sum")
				{
					if (!contextRequest.CustomQuery.SpecificProperties.Contains("GuidTask")){
						contextRequest.CustomQuery.SpecificProperties.Add("GuidTask");
					}

					 if (!string.IsNullOrEmpty(contextRequest.CustomQuery.OrderBy))
					{
						string existPropertyOrderBy = contextRequest.CustomQuery.OrderBy;
						if (contextRequest.CustomQuery.OrderBy.Contains("."))
						{
							existPropertyOrderBy = contextRequest.CustomQuery.OrderBy.Split(char.Parse("."))[0];
						}
						if (!contextRequest.CustomQuery.SpecificProperties.Exists(p => p == existPropertyOrderBy))
						{
							contextRequest.CustomQuery.SpecificProperties.Add(existPropertyOrderBy);
						}
					}

				}
				
	bool isFullDetails = contextRequest.IsFromUI("timeTasks", UIActions.GetForDetails);
	string filterForTest = predicate  + filter.GetFilterComplete();

				if (isFullDetails || !string.IsNullOrEmpty(predicate))
            {
            } 

			if (method == "sum")
            {
            } 
			if (contextRequest.CustomQuery.SelectedFields.Count == 0)
            {
				foreach (var selected in contextRequest.CustomQuery.SpecificProperties)
                {
					string linq = selected;
					switch (selected)
                    {

					 
						
					 default:
                            break;
                    }
					contextRequest.CustomQuery.SelectedFields.Add(new SelectedField() { Name=selected, Linq=linq});
					if (method == "getby" || method == "sum")
					{
						if (includesList.Contains(selected))
							includesList.Remove(selected);

					}

				}
			}
				if (method == "getby" || method == "sum")
				{
					foreach (var otherInclude in includesList.Where(p=> !string.IsNullOrEmpty(p)))
					{
						contextRequest.CustomQuery.SelectedFields.Add(new SelectedField() { Name = otherInclude, Linq = "it." + otherInclude +" as " + otherInclude });
					}
				}
				BusinessRulesEventArgs<timeTask> e = null;
				if (contextRequest.PreventInterceptors == false)
					OnQuerySettings(efContext, e = new BusinessRulesEventArgs<timeTask>() { Filter = filter, ContextRequest = contextRequest /*, FilterExpressionString = (contextRequest != null ? (contextRequest.CustomQuery != null ? contextRequest.CustomQuery.FilterExpressionString : null) : null)*/ });

				//List<timeTask> result = new List<timeTask>();
                 if (e != null)
                {
                    contextRequest = e.ContextRequest;
                }

}
		public List<timeTask> GetBy(Expression<Func<timeTask, bool>> predicate, bool loadRelations, ContextRequest contextRequest)
        {
			if(!loadRelations)
				return GetBy(predicate, contextRequest);
			else
				return GetBy(predicate, contextRequest, "");

        }

        public List<timeTask> GetBy(Expression<Func<timeTask, bool>> predicate, int? pageSize, int? page, string orderBy, SFSdotNet.Framework.Data.SortDirection? sortDirection)
        {
            return GetBy(predicate, new ContextRequest() { CustomQuery = new CustomQuery() { Page = page, PageSize = pageSize, OrderBy = orderBy, SortDirection = sortDirection } });
        }
        public List<timeTask> GetBy(Expression<Func<timeTask, bool>> predicate)
        {

			if (System.Web.HttpContext.Current == null || System.Web.HttpContext.Current.Session == null)
            {
                throw new Exception("Please, specific the contextRequest parameter in the method: GetBy");
            }
			ContextRequest contextRequest = new ContextRequest();
            contextRequest.CustomQuery = new CustomQuery();
			contextRequest.CurrentContext = SFSdotNet.Framework.My.Context.CurrentContext;
			            contextRequest.User = SFSdotNet.Framework.My.Context.CurrentContext.User;
            contextRequest.Company = SFSdotNet.Framework.My.Context.CurrentContext.Company;

            contextRequest.CustomQuery.FilterExpressionString = null;
            return this.GetBy(predicate, contextRequest, "");
        }
        #endregion
        #region Dynamic String
		protected override string GetSpecificFilter(string filter, ContextRequest contextRequest) {
            string result = "";
		    //string linqFilter = String.Empty;
            string freeTextFilter = String.Empty;
            if (filter.Contains("|"))
            {
               // linqFilter = filter.Split(char.Parse("|"))[0];
                freeTextFilter = filter.Split(char.Parse("|"))[1];
            }
            //else {
            //    freeTextFilter = filter;
            //}
            //else {
            //    linqFilter = filter;
            //}
			// linqFilter = SFSdotNet.Framework.Linq.Utils.ReplaceCustomDateFilters(linqFilter);
            //string specificFilter = linqFilter;
            if (!string.IsNullOrEmpty(freeTextFilter))
            {
                System.Text.StringBuilder sbCont = new System.Text.StringBuilder();
                /*if (specificFilter.Length > 0)
                {
                    sbCont.Append(" AND ");
                    sbCont.Append(" ({0})");
                }
                else
                {
                    sbCont.Append("{0}");
                }*/
                //var words = freeTextFilter.Split(char.Parse(" "));
				var word = freeTextFilter;
                System.Text.StringBuilder sbSpec = new System.Text.StringBuilder();
                 int nWords = 1;
				/*foreach (var word in words)
                {
					if (word.Length > 0){
                    if (sbSpec.Length > 0) sbSpec.Append(" AND ");
					if (words.Length > 1) sbSpec.Append("("); */
					
	
					
					
					
									
					sbSpec.Append(string.Format(@"Name.Contains(""{0}"")", word));
					

					
	
					
	
					
	
					
	
					
	
					
	
					
	
					
	
					
	
					
	
					
	
					
								 //sbSpec.Append("*extraFreeText*");

                    /*if (words.Length > 1) sbSpec.Append(")");
					
					nWords++;

					}

                }*/
                //specificFilter = string.Format("{0}{1}", specificFilter, string.Format(sbCont.ToString(), sbSpec.ToString()));
                                 result = sbSpec.ToString();  
            }
			//result = specificFilter;
			
			return result;

		}
	
			public List<timeTask> GetBy(string filter, int? pageSize, int? page, string orderBy, string orderDir,  params object[] extraParams)
        {
			return GetBy(filter, pageSize, page, orderBy, orderDir,  null, extraParams);
		}
           public List<timeTask> GetBy(string filter, int? pageSize, int? page, string orderBy, string orderDir, string usemode, params object[] extraParams)
            { 
                return GetBy(filter, pageSize, page, orderBy, orderDir, usemode, null, extraParams);
            }


		public List<timeTask> GetBy(string filter, int? pageSize, int? page, string orderBy, string orderDir,  string usemode, ContextRequest context, params object[] extraParams)

        {

            // string freetext = null;
            //if (filter.Contains("|"))
            //{
            //    int parts = filter.Split(char.Parse("|")).Count();
            //    if (parts > 1)
            //    {

            //        freetext = filter.Split(char.Parse("|"))[1];
            //    }
            //}
		
            //string specificFilter = "";
            //if (!string.IsNullOrEmpty(filter))
            //  specificFilter=  GetSpecificFilter(filter);
            if (string.IsNullOrEmpty(orderBy))
            {
			                orderBy = "UpdatedDate";
            }
			//orderDir = "desc";
			SFSdotNet.Framework.Data.SortDirection direction = SFSdotNet.Framework.Data.SortDirection.Ascending;
            if (!string.IsNullOrEmpty(orderDir))
            {
                if (orderDir == "desc")
                    direction = SFSdotNet.Framework.Data.SortDirection.Descending;
            }
            if (context == null)
                context = new ContextRequest();
			

             context.UseMode = usemode;
             if (context.CustomQuery == null )
                context.CustomQuery =new SFSdotNet.Framework.My.CustomQuery();

 
                context.CustomQuery.ExtraParams = extraParams;

                    context.CustomQuery.OrderBy = orderBy;
                   context.CustomQuery.SortDirection = direction;
                   context.CustomQuery.Page = page;
                  context.CustomQuery.PageSize = pageSize;
               

            

            if (!preventSecurityRestrictions) {
			 if (context.CurrentContext == null)
                {
					if (SFSdotNet.Framework.My.Context.CurrentContext != null &&  SFSdotNet.Framework.My.Context.CurrentContext.Company != null && SFSdotNet.Framework.My.Context.CurrentContext.User != null)
					{
						context.User = SFSdotNet.Framework.My.Context.CurrentContext.User;
						context.Company = SFSdotNet.Framework.My.Context.CurrentContext.Company;

					}
					else {
						throw new Exception("The security rule require a specific user and company");
					}
				}
            }
            return GetBy(filter, context);
  
        }


        public List<timeTask> GetBy(string strWhere, ContextRequest contextRequest)
        {
        	#region old code
				
				 //Expression<Func<tvsReservationTransport, bool>> predicate = null;
				string strWhereClean = strWhere.Replace("*extraFreeText*", "").Replace("()", "");
                //if (!string.IsNullOrEmpty(strWhereClean)){

                //    object[] extraParams = null;
                //    //if (contextRequest != null )
                //    //    if (contextRequest.CustomQuery != null )
                //    //        extraParams = contextRequest.CustomQuery.ExtraParams;
                //    //predicate = System.Linq.Dynamic.DynamicExpression.ParseLambda<tvsReservationTransport, bool>(strWhereClean, extraParams != null? extraParams.Cast<Guid>(): null);				
                //}
				 if (contextRequest == null)
                {
                    contextRequest = new ContextRequest();
                    if (contextRequest.CustomQuery == null)
                        contextRequest.CustomQuery = new CustomQuery();
                }
                  if (!preventSecurityRestrictions) {
					if (contextRequest.User == null || contextRequest.Company == null)
                      {
                     if (SFSdotNet.Framework.My.Context.CurrentContext.Company != null && SFSdotNet.Framework.My.Context.CurrentContext.User != null)
                     {
                         contextRequest.User = SFSdotNet.Framework.My.Context.CurrentContext.User;
                         contextRequest.Company = SFSdotNet.Framework.My.Context.CurrentContext.Company;

                     }
                     else {
                         throw new Exception("The security rule require a specific User and Company ");
                     }
					 }
                 }
            contextRequest.CustomQuery.FilterExpressionString = strWhere;
				//return GetBy(predicate, contextRequest);  

			#endregion				
				
                    return GetBy(strWhere, contextRequest, "");  


        }
       public List<timeTask> GetBy(string strWhere)
        {
		 	ContextRequest context = new ContextRequest();
            context.CustomQuery = new CustomQuery();
            context.CustomQuery.FilterExpressionString = strWhere;
			
            return GetBy(strWhere, context, null);
        }

        public List<timeTask> GetBy(string strWhere, string includes)
        {
		 	ContextRequest context = new ContextRequest();
            context.CustomQuery = new CustomQuery();
            context.CustomQuery.FilterExpressionString = strWhere;
            return GetBy(strWhere, context, includes);
        }

        #endregion
        #endregion
		
		  #region SaveOrUpdate
        
 		 public timeTask Create(timeTask entity)
        {
				//ObjectContext context = null;
				    if (System.Web.HttpContext.Current == null || System.Web.HttpContext.Current.Session  == null){
                    throw new Exception("Please, specific the contextRequest parameter in the method: Create");
                }

                ContextRequest contextRequest = new ContextRequest();
                contextRequest.User = SFSdotNet.Framework.My.Context.CurrentContext.User;
                contextRequest.Company = SFSdotNet.Framework.My.Context.CurrentContext.Company;

				return this.Create(entity, contextRequest);


        }
        
       
        public timeTask Create(timeTask entity, ContextRequest contextRequest)
        {
		
		bool graph = false;
	
				bool preventPartial = false;
                if (contextRequest != null && contextRequest.PreventInterceptors == true )
                {
                    preventPartial = true;
                } 
               
			using (EFContext con = new EFContext()) {

				timeTask itemForSave = new timeTask();
#region Autos
		if(!preventSecurityRestrictions){

				if (entity.CreatedDate == null )
			entity.CreatedDate = DateTime.Now.ToUniversalTime();
		if(contextRequest.User != null)
			entity.CreatedBy = contextRequest.User.GuidUser;
				if (entity.UpdatedDate == null )
			entity.UpdatedDate = DateTime.Now.ToUniversalTime();
		if(contextRequest.User != null)
			entity.UpdatedBy = contextRequest.User.GuidUser;
	
			if (contextRequest != null)
				if(contextRequest.User != null)
					if (contextRequest.Company != null)
						entity.GuidCompany = contextRequest.Company.GuidCompany;
	

			}
#endregion
               BusinessRulesEventArgs<timeTask> e = null;
			    if (preventPartial == false )
                OnCreating(this,e = new BusinessRulesEventArgs<timeTask>() { ContextRequest = contextRequest, Item=entity });
				   if (e != null) {
						if (e.Cancel)
						{
							context = null;
							return e.Item;

						}
					}

                    if (entity.GuidTask == Guid.Empty)
                   {
                       entity.GuidTask = SFSdotNet.Framework.Utilities.UUID.NewSequential();
					   
                   }
				   itemForSave.GuidTask = entity.GuidTask;
				  
		
			itemForSave.GuidTask = entity.GuidTask;

			itemForSave.Name = entity.Name;

			itemForSave.Hours = entity.Hours;

			itemForSave.HoursWorked = entity.HoursWorked;

			itemForSave.StartDate = entity.StartDate;

			itemForSave.EndDate = entity.EndDate;

			itemForSave.GuidCompany = entity.GuidCompany;

			itemForSave.CreatedDate = entity.CreatedDate;

			itemForSave.UpdatedDate = entity.UpdatedDate;

			itemForSave.CreatedBy = entity.CreatedBy;

			itemForSave.UpdatedBy = entity.UpdatedBy;

			itemForSave.Bytes = entity.Bytes;

			itemForSave.IsDeleted = entity.IsDeleted;

				
				con.timeTasks.Add(itemForSave);


                
				con.ChangeTracker.Entries().Where(p => p.Entity != itemForSave && p.State != EntityState.Unchanged).ForEach(p => p.State = EntityState.Detached);

				con.Entry<timeTask>(itemForSave).State = EntityState.Added;

				con.SaveChanges();

					 
				

				//itemResult = entity;
                //if (e != null)
                //{
                 //   e.Item = itemResult;
                //}
				if (contextRequest != null && contextRequest.PreventInterceptors == true )
                {
                    preventPartial = true;
                } 
				if (preventPartial == false )
                OnCreated(this, e == null ? e = new BusinessRulesEventArgs<timeTask>() { ContextRequest = contextRequest, Item = entity } : e);



                if (e != null && e.Item != null )
                {
                    return e.Item;
                }
                              return entity;
			}
            
        }
        //BusinessRulesEventArgs<timeTask> e = null;
        public void Create(List<timeTask> entities)
        {
				if (System.Web.HttpContext.Current == null || System.Web.HttpContext.Current.Session == null)
            {
                throw new Exception("Please, specific the contextRequest parameter in the method: Create");
            }

            ContextRequest contextRequest = new ContextRequest();
            contextRequest.User = SFSdotNet.Framework.My.Context.CurrentContext.User;
            contextRequest.Company = SFSdotNet.Framework.My.Context.CurrentContext.Company;
            Create(entities, contextRequest);
        }
        public void Create(List<timeTask> entities, ContextRequest contextRequest)
        
        {
			ObjectContext context = null;
            	foreach (timeTask entity in entities)
				{
					this.Create(entity, contextRequest);
				}
        }
         public timeTask Update(timeTask entity)
        {
            if (System.Web.HttpContext.Current == null || System.Web.HttpContext.Current.Session == null)
            {
                throw new Exception("Please, specific the contextRequest parameter in the method: Create");
            }

            ContextRequest contextRequest = new ContextRequest();
            contextRequest.User = SFSdotNet.Framework.My.Context.CurrentContext.User;
            contextRequest.Company = SFSdotNet.Framework.My.Context.CurrentContext.Company;
            return Update(entity, contextRequest);
        }
       
         public timeTask Update(timeTask entity, ContextRequest contextRequest)
        {
		 if ((System.Web.HttpContext.Current == null || System.Web.HttpContext.Current.Session == null) && contextRequest == null)
            {
                throw new Exception("Please, specific the contextRequest parameter in the method: Update");
            }
            if (contextRequest == null)
            {
                contextRequest = new ContextRequest();
                contextRequest.User = SFSdotNet.Framework.My.Context.CurrentContext.User;
                contextRequest.Company = SFSdotNet.Framework.My.Context.CurrentContext.Company;
            }

			
				timeTask  itemResult = null;

	
			//entity.UpdatedDate = DateTime.Now.ToUniversalTime();
			//if(contextRequest.User != null)
				//entity.UpdatedBy = contextRequest.User.GuidUser;

//	    var oldentity = GetBy(p => p.GuidTask == entity.GuidTask, contextRequest).FirstOrDefault();
	//	if (oldentity != null) {
		
          //  entity.CreatedDate = oldentity.CreatedDate;
    //        entity.CreatedBy = oldentity.CreatedBy;
	
      //      entity.GuidCompany = oldentity.GuidCompany;
	
			

	
		//}

			 using( EFContext con = new EFContext()){
				BusinessRulesEventArgs<timeTask> e = null;
				bool preventPartial = false; 
				if (contextRequest != null && contextRequest.PreventInterceptors == true )
                {
                    preventPartial = true;
                } 
				if (preventPartial == false)
                OnUpdating(this,e = new BusinessRulesEventArgs<timeTask>() { ContextRequest = contextRequest, Item=entity});
				   if (e != null) {
						if (e.Cancel)
						{
							//outcontext = null;
							return e.Item;

						}
					}

	string includes = "";
	IQueryable < timeTask > query = con.timeTasks.AsQueryable();
	foreach (string include in includes.Split(char.Parse(",")))
                       {
                           if (!string.IsNullOrEmpty(include))
                               query = query.Include(include);
                       }
	var oldentity = query.FirstOrDefault(p => p.GuidTask == entity.GuidTask);
	if (oldentity.Name != entity.Name)
		oldentity.Name = entity.Name;
	if (oldentity.Hours != entity.Hours)
		oldentity.Hours = entity.Hours;
	if (oldentity.HoursWorked != entity.HoursWorked)
		oldentity.HoursWorked = entity.HoursWorked;
	if (oldentity.StartDate != entity.StartDate)
		oldentity.StartDate = entity.StartDate;
	if (oldentity.EndDate != entity.EndDate)
		oldentity.EndDate = entity.EndDate;

				//if (entity.UpdatedDate == null || (contextRequest != null && contextRequest.IsFromUI("timeTasks", UIActions.Updating)))
			oldentity.UpdatedDate = DateTime.Now.ToUniversalTime();
			if(contextRequest.User != null)
				oldentity.UpdatedBy = contextRequest.User.GuidUser;

           


				con.ChangeTracker.Entries().Where(p => p.Entity != oldentity).ForEach(p => p.State = EntityState.Unchanged);  
				  
				con.SaveChanges();
        
					 
					
               
				itemResult = entity;
				if(preventPartial == false)
					OnUpdated(this, e = new BusinessRulesEventArgs<timeTask>() { ContextRequest = contextRequest, Item=itemResult });

              	return itemResult;
			}
			  
        }
        public timeTask Save(timeTask entity)
        {
			return Create(entity);
        }
        public int Save(List<timeTask> entities)
        {
			 Create(entities);
            return entities.Count;

        }
        #endregion
        #region Delete
        public void Delete(timeTask entity)
        {
				this.Delete(entity, null);
			
        }
		 public void Delete(timeTask entity, ContextRequest contextRequest)
        {
				
				  List<timeTask> entities = new List<timeTask>();
				   entities.Add(entity);
				this.Delete(entities, contextRequest);
			
        }

         public void Delete(string query, Guid[] guids, ContextRequest contextRequest)
        {
			var br = new timeTasksBR(true);
            var items = br.GetBy(query, null, null, null, null, null, contextRequest, guids);
            
            Delete(items, contextRequest);

        }
        public void Delete(timeTask entity,  ContextRequest contextRequest, BusinessRulesEventArgs<timeTask> e = null)
        {
			
				using(EFContext con = new EFContext())
                 {
				
               	BusinessRulesEventArgs<timeTask> _e = null;
               List<timeTask> _items = new List<timeTask>();
                _items.Add(entity);
                if (e == null || e.PreventPartialPropagate == false)
                {
                    OnDeleting(this, _e = (e == null ? new BusinessRulesEventArgs<timeTask>() { ContextRequest = contextRequest, Item = entity, Items = null  } : e));
                }
                if (_e != null)
                {
                    if (_e.Cancel)
						{
							context = null;
							return;

						}
					}


				
									//IsDeleted
					bool logicDelete = true;
					if (entity.IsDeleted != null)
					{
						if (entity.IsDeleted.Value)
							logicDelete = false;
					}
					if (logicDelete)
					{
											//entity = GetBy(p =>, contextRequest).FirstOrDefault();
						entity.IsDeleted = true;
						if (contextRequest != null && contextRequest.User != null)
							entity.UpdatedBy = contextRequest.User.GuidUser;
                        entity.UpdatedDate = DateTime.UtcNow;
						UpdateAgile(entity, "IsDeleted","UpdatedBy","UpdatedDate");

						
					}
					else {
					con.Entry<timeTask>(entity).State = EntityState.Deleted;
					con.SaveChanges();
				
				 
					}
								
				
				 
					
					
			if (e == null || e.PreventPartialPropagate == false)
                {

                    if (_e == null)
                        _e = new BusinessRulesEventArgs<timeTask>() { ContextRequest = contextRequest, Item = entity, Items = null };

                    OnDeleted(this, _e);
                }

				//return null;
			}
        }
 public void UnDelete(string query, Guid[] guids, ContextRequest contextRequest)
        {
            var br = new timeTasksBR(true);
            contextRequest.CustomQuery.IncludeDeleted = true;
            var items = br.GetBy(query, null, null, null, null, null, contextRequest, guids);

            foreach (var item in items)
            {
                item.IsDeleted = false;
						if (contextRequest != null && contextRequest.User != null)
							item.UpdatedBy = contextRequest.User.GuidUser;
                        item.UpdatedDate = DateTime.UtcNow;
            }

            UpdateBulk(items, "IsDeleted","UpdatedBy","UpdatedDate");
        }

         public void Delete(List<timeTask> entities,  ContextRequest contextRequest = null )
        {
				
			 BusinessRulesEventArgs<timeTask> _e = null;

                OnDeleting(this, _e = new BusinessRulesEventArgs<timeTask>() { ContextRequest = contextRequest, Item = null, Items = entities });
                if (_e != null)
                {
                    if (_e.Cancel)
                    {
                        context = null;
                        return;

                    }
                }
                bool allSucced = true;
                BusinessRulesEventArgs<timeTask> eToChilds = new BusinessRulesEventArgs<timeTask>();
                if (_e != null)
                {
                    eToChilds = _e;
                }
                else
                {
                    eToChilds = new BusinessRulesEventArgs<timeTask>() { ContextRequest = contextRequest, Item = (entities.Count == 1 ? entities[0] : null), Items = entities };
                }
				foreach (timeTask item in entities)
				{
					try
                    {
                        this.Delete(item, contextRequest, e: eToChilds);
                    }
                    catch (Exception ex)
                    {
                        SFSdotNet.Framework.My.EventLog.Error(ex);
                        allSucced = false;
                    }
				}
				if (_e == null)
                    _e = new BusinessRulesEventArgs<timeTask>() { ContextRequest = contextRequest, CountResult = entities.Count, Item = null, Items = entities };
                OnDeleted(this, _e);

			
        }
        #endregion
 
        #region GetCount
		 public int GetCount(Expression<Func<timeTask, bool>> predicate)
        {
				if (System.Web.HttpContext.Current == null || System.Web.HttpContext.Current.Session  == null){
                    throw new Exception("Please, specific the contextRequest parameter in the method: GetCount");
                }

                ContextRequest contextRequest = new ContextRequest();
                contextRequest.User = SFSdotNet.Framework.My.Context.CurrentContext.User;
                contextRequest.Company = SFSdotNet.Framework.My.Context.CurrentContext.Company;

			return GetCount(predicate, contextRequest);
		}
        public int GetCount(Expression<Func<timeTask, bool>> predicate, ContextRequest contextRequest)
        {


		
		 using (EFContext con = new EFContext())
            {


				if (predicate == null) predicate = PredicateBuilder.True<timeTask>();
           		predicate = predicate.And(p => p.IsDeleted != true || p.IsDeleted == null);
					if (!preventSecurityRestrictions)
						{
						if (contextRequest != null )
                    		if (contextRequest.User !=null )
                        		if (contextRequest.Company != null && contextRequest.CustomQuery.IncludeAllCompanies == false){
									predicate = predicate.And(p => p.GuidCompany == contextRequest.Company.GuidCompany); //todo: multiempresa

								}
						}
						if (preventSecurityRestrictions) preventSecurityRestrictions= false;
				
				IQueryable<timeTask> query = con.timeTasks.AsQueryable();
                return query.AsExpandable().Count(predicate);

			
				}
			

        }
		  public int GetCount(string predicate,  ContextRequest contextRequest)
         {
             return GetCount(predicate, null, contextRequest);
         }

         public int GetCount(string predicate)
        {
				if (System.Web.HttpContext.Current == null || System.Web.HttpContext.Current.Session  == null){
                    throw new Exception("Please, specific the contextRequest parameter in the method: GetCount");
                }

                ContextRequest contextRequest = new ContextRequest();
                contextRequest.User = SFSdotNet.Framework.My.Context.CurrentContext.User;
                contextRequest.Company = SFSdotNet.Framework.My.Context.CurrentContext.Company;
            return GetCount(predicate, contextRequest);
        }
		 public int GetCount(string predicate, string usemode){
				if (System.Web.HttpContext.Current == null || System.Web.HttpContext.Current.Session  == null){
                    throw new Exception("Please, specific the contextRequest parameter in the method: GetCount");
                }

                ContextRequest contextRequest = new ContextRequest();
                contextRequest.User = SFSdotNet.Framework.My.Context.CurrentContext.User;
                contextRequest.Company = SFSdotNet.Framework.My.Context.CurrentContext.Company;
				return GetCount( predicate,  usemode,  contextRequest);
		 }
        public int GetCount(string predicate, string usemode, ContextRequest contextRequest){

		using (EFContext con = new EFContext()) {
				string computedFields = "";
				string fkIncludes = "";
                List<string> multilangProperties = new List<string>();
				//if (predicate == null) predicate = PredicateBuilder.True<timeTask>();
                var notDeletedExpression = "(IsDeleted != true OR IsDeleted = null)";
				string isDeletedField = "IsDeleted";
	
					bool sharedAndMultiTenant = false;	  
					string multitenantExpression = null;
				if (contextRequest != null && contextRequest.Company != null)
				 {
                    multitenantExpression = @"(GuidCompany = @GuidCompanyMultiTenant)";
                    contextRequest.CustomQuery.SetParam("GuidCompanyMultiTenant", new Nullable<Guid>(contextRequest.Company.GuidCompany));
                }
					 									
					string multiTenantField = "GuidCompany";

                
                return GetCount(con, predicate, usemode, contextRequest, multilangProperties, multiTenantField, isDeletedField, sharedAndMultiTenant, notDeletedExpression, multitenantExpression, computedFields);

			}
			#region old code
			 /* string freetext = null;
            Filter filter = new Filter();

              if (predicate.Contains("|"))
              {
                 
                  filter.SetFilterPart("ft", GetSpecificFilter(predicate, contextRequest));
                 
                  filter.ProcessText(predicate.Split(char.Parse("|"))[0]);
                  freetext = predicate.Split(char.Parse("|"))[1];

				  if (!string.IsNullOrEmpty(freetext) && string.IsNullOrEmpty(contextRequest.FreeText))
                  {
                      contextRequest.FreeText = freetext;
                  }
              }
              else {
                  filter.ProcessText(predicate);
              }
			   predicate = filter.GetFilterComplete();
			// BusinessRulesEventArgs<timeTask>  e = null;
           	using (EFContext con = new EFContext())
			{
			
			

			 QueryBuild(predicate, filter, con, contextRequest, "count", new List<string>());


			
			BusinessRulesEventArgs<timeTask> e = null;

			contextRequest.FreeText = freetext;
			contextRequest.UseMode = usemode;
            OnCounting(this, e = new BusinessRulesEventArgs<timeTask>() {  Filter =filter, ContextRequest = contextRequest });
            if (e != null)
            {
                if (e.Cancel)
                {
                    context = null;
                    return e.CountResult;

                }

            

            }
			
			StringBuilder sbQuerySystem = new StringBuilder();
		
					
                    filter.SetFilterPart("de","(IsDeleted != true OR IsDeleted == null)");
			
					if (!preventSecurityRestrictions)
						{
						if (contextRequest != null )
                    	if (contextRequest.User !=null )
                        	if (contextRequest.Company != null && contextRequest.CustomQuery.IncludeAllCompanies == false){
                        		
								filter.SetFilterPart("co", @"(GuidCompany = Guid(""" + contextRequest.Company.GuidCompany + @""")) "); //todo: multiempresa
						
						
							}
							
							}
							if (preventSecurityRestrictions) preventSecurityRestrictions= false;
		
				   
                 filter.CleanAndProcess("");
				//string predicateWithFKAndComputed = SFSdotNet.Framework.Linq.Utils.ExtractSpecificProperties("", ref predicate );               
				string predicateWithFKAndComputed = filter.GetFilterParentAndCoumputed();
               string predicateWithManyRelations = filter.GetFilterChildren();
			   ///QueryUtils.BreakeQuery1(predicate, ref predicateWithManyRelations, ref predicateWithFKAndComputed);
			   predicate = filter.GetFilterComplete();
               if (!string.IsNullOrEmpty(predicate))
               {
				
					
                    return con.timeTasks.Where(predicate).Count();
					
                }else
                    return con.timeTasks.Count();
					
			}*/
			#endregion

		}
         public int GetCount()
        {
            return GetCount(p => true);
        }
        #endregion
        
         


        public void Delete(List<timeTask.CompositeKey> entityKeys)
        {

            List<timeTask> items = new List<timeTask>();
            foreach (var itemKey in entityKeys)
            {
                items.Add(GetByKey(itemKey.GuidTask));
            }

            Delete(items);

        }
		 public void UpdateAssociation(string relation, string relationValue, string query, Guid[] ids, ContextRequest contextRequest)
        {
            var items = GetBy(query, null, null, null, null, null, contextRequest, ids);
			 var module = SFSdotNet.Framework.Cache.Caching.SystemObjects.GetModuleByKey(SFSdotNet.Framework.Web.Utils.GetRouteDataOrQueryParam(System.Web.HttpContext.Current.Request.RequestContext, "area"));
           
            foreach (var item in items)
            {
			  Guid ? guidRelationValue = null ;
                if (!string.IsNullOrEmpty(relationValue)){
                    guidRelationValue = Guid.Parse(relationValue );
                }

				 if (relation.Contains("."))
                {
                    var partsWithOtherProp = relation.Split(char.Parse("|"));
                    var parts = partsWithOtherProp[0].Split(char.Parse("."));

                    string proxyRelName = parts[0];
                    string proxyProperty = parts[1];
                    string proxyPropertyKeyNameFromOther = partsWithOtherProp[1];
                    //string proxyPropertyThis = parts[2];

                    var prop = item.GetType().GetProperty(proxyRelName);
                    //var entityInfo = //SFSdotNet.Framework.
                    // descubrir el tipo de entidad dentro de la colección
                    Type typeEntityInList = SFSdotNet.Framework.Entities.Utils.GetTypeFromList(prop);
                    var newProxyItem = Activator.CreateInstance(typeEntityInList);
                    var propThisForSet = newProxyItem.GetType().GetProperty(proxyProperty);
                    var entityInfoOfProxy = SFSdotNet.Framework.Common.Entities.Metadata.MetadataAttributes.GetMyAttribute<SFSdotNet.Framework.Common.Entities.Metadata.EntityInfoAttribute>(typeEntityInList);
                    var propOther = newProxyItem.GetType().GetProperty(proxyPropertyKeyNameFromOther);

                    if (propThisForSet != null && entityInfoOfProxy != null && propOther != null )
                    {
                        var entityInfoThis = SFSdotNet.Framework.Common.Entities.Metadata.MetadataAttributes.GetMyAttribute<SFSdotNet.Framework.Common.Entities.Metadata.EntityInfoAttribute>(item.GetType());
                        var valueThisId = item.GetType().GetProperty(entityInfoThis.PropertyKeyName).GetValue(item);
                        if (valueThisId != null)
                            propThisForSet.SetValue(newProxyItem, valueThisId);
                        propOther.SetValue(newProxyItem, Guid.Parse(relationValue));
                        
                        var entityNameProp = newProxyItem.GetType().GetField("EntityName").GetValue(null);
                        var entitySetNameProp = newProxyItem.GetType().GetField("EntitySetName").GetValue(null);

                        SFSdotNet.Framework.Apps.Integration.CreateItemFromApp(entityNameProp.ToString(), entitySetNameProp.ToString(), module.ModuleNamespace, newProxyItem, contextRequest);

                    }

                    // crear una instancia del tipo de entidad
                    // llenar los datos y registrar nuevo


                }
                else
                {
                var prop = item.GetType().GetProperty(relation);
                var entityInfo = SFSdotNet.Framework.Common.Entities.Metadata.MetadataAttributes.GetMyAttribute<SFSdotNet.Framework.Common.Entities.Metadata.EntityInfoAttribute>(prop.PropertyType);
                if (entityInfo != null)
                {
                    var ins = Activator.CreateInstance(prop.PropertyType);
                   if (guidRelationValue != null)
                    {
                        prop.PropertyType.GetProperty(entityInfo.PropertyKeyName).SetValue(ins, guidRelationValue);
                        item.GetType().GetProperty(relation).SetValue(item, ins);
                    }
                    else
                    {
                        item.GetType().GetProperty(relation).SetValue(item, null);
                    }

                    Update(item, contextRequest);
                }

				}
            }
        }
		
	}
	 
}


