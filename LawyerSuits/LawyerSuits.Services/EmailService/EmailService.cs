﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LawyerSuits.Services.EmailService
{
    public class EmailService : IEmailService
    {
        public Task SendEmailAsync(string ToEmail, string FromName, string Subject, string Message)
        {
            throw new NotImplementedException();
        }
    }
}
