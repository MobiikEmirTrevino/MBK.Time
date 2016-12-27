using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcSiteMapProvider;
using MBK.Time.Web.Mvc.Resources;
using System.Web.Mvc;
using MBK.Time.BusinessObjects;

namespace MBK.Time.Web.Mvc
{
    public partial class DynamicNodeProvider
    {

        SFSdotNet.Framework.Globalization.TextUI textUI = new SFSdotNet.Framework.Globalization.TextUI("MBKTime", null);
 
        partial void OnCreatingNodes(object sender, ref List<DynamicNode> nodes)
        {




        }

        partial void OnCreatedNodes(object sender, ref List<DynamicNode> nodes)
        {
            




        }
    }
}
