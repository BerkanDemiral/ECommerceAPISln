using ECommerceAPI.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Persistence
{
    public static class Registiration
    {
        public static void AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            // Presentation katmanında API içerisinde oluşturulan ve Development/Production tarafında tanımlanan defaultConnection değerini gösterdik
            services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));


        }
    }
}
