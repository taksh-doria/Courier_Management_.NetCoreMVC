#pragma checksum "/Users/takshdoria/Desktop/Courier_Management_.NetCoreMVC/Courier_Management_System/Views/Employee/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e030edbb02832fe9af9c2c0902496bc67bcfcd7c"
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
#line 1 "/Users/takshdoria/Desktop/Courier_Management_.NetCoreMVC/Courier_Management_System/Views/_ViewImports.cshtml"
using Courier_Management_System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/takshdoria/Desktop/Courier_Management_.NetCoreMVC/Courier_Management_System/Views/_ViewImports.cshtml"
using Courier_Management_System.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/takshdoria/Desktop/Courier_Management_.NetCoreMVC/Courier_Management_System/Views/Employee/Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e030edbb02832fe9af9c2c0902496bc67bcfcd7c", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ef3885b965a82ff5e3873a9599ae1fc12e1fee7", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Courier_Management_System.Models.Employee>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/profile.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("align-content:center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Employee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "City", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Elist", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Consignment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateStatus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "/Users/takshdoria/Desktop/Courier_Management_.NetCoreMVC/Courier_Management_System/Views/Employee/Index.cshtml"
   ViewData["Title"] = "Index"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e030edbb02832fe9af9c2c0902496bc67bcfcd7c7979", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e030edbb02832fe9af9c2c0902496bc67bcfcd7c8239", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e030edbb02832fe9af9c2c0902496bc67bcfcd7c10094", async() => {
                WriteLiteral(@"
    <div class=""container"">
        <div class=""main-body"">
            <div class=""row gutters-sm"">
                <div class=""col-md-4 mb-3"">
                    <div class=""card"">
                        <div class=""card-body"">
                            <div class=""d-flex flex-column align-items-center text-center"">
                                <img src=""https://bootdey.com/img/Content/avatar/avatar7.png"" alt=""Admin"" class=""rounded-circle"" width=""150"">
                                <div class=""mt-3"">
                                    <h4></h4>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""card mt-3"">
                        <ul class=""list-group list-group-flush"">
");
#nullable restore
#line 28 "/Users/takshdoria/Desktop/Courier_Management_.NetCoreMVC/Courier_Management_System/Views/Employee/Index.cshtml"
                               if (HttpContextAccessor.HttpContext.Session.GetString("logged_in_user") != null)
                                            {
                                                if (HttpContextAccessor.HttpContext.Session.GetString("user_role") == "admin")
                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <li class=\"list-group-item d-flex justify-content-between align-items-center flex-wrap\">\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e030edbb02832fe9af9c2c0902496bc67bcfcd7c11919", async() => {
                    WriteLiteral("Add Employee");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                </li>\r\n                                                    <li class=\"list-group-item d-flex justify-content-between align-items-center flex-wrap\">\r\n                                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e030edbb02832fe9af9c2c0902496bc67bcfcd7c13756", async() => {
                    WriteLiteral("Add City");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                                    </li>
                                                                        <li class=""list-group-item d-flex justify-content-between align-items-center flex-wrap"">
                                                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e030edbb02832fe9af9c2c0902496bc67bcfcd7c15644", async() => {
                    WriteLiteral("Search Employee");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                                        </li> ");
#nullable restore
#line 40 "/Users/takshdoria/Desktop/Courier_Management_.NetCoreMVC/Courier_Management_System/Views/Employee/Index.cshtml"
                                                                              }
                                                                                        else
                                                                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                        <li class=\"list-group-item d-flex justify-content-between align-items-center flex-wrap\">\r\n                                                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e030edbb02832fe9af9c2c0902496bc67bcfcd7c18047", async() => {
                    WriteLiteral("Search Consignment");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_11.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                                        </li> ");
#nullable restore
#line 45 "/Users/takshdoria/Desktop/Courier_Management_.NetCoreMVC/Courier_Management_System/Views/Employee/Index.cshtml"
                                                                              }
                                                                                    } 

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <li class=""list-group-item d-flex justify-content-between align-items-center flex-wrap"">
                                <h6 class=""mb-0""><svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-instagram mr-2 icon-inline text-danger""><rect x=""2"" y=""2"" width=""20"" height=""20"" rx=""5"" ry=""5""></rect><path d=""M16 11.37A4 4 0 1 1 12.63 8 4 4 0 0 1 16 11.37z""></path><line x1=""17.5"" y1=""6.5"" x2=""17.51"" y2=""6.5""></line></svg>Instagram</h6>
                                <span class=""text-secondary"">bootdey</span>
                            </li>
                            <li class=""list-group-item d-flex justify-content-between align-items-center flex-wrap"">
                                <h6 class=""mb-0""><svg xmlns=""http://www.w3.org/2000/svg"" width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""2""");
                WriteLiteral(@" stroke-linecap=""round"" stroke-linejoin=""round"" class=""feather feather-facebook mr-2 icon-inline text-primary""><path d=""M18 2h-3a5 5 0 0 0-5 5v3H7v4h3v8h4v-8h3l1-4h-4V7a1 1 0 0 1 1-1h3z""></path></svg>Facebook</h6>
                                <span class=""text-secondary"">bootdey</span>
                            </li>
                        </ul>
                    </div>
                </div>
                <div class=""col-md-8"">
                    <div class=""card mb-3"">
                        <div class=""card-body"">
                            <div class=""row"">
                                <div class=""col-sm-3"">
                                    <h6 class=""mb-0"">Full Name</h6>
                                </div>
                                <div class=""col-sm-9 text-secondary"">
                                    ");
#nullable restore
#line 66 "/Users/takshdoria/Desktop/Courier_Management_.NetCoreMVC/Courier_Management_System/Views/Employee/Index.cshtml"
                               Write(Model.emp_name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </div>
                            </div>
                            <hr>
                            <div class=""row"">
                                <div class=""col-sm-3"">
                                    <h6 class=""mb-0"">Email</h6>
                                </div>
                                <div class=""col-sm-9 text-secondary"">
                                    ");
#nullable restore
#line 75 "/Users/takshdoria/Desktop/Courier_Management_.NetCoreMVC/Courier_Management_System/Views/Employee/Index.cshtml"
                               Write(Model.emp_email);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </div>
                            </div>
                            <hr>
                            <div class=""row"">
                                <div class=""col-sm-3"">
                                    <h6 class=""mb-0"">Role</h6>
                                </div>
                                <div class=""col-sm-9 text-secondary"">
                                    ");
#nullable restore
#line 84 "/Users/takshdoria/Desktop/Courier_Management_.NetCoreMVC/Courier_Management_System/Views/Employee/Index.cshtml"
                               Write(Model.emp_role);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </div>
                            </div>
                            <hr>
                            <div class=""row"">
                                <div class=""col-sm-3"">
                                    <h6 class=""mb-0"">City</h6>
                                </div>
                                <div class=""col-sm-9 text-secondary"">
                                    ");
#nullable restore
#line 93 "/Users/takshdoria/Desktop/Courier_Management_.NetCoreMVC/Courier_Management_System/Views/Employee/Index.cshtml"
                               Write(Model.emp_city);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""row gutters-sm"">
                        <div class=""col-sm-6 mb-3"">
                            <div class=""card h-100"">
                                <div class=""card-body"">
                                    <h6 class=""d-flex align-items-center mb-3""><i class=""material-icons text-info mr-2"">assignment</i>Project Status</h6>
                                    <small>Web Design</small>
                                    <div class=""progress mb-3"" style=""height: 5px"">
                                        <div class=""progress-bar bg-primary"" role=""progressbar"" style=""width: 80%"" aria-valuenow=""80"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                    </div>
                                    <small>Website Markup</small>
                                    <div class=""progress mb-3"" style=""height: ");
                WriteLiteral(@"5px"">
                                        <div class=""progress-bar bg-primary"" role=""progressbar"" style=""width: 72%"" aria-valuenow=""72"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                    </div>
                                    <small>One Page</small>
                                    <div class=""progress mb-3"" style=""height: 5px"">
                                        <div class=""progress-bar bg-primary"" role=""progressbar"" style=""width: 89%"" aria-valuenow=""89"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                    </div>
                                    <small>Mobile Template</small>
                                    <div class=""progress mb-3"" style=""height: 5px"">
                                        <div class=""progress-bar bg-primary"" role=""progressbar"" style=""width: 55%"" aria-valuenow=""55"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                    </div>
                                    <small>Bac");
                WriteLiteral(@"kend API</small>
                                    <div class=""progress mb-3"" style=""height: 5px"">
                                        <div class=""progress-bar bg-primary"" role=""progressbar"" style=""width: 66%"" aria-valuenow=""66"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-6 mb-3"">
                            <div class=""card h-100"">
                                <div class=""card-body"">
                                    <h6 class=""d-flex align-items-center mb-3""><i class=""material-icons text-info mr-2"">assignment</i>Project Status</h6>
                                    <small>Web Design</small>
                                    <div class=""progress mb-3"" style=""height: 5px"">
                                        <div class=""progress-bar bg-primary"" role=""progressbar"" style=""width: 80%"" aria-va");
                WriteLiteral(@"luenow=""80"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                    </div>
                                    <small>Website Markup</small>
                                    <div class=""progress mb-3"" style=""height: 5px"">
                                        <div class=""progress-bar bg-primary"" role=""progressbar"" style=""width: 72%"" aria-valuenow=""72"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                    </div>
                                    <small>One Page</small>
                                    <div class=""progress mb-3"" style=""height: 5px"">
                                        <div class=""progress-bar bg-primary"" role=""progressbar"" style=""width: 89%"" aria-valuenow=""89"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                    </div>
                                    <small>Mobile Template</small>
                                    <div class=""progress mb-3"" style=""height: 5px"">
                       ");
                WriteLiteral(@"                 <div class=""progress-bar bg-primary"" role=""progressbar"" style=""width: 55%"" aria-valuenow=""55"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                    </div>
                                    <small>Backend API</small>
                                    <div class=""progress mb-3"" style=""height: 5px"">
                                        <div class=""progress-bar bg-primary"" role=""progressbar"" style=""width: 66%"" aria-valuenow=""66"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
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
            WriteLiteral("\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Courier_Management_System.Models.Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591
