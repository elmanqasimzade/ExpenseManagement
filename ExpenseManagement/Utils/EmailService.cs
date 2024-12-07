using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManagement.Utils
{
    public class EmailService
    {
        public static void SendExpenseEmail(IEnumerable<Expense> expenses)
        {
            try
            {
                var jsonData = JsonConvert.SerializeObject(expenses, Formatting.Indented);

                var mailMessage = new MailMessage
                {
                    From = new MailAddress("elmanqasimzade05@gmail.com"),
                    Subject = "Today's Expenses Report",
                    Body = $"Today's expenses are:\n{jsonData}",
                    IsBodyHtml = false
                };

                mailMessage.To.Add("elmanqasimzade24@gmail.com");

                var smtpClient = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential("elmanqasimzade05@gmail.com", "default wtps ysmt"),
                    EnableSsl = true
                };

                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
            }
        }
    }
}
