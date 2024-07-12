using MimeKit;
using System;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit.Security;

namespace YourProply.Services
{
    public class EmailService
    {
        private readonly string _smtpServer;
        private readonly int _smtpPort;
        private readonly string _username;
        private readonly string _password;

        public EmailService(string smtpServer, int smtpPort, string username, string password)
        {
            _smtpServer = smtpServer;
            _smtpPort = smtpPort;
            _username = username;
            _password = password;
        }

        /// <summary>
        /// Wysyła email asynchronicznie.
        /// </summary>
        public async Task SendEmailAsync(string to, string subject, string body)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("YourProply", _username));
            message.To.Add(new MailboxAddress("", to));
            message.Subject = subject;
            message.Body = new TextPart("plain") { Text = body };

            using (var client = new SmtpClient())
            {
                try
                {
                    await client.ConnectAsync(_smtpServer, _smtpPort, SecureSocketOptions.StartTls);
                    await client.AuthenticateAsync(_username, _password);
                    await client.SendAsync(message);
                    await client.DisconnectAsync(true);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Bład w wysłaniu: {ex.Message}");
                    Console.WriteLine($"SMTP Server: {_smtpServer}, Port: {_smtpPort}, Nazwa: {_username}, Hasło: {_password}");
                    throw new InvalidOperationException("Bład w wysłaniu w EmailService", ex);
                }
            }
        }
    }
}
