using GraphqlBasics.IService;
using GraphqlBasics.Models;
using GraphqlBasics.Service;
using HotChocolate;
using HotChocolate.AspNetCore;
using HotChocolate.AspNetCore.Playground;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphqlBasics
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<StudentQuery>();
            services.AddGraphQLServer().AddQueryType<StudentQuery>();
            services.AddGraphQLServer().AddType<StudentType>();

            //services.AddGraphQL(p => SchemaBuilder.New().AddServices(p)
            //.AddType<StudentType>()
            //.AddQueryType<StudentQuery>()
            //.Create()
            //);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UsePlayground(new PlaygroundOptions()
                {
                    QueryPath = "/api",
                    Path = "/playground"
                });
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseGraphQL();


        }
    }
}
