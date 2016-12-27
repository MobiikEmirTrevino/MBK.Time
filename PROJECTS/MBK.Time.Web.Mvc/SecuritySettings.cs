
 
 
// <Template>
//   <SolutionTemplate></SolutionTemplate>
//   <Version>20140213.2136</Version>
//   <Update>Agregado el objeto ContextRequest en todas las peticiones de reglas de negocio</Update>
// </Template>using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System;
using System.Collections.Generic;
using SFSdotNet.Framework.Security.BusinessObjects;
using SFSdotNet.Framework.My;


namespace MBK.Time.Web.Mvc
{
    public partial class SecuritySettings
    {
		static partial void OnCreatingRolesAndUsers(object sender, secModule module);
		static partial void OnIntegrationSetting(object sender, SFSdotNet.Framework.Security.BusinessObjects.secModule module, ContextRequest contextRequest);
        
        public static void PermissionsInitialization() {
			ContextRequest contextRequest = new ContextRequest();
            string moduleKey = "MBKTime";

			var module = SFSdotNet.Framework.Security.SiteMapBuilder.AddModuleIfNotExist(moduleKey, moduleKey, "MBK.Time", null);

            #region permissions
            secPermission createPermission = SFSdotNet.Framework.Security.Permissions.AddPermissionIfNotExist("c", "Create", module, contextRequest);
            secPermission readPermission = SFSdotNet.Framework.Security.Permissions.AddPermissionIfNotExist("r", "Read", module, contextRequest);
            secPermission updatePermission = SFSdotNet.Framework.Security.Permissions.AddPermissionIfNotExist("u", "Update", module, contextRequest);
            secPermission deletePermission = SFSdotNet.Framework.Security.Permissions.AddPermissionIfNotExist("d", "Delete", module, contextRequest);
			
			OnCreatingRolesAndUsers(null, module);
			 OnIntegrationSetting(null, module, contextRequest);
		
			//if (SFSdotNet.Framework.Security.BR.secRolesBR.Instance.GetBy(p => p.LoweredRoleName == "superadmin").Count == 0)
            //    SFSdotNet.Framework.Security.BR.secRolesBR.Instance.Create(new secRole() { LoweredRoleName="superadmin", RoleName="superadmin" });


			 if (SFSdotNet.Framework.Security.BR.secRolesBR.Instance.GetBy(p => p.LoweredRoleName == "mbktime admin", contextRequest).Count == 0)
                SFSdotNet.Framework.Security.BR.secRolesBR.Instance.Create(new secRole() { LoweredRoleName="mbktime admin", RoleName="MBKTime Admin" }, contextRequest);
            
            
			AddPermissionIfNotExist(module, null, readPermission);
            #endregion
			
			secBusinessObject bo = null;
			secModuleObjectPermission mop =  null;
            secRoleModuleObjectPermission rmop = null;
			#region BusinessObjects
			
            #region timeTask
            bo = SFSdotNet.Framework.Security.BR.secBusinessObjectsBR.Instance.GetBy(p=>p.BusinessObjectKey == "timeTask" && p.secModule.ModuleKey == module.ModuleKey , contextRequest).FirstOrDefault();
            if (bo == null) {
                            bo = SFSdotNet.Framework.Security.BR.secBusinessObjectsBR.Instance.Create(new secBusinessObject() { BusinessObjectKey="timeTask",EntitySetName="timeTasks", Name="timeTask", secModule = module, GuidBusinessObject= Guid.NewGuid()  }, contextRequest);
            }else{
				bo.EntitySetName = "timeTasks";
				bo = SFSdotNet.Framework.Security.BR.secBusinessObjectsBR.Instance.Update(bo, contextRequest);
			}
            AddPermissionIfNotExist(module, bo, createPermission);
            AddPermissionIfNotExist(module, bo, readPermission);
            AddPermissionIfNotExist(module, bo, updatePermission);
            AddPermissionIfNotExist(module, bo, deletePermission);
            #endregion

            #endregion
        }
		
