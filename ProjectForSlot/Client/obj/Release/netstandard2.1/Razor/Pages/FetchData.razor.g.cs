#pragma checksum "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45c9111af23ffd4aee909fe66004c691264a6c8b"
// <auto-generated/>
#pragma warning disable 1591
namespace ProjectForSlot.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\_Imports.razor"
using ProjectForSlot.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\_Imports.razor"
using ProjectForSlot.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\Pages\FetchData.razor"
using ProjectForSlot.Shared.Contracts;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\Pages\FetchData.razor"
 if (finalFlag)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\Pages\FetchData.razor"
     if (otpResponse == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "        ");
            __builder.AddMarkupContent(1, "<h1>Please Enter Phone Number For OTP</h1>\r\n");
#nullable restore
#line 10 "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\Pages\FetchData.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "        ");
            __builder.AddMarkupContent(3, "<h1>Enter OTP Please</h1>\r\n");
#nullable restore
#line 14 "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\Pages\FetchData.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "p");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\Pages\FetchData.razor"
                             forecasts

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => forecasts = __value, forecasts));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
#nullable restore
#line 18 "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\Pages\FetchData.razor"
     if (otpResponse == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "        ");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\Pages\FetchData.razor"
                          GetOtpViaApi

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(15, "Get Otp");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
#nullable restore
#line 21 "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\Pages\FetchData.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(17, "        ");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\Pages\FetchData.razor"
                          VerifyOtp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(20, "Verify Otp");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
