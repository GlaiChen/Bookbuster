#pragma checksum "C:\Users\97254\Documents\GitHub\Store\Views\Orders\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6a476ca87a1a262dd49ab2f27099a401c71ddd4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Checkout), @"mvc.1.0.view", @"/Views/Orders/Checkout.cshtml")]
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
#line 1 "C:\Users\97254\Documents\GitHub\Store\Views\_ViewImports.cshtml"
using BooksStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\97254\Documents\GitHub\Store\Views\_ViewImports.cshtml"
using BooksStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6a476ca87a1a262dd49ab2f27099a401c71ddd4", @"/Views/Orders/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c269e86a9abc6e417b650ea50037e65f98d4826", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Order>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/checkout.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("go-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/payment-item.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Terms", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Checkout/displayOrderdetails.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Checkout/acceptTerms.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6a476ca87a1a262dd49ab2f27099a401c71ddd48133", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f6a476ca87a1a262dd49ab2f27099a401c71ddd48395", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6a476ca87a1a262dd49ab2f27099a401c71ddd410365", async() => {
                WriteLiteral(@"
<!-- Banner Section Begin -->
<section class=""banner-section set-bg"" data-setbg=""img/bluebanner.jpg"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12 text-center"">
                <div class=""banner__text"">
                    <h2>Checkout</h2>
                    <div class=""banner__option"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6a476ca87a1a262dd49ab2f27099a401c71ddd411003", async() => {
                    WriteLiteral("Home");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        <span>Checkout</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Banner Section End -->

<!--Payment Cpmpletion Begin-->
<div id=""wrap"">
	<div id=""grid"">
		<div class=""column column1"">
			<div class=""step"" id=""step1"">
				<div class=""number"">
					<span>1</span>
			</div>
			<div class=""title"">
				<h4 class=""checkout_h4"">Email Address</h4>
			</div>
		</div>
		<div class=""content"" id=""email"">
			");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6a476ca87a1a262dd49ab2f27099a401c71ddd412968", async() => {
                    WriteLiteral("\r\n\t\t\t\t<div>\r\n        <input type=\"email\" name=\"email\"");
                    BeginWriteAttribute("value", " value=\"", 1122, "\"", 1130, 0);
                    EndWriteAttribute();
                    WriteLiteral(" id=\"email-address\" data-trigger=\"change\" data-validation-minlength=\"1\" data-type=\"email\" data-required=\"true\" disabled/><label for=\"email\">");
#nullable restore
#line 40 "C:\Users\97254\Documents\GitHub\Store\Views\Orders\Checkout.cshtml"
                                                                                                                                                                                        Write(ViewData["User"]);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</label>\r\n        </div>\r\n\t\t\t");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t</div>\r\n\t\t<div class=\"step\" id=\"step2\">\r\n\t\t\t<div class=\"number\">\r\n\t\t\t\t<span>2</span>\r\n\t\t\t</div>\r\n\t\t\t<div class=\"title\">\r\n\t\t\t\t<h4 class=\"checkout_h4\">Delivery Info</h4>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t\t<div class=\"content\" id=\"address\">\r\n\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6a476ca87a1a262dd49ab2f27099a401c71ddd415461", async() => {
                    WriteLiteral("\r\n\t\t\t\t<div>\r\n\t\t\t\t\t<input type=\"name\" name=\"first_name\"");
                    BeginWriteAttribute("value", " value=\"", 1636, "\"", 1644, 0);
                    EndWriteAttribute();
                    WriteLiteral(@" id=""first_name"" placeholder=""First Name"" data-trigger=""change"" data-validation-minlength=""1"" data-type=""name"" data-required=""true"" data-error-message=""Enter Your First Name""/><label for=""first_name"">First Name</label>
				</div>
				<div>
					<input type=""name"" name=""last_name""");
                    BeginWriteAttribute("value", " value=\"", 1928, "\"", 1936, 0);
                    EndWriteAttribute();
                    WriteLiteral(@" id=""last_name"" placeholder=""Last Name"" data-trigger=""change"" data-validation-minlength=""1"" data-type=""name"" data-required=""true"" data-error-message=""Enter Your Last Name""/><label for=""last_name"">Last Name</label>
				</div>
				<div>
					<input type=""phone"" name=""telephone""");
                    BeginWriteAttribute("value", " value=\"", 2216, "\"", 2224, 0);
                    EndWriteAttribute();
                    WriteLiteral(@" id=""telephone"" placeholder=""Phone 054-1234567"" data-trigger=""change"" data-validation-minlength=""1"" data-type=""number"" data-required=""true"" data-error-message=""Enter Your Telephone Number""/><label for=""telephone"">Telephone</label>
				</div>
				<div>
					<input type=""text"" name=""address""");
                    BeginWriteAttribute("value", " value=\"", 2518, "\"", 2526, 0);
                    EndWriteAttribute();
                    WriteLiteral(@" id=""address"" placeholder=""Address"" data-trigger=""change"" data-validation-minlength=""1"" data-type=""text"" data-required=""true"" data-error-message=""Enter Your Billing Address""/><label for=""Address"">Address</label>
				</div>
				<div>
					<input type=""text"" name=""city""");
                    BeginWriteAttribute("value", " value=\"", 2798, "\"", 2806, 0);
                    EndWriteAttribute();
                    WriteLiteral(" id=\"city\" placeholder=\"City\" data-trigger=\"change\" data-validation-minlength=\"1\" data-type=\"text\" data-required=\"true\" data-error-message=\"Enter Your Billing City\"/><label for=\"city\">City</label>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div>\r\n\t\t\t\t\t<input type=\"text\" name=\"zip\"");
                    BeginWriteAttribute("value", " value=\"", 3062, "\"", 3070, 0);
                    EndWriteAttribute();
                    WriteLiteral(" id=\"zip\" placeholder=\"Zip Code\" data-trigger=\"change\" data-validation-minlength=\"1\" data-type=\"text\" data-required=\"true\" data-error-message=\"Enter Your Billing Zip Code\"/><label for=\"zip\">Zip Code</label>\r\n\t\t\t\t</div>\r\n\t\t\t");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
		</div>
	</div>
	<div class=""column column2"">
		<div class=""step"" id=""step3"">
			<div class=""number"">
				<span>3</span>
			</div>
			<div class=""title"">
				<h4 class=""checkout_h4"">Shipping</h4>
			</div>
		</div>
		<div class=""content"" id=""shipping"">
			");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6a476ca87a1a262dd49ab2f27099a401c71ddd419945", async() => {
                    WriteLiteral("\r\n\t\t\t\t<p>\t\t\r\n\t\t\t\t\t<input type=\"radio\" id=\"shipping_1\" value=\"1\"/><label for=\"shipping_1\">Shipping Only<span class=\"price\">(Free - COVID-19)</span></label>\r\n\t\t\t\t</p>\r\n\t\t\t");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
		</div>
		<div class=""step"" id=""step4"">
			<div class=""number"">
				<span>4</span>
			</div>
			<div class=""title"">
				<h4 class=""checkout_h4"">Payment</h4>
			</div>
		</div>
			<div class=""content"" id=""payment label"">
				<div class=""content"" id=""shipping"">
					");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6a476ca87a1a262dd49ab2f27099a401c71ddd422118", async() => {
                    WriteLiteral("\r\n\t\t\t\t\t\t<p>\t\t\r\n\t\t\t\t\t\t\t<input type=\"radio\" id=\"shipping_1\" value=\"1\"/><label for=\"shipping_1\">Shipping Only<span class=\"price\">(Free - COVID-19)</span></label>\r\n\t\t\t\t\t\t</p>\r\n\t\t\t\t\t");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t\t<div class=\"right\">\r\n\t\t\t\t<div class=\"accepted\">\r\n\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f6a476ca87a1a262dd49ab2f27099a401c71ddd424124", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
				</div>
				<div class=""secured"">
					<img class=""lock"" src=""https://i.imgur.com/hHuibOR.png"">
					<span class=""secured-text"">Secured Payment by BOOKBUSTER ltd.</span>
				</div>
			</div>
 		</div>
 	</div>
 	<div class=""column column3"">
 		<div class=""step"" id=""step5"">
			<div class=""number"">
				<span>5</span>
			</div>
			<div class=""title"">
				<h4 class=""checkout_h4"">Finalize Order</h4>
			</div>
		</div>
		<div class=""content"" id=""final_products"">
			<div class=""left"" id=""ordered"">
				<div class=""products"">
					<div class=""product_image"">
						image
					</div>
					<div class=""product_details"">
						<span class=""product_name"">Name</span>
						<span class=""quantity"">X</span>
						<span class=""price"">$</span>
					</div>
				</div>
				<div class=""totals"">
");
#nullable restore
#line 141 "C:\Users\97254\Documents\GitHub\Store\Views\Orders\Checkout.cshtml"
                      
						var GrandSubtotals= 0;
						var Tax = Math.Round(GrandSubtotals * 0.17,2);
						var GradnTotal= Math.Round(GrandSubtotals + Tax,2);


#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t<span class=\"subtitle\">Subtotal <span id=\"sub_price\">$");
#nullable restore
#line 146 "C:\Users\97254\Documents\GitHub\Store\Views\Orders\Checkout.cshtml"
                                                                     Write(GrandSubtotals);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></span>\r\n\t\t\t\t\t<span class=\"subtitle\">Tax (17%) <span id=\"sub_tax\">$");
#nullable restore
#line 147 "C:\Users\97254\Documents\GitHub\Store\Views\Orders\Checkout.cshtml"
                                                                    Write(Tax);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></span>\r\n\t\t\t\t\t<span class=\"subtitle\">Shipping <span id=\"sub_ship\">$</span></span>\r\n");
                WriteLiteral("\t\t\t\t</div>\r\n\t\t\t\t<div class=\"final\">\r\n\t\t\t\t\t<span class=\"title\">Total <span id=\"calculated_total\">$");
#nullable restore
#line 152 "C:\Users\97254\Documents\GitHub\Store\Views\Orders\Checkout.cshtml"
                                                                      Write(GradnTotal);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span></span>
				</div>
			</div>	
			<div class=""right"" id=""reviewed"">
				<div id=""complete"">
					<button type=""submit"" id=""placeOrder"" class=""button-done"" disabled>Complete Order</button>
						<div class=""input-checkbox"">
							  <label for=""terms"">
									<span class=""sub"">By selecting this button you agree to the purchase and subsequent payment for this order.<br/>
									<input type=""checkbox"" id=""terms"" onclick=""acceptTerms()"">
									I've read and accept the ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6a476ca87a1a262dd49ab2f27099a401c71ddd428164", async() => {
                    WriteLiteral("terms & conditions");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</span>\r\n\t\t\t\t\t\t\t</label>\r\n\t\t\t\t\t\t</div>\r\n                 </div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n\r\n<!--Payment Cpmpletion End-->\r\n\r\n");
                DefineSection("Scripts", async() => {
                    WriteLiteral("\r\n    <script src=\"https://ajax.aspnetcdn.com/ajax/jquery.templates/beta1/jquery.tmpl.min.js\"></script>\r\n    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6a476ca87a1a262dd49ab2f27099a401c71ddd429786", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6a476ca87a1a262dd49ab2f27099a401c71ddd430943", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 177 "C:\Users\97254\Documents\GitHub\Store\Views\Orders\Checkout.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n    <script id=\"restuls\" type=\"text/html\">\r\n\r\n        <div class=\"order-col\">\r\n            <div>${id}</div>\r\n            <div>${book}</div>\r\n            <div>${quantity}</div>\r\n            <div>${price}</div>\r\n        </div>\r\n\r\n    </script>\r\n");
                }
                );
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
