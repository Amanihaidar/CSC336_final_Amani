using BLL.Mapping;

namespace CSC336_final_Amani.Extention
{
    public static class AutoMapperExtention
    {
        public static IServiceCollection AddAutoMapperConfig(this IServiceCollection service)
        {
            service.AddAutoMapper(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            }, typeof(Program));

            return service;
        }
    }
}
