namespace FlexBazaar.Infrastructure;
public static class DependencyInjection
{
    public static IServiceCollection ConfigureInfrastructureLayer(this IServiceCollection services, IConfiguration configuration)
    {
        // Inject here e.g.
        // EmailSettings & Services
        // DBContext
        // Repositories

        return services;
    }
}