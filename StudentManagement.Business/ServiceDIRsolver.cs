using Microsoft.Extensions.DependencyInjection;
using StudentManagement.Business.Interfaces;
using StudentManagement.Business.Services;
using StudentManagement.DataAccess;

namespace StudentManagement.Business
{
    public static class ServiceDIRsolver
    {
        public static IServiceCollection AddServiceResolver(this IServiceCollection serviceCollection)
        {
            serviceCollection
           .AddRepositoryResolver()
           .AddSingleton<IStudentService, StudentService>()
           .AddSingleton<IUserService, UserService>()
           .AddSingleton<ISchoolClassService, SchoolClassService>();

            return serviceCollection;
        }
    }
}