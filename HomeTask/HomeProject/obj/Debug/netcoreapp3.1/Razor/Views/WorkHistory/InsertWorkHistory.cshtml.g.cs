#pragma checksum "D:\Project\HomeTask\HomeProject\Views\WorkHistory\InsertWorkHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58375787d2af12ee87ee29ff58c699bf5fcfe215"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WorkHistory_InsertWorkHistory), @"mvc.1.0.view", @"/Views/WorkHistory/InsertWorkHistory.cshtml")]
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
#line 1 "D:\Project\HomeTask\HomeProject\Views\_ViewImports.cshtml"
using System.Xml.Serialization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Project\HomeTask\HomeProject\Views\_ViewImports.cshtml"
using HomeProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Project\HomeTask\HomeProject\Views\_ViewImports.cshtml"
using HomeProject.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Project\HomeTask\HomeProject\Views\_ViewImports.cshtml"
using HomeProject.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58375787d2af12ee87ee29ff58c699bf5fcfe215", @"/Views/WorkHistory/InsertWorkHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13ce7d51c2d5f315f472cb814c8b71fdde104920", @"/Views/_ViewImports.cshtml")]
    public class Views_WorkHistory_InsertWorkHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeProject.Models.WorkHistory>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"container\">\r\n");
#nullable restore
#line 3 "D:\Project\HomeTask\HomeProject\Views\WorkHistory\InsertWorkHistory.cshtml"
     using (Html.BeginForm("InsertWorkHistory", "WorkHistory", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""py-3"">
            <div class=""container"">
                <div class=""col-3 g-2""> </div>
                <div class=""row gx-5"">
                    <div class=""col-md-12 p-4"">
                        <h3 class=""mb-3"" style=""text-align: center"">Место работы в прошлом<br></h3>
                        <div class=""row gy-5"">
                            <div class=""col-12"">
                                <div class=""p-3 border bg-light"">
                                    ");
#nullable restore
#line 14 "D:\Project\HomeTask\HomeProject\Views\WorkHistory\InsertWorkHistory.cshtml"
                               Write(Html.TextBoxFor(x => x.WorkName, new { @placeholder = "Работа", @type = "text", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <div style=\"color: red\">\r\n                                        ");
#nullable restore
#line 16 "D:\Project\HomeTask\HomeProject\Views\WorkHistory\InsertWorkHistory.cshtml"
                                   Write(Html.ValidationMessageFor(x => x.WorkName));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </div>

                                </div>
                            </div>
                            <div class=""col-6"">
                                <div class=""p-3 border justify-content-center"">
                                    <div class=""p-0 justify-content-center"">Начало работы </div>

                                    ");
#nullable restore
#line 25 "D:\Project\HomeTask\HomeProject\Views\WorkHistory\InsertWorkHistory.cshtml"
                               Write(Html.TextBoxFor(x => x.StartDate, "{0:dd.MM.yyyy}", new
                                    {
                                        //@style = "text-align: left",
                                        onClick = "xCal(this, { lang: 'ru', order: 0 })",
                                        onmouseenter = "xCal(this, { lang: 'ru', order: 0 })",
                                        // onKeyUp = "xCal()",
                                        value = ""
                                    }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


                                </div>
                            </div>
                            <div class=""col-6"">
                                <div class=""p-3 border bg-light r"">
                                    <div class=""p-0"">Конец работы ");
#nullable restore
#line 39 "D:\Project\HomeTask\HomeProject\Views\WorkHistory\InsertWorkHistory.cshtml"
                                                             Write(ViewBag.EmployeeID);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n                                    ");
#nullable restore
#line 40 "D:\Project\HomeTask\HomeProject\Views\WorkHistory\InsertWorkHistory.cshtml"
                               Write(Html.TextBoxFor(x => x.EndDate, "{0:dd.MM.yyyy}", new
                                    {
                                        //@style = "text-align: left",
                                        onClick = "xCal(this, { lang: 'ru', order: 0 })",
                                        onmouseenter = "xCal(this, { lang: 'ru', order: 0 })",
                                        // onKeyUp = "xCal()",
                                        value = ""
                                    }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


                                </div>
                            </div>


                            <div class=""col-6"">
                                <div class=""p-3 border bg-light"">

                                    <button type=""submit"" class=""btn btn-primary col-12"">Сохранить</button>
                                </div>
                            </div>
                            <div class=""col-6"">
                                <div class=""p-3 border bg-light"">

                                    ");
#nullable restore
#line 63 "D:\Project\HomeTask\HomeProject\Views\WorkHistory\InsertWorkHistory.cshtml"
                               Write(Html.ActionLink("Отмена", "DetalisEmployee", "Employee", new {id = @ViewBag.EmployeeID }, new { @class = "btn btn-primary col-12" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                </div>\r\n                            </div>\r\n\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n           \r\n        </div>\r\n");
#nullable restore
#line 74 "D:\Project\HomeTask\HomeProject\Views\WorkHistory\InsertWorkHistory.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeProject.Models.WorkHistory> Html { get; private set; }
    }
}
#pragma warning restore 1591
