#pragma checksum "C:\Users\HoboPrime\Desktop\GCTechnicalChallenge\GCTechnicalChallenge\GCTechnicalChallenge\Views\TaskList\SearchTasks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6743b343b70470cf1dfd1e113353815f220a4fca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TaskList_SearchTasks), @"mvc.1.0.view", @"/Views/TaskList/SearchTasks.cshtml")]
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
#line 1 "C:\Users\HoboPrime\Desktop\GCTechnicalChallenge\GCTechnicalChallenge\GCTechnicalChallenge\Views\_ViewImports.cshtml"
using GCTechnicalChallenge;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HoboPrime\Desktop\GCTechnicalChallenge\GCTechnicalChallenge\GCTechnicalChallenge\Views\_ViewImports.cshtml"
using GCTechnicalChallenge.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6743b343b70470cf1dfd1e113353815f220a4fca", @"/Views/TaskList/SearchTasks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58ed5faa246972df70bf116091f1d178c61a16ae", @"/Views/_ViewImports.cshtml")]
    public class Views_TaskList_SearchTasks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Tasks>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\HoboPrime\Desktop\GCTechnicalChallenge\GCTechnicalChallenge\GCTechnicalChallenge\Views\TaskList\SearchTasks.cshtml"
  
    ViewData["Title"] = "Search Tasks";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\HoboPrime\Desktop\GCTechnicalChallenge\GCTechnicalChallenge\GCTechnicalChallenge\Views\TaskList\SearchTasks.cshtml"
 if (Model.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Tasks matching: \"");
#nullable restore
#line 9 "C:\Users\HoboPrime\Desktop\GCTechnicalChallenge\GCTechnicalChallenge\GCTechnicalChallenge\Views\TaskList\SearchTasks.cshtml"
                    Write(ViewBag.Query);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"</h1>\r\n");
#nullable restore
#line 11 "C:\Users\HoboPrime\Desktop\GCTechnicalChallenge\GCTechnicalChallenge\GCTechnicalChallenge\Views\TaskList\SearchTasks.cshtml"
Write(await Html.PartialAsync("_SearchTasks"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\HoboPrime\Desktop\GCTechnicalChallenge\GCTechnicalChallenge\GCTechnicalChallenge\Views\TaskList\SearchTasks.cshtml"
Write(await Html.PartialAsync("_TaskTable", Model));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\HoboPrime\Desktop\GCTechnicalChallenge\GCTechnicalChallenge\GCTechnicalChallenge\Views\TaskList\SearchTasks.cshtml"
                                                 
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>No tasks matching \"");
#nullable restore
#line 16 "C:\Users\HoboPrime\Desktop\GCTechnicalChallenge\GCTechnicalChallenge\GCTechnicalChallenge\Views\TaskList\SearchTasks.cshtml"
                      Write(ViewBag.Query);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"</h2>\r\n");
#nullable restore
#line 18 "C:\Users\HoboPrime\Desktop\GCTechnicalChallenge\GCTechnicalChallenge\GCTechnicalChallenge\Views\TaskList\SearchTasks.cshtml"
Write(await Html.PartialAsync("_SearchTasks"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\HoboPrime\Desktop\GCTechnicalChallenge\GCTechnicalChallenge\GCTechnicalChallenge\Views\TaskList\SearchTasks.cshtml"
                                            
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 21 "C:\Users\HoboPrime\Desktop\GCTechnicalChallenge\GCTechnicalChallenge\GCTechnicalChallenge\Views\TaskList\SearchTasks.cshtml"
Write(await Html.PartialAsync("_AddTask"));

#line default
#line hidden
#nullable disable
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
