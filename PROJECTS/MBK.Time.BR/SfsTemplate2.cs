 
 
// <Template>
//   <SolutionTemplate>EF POCO 1</SolutionTemplate>
//   <Version>1.1422.1</Version>
//   <Update>True</Update>
// </Template>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MBK.Time.BusinessObjects;

using System.IO;
using SFSdotNet.Framework.Cache;
using System.Data.Entity.Core.Objects;
using SFSdotNet.Framework.Security.BusinessObjects;
using System.Data;
using System.Data.Entity.Infrastructure;
using SFSdotNet.Framework.My;


namespace MBK.Time.BR
{


	      public class EFContext : MBK.Time.BusinessObjects.EF.MBKTimeContext
    {
		List<secAudit> auditTrailList = new List<secAudit>();

      public EFContext(ContextRequest contextRequest): base(SFSdotNet.Framework.Configuration.ConfigurationSettings.GetConnectionString("MBKTimeContext", "MBK.Time") ,  (contextRequest != null ? (contextRequest.CurrentContext != null ? (contextRequest.CurrentContext.ApplicationPath != null ? (contextRequest.CurrentContext.ApplicationPath + "App_Data\\") : null) : null): null ))

            {
             var objectContext = (this as IObjectContextAdapter).ObjectContext;

            // Sets the command timeout for all the commands
            objectContext.CommandTimeout = 500;
        }

		 public EFContext(): base(SFSdotNet.Framework.Configuration.ConfigurationSettings.GetConnectionString("MBKTimeContext", "MBK.Time") , null)

            {
             var objectContext = (this as IObjectContextAdapter).ObjectContext;

            // Sets the command timeout for all the commands
            objectContext.CommandTimeout = 500;
        }


        public void AuditChanges(object entity, SFSdotNet.Framework.My.Audit.AuditActions action, params string[] properties) { 
            SFSdotNet.Framework.My.Audit.AuditTrailFactory(entity, action, "MBKTime",null, properties);
        
        }
		 public void AuditChanges(object entity, SFSdotNet.Framework.My.Audit.AuditActions action, ContextRequest context, params string[] properties) { 
            SFSdotNet.Framework.My.Audit.AuditTrailFactory(entity, action, "MBKTime", context, properties);
        
        }
      


    }

}
