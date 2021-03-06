#pragma checksum "D:\Project\HomeTask\HomeProject\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35e8700c46dbc76dc282d0adb6e0f480c4381df9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35e8700c46dbc76dc282d0adb6e0f480c4381df9", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13ce7d51c2d5f315f472cb814c8b71fdde104920", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HomeProject.Models.Employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n   \r\n\r\n<div>\r\n\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                ");
#nullable restore
#line 9 "D:\Project\HomeTask\HomeProject\Views\Employee\Index.cshtml"
           Write(Html.ActionLink("Новый сотрудник","InsertEmployee", "Employee",null, new {@class="btn btn-success", @style= "background-color: #8dc63f" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

            </div>
        </div>
        <div class=""container"" style=""padding-top: 2%"">
            <div class=""row""></div>
            <div>
                <table class=""table table-hover"">
                    <thead style=""font-weight: 400; text-align: center"">
                    <tr>
                        <th scope=""col"">Должность</th>
                        <th scope=""col"">Имя</th>
                        <th scope=""col"">Фамилия</th>
                        <th scope=""col"">Телефон</th>
                        <th scope=""col"">Дата рождения</th>
                        <td scope=""col""></td>
                    </tr>
                    </thead>
                    <tbody style=""text-align: center"">
");
#nullable restore
#line 28 "D:\Project\HomeTask\HomeProject\Views\Employee\Index.cshtml"
                         foreach (var item in Model)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n\r\n                                <td>");
#nullable restore
#line 33 "D:\Project\HomeTask\HomeProject\Views\Employee\Index.cshtml"
                               Write(Html.DisplayFor(Modelitem => item.DepartmentName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 34 "D:\Project\HomeTask\HomeProject\Views\Employee\Index.cshtml"
                               Write(Html.DisplayFor(Modelitem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 35 "D:\Project\HomeTask\HomeProject\Views\Employee\Index.cshtml"
                               Write(Html.DisplayFor(Modelitem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 36 "D:\Project\HomeTask\HomeProject\Views\Employee\Index.cshtml"
                               Write(Html.DisplayFor(Modelitem => item.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 37 "D:\Project\HomeTask\HomeProject\Views\Employee\Index.cshtml"
                               Write(Html.DisplayFor(Modelitem => item.DateBirth));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    <div>\r\n                                        ");
#nullable restore
#line 40 "D:\Project\HomeTask\HomeProject\Views\Employee\Index.cshtml"
                                   Write(Html.ActionLink("редактировать", "DetalisEmployee",
                                            "Employee", new { item.Id }, new {@style = "color: green"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" | \r\n                                        ");
#nullable restore
#line 42 "D:\Project\HomeTask\HomeProject\Views\Employee\Index.cshtml"
                                   Write(Html.ActionLink("удалить", "DeleteEmployee",
                                            "Employee", new { item.Id }, new {@style = "color: red" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                                    </div>\r\n                                </td>\r\n");
            WriteLiteral("\r\n                        </tr>\r\n");
#nullable restore
#line 51 "D:\Project\HomeTask\HomeProject\Views\Employee\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n\r\n                </table>\r\n            </div>\r\n\r\n\r\n        </div>\r\n\r\n    }\r\n\r\n\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HomeProject.Models.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
