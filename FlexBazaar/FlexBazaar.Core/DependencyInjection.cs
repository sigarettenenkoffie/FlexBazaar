using FlexBazaar.Core;
using Microsoft.Extensions.Configuration;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace FlexBazaar.Core;
public static class DependencyInjection
{
    public static IServiceCollection ConfigureCoreLayer(this IServiceCollection services, IConfiguration configuration)
    {
        // Inject services here
        //services.AddTransient<IArticleService, ArticleService>();

        var application = typeof(IAssemblyMarker);

        services.AddMediatR(configure =>
        {
            configure.RegisterServicesFromAssembly(application.Assembly);
        });


        return services;
    }
}