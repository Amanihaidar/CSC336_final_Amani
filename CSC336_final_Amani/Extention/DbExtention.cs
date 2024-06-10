using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace CSC336_final_Amani.Extention
{
    public static class DbExtention
    {
        public static IServiceCollection addDb(this IServiceCollection service, ConfigurationManager config)
        {
            var ConnectionString = config.GetConnectionString("DefaultConnection");

            service.AddDbContext<AirplaneSystemContext>(options =>
                                options.UseSqlServer(ConnectionString)
                                );
            return service;
        }
    }
}
