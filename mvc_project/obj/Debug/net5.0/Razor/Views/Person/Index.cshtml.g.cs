#pragma checksum "C:\Users\betul\Desktop\asp.netcore\mvc_project\mvc_project\Views\Person\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b7a49297e646a92874b1199f73b5b1207ab59c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Person_Index), @"mvc.1.0.view", @"/Views/Person/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\betul\Desktop\asp.netcore\mvc_project\mvc_project\Views\_ViewImports.cshtml"
using mvc_project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\betul\Desktop\asp.netcore\mvc_project\mvc_project\Views\Person\Index.cshtml"
using mvc_project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b7a49297e646a92874b1199f73b5b1207ab59c9", @"/Views/Person/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1291e31b91ce9ef81dab6f2331e836eaf1ff193a", @"/Views/_ViewImports.cshtml")]
    public class Views_Person_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Person>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\betul\Desktop\asp.netcore\mvc_project\mvc_project\Views\Person\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_TestLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table table-bordered"">
    <tr>
        <th>Id</th>
        <th>Name</th>
        <th>Surname</th>
        <th>City</th>
        <th>departmentId</th>
        <th>Delete</th>
        <th>Update</th>
        <th>Details</th>
    </tr>

");
#nullable restore
#line 20 "C:\Users\betul\Desktop\asp.netcore\mvc_project\mvc_project\Views\Person\Index.cshtml"
     foreach (var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\betul\Desktop\asp.netcore\mvc_project\mvc_project\Views\Person\Index.cshtml"
           Write(x.PersonId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\betul\Desktop\asp.netcore\mvc_project\mvc_project\Views\Person\Index.cshtml"
           Write(x.PersonName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\betul\Desktop\asp.netcore\mvc_project\mvc_project\Views\Person\Index.cshtml"
           Write(x.PersonSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\betul\Desktop\asp.netcore\mvc_project\mvc_project\Views\Person\Index.cshtml"
           Write(x.PersonCity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\betul\Desktop\asp.netcore\mvc_project\mvc_project\Views\Person\Index.cshtml"
           Write(x.Department.DepartmentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <th><a");
            BeginWriteAttribute("href", " href=\"", 669, "\"", 708, 2);
            WriteAttributeValue("", 676, "/Person/DeletePerson/", 676, 21, true);
#nullable restore
#line 28 "C:\Users\betul\Desktop\asp.netcore\mvc_project\mvc_project\Views\Person\Index.cshtml"
WriteAttributeValue("", 697, x.PersonId, 697, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a></th>\r\n            <th><a");
            BeginWriteAttribute("href", " href=\"", 768, "\"", 804, 2);
            WriteAttributeValue("", 775, "/Person/GetPerson/", 775, 18, true);
#nullable restore
#line 29 "C:\Users\betul\Desktop\asp.netcore\mvc_project\mvc_project\Views\Person\Index.cshtml"
WriteAttributeValue("", 793, x.PersonId, 793, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Update</a></th>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 32 "C:\Users\betul\Desktop\asp.netcore\mvc_project\mvc_project\Views\Person\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Person/NewPerson/\" class=\"btn btn-primary\">new Person</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Person>> Html { get; private set; }
    }
}
#pragma warning restore 1591
