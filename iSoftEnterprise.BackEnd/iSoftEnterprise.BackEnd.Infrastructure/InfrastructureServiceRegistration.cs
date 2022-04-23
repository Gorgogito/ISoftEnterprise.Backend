using iSoftEnterprise.BackEnd.Infrastructure.Persistence;
using iSoftEnterprise.BackEnd.Infrastructure.Repositories;
using iSoftEnterpriseBackEnd.Application.Contracts.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSoftEnterprise.BackEnd.Infrastructure
{
  public static class InfrastructureServiceRegistration
  {
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {

      services.AddDbContext<ManagerDbContext>(options =>
          options.UseSqlServer(configuration.GetConnectionString("ConnectionString"))
      );

      services.AddDbContext<SecurityDbContext>(options =>
          options.UseSqlServer(configuration.GetConnectionString("ConnectionString"))
      );

      services.AddDbContext<EnterpriseDbContext>(options =>
          options.UseSqlServer(configuration.GetConnectionString("ConnectionString"))
      );

      services.AddScoped<IUnitOfWork, ManagerUnitOfWork>();
      services.AddScoped(typeof(IAsyncRepository<>), typeof(ManagerRepositoryBase<>));

      services.AddScoped<IUnitOfWork, SecurityUnitOfWork>();
      services.AddScoped(typeof(IAsyncRepository<>), typeof(SecurityRepositoryBase<>));

      services.AddScoped<IUnitOfWork, EnterpriseUnitOfWork>();
      services.AddScoped(typeof(IAsyncRepository<>), typeof(EnterpriseRepositoryBase<>));

      return services;
    }

  }

}
