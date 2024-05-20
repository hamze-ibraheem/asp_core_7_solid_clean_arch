using HR.LeaveManagement.Application.Contracts.Email;
using HR.LeaveManagement.Application.Contracts.Logging;
using HR.LeaveManagement.Application.Models.Email;
using HR.LeaveManagment.Infrastructure.EmailService;
using HR.LeaveManagment.Infrastructure.Logging;

namespace HR.LeaveManagment.Infrastructure;

public static class InfrastructureServicesRegistration
{
    public static IServiceCollection InfrastructureSeArvicesRegistration(this IServiceCollection  services, IConfiguration configuration )
    {
        services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));
        services.AddTransient<IEmailSender, EmailSender>();
        services.AddScoped(typeof(IAppLogger<>),typeof(LoggerAdapter<>));
        return services;
    }
}
