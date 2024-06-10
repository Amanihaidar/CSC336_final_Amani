using CSC336_final_Amani.Filter;

namespace CSC336_final_Amani.Extention
{
    public static class ExceptExtention
    { 
        public static IServiceCollection AddException(this IServiceCollection services)
    {
        services.AddControllers(options =>
        {
            options.Filters.Add(new GlobalExceptionFilter());
        });
        return services;
    }

}
}
