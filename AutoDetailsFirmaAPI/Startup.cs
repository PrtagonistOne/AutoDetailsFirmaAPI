using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using AutoDetailsFirmaDAL.EF;
using Microsoft.EntityFrameworkCore;
using AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFRepositories;
using AutoDetailsFirmaDAL.Repositories.EFRepositories;
using AutoMapper;
using AutoDetailsFirmaDAL.Entities;
using AutoDetailsFirmaBLL.DTO;
using AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFServices;
using AutoDetailsFirmaBLL.Services.EFServices;
using AutoDetailsFirmaDAL.Interfaces;
using AutoDetailsFirmaDAL.UnitOfWork;
using Microsoft.AspNetCore.Identity;

namespace AutoDetailsFirmaAPI
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
            services.AddDbContext<AutoDetailContext>(cfg =>
            {
                
                cfg.UseSqlServer(Configuration.GetConnectionString("Default"), b => b.MigrationsAssembly("AutoDetailsFirmaAPI"));
            });

            services.AddMvc();
            services.AddIdentity<User, Role>()
                .AddEntityFrameworkStores<AutoDetailContext>();
    
            services.AddTransient<IEFDetailRepository, EFDetailRepository>();
            services.AddTransient<IEFGroupOfDetailRepository, EFGroupOfDetailRepository>();
            services.AddTransient<IEFProvideRepository, EFProvideRepository>();
            services.AddTransient<IEFProviderRepository, EFProviderRepository>();
            services.AddTransient<IEFShopRepository, EFShopRepository>();

            services.AddAutoMapper(cfg =>
            {
                cfg.CreateMap<Detail, DetailDTO>().ReverseMap();
                cfg.CreateMap<GroupOfDetail, GroupOfDetailDTO>().ReverseMap();
                cfg.CreateMap<Provide, ProvideDTO>().ReverseMap();
                cfg.CreateMap<Provider, ProviderDTO>().ReverseMap();
                cfg.CreateMap<Shop, ShopDTO>().ReverseMap();
            }, typeof(Startup));

            services.AddTransient<IEFDetailService, EFDetailService>();
            services.AddTransient<IEFGroupOfDetailService, EFGroupOfDetailService>();
            services.AddTransient<IEFProvideService, EFProvideService>();
            services.AddTransient<IEFProviderService, EFProviderService>();
            services.AddTransient<IEFShopService, EFShopService>();

            services.AddTransient<IEFUnitOfWork, EFUnitOfWork>();

            services.AddControllersWithViews();
        }

        
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
