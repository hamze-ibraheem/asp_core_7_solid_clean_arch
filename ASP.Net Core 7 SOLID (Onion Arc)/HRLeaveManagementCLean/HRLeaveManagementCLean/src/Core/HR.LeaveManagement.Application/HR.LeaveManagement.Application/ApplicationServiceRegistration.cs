
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using MediatR;
using AutoMapper;


namespace HR.LeaveManagement.Application;

public static class ApplicationServiceRegistration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(  Assembly.GetExecutingAssembly());
        return services;
    }
}
