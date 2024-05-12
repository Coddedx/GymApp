using GymApp.Web.Models;
using Microsoft.AspNetCore.Http;
using System.Net;
using System.Net.Mail;

namespace Fitness.Web.Helpers
{
    public static class MailSender //new ile çağırmamak için static
    {
        private const string senderMail = "rumeysa_cetinkaya@outlook.com";
        private const string senderPassword = "Jb4e6je4-0";
        //smtp -> simple mail transfer protocol
        public static void SendMail(string fullname, List<string> mailAddresses) //tek tek gönderceksek list kullanmıyoruz for a da gerek kalmıyo
        {
            try
            {
                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress(senderMail);

                for (int i = 0; i < mailAddresses.Count; i++)
                {
                    mailMessage.To.Add(mailAddresses[i]);
                }

                string body = "";

                mailMessage.Subject = "Hoş geldiniz";
                mailMessage.Body = $"Merhaba {fullname},<h1> \n Sitemize Hoşgeldinzş"; //html tasarımını koyabiliriz style ag içine alıyoruz yol vermiyoruz
                mailMessage.IsBodyHtml = true;

                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Host = "smtp-mail.outlook.com";
                smtpClient.Port = 587;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(senderMail, senderPassword);
                smtpClient.EnableSsl = true;

                smtpClient.Send(mailMessage);
                Console.WriteLine("Email Sent Successfully.");


            }
            catch (Exception ex)
            {

                Console.WriteLine("Error" + ex.Message);
            }

        }

        public static void SendMailContact(string FirstName, string LastName, string mailAddresses) 
        {
            try
            {
                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress(senderMail);

                mailMessage.To.Add(mailAddresses);
              

                string body = "";

                mailMessage.Subject = "Hoş geldiniz";
                mailMessage.Body = $"Merhaba {FirstName}{LastName},<h1> \n Sitemize Hoşgeldinzş"; 
                mailMessage.IsBodyHtml = true;

                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Host = "smtp-mail.outlook.com";
                smtpClient.Port = 587;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(senderMail, senderPassword);
                smtpClient.EnableSsl = true;

                smtpClient.Send(mailMessage);
                Console.WriteLine("Email Sent Successfully.");


            }
            catch (Exception ex)
            {

                Console.WriteLine("Error" + ex.Message);
            }

        }



        private static void ResetPassword(string fullname, string mailAddresses)//birden fazla kişi şifrsini sıfırlamaz 
        {


        }


        private async static Task HolidayMessage(string fullname,List<User>user, List<string> mailAddresses) //geriye parametre döndürcekse task
        {

            for (int i = 0; i < user.Count; i++)
            {
                try
                {
                    MailMessage mailMessage = new MailMessage();
                    mailMessage.From = new MailAddress(senderMail);

                    for (int j = 0; j < mailAddresses.Count; j++)
                    {
                        mailMessage.To.Add(mailAddresses[i]);
                    }

                    string body = "";

                    mailMessage.Subject = "Hoş geldiniz";
                    mailMessage.Body = $"Merhaba {fullname},<h1> \n Sitemize Hoşgeldinzş"; //html tasarımını koyabiliriz style  içine alıyoruz (body taginin üstüne style diye ekliyoduk ya oraya ) yol vermiyoruz o zaman da sadece = body deriz
                    mailMessage.IsBodyHtml = true;

                    SmtpClient smtpClient = new SmtpClient();
                    smtpClient.Host = "smtp-mail.outlook.com";
                    smtpClient.Port = 587;
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = new NetworkCredential(senderMail, senderPassword);
                    smtpClient.EnableSsl = true;

                    await smtpClient.SendMailAsync(mailMessage); //await bklenmicek işlem 
                    Console.WriteLine("Email Sent Successfully.");


                }
                catch (Exception ex)
                {

                    Console.WriteLine("Error" + ex.Message);
                }

            }
        }



    }
}
