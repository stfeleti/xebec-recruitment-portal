// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace XebecPortal.Client.JobPortalTestEnv.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Kian\source\repos\xebec-recruitment-portal\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kian\source\repos\xebec-recruitment-portal\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kian\source\repos\xebec-recruitment-portal\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Kian\source\repos\xebec-recruitment-portal\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Kian\source\repos\xebec-recruitment-portal\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kian\source\repos\xebec-recruitment-portal\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Kian\source\repos\xebec-recruitment-portal\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Kian\source\repos\xebec-recruitment-portal\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Kian\source\repos\xebec-recruitment-portal\Client\_Imports.razor"
using XebecPortal.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Kian\source\repos\xebec-recruitment-portal\Client\_Imports.razor"
using XebecPortal.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Kian\source\repos\xebec-recruitment-portal\Client\_Imports.razor"
using XebecPortal.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kian\source\repos\xebec-recruitment-portal\Client\JobPortalTestEnv\Pages\CandidateInfoTest.razor"
using XebecPortal.Client.JobPortalTestEnv.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/candidateinfo")]
    public partial class CandidateInfoTest : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 193 "C:\Users\Kian\source\repos\xebec-recruitment-portal\Client\JobPortalTestEnv\Pages\CandidateInfoTest.razor"
 
    static string searchTerm = string.Empty;
    private static List<CandidateTest> Candidates = new List<CandidateTest>
    {


        new CandidateTest
        {
            Id = 1,
            Name = "Johnathan Snow",
            JobAppliedFor = "Developer",
            YearsOfExp = 2,
            ExtraInfo = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Iure laborum nesciunt unde iusto quas rerumores quaerat eum velit totam!"

        },

        new CandidateTest
        {
            Id = 2,
            Name = "Edward Stark",
            JobAppliedFor = "Lawyer",
            YearsOfExp = 8,
            ExtraInfo = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Iure laborum nesciunt unde iusto quas rerumores quaerat eum velit totam!"

        },

        new CandidateTest
        {
            Id = 3,
            Name = "Peter Parker",
            JobAppliedFor = "Developer",
            YearsOfExp = 1,
            ExtraInfo = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Iure laborum nesciunt unde iusto quas rerumores quaerat eum velit totam!"

        },

        new CandidateTest
        {
            Id = 4,
            Name = "Bruce Banner",
            JobAppliedFor = "Cloud Engineer",
            YearsOfExp = 5,
            ExtraInfo = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Iure laborum nesciunt unde iusto quas rerumores quaerat eum velit totam!"

        }

    };

    private static List<CandidateTest> SearchResults = Candidates;
    private static bool isFound = false;    

    private static void Search()
    {
        SearchResults = Candidates.FindAll(q => q.JobAppliedFor.ToLower().Equals(searchTerm.ToLower())); 
       if(SearchResults == null || SearchResults.Count <= 0)
            SearchResults = Candidates;
    }    

    bool IsClicked = false;
    private int ReturnedCandidateId = 0;
    private CandidateTest CurrentCandidate = null;
    private async Task On()
    {
        IsClicked = true;
        ReturnedCandidateId = Int32.Parse(await jsr.InvokeAsync<string>("show"));
       
       
        CurrentCandidate = SearchResults.FirstOrDefault(q => q.Id == ReturnedCandidateId); 
    
           
            

    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if(firstRender)
        {
            await jsr.InvokeVoidAsync("initialize");
        }
    }

    




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsr { get; set; }
    }
}
#pragma warning restore 1591
