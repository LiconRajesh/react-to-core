using System.Threading.Tasks;

namespace Core_To_React_Api.Core.Interfaces
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string to, string from, string subject, string body);
    }
}
