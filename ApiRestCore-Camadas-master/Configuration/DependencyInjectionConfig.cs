using ApiRestCore.Business.Interfaces;
using ApiRestCore.Business.Notificacoes;
using ApiRestCore.Business.Services;
using ApiRestCore.Data.Context;
using ApiRestCore.Data.Repository;
using ApiRestCore.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace ApiRestCore.Configuration
{
    //classe para resolver as dependencias 
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<MeuDbContext>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();

            services.AddScoped<INotificador, Notificador>();
            services.AddScoped<IProdutoService, ProdutoService>();
            services.AddScoped<IFornecedorService, FornecedorService>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>(); //Para aplicação toda, não confunde os usuarios
            services.AddScoped<IUser, AspNetUser>();


            services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();
            return services;
        }
    }
}
