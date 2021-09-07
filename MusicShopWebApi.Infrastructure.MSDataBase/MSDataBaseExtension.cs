using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MusicShopWebApi.Core.Domain.Repositories;
using MusicShopWebApi.Infrastructure.MSDataBase.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShopWebApi.Infrastructure.MSDataBase
{
    public static class MSDataBaseExtension
    {
        public static IServiceCollection AddMSDataBaseServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MSDataBaseContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("MSDataBaseConnectionString")));
            services.AddTransient<IProducerRepository, ProducerRepository>();

            return services;
        }
    }
}
