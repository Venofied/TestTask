#pragma checksum "C:\Users\Venofied\source\repos\TestTask\TestTask\TestTask\Views\Employee\IndexDepartment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "343c4017650d2a5439778324e668a94baab3a420"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_IndexDepartment), @"mvc.1.0.view", @"/Views/Employee/IndexDepartment.cshtml")]
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
#line 1 "C:\Users\Venofied\source\repos\TestTask\TestTask\TestTask\Views\Employee\IndexDepartment.cshtml"
using TestTask.models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"343c4017650d2a5439778324e668a94baab3a420", @"/Views/Employee/IndexDepartment.cshtml")]
    public class Views_Employee_IndexDepartment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Employee>>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Venofied\source\repos\TestTask\TestTask\TestTask\Views\Employee\IndexDepartment.cshtml"
  
    ViewData["Title"] = "IndexDepartment";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "343c4017650d2a5439778324e668a94baab3a4203225", async() => {
                WriteLiteral("\r\n    <title>Сотрудники отдела ");
#nullable restore
#line 11 "C:\Users\Venofied\source\repos\TestTask\TestTask\TestTask\Views\Employee\IndexDepartment.cshtml"
                        Write(ViewBag.nameDepartment);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "343c4017650d2a5439778324e668a94baab3a4204500", async() => {
                WriteLiteral("\r\n    <h2>Сотрудники</h2>\r\n    <h2>Средння заработная плата ");
#nullable restore
#line 15 "C:\Users\Venofied\source\repos\TestTask\TestTask\TestTask\Views\Employee\IndexDepartment.cshtml"
                            Write(ViewBag.middleSalary);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n    <p>\r\n        ");
#nullable restore
#line 17 "C:\Users\Venofied\source\repos\TestTask\TestTask\TestTask\Views\Employee\IndexDepartment.cshtml"
   Write(Html.ActionLink("Добавить сотрудника", "Create"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    </p>
    <table class=""table"">
        <style type=""text/css"">
            .table {
                border: 1px solid #eee;
                table-layout: fixed;
                width: 100%;
                margin-bottom: 20px;
            }

                .table th {
                    font-weight: bold;
                    padding: 5px;
                    background: #efefef;
                    border: 1px solid #dddddd;
                }

                .table td {
                    padding: 5px 10px;
                    border: 1px solid #eee;
                    text-align: left;
                }

                .table tbody tr:nth-child(odd) {
                    background: #fff;
                }

                .table tbody tr:nth-child(even) {
                    background: #F7F7F7;
                }
        </style>
        <thead>
            <tr>
                <th>ID</th>
                <th>ФИО</th>
                <th>Зарплата</th>
        ");
                WriteLiteral("        <th>Отдел</th>\r\n                <th></th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 60 "C:\Users\Venofied\source\repos\TestTask\TestTask\TestTask\Views\Employee\IndexDepartment.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 64 "C:\Users\Venofied\source\repos\TestTask\TestTask\TestTask\Views\Employee\IndexDepartment.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 67 "C:\Users\Venofied\source\repos\TestTask\TestTask\TestTask\Views\Employee\IndexDepartment.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 70 "C:\Users\Venofied\source\repos\TestTask\TestTask\TestTask\Views\Employee\IndexDepartment.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Salary));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 73 "C:\Users\Venofied\source\repos\TestTask\TestTask\TestTask\Views\Employee\IndexDepartment.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name_department));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 76 "C:\Users\Venofied\source\repos\TestTask\TestTask\TestTask\Views\Employee\IndexDepartment.cshtml"
                   Write(Html.ActionLink("Редактировать", "Edit", "Employee", new { id = @item.ID, IdEmp = @item.ID }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <form method=\"post\" action=\"Index\">\r\n                            <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=", 2413, "", 2428, 1);
#nullable restore
#line 80 "C:\Users\Venofied\source\repos\TestTask\TestTask\TestTask\Views\Employee\IndexDepartment.cshtml"
WriteAttributeValue("", 2420, item.ID, 2420, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n                            <input type=\"submit\" value=\"Удалить\" />\r\n                        </form>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 85 "C:\Users\Venofied\source\repos\TestTask\TestTask\TestTask\Views\Employee\IndexDepartment.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n    <p>\r\n        ");
#nullable restore
#line 89 "C:\Users\Venofied\source\repos\TestTask\TestTask\TestTask\Views\Employee\IndexDepartment.cshtml"
   Write(Html.ActionLink("Отделы", "Index", "Department"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </p>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
