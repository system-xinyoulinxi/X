﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 1 "..\..\Views\Shared\_List_Toolbar.cshtml"
    using NewLife;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    
    #line 2 "..\..\Views\Shared\_List_Toolbar.cshtml"
    using NewLife.Web;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Shared\_List_Toolbar.cshtml"
    using XCode;
    
    #line default
    #line hidden
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_List_Toolbar.cshtml")]
    public partial class _Views_Shared__List_Toolbar_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__List_Toolbar_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 4 "..\..\Views\Shared\_List_Toolbar.cshtml"
  
    var fact = ViewBag.Factory as IEntityOperate;
    var page = ViewBag.Page as Pager;
    var user = ViewBag.User as IUser ?? User.Identity as IUser;

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"tableTools-container\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"form-inline\"");

WriteLiteral(">\r\n        <form");

WriteAttribute("action", Tuple.Create(" action=\"", 295), Tuple.Create("\"", 375)
            
            #line 11 "..\..\Views\Shared\_List_Toolbar.cshtml"
, Tuple.Create(Tuple.Create("", 304), Tuple.Create<System.Object, System.Int32>(Url.Action("index")
            
            #line default
            #line hidden
, 304), false)
            
            #line 11 "..\..\Views\Shared\_List_Toolbar.cshtml"
, Tuple.Create(Tuple.Create("", 324), Tuple.Create<System.Object, System.Int32>(Html.Raw("?" + page.GetBaseUrl(false, true, true))
            
            #line default
            #line hidden
, 324), false)
);

WriteLiteral(" method=\"post\"");

WriteLiteral(" role=\"form\"");

WriteLiteral(">\r\n");

            
            #line 12 "..\..\Views\Shared\_List_Toolbar.cshtml"
            
            
            #line default
            #line hidden
            
            #line 12 "..\..\Views\Shared\_List_Toolbar.cshtml"
             if (user.Has(PermissionFlags.Insert))
            {
                
            
            #line default
            #line hidden
            
            #line 14 "..\..\Views\Shared\_List_Toolbar.cshtml"
           Write(Html.ActionLink("添加" + ViewContext.Controller.GetType().GetDisplayName(), "Add", null, new { @class = "btn btn-success btn-sm" }));

            
            #line default
            #line hidden
            
            #line 14 "..\..\Views\Shared\_List_Toolbar.cshtml"
                                                                                                                                                  
            }

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"pull-right form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 17 "..\..\Views\Shared\_List_Toolbar.cshtml"
           Write(Html.Partial("_List_Search"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 18 "..\..\Views\Shared\_List_Toolbar.cshtml"
           Write(Html.Partial("_List_Toolbar_Search"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 19 "..\..\Views\Shared\_List_Toolbar.cshtml"
           Write(Html.Partial("_List_Toolbar_Adv"));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n        </form>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
