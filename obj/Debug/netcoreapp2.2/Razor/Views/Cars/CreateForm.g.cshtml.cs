#pragma checksum "/Users/Guest/Desktop/CarDealership.Solution/Views/Cars/CreateForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a30368da6ad0d3778ec95a3e17e33498566c5905"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_CreateForm), @"mvc.1.0.view", @"/Views/Cars/CreateForm.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cars/CreateForm.cshtml", typeof(AspNetCore.Views_Cars_CreateForm))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a30368da6ad0d3778ec95a3e17e33498566c5905", @"/Views/Cars/CreateForm.cshtml")]
    public class Views_Cars_CreateForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 506, true);
            WriteLiteral(@"<form action=""/cars"" method=""post"">
  <label for=""makeModel"">Add the Year Make and Model</label>
  <input id=""makeModel"" name=""makeModel"" type=""text"">
  <label for=""price"">Add the Blue Book Value</label>
  <input id=""price"" name=""price"" type=""text"">
  <label for=""miles"">Add the Current Mileage</label>
  <input id=""miles"" name=""miles"" type=""text"">
  <label for=""message"">Add More Info About this Car</label>
  <input id=""message"" name=""message"" type=""text"">
  <button type=""submit"">Submit</button>
</form>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
