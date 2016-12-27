using MBK.Time.BR;
using MBK.Time.BusinessObjects;
using MBK.Time.Web.Mvc.Models;
using Newtonsoft.Json;
using SFSdotNet.Framework.Common.Entities;
using SFSdotNet.Framework.Entities;
using SFSdotNet.Framework.My;
using SFSdotNet.Framework.Security.BR;
using SFSdotNet.Framework.Security.BusinessObjects;
using SFSdotNet.Framework.Security.Web.Mvc.Models.secCompanies;
using SFSdotNet.Framework.Web.Mvc;
using SFSdotNet.Framework.Web.Mvc.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MBK.Time.Web.Mvc.Controllers
{

    public class IntegrationAppsController : SFSdotNet.Framework.Web.Mvc.ControllerBase
    {
    
        public void OnLayoutSettings(object sender, object e)
        {
            MBK.Time.Web.Mvc.ControllerBase<ModelBase> controller = new ControllerBase<ModelBase>();
            MyEventArgs<SFSdotNet.Framework.Web.Mvc.Models.UIModel<ModelBase>> eModel = (MyEventArgs<SFSdotNet.Framework.Web.Mvc.Models.UIModel<ModelBase>>)e;
            controller.LayoutSettings(this, eModel);
            e = eModel;

        }

        public void OnEdited(object sender, object e)
        {
            if (sender.GetType().FullName.Contains("secCompaniesController"))
            {
              
            }
        }
        public void OnShowing(object sender, object e)
        {


            if (sender.GetType().FullName.Contains("secCompaniesController"))
            {
                MyEventArgs<SFSdotNet.Framework.Web.Mvc.Models.UIModel<SFSdotNet.Framework.Security.Web.Mvc.Models.secCompanies.secCompanyModel>> eModel = (MyEventArgs<SFSdotNet.Framework.Web.Mvc.Models.UIModel<SFSdotNet.Framework.Security.Web.Mvc.Models.secCompanies.secCompanyModel>>)e;
                if (eModel.UIModel.ContextType == SFSdotNet.Framework.Web.Mvc.Models.UIModelContextTypes.DisplayForm)
                {
                 
                }
                if (IsEditOrDetailsForm(eModel.UIModel))
                {
                   
                  
                }

            }
        }
    }
}