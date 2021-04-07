using Aula2.Adapter;
using Aula2.Bordas.Adapter;
using Aula2.Bordas.Repositorios;
using Aula2.Context;
using Aula2.Repositorios;
using Aula2.Services;
using Aula2.UseCase;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula2
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
            services.AddEntityFrameworkNpgsql().AddDbContext<LocalDbContext>(opt => opt.UseNpgsql
            (Configuration.GetConnectionString("urlSquadra")));

            services.AddScoped<IProdutoService, ProdutoService>();

            services.AddScoped<IAdicionarProdutoUseCase, AdicionarProdutoUseCase>();
            services.AddScoped<IAtualizarProdutoUseCase, AtualizarProdutoUseCase>();
            services.AddScoped<IRemoverProdutoUseCase, RemoverProdutoUseCase>();
            services.AddScoped<IRetornarListadeProdutosUseCase, RetornarListadeProdutosUseCase>();
            services.AddScoped<IRetornarProdutosPorIdUseCase, RetornarProdutosPorIdUseCase>();

            services.AddScoped<IRepositorioProdutos, RepositorioProdutos>();
            services.AddScoped<IAdicionarProdutoAdapter, AdicionarProdutoAdapter>();
            



            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
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
