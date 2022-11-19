using ApiProyecto1002.Context;
using ApiProyecto1002.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace ApiProyecto1002
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ApiMongo", Version = "v1" });
            });
            services.Configure<EscuelaSettings>(Configuration.GetSection(nameof(EscuelaSettings)));
            services.AddSingleton<IEscuelaSettings>(d => d.GetRequiredService<IOptions<EscuelaSettings>>().Value;
            services.AddSingleton<EscuelaService>();
            service.AddControllers();
           
        }

        public void Configure(IApplicationBuilder app, IHostApplicationLifetime lifetime);
    }
}
