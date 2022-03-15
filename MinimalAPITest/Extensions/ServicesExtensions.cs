using MinimalAPITest.Model;

namespace MinimalAPITest.Extensions
{
    public static class ServicesExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IToDoItemRepository, ToDoItemRepository>();

            return services;
        }
    }
}
