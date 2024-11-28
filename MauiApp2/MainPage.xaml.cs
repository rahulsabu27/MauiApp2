using System.Net.Mail;
using System.Net;

namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            string from = "rahulsabu27sep@gmail.com";
            string pass = "rjjdpguackhljccb";
            string to = "sidharths31434@gmail.com";
            MailMessage message = new MailMessage();
            message.From = new MailAddress(from);
            message.Subject = "Test";
            message.To.Add(new MailAddress(to));
            message.Body = "Test";
            message.IsBodyHtml = false;
            var smt = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(from, pass)
                 ,
                EnableSsl = true,
            };
            smt.Send(message);
        }
    }

}
