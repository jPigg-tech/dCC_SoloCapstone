﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalorieTracker.Models
{
    using SendGrid;
    using SendGrid.Helpers.Mail;
    using System;
    using System.Threading.Tasks;

    namespace Example
    {
        internal class Example
        {
            //private void Main()
            //{
            //    Execute().Wait();
            //}

            public async Task Execute(string To)
            {
                var apiKey = "";
                var client = new SendGridClient(apiKey);
                var from = new EmailAddress("jeffpigg5@gmail.com", "Jeff Pigg");
                var subject = "Welcome To KnowCal";
                var to = new EmailAddress(To);
                var plainTextContent = "Thanks for subscribing to KnowCal's E-Mail subscription.";
                var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
                var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
                var response = await client.SendEmailAsync(msg);
            }
        }
    }
}