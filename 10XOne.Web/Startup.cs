using System;
using _10XOne.Core.Models;
using _10XOne.Core.Services.Interfaces;
using _10XOne.Infrastructure.Persistence;
using _10XOne.Infrastructure.Repository.Implementations;
using _10XOne.Infrastructure.Repository.Interaces;
using _10XOne.Infrastructure.Services.Implementations;
using _10XOne.Infrastructure.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace _10XOne.Web
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
            services.AddControllersWithViews();

            services.AddDbContext<ApplicationContext>(opt => opt.UseInMemoryDatabase("10XOneInMemory"));



            services.AddScoped<IPartnerService, PartnerService>();
            services.AddScoped<IFinancialItemService, FinancialItemService>();
            services.AddScoped<IPartnerRepository, PartnerRepository>();
            services.AddScoped<IFinancialItemRepository, FinancialItemRepository>();
            services.AddScoped<ICalculation, Calculation>();

            var context = services.BuildServiceProvider().GetService<ApplicationContext>();
            InitFinancialTable(context);
            InitPartners(context);
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

        private static void InitFinancialTable(ApplicationContext _context)
        {
            FinancialItem myDataRow = new FinancialItem();
            myDataRow.PARTNER_ID = 1;
            myDataRow.ID = 1;
            myDataRow.DATE = DateTime.Now;
            myDataRow.AMOUNT = 100;
            _context.FinancialItems.Add(myDataRow);

            myDataRow = new FinancialItem();
            myDataRow.ID = 2;
            myDataRow.PARTNER_ID = 2;
            myDataRow.DATE = DateTime.Now;
            myDataRow.AMOUNT = 100;
            _context.FinancialItems.Add(myDataRow);

            myDataRow = new FinancialItem();
            myDataRow.ID = 3;
            myDataRow.PARTNER_ID = 3;
            myDataRow.DATE = DateTime.Now;
            myDataRow.AMOUNT = 100;
            _context.FinancialItems.Add(myDataRow);

            myDataRow = new FinancialItem();
            myDataRow.ID = 4;
            myDataRow.PARTNER_ID = 4;
            myDataRow.DATE = DateTime.Now;
            myDataRow.AMOUNT = 100;
            _context.FinancialItems.Add(myDataRow);

            myDataRow = new FinancialItem();
            myDataRow.ID = 5;
            myDataRow.PARTNER_ID = 5;
            myDataRow.DATE = DateTime.Now;
            myDataRow.AMOUNT = 100;
            _context.FinancialItems.Add(myDataRow);

            myDataRow = new FinancialItem();
            myDataRow.ID = 6;
            myDataRow.PARTNER_ID = 6;
            myDataRow.DATE = DateTime.Now;
            myDataRow.AMOUNT = 100;
            _context.FinancialItems.Add(myDataRow);

            myDataRow = new FinancialItem();
            myDataRow.ID = 7;
            myDataRow.PARTNER_ID = 7;
            myDataRow.DATE = DateTime.Now;
            myDataRow.AMOUNT = 100;
            _context.FinancialItems.Add(myDataRow);

            myDataRow = new FinancialItem();
            myDataRow.ID = 8;
            myDataRow.PARTNER_ID = 8;
            myDataRow.DATE = DateTime.Now;
            myDataRow.AMOUNT = 100;
            _context.FinancialItems.Add(myDataRow);

            _context.SaveChanges();

        }

        private void InitPartners(ApplicationContext _context)
        {
            Partner myDataRow = new Partner();
            myDataRow.ID = 1;
            myDataRow.PARTNER_NAME = "Partner 1";
            myDataRow.PARENT_PARTNER_ID = 0;
            myDataRow.FEE_PERCENT = 15;
            _context.Partners.Add(myDataRow);

            myDataRow = new Partner();
            myDataRow.ID = 2;
            myDataRow.PARTNER_NAME = "Partner 2";
            myDataRow.PARENT_PARTNER_ID = 1;
            myDataRow.FEE_PERCENT = 5;
            _context.Partners.Add(myDataRow);

            myDataRow = new Partner();
            myDataRow.ID = 3;
            myDataRow.PARTNER_NAME = "Partner 3";
            myDataRow.PARENT_PARTNER_ID = 1;
            myDataRow.FEE_PERCENT = 7;
            _context.Partners.Add(myDataRow);

            myDataRow = new Partner();
            myDataRow.ID = 4;
            myDataRow.PARTNER_NAME = "Partner 4";
            myDataRow.PARENT_PARTNER_ID = 2;
            myDataRow.FEE_PERCENT = 3;
            _context.Partners.Add(myDataRow);

            myDataRow = new Partner();
            myDataRow.ID = 5;
            myDataRow.PARTNER_NAME = "Partner 5";
            myDataRow.PARENT_PARTNER_ID = 2;
            myDataRow.FEE_PERCENT = 17;
            _context.Partners.Add(myDataRow);

            myDataRow = new Partner();
            myDataRow.ID = 6;
            myDataRow.PARTNER_NAME = "Partner 6";
            myDataRow.PARENT_PARTNER_ID = 3;
            myDataRow.FEE_PERCENT = 20;
            _context.Partners.Add(myDataRow);

            myDataRow = new Partner();
            myDataRow.ID = 7;
            myDataRow.PARTNER_NAME = "Partner 7";
            myDataRow.PARENT_PARTNER_ID = 3;
            myDataRow.FEE_PERCENT = 14;
            _context.Partners.Add(myDataRow);

            myDataRow = new Partner();
            myDataRow.ID = 8;
            myDataRow.PARTNER_NAME = "Partner 8";
            myDataRow.PARENT_PARTNER_ID = 7;
            myDataRow.FEE_PERCENT = 11;
            _context.Partners.Add(myDataRow);

            _context.SaveChanges();
        }
    }
}
