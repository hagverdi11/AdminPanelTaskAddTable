#pragma checksum "C:\Users\HP\Desktop\Fiorello-backend\EntityFrameworkProject\Areas\AdminArea\Views\SliderDetails\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2294da26f03f58490f80a7a8a8c196466d4f6bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminArea_Views_SliderDetails_Index), @"mvc.1.0.view", @"/Areas/AdminArea/Views/SliderDetails/Index.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\Fiorello-backend\EntityFrameworkProject\Areas\AdminArea\Views\_ViewImports.cshtml"
using EntityFrameworkProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2294da26f03f58490f80a7a8a8c196466d4f6bf", @"/Areas/AdminArea/Views/SliderDetails/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4472e57ccb85564f0ed85bc069dcc9853bd128a9", @"/Areas/AdminArea/Views/_ViewImports.cshtml")]
    public class Areas_AdminArea_Views_SliderDetails_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SliderDetail>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"


<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">First</th>
            <th scope=""col"">Last</th>
            <th scope=""col"">Handle</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <th scope=""row"">1</th>
            <td>Mark</td>
            <td>Otto</td>
            <td>mdo</td>
        </tr>
        <tr>
            <th scope=""row"">2</th>
            <td>Jacob</td>
            <td>Thornton</td>
            <td>fat</td>
        </tr>
        <tr>
            <th scope=""row"">3</th>
            <td>Larry</td>
            <td>the Bird</td>
            <td>twitter</td>
        </tr>
    </tbody>
</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SliderDetail>> Html { get; private set; }
    }
}
#pragma warning restore 1591
