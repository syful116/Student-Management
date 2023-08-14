using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StudentManagement.Core.Mapper;
using StudentManagement.Infrustructure;
using AutoMapper;
using MediatR;
using StudentManagement.Repositories.Interface;
using StudentManagement.Repositories.Base;
using System.Reflection;
using StudentManagement.Core;

namespace StudentManagement.Ioc.Configuration;

public static class ConfigurationServices
{
    public static IServiceCollection AddExtention(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<StudentManagementDbContext>(options =>
        options.UseSqlServer(configuration.GetConnectionString("DbConnection")));
        services.AddAutoMapper(typeof(CommonMapper).Assembly);
        services.AddTransient<IStudentRepository,StudentRepository>();
        services.AddTransient<ITeacherRepository,TeacherRepository>();

        services.AddMediatR(options=>options.RegisterServicesFromAssemblies(typeof(ICor).Assembly));
      // services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
        //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));
    

        return services;
    }

    



}
