using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using MBK.Time.Web.Mvc.Resources;
using System.Runtime.Serialization;
using SFSdotNet.Framework.Web.Mvc.Models;
using SFSdotNet.Framework.Web.Mvc.Extensions;
using BO = MBK.Time.BusinessObjects;
using System.Web.Mvc;
//using SFSdotNet.Framework.Web.Mvc.Validation;
//using SFSdotNet.Framework.Web.Mvc.Models;
using SFSdotNet.Framework.Web.Mvc.Resources;
using SFSdotNet.Framework.Common.Entities.Metadata;
using System.Text;
using MBK.Time.BusinessObjects;
	namespace MBK.Time.Web.Mvc.Models.timeTasks 
	{
	public partial class timeTaskModel: ModelBase{

	  public timeTaskModel(BO.timeTask resultObj)
        {

            Bind(resultObj);
        }
#region Tags		
#endregion
		public timeTaskModel()
        {
		}
		public override string Id
        {
            get
            {
                return this.GuidTask.ToString();
            }
        }
			
			
        public override string ToString()
        {
			if (this.Name != null)
		
            return this.Name.ToString();
			else
				return "";
		
        }    
			

       
	
		[SystemProperty()]		
		public Guid? GuidTask{ get; set; }
		
	
[Exportable()]
		
	[RelationFilterable()] 
	[LocalizedDisplayName("NAME"/*, NameResourceType=typeof(timeTaskResources)*/)]
	public String   Name { get; set; }
		
		
	
[Exportable()]
		
	[RelationFilterable()] 
	[DataType("Integer")]
	[LocalizedDisplayName("HOURS"/*, NameResourceType=typeof(timeTaskResources)*/)]
	public Int32  ? Hours { get; set; }
	public string _HoursText = null;
    public string HoursText {
        get {
			if (string.IsNullOrEmpty( _HoursText ))
				{
	
            if (Hours != null)
				return Hours.ToString();
				
            else
                return String.Empty;
	
			}else{
				return _HoursText ;
			}			
        }
		set{
			_HoursText = value;
		}
        
    }

		
		
	
[Exportable()]
		
	[RelationFilterable()] 
	[DataType("Integer")]
	[LocalizedDisplayName("HOURSWORKED"/*, NameResourceType=typeof(timeTaskResources)*/)]
	public Int64  ? HoursWorked { get; set; }
	public string _HoursWorkedText = null;
    public string HoursWorkedText {
        get {
			if (string.IsNullOrEmpty( _HoursWorkedText ))
				{
	
            if (HoursWorked != null)
				return HoursWorked.ToString();
				
            else
                return String.Empty;
	
			}else{
				return _HoursWorkedText ;
			}			
        }
		set{
			_HoursWorkedText = value;
		}
        
    }

		
		
	
[Exportable()]
		
	[RelationFilterable()] 
	[DateTime(true, false, null)]	
	[LocalizedDisplayName("STARTDATE"/*, NameResourceType=typeof(timeTaskResources)*/)]
	public DateTime  ? StartDate { get; set; }
	public string StartDateText {
        get {
            if (StartDate != null)
				return ((DateTime)StartDate).ToShortDateString() ;
            else
                return String.Empty;
        }
				set{
					if (!string.IsNullOrEmpty(value))
						this.StartDate = Convert.ToDateTime(value);
    }
		}
		
		
	
[Exportable()]
		
	[RelationFilterable()] 
	[DateTime(true, false, null)]	
	[LocalizedDisplayName("ENDDATE"/*, NameResourceType=typeof(timeTaskResources)*/)]
	public DateTime  ? EndDate { get; set; }
	public string EndDateText {
        get {
            if (EndDate != null)
				return ((DateTime)EndDate).ToShortDateString() ;
            else
                return String.Empty;
        }
				set{
					if (!string.IsNullOrEmpty(value))
						this.EndDate = Convert.ToDateTime(value);
    }
		}
		
		
	
[Exportable()]
		
	[RelationFilterable()] 
	[SystemProperty()]
	[LocalizedDisplayName("GUIDCOMPANY"/*, NameResourceType=typeof(timeTaskResources)*/)]
	public Guid  ? GuidCompany { get; set; }
		
		
	
[Exportable()]
		
	[RelationFilterable()] 
	[SystemProperty()]
	[DateTime(true, false, null)]	
	[LocalizedDisplayName("CREATEDDATE"/*, NameResourceType=typeof(timeTaskResources)*/)]
	public DateTime  ? CreatedDate { get; set; }
	public string CreatedDateText {
        get {
            if (CreatedDate != null)
				return ((DateTime)CreatedDate).ToShortDateString() ;
            else
                return String.Empty;
        }
				set{
					if (!string.IsNullOrEmpty(value))
						this.CreatedDate = Convert.ToDateTime(value);
    }
		}
		
		
	
[Exportable()]
		
	[RelationFilterable()] 
	[SystemProperty()]
	[DateTime(true, false, null)]	
	[LocalizedDisplayName("UPDATEDDATE"/*, NameResourceType=typeof(timeTaskResources)*/)]
	public DateTime  ? UpdatedDate { get; set; }
	public string UpdatedDateText {
        get {
            if (UpdatedDate != null)
			
                return ((DateTime)UpdatedDate).ToString("s") ;
            else
                return String.Empty;
        }
				set{
					if (!string.IsNullOrEmpty(value))
						this.UpdatedDate = Convert.ToDateTime(value);
    }
		}
		
		
	
[Exportable()]
		
[RelationFilterable(FiltrablePropertyPathName = "CreatedBy", IsExternal =true )]
[AutoComplete("SFSdotNetFrameworkSecurity", "secUsers", "FindUsers", "filter", "DisplayName", "GuidUser", true)]	

	[SystemProperty()]
	[LocalizedDisplayName("CREATEDBY"/*, NameResourceType=typeof(timeTaskResources)*/)]
	public Guid  ? CreatedBy { get; set; }
		
		
	
[Exportable()]
		
[RelationFilterable(FiltrablePropertyPathName = "UpdatedBy", IsExternal =true )]
[AutoComplete("SFSdotNetFrameworkSecurity", "secUsers", "FindUsers", "filter", "DisplayName", "GuidUser", true)]	

	[SystemProperty()]
	[LocalizedDisplayName("UPDATEDBY"/*, NameResourceType=typeof(timeTaskResources)*/)]
	public Guid  ? UpdatedBy { get; set; }
		
		
	
[Exportable()]
		
	[RelationFilterable()] 
	[SystemProperty()]
	[DataType("Integer")]
	[LocalizedDisplayName("BYTES"/*, NameResourceType=typeof(timeTaskResources)*/)]
	public Int32  ? Bytes { get; set; }
	public string _BytesText = null;
    public string BytesText {
        get {
			if (string.IsNullOrEmpty( _BytesText ))
				{
	
            if (Bytes != null)
				return Bytes.ToString();
				
            else
                return String.Empty;
	
			}else{
				return _BytesText ;
			}			
        }
		set{
			_BytesText = value;
		}
        
    }

		
		
	
[Exportable()]
		
	[RelationFilterable()] 
	[SystemProperty()]
	[LocalizedDisplayName("ISDELETED"/*, NameResourceType=typeof(timeTaskResources)*/)]
	public Boolean  ? IsDeleted { get; set; }
	public string _IsDeletedText = null;
    public string IsDeletedText {
        get {
			if (string.IsNullOrEmpty( _IsDeletedText ))
				{
	
            if (IsDeleted != null)

				return IsDeleted.ToString();
				
            else
                return String.Empty;
	
			}else{
				return _IsDeletedText ;
			}			
        }
		set{
			_IsDeletedText = value;
		}
        
    }

		
		
		
	public override string SafeKey
   	{
		get
        {
			if(this.GuidTask != null)
				return SFSdotNet.Framework.Entities.Utils.GetKey(this ,"GuidTask").Replace("/","-");
			else
				return String.Empty;
		}
    }		
		public void Bind(timeTaskModel model){
            
		this.GuidTask = model.GuidTask;
		this.Name = model.Name;
		this.Hours = model.Hours;
		this.HoursWorked = model.HoursWorked;
		this.StartDate = model.StartDate;
		this.EndDate = model.EndDate;
		this.GuidCompany = model.GuidCompany;
		this.CreatedDate = model.CreatedDate;
		this.UpdatedDate = model.UpdatedDate;
		this.CreatedBy = model.CreatedBy;
		this.UpdatedBy = model.UpdatedBy;
		this.Bytes = model.Bytes;
		this.IsDeleted = model.IsDeleted;
        }

        public BusinessObjects.timeTask GetBusinessObject()
        {
            BusinessObjects.timeTask result = new BusinessObjects.timeTask();


			       
	if (this.GuidTask != null )
				result.GuidTask = (Guid)this.GuidTask;
				
	if (this.Name != null )
				result.Name = (String)this.Name.Trim().Replace("\t", String.Empty);
				
	if (this.Hours != null )
				result.Hours = (Int32)this.Hours;
				
	if (this.HoursWorked != null )
				result.HoursWorked = (Int64)this.HoursWorked;
				
				if(this.StartDate != null)
					if (this.StartDate != null)
				result.StartDate = (DateTime)this.StartDate;		
				
				if(this.EndDate != null)
					if (this.EndDate != null)
				result.EndDate = (DateTime)this.EndDate;		
				
	if (this.GuidCompany != null )
				result.GuidCompany = (Guid)this.GuidCompany;
				
				if(this.CreatedDate != null)
					if (this.CreatedDate != null)
				result.CreatedDate = (DateTime)this.CreatedDate;		
				
				if(this.UpdatedDate != null)
					if (this.UpdatedDate != null)
				result.UpdatedDate = (DateTime)this.UpdatedDate;		
				
	if (this.CreatedBy != null )
				result.CreatedBy = (Guid)this.CreatedBy;
				
	if (this.UpdatedBy != null )
				result.UpdatedBy = (Guid)this.UpdatedBy;
				
	if (this.Bytes != null )
				result.Bytes = (Int32)this.Bytes;
				
	if (this.IsDeleted != null )
				result.IsDeleted = (Boolean)this.IsDeleted;
				

            return result;
        }
        public void Bind(BusinessObjects.timeTask businessObject)
        {
				this.BusinessObjectObject = businessObject;

			this.GuidTask = businessObject.GuidTask;
				
				
	if (businessObject.Name != null )
				this.Name = (String)businessObject.Name;
				
	if (businessObject.Hours != null )
				this.Hours = (Int32)businessObject.Hours;
				
	if (businessObject.HoursWorked != null )
				this.HoursWorked = (Int64)businessObject.HoursWorked;
				if (businessObject.StartDate != null )
				this.StartDate = (DateTime)businessObject.StartDate;
				if (businessObject.EndDate != null )
				this.EndDate = (DateTime)businessObject.EndDate;
				
	if (businessObject.GuidCompany != null )
				this.GuidCompany = (Guid)businessObject.GuidCompany;
				if (businessObject.CreatedDate != null )
				this.CreatedDate = (DateTime)businessObject.CreatedDate;
				if (businessObject.UpdatedDate != null )
				this.UpdatedDate = (DateTime)businessObject.UpdatedDate;
				
	if (businessObject.CreatedBy != null )
				this.CreatedBy = (Guid)businessObject.CreatedBy;
				
	if (businessObject.UpdatedBy != null )
				this.UpdatedBy = (Guid)businessObject.UpdatedBy;
				
	if (businessObject.Bytes != null )
				this.Bytes = (Int32)businessObject.Bytes;
				
	if (businessObject.IsDeleted != null )
				this.IsDeleted = (Boolean)businessObject.IsDeleted;
           
        }
	}
}
