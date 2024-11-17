using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.IO;
using System.Net.Mail;
using System.Text;
using System.Threading;
using MimeKit;

namespace WasteNoMoreUI.Models
{
    internal class GmailServiceAPI
    {
        private static readonly string[] Scopes = { GmailService.Scope.GmailSend };
        private static readonly string ApplicationName = "WasteNoMore";

        public static GmailService GetGmailService()
        {
            UserCredential credential;
            using (var stream = new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
            }

            return new GmailService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
        }

        public static void SendEmail(string to, string subject, string body)
        {
            var gmailService = GetGmailService();

            var email = new MimeMessage();
            email.From.Add(new MimeKit.MailboxAddress("WasteNoMore", "wastenomoreapp@gmail.com"));
            email.To.Add(MimeKit.MailboxAddress.Parse(to));
            email.Subject = subject;
            email.Body = new MimeKit.TextPart("plain")
            {
                Text = body
            };

            using (var memoryStream = new MemoryStream())
            {
                email.WriteTo(memoryStream);
                var rawMessage = Convert.ToBase64String(memoryStream.ToArray())
                                    .Replace('+', '-')
                                    .Replace('/', '_')
                                    .Replace("=", "");

                // Perbaiki referensi Message untuk menghindari ambiguitas
                Google.Apis.Gmail.v1.Data.Message message = new Google.Apis.Gmail.v1.Data.Message
                {
                    Raw = rawMessage
                };

                gmailService.Users.Messages.Send(message, "me").Execute();
            }
        }
    }
}
