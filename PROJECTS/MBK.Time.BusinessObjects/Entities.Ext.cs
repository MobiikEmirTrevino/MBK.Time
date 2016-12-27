 
 
// <Template>
//   <SolutionTemplate>EF POCO 1</SolutionTemplate>
//   <Version>20140822.0944</Version>
//   <Update>Metadata de identificador</Update>
// </Template>
#region using
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using SFSdotNet.Framework.Common.Entities.Metadata;
using SFSdotNet.Framework.Common.Entities;
using System.Linq.Dynamic;
//using Repository.Pattern.Ef6;
#endregion
namespace MBK.Time.BusinessObjects
{

	  [Serializable()]
	  [EntityInfo(PropertyKeyName="GuidTask",PropertyDefaultText="Name", CompanyPropertyName = "GuidCompany",CreatedByPropertyName="CreatedBy",UpdatedByPropertyName="UpdatedBy",CreatedDatePropertyName="CreatedDate",UpdatedDatePropertyName="UpdatedDate",DeletedPropertyName="IsDeleted")]
	  [DynamicLinqType]
	  public partial class timeTask:  IMyEntity{
			public SFSdotNet.Framework.Common.GlobalObjects.UserInfo CreatedByUser { get; set; }

			public override string ToString()
            {
	
				if (this.Name != null )		
            		return this.Name.ToString();
				else
					return String.Empty;
			}

		//public timeTask()
        //  {

        //  }

	  #region Composite Key
	   public string Key { 
                  get {
                      StringBuilder sb = new StringBuilder();
					sb.Append(this.GuidTask.ToString());
                      return sb.ToString();
                } 
		}
        [Serializable()]
        [DataContract]
        public class CompositeKey {

			
            public CompositeKey(Guid guidTask)
            {
				_GuidTask = guidTask;

            }
			private Guid _GuidTask;
			[DataMember]
			public Guid GuidTask
			{
				get{
					return _GuidTask;
				}
				set{
                     
					_GuidTask = value;
				}
	        }

            
        }
        #endregion
        
	
       
      


	      #region propertyNames
		public static readonly string EntityName = "timeTask";
		public static readonly string EntitySetName = "timeTasks";
        public struct PropertyNames {
            public static readonly string GuidTask = "GuidTask";
            public static readonly string Name = "Name";
            public static readonly string Hours = "Hours";
            public static readonly string HoursWorked = "HoursWorked";
            public static readonly string StartDate = "StartDate";
            public static readonly string EndDate = "EndDate";
            public static readonly string GuidCompany = "GuidCompany";
            public static readonly string CreatedDate = "CreatedDate";
            public static readonly string UpdatedDate = "UpdatedDate";
            public static readonly string CreatedBy = "CreatedBy";
            public static readonly string UpdatedBy = "UpdatedBy";
            public static readonly string Bytes = "Bytes";
            public static readonly string IsDeleted = "IsDeleted";
		}
		#endregion
	}
	 
	
}
