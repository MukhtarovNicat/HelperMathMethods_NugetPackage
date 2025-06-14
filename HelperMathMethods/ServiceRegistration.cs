using HelperMathMethods.Servives.MathMetods;
using Microsoft.Extensions.DependencyInjection;

namespace HelperMathMethods;

public static class ServiceRegistration
{
    public static IServiceCollection AddMathService(this IServiceCollection services)
    {
        services.AddScoped<IMathMethodsService, MathMetodsService>();
        return services;
    }
}
