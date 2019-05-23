using curve_api.Data;
using curve_api.Models;
using curve_api.Models.Interfaces;
using curve_api.Models.Services;
using curve_api.Queries;
using curve_api.Schema;
using GraphiQl;
using GraphQL;
using GraphQL.Types;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Swashbuckle.AspNetCore.Swagger;
using System.Text;

namespace curve_api
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public IHostingEnvironment Environment { get; }

        public Startup(IHostingEnvironment environment)
        {
            Environment = environment;
            var builder = new ConfigurationBuilder().AddEnvironmentVariables();
            builder.AddUserSecrets<Startup>();
            Configuration = builder.Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.Authority = Configuration["Auth0:Authority"];
                options.Audience = Configuration["Auth0:Audience"];
            });

            services.AddMvc();

            //Database connection strings
            string connectionString_CurveDB, connectionString_CurveUserDB;
            if (Environment.IsDevelopment())
            {
                connectionString_CurveDB = Configuration.GetConnectionString("CurveDB");
                connectionString_CurveUserDB = Configuration.GetConnectionString("CurveUserDB");
            }
            else
            {
                connectionString_CurveDB = Configuration.GetConnectionString("ProductionConnection_CurveDB");
                connectionString_CurveUserDB = Configuration.GetConnectionString("ProductionConnection_CurveDB");
            }

            // Register DB context in services

            services.AddDbContext<CurveDBContext>(options => options.UseSqlServer(connectionString_CurveDB));

            services.AddDbContext<CurveUserDBContext>(options => options.UseSqlServer(connectionString_CurveUserDB));

            services.AddTransient<IIndividualManager, IndividualService>();
            services.AddTransient<IReviewManager, ReviewService>();
            services.AddTransient<ICategoryManager, CategoryService>();
            services.AddTransient<ISubcategoryManager, SubCategoryService>();
            services.AddTransient<IReviewCommentManager, ReviewCommentService>();
            services.AddTransient<ICategoryCommentManager, CategoryCommentService>();
            services.AddTransient<ISubCategoryCommentManager, SubCategoryCommentService>();

            services.AddScoped<IUser, UserService>();

            services.AddSingleton<IDocumentExecuter, DocumentExecuter>();

            services.AddSingleton<IndividualQuery>();

            services.AddSingleton<Types.Individual.IndividualType>();
            services.AddSingleton<Types.Review.ReviewType>();
            services.AddSingleton<Types.Category.CategoryType>();
            services.AddSingleton<Types.SubCategory.SubCategoryType>();
            services.AddSingleton<Types.ReviewComment.ReviewCommentType>();
            services.AddSingleton<Types.CategoryComment.CategoryCommentType>();
            services.AddSingleton<Types.SubCategoryComment.SubCategoryCommentType>();

            services.AddSingleton<Types.Individual.IndividualInputType>();

            var sp = services.BuildServiceProvider();
            services.AddSingleton<ISchema>(new CurveSchema(new FuncDependencyResolver(type => sp.GetService(type))));

            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
            });

            // LEGACY CODE DO NOT USE
            // LEGACY CODE DO NOT USE
            // LEGACY CODE DO NOT USE


            //services.AddIdentity<ApplicationUser, IdentityRole>()
            //    .AddEntityFrameworkStores<CurveUserDbContext>()
            //    .AddDefaultTokenProviders();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseGraphiQl();
            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseMvc();


            // Swagger
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Visit URL/swagger for interactive endpoint documentation.");
            });
        }
    }
}
