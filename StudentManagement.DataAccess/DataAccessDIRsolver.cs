using Microsoft.Extensions.DependencyInjection;
using StudentManagement.DataAccess.Interfaces;
using StudentManagement.DataAccess.Repositories;

namespace StudentManagement.DataAccess
{
    public static class DataAccessDIRsolver
    {
        public static IServiceCollection AddRepositoryResolver(this IServiceCollection serviceCollection)
        {
            serviceCollection
           .AddSingleton<IParentStudentRepository, ParentStudentRepository>()
           .AddSingleton<IUserRepository, UserRepository>()
           .AddSingleton<ISchoolClassRepository, SchoolClassRepository>();

            return serviceCollection;
        }
    }
}