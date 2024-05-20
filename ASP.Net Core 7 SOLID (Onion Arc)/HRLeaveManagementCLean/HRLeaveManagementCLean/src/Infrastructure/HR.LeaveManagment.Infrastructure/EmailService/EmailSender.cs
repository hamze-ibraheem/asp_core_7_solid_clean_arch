using System;
using HR.LeaveManagement.Application.Contracts.Email;
using HR.LeaveManagement.Application.Models.Email;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace HR.LeaveManagment.Infrastructure.EmailService
{
    public class EmailSender : IEmailSender
    {
        public EmailSettings _emailSettings { get; set; }

        public EmailSender(IOptions<EmailSettings> emailSettings)
        {
            _emailSettings = emailSettings.Value;
        }


        public async Task<bool> SendEmail(EmailMessage email)
        {
            var _client = new SendGridClient(_emailSettings.ApiKey);

            var To = new EmailAddress(email.To);

            var From = new EmailAddress
            {
                Email = _emailSettings.FromAddress,
                Name = _emailSettings.FromName,

            };

            var message = MailHelper.CreateSingleEmail(From, To, email.Subject, email.Body, email.Body);

            var response = await _client.SendEmailAsync(message);

            return response.IsSuccessStatusCode;
        }
    }
}

