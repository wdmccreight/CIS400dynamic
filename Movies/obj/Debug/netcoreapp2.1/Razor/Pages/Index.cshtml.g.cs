#pragma checksum "C:\Users\William\Source\Repos\movie-site\Movies\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a8658b3482f42e433917128053222486904b37f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Movies.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(Movies.Pages.Pages_Index), null)]
namespace Movies.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\William\Source\Repos\movie-site\Movies\Pages\_ViewImports.cshtml"
using Movies;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a8658b3482f42e433917128053222486904b37f", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e43305f2e50e86c75c86aaa9ccf4ae196e962e7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("movie-database"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\William\Source\Repos\movie-site\Movies\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(71, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(73, 2193, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da209ae09ec5494988293988d91323d1", async() => {
                BeginContext(99, 72, true);
                WriteLiteral("\r\n\r\n    <div id=\"search\">\r\n        <input type=\"text\" name=\"SearchTerms\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 171, "\"", 197, 1);
#line 10 "C:\Users\William\Source\Repos\movie-site\Movies\Pages\Index.cshtml"
WriteAttributeValue("", 179, Model.SearchTerms, 179, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(198, 121, true);
                WriteLiteral(" />\r\n        <input type=\"submit\" value=\"Search\">\r\n    </div>\r\n\r\n    <div id=\"filters\">\r\n\r\n        <h4>MPAA Rating</h4>\r\n");
                EndContext();
#line 17 "C:\Users\William\Source\Repos\movie-site\Movies\Pages\Index.cshtml"
         foreach (String rating in MovieDatabase.MPAARating)
        {

#line default
#line hidden
                BeginContext(392, 78, true);
                WriteLiteral("            <label>\r\n                <input type=\"checkbox\" name=\"MPAARatings\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 470, "\"", 485, 1);
#line 20 "C:\Users\William\Source\Repos\movie-site\Movies\Pages\Index.cshtml"
WriteAttributeValue("", 478, rating, 478, 7, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("checked", " checked=\"", 486, "\"", 531, 1);
#line 20 "C:\Users\William\Source\Repos\movie-site\Movies\Pages\Index.cshtml"
WriteAttributeValue("", 496, Model.MPAARatings.Contains(rating), 496, 35, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(532, 21, true);
                WriteLiteral(" />\r\n                ");
                EndContext();
                BeginContext(554, 6, false);
#line 21 "C:\Users\William\Source\Repos\movie-site\Movies\Pages\Index.cshtml"
           Write(rating);

#line default
#line hidden
                EndContext();
                BeginContext(560, 24, true);
                WriteLiteral("\r\n            </label>\r\n");
                EndContext();
#line 23 "C:\Users\William\Source\Repos\movie-site\Movies\Pages\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(595, 26, true);
                WriteLiteral("\r\n        <h4>Genre</h4>\r\n");
                EndContext();
#line 26 "C:\Users\William\Source\Repos\movie-site\Movies\Pages\Index.cshtml"
         foreach (String genre in MovieDatabase.Genres)
        {

#line default
#line hidden
                BeginContext(689, 73, true);
                WriteLiteral("            <label>\r\n                <input type=\"checkbox\" name=\"Genres\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 762, "\"", 776, 1);
#line 29 "C:\Users\William\Source\Repos\movie-site\Movies\Pages\Index.cshtml"
WriteAttributeValue("", 770, genre, 770, 6, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(777, 21, true);
                WriteLiteral(" />\r\n                ");
                EndContext();
                BeginContext(799, 5, false);
#line 30 "C:\Users\William\Source\Repos\movie-site\Movies\Pages\Index.cshtml"
           Write(genre);

#line default
#line hidden
                EndContext();
                BeginContext(804, 24, true);
                WriteLiteral("\r\n            </label>\r\n");
                EndContext();
#line 32 "C:\Users\William\Source\Repos\movie-site\Movies\Pages\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(839, 404, true);
                WriteLiteral(@"
        <h4>IMDB Rating</h4>
        <div>
            Between
            <input name=""IMDBMin"" type=""number"" min=""0"" max=""10"" step=""0.1"" placeholder=""min"" />
            and
            <input name=""IMDBMax"" type=""number"" min=""0"" max=""10"" step=""0.1"" placeholder=""min"" />
        </div>

    </div>

    <div id=""results"">
        <h1>Movie Results</h1>

        <ul class=""movie-list"">
");
                EndContext();
#line 48 "C:\Users\William\Source\Repos\movie-site\Movies\Pages\Index.cshtml"
             foreach (Movie movie in @Model.Movies)
            {

#line default
#line hidden
                BeginContext(1311, 107, true);
                WriteLiteral("                <li>\r\n                    <div class=\"details\">\r\n                        <h3 class=\"title\">");
                EndContext();
                BeginContext(1419, 11, false);
#line 52 "C:\Users\William\Source\Repos\movie-site\Movies\Pages\Index.cshtml"
                                     Write(movie.Title);

#line default
#line hidden
                EndContext();
                BeginContext(1430, 49, true);
                WriteLiteral("</h3>\r\n                        <div class=\"mpaa\">");
                EndContext();
                BeginContext(1480, 16, false);
#line 53 "C:\Users\William\Source\Repos\movie-site\Movies\Pages\Index.cshtml"
                                     Write(movie.MPAARating);

#line default
#line hidden
                EndContext();
                BeginContext(1496, 51, true);
                WriteLiteral("</div>\r\n                        <div class=\"genre\">");
                EndContext();
                BeginContext(1548, 16, false);
#line 54 "C:\Users\William\Source\Repos\movie-site\Movies\Pages\Index.cshtml"
                                      Write(movie.MajorGenre);

#line default
#line hidden
                EndContext();
                BeginContext(1564, 79, true);
                WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"ratings\">\r\n");
                EndContext();
#line 57 "C:\Users\William\Source\Repos\movie-site\Movies\Pages\Index.cshtml"
                         if (movie.IMDBRating != null)
                        {

#line default
#line hidden
                BeginContext(1726, 80, true);
                WriteLiteral("                            <div class=\"imdb\">\r\n                                ");
                EndContext();
                BeginContext(1807, 16, false);
#line 60 "C:\Users\William\Source\Repos\movie-site\Movies\Pages\Index.cshtml"
                           Write(movie.IMDBRating);

#line default
#line hidden
                EndContext();
                BeginContext(1823, 38, true);
                WriteLiteral("\r\n                            </div>\r\n");
                EndContext();
#line 62 "C:\Users\William\Source\Repos\movie-site\Movies\Pages\Index.cshtml"
                        }

#line default
#line hidden
                BeginContext(1888, 24, true);
                WriteLiteral("                        ");
                EndContext();
#line 63 "C:\Users\William\Source\Repos\movie-site\Movies\Pages\Index.cshtml"
                         if (movie.RottenTomatoesRating != null)
                        {

#line default
#line hidden
                BeginContext(1981, 91, true);
                WriteLiteral("                            <div class=\"rotten-tomatoes\">\r\n                                ");
                EndContext();
                BeginContext(2073, 26, false);
#line 66 "C:\Users\William\Source\Repos\movie-site\Movies\Pages\Index.cshtml"
                           Write(movie.RottenTomatoesRating);

#line default
#line hidden
                EndContext();
                BeginContext(2099, 38, true);
                WriteLiteral("\r\n                            </div>\r\n");
                EndContext();
#line 68 "C:\Users\William\Source\Repos\movie-site\Movies\Pages\Index.cshtml"
                        }

#line default
#line hidden
                BeginContext(2164, 51, true);
                WriteLiteral("                    </div>\r\n                </li>\r\n");
                EndContext();
#line 71 "C:\Users\William\Source\Repos\movie-site\Movies\Pages\Index.cshtml"
            }

#line default
#line hidden
                BeginContext(2230, 29, true);
                WriteLiteral("        </ul>\r\n    </div>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2266, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591