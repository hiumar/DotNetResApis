using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Text;
using UserRegistrationForm.Configuration;
using UserRegistrationForm.Interfaces;
using UserRegistrationForm.Services;

public class Startup
{

    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }
    public IConfiguration Configuration { get; }
    // This method gets called by the runtime. Use this method to add services to the container.
    // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940


    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<DbContextModel>(options =>
              options.UseSqlServer(Configuration.GetConnectionString("ContactAPIConnectionString")));
        services.AddSwaggerGen(s =>
        {
            s.SwaggerDoc("v1", new OpenApiInfo { Title = "AKD BACKEND APIS", Version = "v1" });
        });
            services.AddCors();

        services.AddTransient<IUser, UserService>();
        services.AddMvc();



    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseCors(x => x
        .AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

    
        app.UseHttpsRedirection();
        app.UseRouting();
        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "AKD Finance BACKEND APIS V1");
        });
    
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapDefaultControllerRoute();
            endpoints.MapControllers();
        });



    }


}