#pragma checksum "C:\Users\Cameron\source\repos\TaskList\TaskList\Views\Tasks\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "118b727dc0275db75f2af7949e51eecb605f7d21"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tasks_Index), @"mvc.1.0.view", @"/Views/Tasks/Index.cshtml")]
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
#line 1 "C:\Users\Cameron\source\repos\TaskList\TaskList\Views\_ViewImports.cshtml"
using TaskList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Cameron\source\repos\TaskList\TaskList\Views\_ViewImports.cshtml"
using TaskList.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"118b727dc0275db75f2af7949e51eecb605f7d21", @"/Views/Tasks/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e64bae3a82f6254846285d1263518312fd27751c", @"/Views/_ViewImports.cshtml")]
    public class Views_Tasks_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Tasks>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Cameron\source\repos\TaskList\TaskList\Views\Tasks\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<h1>Index</h1>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Task Name</th>\r\n        <th>Due Date</th>\r\n        <th>Completed?</th>\r\n    </tr>\r\n");
#nullable restore
#line 15 "C:\Users\Cameron\source\repos\TaskList\TaskList\Views\Tasks\Index.cshtml"
     foreach (Tasks task in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 18 "C:\Users\Cameron\source\repos\TaskList\TaskList\Views\Tasks\Index.cshtml"
           Write(task.TaskName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 19 "C:\Users\Cameron\source\repos\TaskList\TaskList\Views\Tasks\Index.cshtml"
           Write(task.DueDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\Cameron\source\repos\TaskList\TaskList\Views\Tasks\Index.cshtml"
           Write(task.Completed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 417, "\"", 457, 2);
            WriteAttributeValue("", 424, "../Tasks/ChangeStatus?id=", 424, 25, true);
#nullable restore
#line 21 "C:\Users\Cameron\source\repos\TaskList\TaskList\Views\Tasks\Index.cshtml"
WriteAttributeValue("", 449, task.Id, 449, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Change Completeion Status!</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 538, "\"", 576, 2);
            WriteAttributeValue("", 545, "../Tasks/DeleteTask?id=", 545, 23, true);
#nullable restore
#line 22 "C:\Users\Cameron\source\repos\TaskList\TaskList\Views\Tasks\Index.cshtml"
WriteAttributeValue("", 568, task.Id, 568, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete Task!</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 24 "C:\Users\Cameron\source\repos\TaskList\TaskList\Views\Tasks\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n<br />\r\n<a href=\"../Tasks/AddTask\" class=\"btn btn-success\">Add a Task!</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Tasks>> Html { get; private set; }
    }
}
#pragma warning restore 1591