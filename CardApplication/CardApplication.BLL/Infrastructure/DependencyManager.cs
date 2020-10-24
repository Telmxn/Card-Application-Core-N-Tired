using CardApplication.BLL.Services;
using CardApplication.DataAccess;
using CardApplication.DataAccess.Implementation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardApplication.BLL.Infrastructure
{
    public static class DependencyManager
    {
        public static void AddApplicationDependencies(this IServiceCollection serviceDescriptors)
        {
            var provider = serviceDescriptors.BuildServiceProvider();
            serviceDescriptors.AddDbContext<CardApplicationDbContext>(x => x.UseSqlServer(provider.GetRequiredService<IConfiguration>()["ConnectionStrings:CardAppCOnnect"]));
            serviceDescriptors.AddTransient<ICardService, CardService>();
            serviceDescriptors.AddScoped<ICardAppCardRepository, CardAppCardRepository>();
        }
    }
}
