using Biryukovv_Maskem_KT_41_21.Interfaces;

namespace Biryukovv_Maskem_KT_41_21.ServiceExtensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IStudentService, StudentService>();

            return services;
        }
    }
}