		public static void AddPermissionIfNotExist(secModule module, secBusinessObject businessObject, secPermission permission) {
              // se asume que el permiso ya existe
            // se asume que el m?dulo ya existe
             ContextRequest contextRequest = new ContextRequest();
            if (businessObject == null)
            {
                // m?dulo y permiso ya existen
                secPermission mp = SFSdotNet.Framework.Security.BR.secPermissionsBR.Instance.GetBy(
                p => p.PermissionKey == permission.PermissionKey
                && p.secModules.Any(x=>x.ModuleKey == module.ModuleKey)
                , contextRequest).FirstOrDefault();
                if (mp == null) {

                    SFSdotNet.Framework.Security.BR.secPermissionsBR.Instance.AddRelation(permission, module);
                }

                secRoleModulePermission rmp = SFSdotNet.Framework.Security.BR.secRoleModulePermissionsBR.Instance.GetBy(
                    p => p.secRole.LoweredRoleName == "superadmin"
                    && p.secModule.ModuleKey == module.ModuleKey
                
                    && p.secPermission.PermissionKey == permission.PermissionKey, contextRequest).FirstOrDefault();
                if (rmp == null) {
                    rmp = new secRoleModulePermission();
					rmp.secRole = SFSdotNet.Framework.Security.BR.secRolesBR.Instance.GetBy(p => p.LoweredRoleName == "superadmin", contextRequest).FirstOrDefault();
                    rmp.secModule = module;
                    rmp.secPermission = permission;
					rmp.IsAllowed = true;
                    SFSdotNet.Framework.Security.BR.secRoleModulePermissionsBR.Instance.Create(rmp, contextRequest);
                }
				rmp = SFSdotNet.Framework.Security.BR.secRoleModulePermissionsBR.Instance.GetBy(
                    p => p.secRole.LoweredRoleName == "mbktime admin"
                    && p.secModule.ModuleKey == module.ModuleKey
                
                    && p.secPermission.PermissionKey == permission.PermissionKey, contextRequest).FirstOrDefault();
                if (rmp == null) {
                    rmp = new secRoleModulePermission();
					rmp.secRole = SFSdotNet.Framework.Security.BR.secRolesBR.Instance.GetBy(p => p.LoweredRoleName == "mbktime admin", contextRequest).FirstOrDefault();
                    rmp.secModule = module;
                    rmp.secPermission = permission;
					rmp.IsAllowed = true;
                    SFSdotNet.Framework.Security.BR.secRoleModulePermissionsBR.Instance.Create(rmp, contextRequest);
                }
            }
            else { 
				secModuleObjectPermission mop = SFSdotNet.Framework.Security.BR.secModuleObjectPermissionsBR.Instance.GetBy(
					p => p.secPermission.PermissionKey == permission.PermissionKey
					&& p.secBusinessObject.BusinessObjectKey == businessObject.BusinessObjectKey
					&& p.secModule.ModuleKey == module.ModuleKey
					, contextRequest).FirstOrDefault();
				if (mop == null)
				{
					mop = new secModuleObjectPermission();
					mop.secModule = module;
					mop.secBusinessObject = businessObject;
					mop.secPermission = permission;

					mop = SFSdotNet.Framework.Security.BR.secModuleObjectPermissionsBR.Instance.Create(mop, contextRequest);
				}

				secRoleModuleObjectPermission rmop = SFSdotNet.Framework.Security.BR.secRoleModuleObjectPermissionsBR.Instance.GetBy(
					p => p.secRole.LoweredRoleName == "superadmin"
					&& p.secModule.ModuleKey == module.ModuleKey 
					&& p.secBusinessObject.BusinessObjectKey == businessObject.BusinessObjectKey 
					&& p.secPermission.PermissionKey == permission.PermissionKey, contextRequest).FirstOrDefault();
				if (rmop == null)
				{
					rmop = new secRoleModuleObjectPermission();
					rmop.secBusinessObject = businessObject ;
					rmop.secModule = module;
					rmop.secRole = SFSdotNet.Framework.Security.BR.secRolesBR.Instance.GetBy(p => p.LoweredRoleName == "superadmin", contextRequest).FirstOrDefault();
					rmop.secPermission = permission ;
					rmop.IsAllowed = true;

					SFSdotNet.Framework.Security.BR.secRoleModuleObjectPermissionsBR.Instance.Create(rmop, contextRequest);

				}
				
				rmop = SFSdotNet.Framework.Security.BR.secRoleModuleObjectPermissionsBR.Instance.GetBy(
					p => p.secRole.LoweredRoleName == "mbktime admin"
					&& p.secModule.ModuleKey == module.ModuleKey 
					&& p.secBusinessObject.BusinessObjectKey == businessObject.BusinessObjectKey 
					&& p.secPermission.PermissionKey == permission.PermissionKey, contextRequest).FirstOrDefault();
				if (rmop == null)
				{
					rmop = new secRoleModuleObjectPermission();
					rmop.secBusinessObject = businessObject ;
					rmop.secModule = module;
					rmop.secRole = SFSdotNet.Framework.Security.BR.secRolesBR.Instance.GetBy(p => p.LoweredRoleName == "mbktime admin", contextRequest).FirstOrDefault();
					rmop.secPermission = permission ;
					rmop.IsAllowed = true;

					SFSdotNet.Framework.Security.BR.secRoleModuleObjectPermissionsBR.Instance.Create(rmop, contextRequest);

				}
			}

        }

    }
}