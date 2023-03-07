using CI.Entity.Data;
using CI.Entity.Models;
using CI.Repositories.Interface;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;
using System.Net.Mail;
namespace CI.Repositories.IRepository
{
    public class UserRepository : IUser
    {

        public readonly DatabasewithDataContext _db;

        public UserRepository(DatabasewithDataContext db)
        {
            _db = db;
        }

        public User Index(User obj)
        {
            var user = _db.Users.FirstOrDefault(x => x.Email == obj.Email && x.Password == obj.Password);
            return user;

        }

        public User ForgotPassword(User obj)
        {
            var user = _db.Users.FirstOrDefault(x => x.Email.Equals(obj.Email.ToLower()));

            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[16];
            var random = new Random();
            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            var finalString = new String(stringChars);
            //#endregion Genrate Token

            //#region Update Password Reset Table
            PasswordReset entry = new PasswordReset();
            entry.Email = obj.Email;
            entry.Token = finalString;
            _db.PasswordResets.Add(entry);
            _db.SaveChanges();
            //#endregion Update Password Reset Table

            //#region Send Mail
            var mailBody = "<h1>Click link to reset password</h1><br><h2><a href='" + "https://localhost:7287/User/ResetPassword?token=" + finalString + "'>Reset Password</a></h2>";

            // create email message
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse("harshpatel1811197425@gmail.com"));
            email.To.Add(MailboxAddress.Parse(user.Email));
            email.Subject = "Reset Your Password";
            email.Body = new TextPart(TextFormat.Html) { Text = mailBody };

            // send email
            using var smtp = new SmtpClient();
            smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate("harshpatel1811197425@gmail.com", "ewxyauwzyfbcarlt");
            smtp.Send(email);
            smtp.Disconnect(true);


            return user;




        }

        public PasswordReset ResetPassword(User obj, String token)
        {
            var validToken = _db.PasswordResets.FirstOrDefault(x => x.Token == token);
            if (validToken != null)
            {
                var user = _db.Users.FirstOrDefault(x => x.Email == validToken.Email);
                user.Password = obj.Password;
                _db.Users.Update(user);
                _db.SaveChanges();

            }
            return validToken;

        }

        public User Register(User obj)
        {
            var user = _db.Users.FirstOrDefault(u => u.Email == obj.Email);
            if (user == null)
            {
                _db.Users.Add(obj);
                _db.SaveChanges();
            }


            return user;
        }
    }
}