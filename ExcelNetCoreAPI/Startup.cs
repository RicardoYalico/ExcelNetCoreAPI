using ExcelNetCoreAPI.Domain;
using ExcelNetCoreAPI.Domain.ArtesanosDomain;
using ExcelNetCoreAPI.Domain.PersonasDomain;
using ExcelNetCoreAPI.Domain.ProductosDomain;
using ExcelNetCoreAPI.Domain.RedesSocialesArtesanosDomain;
using ExcelNetCoreAPI.Domain.SubcategoriasDomain;
using ExcelNetCoreAPI.Domain.UsuariosDomain;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace ExcelNetCoreAPI
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

            var postgreSQLConnectionConfiguration = new PostgreSQLConfiguration(Configuration.GetConnectionString("PostgreSQLConnection"));
            services.AddSingleton(postgreSQLConnectionConfiguration);
            services.AddScoped<ICategoriasRepository, CategoriasRepository>();
            services.AddScoped<ISubCategoriasRepository, SubCategoriasRepository>();
            services.AddScoped<IUsuariosRepository, UsuariosRepository>();
            services.AddScoped<IPersonasRepository, PersonasRepository>();
            services.AddScoped<IArtesanosRepository, ArtesanosRepository>();
            services.AddScoped<IRedesSocialesArtesanosRepository, RedesSocialesArtesanosRepository>();
            services.AddScoped<IProductosRepository, ProductosRepository>();

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ExcelNetCoreAPI", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ExcelNetCoreAPI v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
