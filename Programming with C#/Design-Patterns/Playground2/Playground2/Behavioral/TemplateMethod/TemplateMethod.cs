using System;

namespace Playground2.Behavioral.TemplateMethod
{
    public static class TemplateMethod
    {
        public static void Run()
        {
            EmailSenderBase emailSender =
                new YahooEmailSender("admin@yahoo.com", "admin@telerik.com", "Sup, guys?");
            //// new GoogleEmailSender(...)
            var sendEmailResult = emailSender.SendEmail();
            Console.WriteLine("Result: {0}", sendEmailResult ? "Success" : "Fail");
        }
    }
}
