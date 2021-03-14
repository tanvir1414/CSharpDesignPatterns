using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com._12basicconcepts
{
    interface IEmail
    {
        void SendEmail();
    }

    class OutlookEmail : IEmail
    {
        public void SendEmail()
        {
            Console.WriteLine("Send Outlook email");
        }
    }

    class WebServicesEmail : IEmail
    {
        public void SendEmail()
        {
            Console.WriteLine("Send WebServices email");
        }
    }
}
