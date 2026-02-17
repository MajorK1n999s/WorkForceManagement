using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WFM.Infrastructure.Persistence.Context;
using WFM.Application.Interfaces.Repositories;
using WFM.Infrastructure.Repositories;

namespace WFM.Infrastructure.DependencyInjection
{
    // This class will register infrastructure services later
    public static class ServiceRegistration
    {
        public static IServiceCollection AddInfrastructure( this IServiceCollection services, 
            IConfiguration configuration)
        {

            // Register Dbcontext with PostgresSQL

            services.AddDbContext<WfmDbContext>(options => 
                         options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

            // Register Repositories
            services.AddScoped<IEmployeeRepository , EmployeeRepository>();
            services.AddScoped<TaskRepository>();
            services.AddScoped<AttendanceRepository>();


            return services;
        }
    }
}
