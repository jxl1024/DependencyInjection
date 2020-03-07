using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjectionDemo.Context;
using DependencyInjectionDemo.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DependencyInjectionDemo
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
            // 添加EntityFrameworkCore服务
            // 这里是注册AppDbContext使用AddDbContext<T>的形式
            services.AddDbContext<AppDbContext>(options => 
            {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });

            // 添加自己的服务
            // IRepository是一个接口，表示要请求的类型
            // UserRepository表示IRepository接口的具体实现类型
            services.AddTransient<IRepository, UserRepository>();

            // 注册ICharacterRepository类型
            services.AddTransient<ICharacterRepository, CharacterRepository>();

            // 添加瞬时生命周期
            services.AddTransient<IOperationTransientRepository, OperationTransientRepository>();
            // 添加作用域生命周期
            services.AddScoped<IOperationScopeRepository, OperationScopeRepository>();
            // 添加单例生命周期
            services.AddSingleton<IOperationSingletonRepository, OperationSingletonRepository>();
            // 添加MVC服务
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