#nullable restore
#line 25 "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\Pages\FetchData.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\Pages\FetchData.razor"
     if (otpResponse == null && !flag)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(22, "        ");
            __builder.AddMarkupContent(23, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 29 "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\Pages\FetchData.razor"
    }
    else if (otpResponse != null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(24, "        ");
            __builder.OpenElement(25, "div");
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.AddContent(27, 
#nullable restore
#line 33 "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\Pages\FetchData.razor"
             otpResponse.txnId

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
#nullable restore
#line 35 "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\Pages\FetchData.razor"
    }
    else if (ValidateOtpResponse != null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(30, "        ");
            __builder.OpenElement(31, "div");
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.AddContent(33, 
#nullable restore
#line 39 "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\Pages\FetchData.razor"
             ValidateOtpResponse.token

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
#nullable restore
#line 41 "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\Pages\FetchData.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\Pages\FetchData.razor"
     
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(36, "    ");
            __builder.AddMarkupContent(37, "<p>\r\n\r\n        <div>\r\n            Finding Slots In <em>DELHI</em>\r\n        </div>\r\n    </p>\r\n    ");
            __builder.OpenElement(38, "p");
            __builder.AddMarkupContent(39, "\r\n        ");
            __builder.AddMarkupContent(40, "<span>\r\n            Enter Date : dd/mm/yyyy(optional)\r\n        </span>\r\n        ");
            __builder.OpenElement(41, "span");
            __builder.AddMarkupContent(42, "\r\n            ");
            __builder.OpenElement(43, "input");
            __builder.AddAttribute(44, "placeholder", 
#nullable restore
#line 70 "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\Pages\FetchData.razor"
                                 date

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(45, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 70 "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\Pages\FetchData.razor"
                                                     date

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => date = __value, date));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n    ");
            __builder.OpenElement(50, "p");
            __builder.AddMarkupContent(51, "\r\n        ");
            __builder.AddMarkupContent(52, "<span>\r\n            Enter Dose : first or second\r\n        </span>\r\n        ");
            __builder.OpenElement(53, "span");
            __builder.AddMarkupContent(54, "\r\n            ");
            __builder.OpenElement(55, "input");
            __builder.AddAttribute(56, "placeholder", "First/Second");
            __builder.AddAttribute(57, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 83 "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\Pages\FetchData.razor"
                                                            dose

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(58, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => dose = __value, dose));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n    ");
            __builder.OpenElement(62, "p");
            __builder.AddMarkupContent(63, "\r\n        ");
            __builder.AddMarkupContent(64, "<span>\r\n            Enter Vaccine : COVISHIELD or COVAXIN\r\n        </span>\r\n        ");
            __builder.OpenElement(65, "span");
            __builder.AddMarkupContent(66, "\r\n            ");
            __builder.OpenElement(67, "input");
            __builder.AddAttribute(68, "placeholder", "Covishield/Covaxin");
            __builder.AddAttribute(69, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 96 "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\Pages\FetchData.razor"
                                                                  vaccine

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(70, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => vaccine = __value, vaccine));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n    ");
            __builder.OpenElement(74, "p");
            __builder.AddMarkupContent(75, "\r\n        ");
            __builder.AddMarkupContent(76, "<span>\r\n            Enter AgeGroup Above 45 Or Below :\r\n        </span>\r\n        ");
            __builder.OpenElement(77, "span");
            __builder.AddMarkupContent(78, "\r\n            ");
            __builder.OpenElement(79, "input");
            __builder.AddAttribute(80, "placeholder", "above/below");
            __builder.AddAttribute(81, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 109 "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\Pages\FetchData.razor"
                                                           ageGrp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(82, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ageGrp = __value, ageGrp));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n    ");
            __builder.OpenElement(86, "button");
            __builder.AddAttribute(87, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 112 "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\Pages\FetchData.razor"
                      FindCenters

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(88, "Find Centers");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n");
#nullable restore
#line 113 "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\Pages\FetchData.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 114 "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\Pages\FetchData.razor"
 if (!flagSlot)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(90, "    ");
            __builder.AddMarkupContent(91, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 117 "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\Pages\FetchData.razor"
}
else if (slotResponse != null && slotResponse.Values.Count != 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(92, "    ");
            __builder.OpenElement(93, "p");
            __builder.AddMarkupContent(94, "\r\n        Slots Available: ");
            __builder.AddContent(95, 
#nullable restore
#line 121 "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\Pages\FetchData.razor"
                          slotResponse["value"].Count

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(96, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n    ");
            __builder.OpenElement(98, "table");
            __builder.AddAttribute(99, "class", "table");
            __builder.AddMarkupContent(100, "\r\n        ");
            __builder.AddMarkupContent(101, @"<thead>
            <tr>
                <th>Dose</th>
                <th>Address</th>
                <th>District Name</th>
                <th>Fee</th>
                <th>Min_Age_Limit</th>
                <th>Name</th>
                <th>Pincode</th>
                <th>State Name</th>
                <th>Vaccine</th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(102, "tbody");
            __builder.AddMarkupContent(103, "\r\n");
#nullable restore
#line 138 "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\Pages\FetchData.razor"
             foreach (var slotss in slotResponse.Values)
            {
                foreach (var slots in slotss)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(104, "                    ");
            __builder.OpenElement(105, "tr");
            __builder.AddMarkupContent(106, "\r\n");
#nullable restore
#line 143 "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\Pages\FetchData.razor"
                         if (slots.available_capacity_dose1 != 0)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(107, "                            ");
            __builder.OpenElement(108, "td");
            __builder.AddContent(109, 
#nullable restore
#line 145 "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\Pages\FetchData.razor"
                                 slots.available_capacity_dose1

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n");
#nullable restore
#line 146 "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\Pages\FetchData.razor"
                        }
                        else if (slots.available_capacity_dose2 != 0)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(111, "                            ");
            __builder.OpenElement(112, "td");
            __builder.AddContent(113, 
#nullable restore
#line 149 "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\Pages\FetchData.razor"
                                 slots.available_capacity_dose2

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n");
#nullable restore
#line 150 "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\Pages\FetchData.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(115, "\r\n                        ");
            __builder.OpenElement(116, "td");
            __builder.AddContent(117, 
#nullable restore
#line 152 "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\Pages\FetchData.razor"
                             slots.address

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n                        ");
            __builder.OpenElement(119, "td");
            __builder.AddContent(120, 
#nullable restore
#line 153 "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\Pages\FetchData.razor"
                             slots.district_name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n                        ");
            __builder.OpenElement(122, "td");
            __builder.AddContent(123, 
#nullable restore
#line 154 "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\Pages\FetchData.razor"
                             slots.fee

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n                        ");
            __builder.OpenElement(125, "td");
            __builder.AddContent(126, 
#nullable restore
#line 155 "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\Pages\FetchData.razor"
                             slots.min_age_limit

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n                        ");
            __builder.OpenElement(128, "td");
            __builder.AddContent(129, 
#nullable restore
#line 156 "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\Pages\FetchData.razor"
                             slots.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\r\n                        ");
            __builder.OpenElement(131, "td");
            __builder.AddContent(132, 
#nullable restore
#line 157 "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\Pages\FetchData.razor"
                             slots.pincode

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(133, "\r\n                        ");
            __builder.OpenElement(134, "td");
            __builder.AddContent(135, 
#nullable restore
#line 158 "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\Pages\FetchData.razor"
                             slots.state_name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n                        ");
            __builder.OpenElement(137, "td");
            __builder.AddContent(138, 
#nullable restore
#line 159 "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\Pages\FetchData.razor"
                             slots.vaccine

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(140, "\r\n");
#nullable restore
#line 161 "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\Pages\FetchData.razor"
                }

            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(141, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(142, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\r\n");
#nullable restore
#line 166 "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\Pages\FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 168 "E:\FolderForPractise\ProjectForSlot\ProjectForSlot\Client\Pages\FetchData.razor"
       
    private string forecasts;
    private string dose;
    private string vaccine;
    private string ageGrp;
    private bool flagSlot;
    private string date;

    private List<string> templates;

    private bool flag;
    private bool finalFlag;
    public OtpResponse otpResponse;
    public ValidateOtpResponse ValidateOtpResponse;

    public Dictionary<string, List<slot>> slotResponse;

    protected override Task OnInitializedAsync()
    {
        flag = true;
        templates = new List<string>();
        templates.Add("-Select State-");
        templates.Add("Delhi");
        templates.Add("Haryana");
        templates.Add("Punjab");
        slotResponse = new Dictionary<string, List<slot>>();
        flagSlot = true;
        DateTime dateTime = DateTime.UtcNow.Date;
        date = dateTime.ToString("dd/MM/yyyy");
        return base.OnInitializedAsync();
    }

    public async Task GetOtpViaApi()
    {
        flag = false;
        finalFlag = true;
        otpResponse = await Http.GetFromJsonAsync<OtpResponse>("WeatherForecast/GetOtp/" + forecasts);
        if (otpResponse != null)
        {
            flag = false;
            forecasts = "";
        }

    }
    public async Task VerifyOtp()
    {
        ValidateOtpResponse = await Http.GetFromJsonAsync<ValidateOtpResponse>("WeatherForecast/VerifyOtp/" + forecasts + "/" + otpResponse.txnId);
        if (ValidateOtpResponse != null)
        {
            finalFlag = false;
        }
    }
    public async Task FindCenters()
    {
        var dateinp = date;
        if (string.IsNullOrEmpty(date))
        {
            dateinp = "nothing";
        }
        else
        {
            dateinp = dateinp.Replace('/', '@');
        }
        flagSlot = false;
        slotResponse = await Http.GetFromJsonAsync<Dictionary<string, List<slot>>>("WeatherForecast/FindCenters/Delhi" + "/" + dose + "/" + vaccine + "/" + ageGrp + "/" + dateinp);
        if (slotResponse != null)
        {
            flagSlot = true;
            finalFlag = false;
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
