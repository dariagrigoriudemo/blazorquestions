using QuestionsClient.State;
using Microsoft.AspNetCore.Blazor.Http;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Runtime.InteropServices;

namespace QuestionsClient
{
    public class Startup
    {   
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<QuestionsFunctionsClient>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Create("WEBASSEMBLY"))) {

                // WebAssemblyHttpMessageHandler.DefaultCredentials = FetchCredentialsOption.Include;
            }

            app.AddComponent<App>("app");
        }
    }
}
