using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using MN_Groop_A.P.S.Database;
using MN_Groop_A.P.S.IRepositories;
using MN_Groop_A.P.S.IServices;
using MN_Groop_A.P.S.Repositories;
using MN_Groop_A.P.S.services;
using Newtonsoft.Json;



namespace MN_Groop_A.P.S
{
    public class Startup
    {
        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(name: MyAllowSpecificOrigins,
                    builder =>
                    {
                        builder.AllowAnyOrigin()// WithOrigins("http://localhost:4200")
                                .AllowAnyHeader()
                                .AllowAnyMethod();
                    });
            });

            services.AddDbContext<MNGroupDBConktext>(
                options => options.UseSqlServer(Configuration.GetConnectionString
                ("MyConnection"))
                );

            services.AddScoped<IKategoriRepository, KategoriRepository>();
            services.AddScoped<IKategoriServices, KategoriServices>();

            services.AddScoped<IKundeRepository, KundeRepository>();
            services.AddScoped<IKundeServices, KundeServices>();

            services.AddScoped<ILoginRepository, LoginRepository>();
            services.AddScoped<ILoginServices, LoginServices>();

            services.AddScoped<IOrder_DetailseRepository, Order_DetailseRepository>();
            services.AddScoped<IOrder_Detailes_Services, Order_deatails_Services>();

            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IOrderServices, OrderServices>();

            services.AddScoped<IProduktRepository, ProduktRepository>();
            services.AddScoped<IProduktServices, ProduktServices>();



            services.AddControllers()
                .AddNewtonsoftJson(
                o => o.SerializerSettings.ReferenceLoopHandling =
                ReferenceLoopHandling.Ignore);
                
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MN_Groop_A.P.S", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MN_Groop_A.P.S v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(MyAllowSpecificOrigins);

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}
