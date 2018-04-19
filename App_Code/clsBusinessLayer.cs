﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;

/// <summary>
/// Summary description for csBusinessLayer
/// </summary>
public class clsBusinessLayer
{
    public clsBusinessLayer()
    {
        //
        // TODO: Add constructor logic here
        //
    }//end csBusinessLayer constructer

    //**** Add the following code inside the body of public class clsBusinessLayer ****
    public static bool SendEmail(string Sender, string Recipient, string bcc, string cc,
    string Subject, string Body)
    {
        try
        {
            // Add your comments here
            MailMessage MyMailMessage = new MailMessage();
            // Add your comments here
            MyMailMessage.From = new MailAddress(Sender);
            // Add your comments here
            MyMailMessage.To.Add(new MailAddress(Recipient));
            // Add your comments here
            if (bcc != null && bcc != string.Empty)
            {
                // Add your comments here
                MyMailMessage.Bcc.Add(new MailAddress(bcc));
            }
            // Add your comments here
            if (cc != null && cc != string.Empty)
            {
                // Add your comments here
                MyMailMessage.CC.Add(new MailAddress(cc));
            }
            // Add your comments here
            MyMailMessage.Subject = Subject;
            // Add your comments here
            MyMailMessage.Body = Body;
            // Add your comments here
            MyMailMessage.IsBodyHtml = true;
            // Add your comments here
            MyMailMessage.Priority = MailPriority.Normal;
            // Add your comments here
            SmtpClient MySmtpClient = new SmtpClient("localhost");
            //SMTP Port = 25;
            //Generic IP host = "127.0.0.1";
            // Add your comments here
            MySmtpClient.Send(MyMailMessage);
            // Add your comments here
            return true;
        }
        catch (Exception ex)
        {
            // Add your comments here
            return false;
        }
    }

}//end csBusinessLayer Class