using System;
using System.Configuration;
using System.Net;
using System.Net.Mail;

namespace Core.Common
{
   public class EmailSender
    {
        public bool SendEmail(string pTo, string pSubject, string pBody, string cc = null, string attachement = null)
        {
            try
            {
                SmtpClient SmtpServer = new SmtpClient();
                MailMessage mail = new MailMessage();
                System.Text.StringBuilder mailbody = new System.Text.StringBuilder();


                SmtpServer.Port = 587;
                SmtpServer.Host = "smtp.office365.com";
                SmtpServer.Credentials = new NetworkCredential("smtp.office365.com\\registration@sun.edu.ng", "ReSUNdir$8989");
                SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
                SmtpServer.EnableSsl = true;


                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | (SecurityProtocolType)3072 | SecurityProtocolType.Tls | (SecurityProtocolType)0x00000C00;

                mail.From = new MailAddress("registration@sun.edu.ng", "SUN");
                mail.To.Add(pTo);
                mail.Subject = pSubject;
                if (cc != null)
                {
                    var ccs = cc.Split(',');
                    foreach (var ccc in ccs)
                    {
                        mail.Bcc.Add(ccc);
                    }
                }
                mail.IsBodyHtml = true;
                mailbody.Append(pBody);
                mail.Body = mailbody.ToString();
                if (attachement != null)
                {
                    mail.Attachments.Add(new Attachment(attachement));
                    // mail.Attachments.Dispose(); 
                }
                try
                {
                    SmtpServer.Send(mail);
                }
                catch (SmtpFailedRecipientsException ex)
                {
                    for (int i = 0; i < ex.InnerExceptions.Length; i++)
                    {
                        SmtpStatusCode status = ex.InnerExceptions[i].StatusCode;
                        if (status == SmtpStatusCode.MailboxBusy ||
                            status == SmtpStatusCode.MailboxUnavailable)
                        {
                            //Delivery failed - retrying in 5 seconds.
                            System.Threading.Thread.Sleep(5000);
                            SmtpServer.Send(mail);
                        }
                        else
                        {
                            Console.WriteLine("Failed to deliver message to {0}",
                                ex.InnerExceptions[i].FailedRecipient);

                            //var data = new Admin_ErrorLogVM
                            //{
                            //    affectedUser = "",
                            //    errorType = "",
                            //    errorMessage = ex.Message,
                            //    controllerName = "",
                            //    methodName = "",
                            //    action = "",
                            //    description = "",
                            //    tenantId = 1
                            //};

                            // var resp =  _wrapper.Admin_ErrorLog.CreateAdmin_ErrorLogAsync(data);
                        }
                    }
                    return false;
                }
                catch (Exception ex)
                {
                    //var data = new Admin_ErrorLogVM
                    //{
                    //    affectedUser = "",
                    //    errorType = "",
                    //    errorMessage = ex.Message,
                    //    controllerName = "",
                    //    methodName = "",
                    //    action = "",
                    //    description = "",
                    //    tenantId = 1
                    //};

                    // var resp =  _wrapper.Admin_ErrorLog.CreateAdmin_ErrorLogAsync(data);
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                //var data = new Admin_ErrorLogVM
                //{
                //    affectedUser = "",
                //    errorType = "",
                //    errorMessage = ex.Message,
                //    controllerName = "",
                //    methodName = "",
                //    action = "",
                //    description = "",
                //    tenantId = 1
                //};

                // var resp =  _wrapper.Admin_ErrorLog.CreateAdmin_ErrorLogAsync(data);

                return false;
            }
        }
    }
}
