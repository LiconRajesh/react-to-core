#pragma checksum "D:\Core_To_React_Api\Core_To_React_Api\src\Core_To_React_Api.Web\Pages\ProjectDetails\Incomplete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df9b15407a62863e5cd945a8d395fbb9f6471a76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_ProjectDetails_Incomplete), @"mvc.1.0.razor-page", @"/Pages/ProjectDetails/Incomplete.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df9b15407a62863e5cd945a8d395fbb9f6471a76", @"/Pages/ProjectDetails/Incomplete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ProjectDetails_Incomplete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Incomplete To Do Items (Razor Page)</h2>\r\n<ul>\r\n");
#nullable restore
#line 6 "D:\Core_To_React_Api\Core_To_React_Api\src\Core_To_React_Api.Web\Pages\ProjectDetails\Incomplete.cshtml"
     foreach (var item in Model.ToDoItems)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\r\n            ");
#nullable restore
#line 9 "D:\Core_To_React_Api\Core_To_React_Api\src\Core_To_React_Api.Web\Pages\ProjectDetails\Incomplete.cshtml"
       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 9 "D:\Core_To_React_Api\Core_To_React_Api\src\Core_To_React_Api.Web\Pages\ProjectDetails\Incomplete.cshtml"
                         if (item.IsDone)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span>DONE!</span>\r\n");
#nullable restore
#line 12 "D:\Core_To_React_Api\Core_To_React_Api\src\Core_To_React_Api.Web\Pages\ProjectDetails\Incomplete.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span>NOT DONE</span>\r\n");
#nullable restore
#line 16 "D:\Core_To_React_Api\Core_To_React_Api\src\Core_To_React_Api.Web\Pages\ProjectDetails\Incomplete.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <br />");
#nullable restore
#line 17 "D:\Core_To_React_Api\Core_To_React_Api\src\Core_To_React_Api.Web\Pages\ProjectDetails\Incomplete.cshtml"
             Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </li>\r\n");
#nullable restore
#line 19 "D:\Core_To_React_Api\Core_To_React_Api\src\Core_To_React_Api.Web\Pages\ProjectDetails\Incomplete.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Core_To_React_Api.Web.Pages.ToDoRazorPage.IncompleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Core_To_React_Api.Web.Pages.ToDoRazorPage.IncompleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Core_To_React_Api.Web.Pages.ToDoRazorPage.IncompleteModel>)PageContext?.ViewData;
        public Core_To_React_Api.Web.Pages.ToDoRazorPage.IncompleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
