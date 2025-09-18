using Finbuckle.MultiTenant;
using GbabtechSchool.Infrastructure.Tenancy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GbabtechSchool.Infrastructure;

public static class InfrastructureServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<TenantDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        services.AddMultiTenant<GbabtechSchoolTenantInfo>()
            .WithHeaderStrategy("tenant")
            .WithClaimStrategy("tenant")
            .WithEFCoreStore<TenantDbContext, GbabtechSchoolTenantInfo>();
        return services;
    }
}
