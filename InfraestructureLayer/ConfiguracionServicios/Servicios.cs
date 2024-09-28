using AccesDataBase.Repository;
using Microsoft.Extensions.DependencyInjection;
using RecepcionMercancia;
using RecepcionMercancia.Command;
using RecepcionMercancia.Command.Interfaces;
using RecepcionMercancia.Interfaces;
using RecepcionMercancia.Query;
using RecepcionMercancia.Query.Interfaces;
using Utilidades;

namespace ConfiguracionServicios
{
    public class Servicios
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IProductoActor, ProductoActor>();
            services.AddScoped<IProductoQuy, ProductoQuy>();
            services.AddScoped<IProductoCmd, ProductoCmd>();
            services.AddScoped<IRepository, Repository>();
            services.AddScoped<IGestorId, GestorId>();
        }
    }
}
