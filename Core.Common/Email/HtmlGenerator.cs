using System;
using System.Collections.Generic;
namespace Core.Common.Email
{
    public static class HtmlGenerator
    {
       

        public static string NotificationForDisapproval( string name, string date)
        {
            string body = $@"
<html lang=""en"" xmlns=""http://www.w3.org/1999/xhtml"" xmlns:v=""urn:schemas-microsoft-com:vml"" xmlns:o=""urn:schemas-microsoft-com:office:office"">
<head>
    <title>
    </title>
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta http-equiv=""Content-Type"" content=""text/html; charset=UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
</head>
<body>
    <div>
        <table align='center' background='https://portalapi.maaun.edu.ng/logo.png' border='0' cellpadding='0' cellspacing='0' role='presentation' style='background:url(https://s3.amazonaws.com/swu-filepicker/4E687TRe69Ld95IDWyEg_bg_top_02.jpg) top center / auto repeat;width:100%;'>
            <tbody>
                <tr>
                    <td>

                        <div style='margin:0px auto;max-width:600px;'>
                            <div style='font-size:0;line-height:0;'>
                                <table align='center' border='0' cellpadding='0' cellspacing='0' role='presentation' style='width:100%;'>
                                    <tbody>
                                        <tr>
                                            <td style='direction:ltr;font-size:0px;padding:20px 0px 30px 0px;text-align:center;vertical-align:top;'>

                                                <div class='dys-column-per-100 outlook-group-fix' style='direction:ltr;display:inline-block;font-size:13px;text-align:left;vertical-align:top;width:100%;'>
                                                    <table border='0' cellpadding='0' cellspacing='0' role='presentation' width='100%'>
                                                        <tbody>
                                                            <tr>
                                                                <td style='padding:0px 20px;vertical-align:top;'>
                                                                    <table border='0' cellpadding='0' cellspacing='0' role='presentation' style='' width='100%'>
                                                                        <tr>
                                                                            <td align='left' style='font-size:0px;padding:0px;word-break:break-word;'>
                                                                                <table border='0' cellpadding='0' cellspacing='0' style='cellpadding:0;cellspacing:0;color:#000000;font-family:Helvetica, Arial, sans-serif;font-size:13px;line-height:22px;table-layout:auto;width:100%;' width='100%'>
                                                                                    <tr>
                                                                                        <td align='left'>
                                                                                            <a href='#'>
                                                                                                <img align='left' alt='Logo' height='37' padding='5px' src='https://portalapi.maaun.edu.ng/logo.png' width='37' />
                                                                                            </a>
                                                                                        </td>
                                                                                        <td align='right' style='vertical-align:bottom;' width='34px'>
                                                                                            <a href='#'>
                                                                                                <img alt='Twitter' height='22' src='https://s3.amazonaws.com/swu-cs-assets/OSET/social/Twitter_grey.png' width='22' />
                                                                                            </a>
                                                                                        </td>
                                                                                        <td align='right' style='vertical-align:bottom;' width='34px'>
                                                                                            <a href='#'>
                                                                                                <img alt='Facebook' height='22' src='https://swu-cs-assets.s3.amazonaws.com/OSET/social/f_grey.png' width='22' />
                                                                                            </a>
                                                                                        </td>
                                                                                        <td align='right' style='vertical-align:bottom;' width='34px'>
                                                                                            <a href='#'>
                                                                                                <img alt='Instagram' height='22' src='https://swu-cs-assets.s3.amazonaws.com/OSET/social/instagrey.png' width='22' />
                                                                                            </a>
                                                                                        </td>
                                                                                    </tr>
                                                                                </table>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                </td>
                                                            </tr>
                                                        </tbody>
                                                    </table>
                                                </div>
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </td>
                </tr>
            </tbody>
        </table>
        <table align='center' border='0' cellpadding='0' cellspacing='0' role='presentation' style='background:#f7f7f7;background-color:#f7f7f7;width:100%;'>
            <tbody>
                <tr>
                    <td>
                        <div style='margin:0px auto;max-width:600px;'>
                            <table align='center' border='0' cellpadding='0' cellspacing='0' role='presentation' style='width:100%;'>
                                <tbody>
                                    <tr>
                                        <td style='direction:ltr;font-size:0px;padding:20px 0;text-align:center;vertical-align:top;'>
                                            <div class='dys-column-per-100 outlook-group-fix' style='direction:ltr;display:inline-block;font-size:13px;text-align:left;vertical-align:top;width:100%;'>
                                                <table border='0' cellpadding='0' cellspacing='0' role='presentation' style='vertical-align:top;' width='100%'>
                                                    <tr>
                                                        <td align='center' style='font-size:0px;padding:10px 25px;word-break:break-word;'>
                                                            <div style='color:#292929;font-family:Oxygen, Helvetica neue, sans-serif;font-size:15px;line-height:21px;text-align:left;'>
                                                                Dear {name},
                                                            </div>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align='center' style='font-size:0px;padding:10px 25px;word-break:break-word;'>
                                                            <div style='color:#292929;font-family:Oxygen, Helvetica neue, sans-serif;font-size:15px;line-height:21px;text-align:left;'>
                                                                Greetings from Skyline University Nigeria!!
                                                            </div>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align='center' style='font-size:0px;padding:10px 25px;word-break:break-word;'>
                                                            <div style='color:#292929;font-family:Oxygen, Helvetica neue, sans-serif;font-size:15px;line-height:21px;text-align:left;'>
                                                                We thank you for applying for scholarship at Skyline University Nigeria. We hereby invite you to visit our Campus at Number 2, Zaria Road, Kano, on {date}.
                                                            </div>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align='center' style='font-size:0px;padding:10px 25px;word-break:break-word;'>
                                                            <div style='color:#292929;font-family:Oxygen, Helvetica neue, sans-serif;font-size:15px;line-height:21px;text-align:left;'>
                                                               Our able Admission Counsellors will advise you to apply for full self-sponsorship, and further guide you on the appropriate career path options offered by Skyline University Nigeria.
                                                            </div>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align='center' style='font-size:0px;padding:10px 25px;word-break:break-word;'>
                                                            <div style='color:#292929;font-family:Oxygen, Helvetica neue, sans-serif;font-size:15px;line-height:21px;text-align:left;'>
                                                               Wishing you all the best and looking forward for your visit at our campus.
                                                            </div>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </div>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </td>
                </tr>
            </tbody>
        </table>
        <table align='center' border='0' cellpadding='0' cellspacing='0' role='presentation' style='background:#f7f7f7;background-color:#f7f7f7;width:100%;'>
            <tbody>
                <tr>
                    <td>
                        <div style='margin:0px auto;max-width:600px;'>
                            <table align='center' border='0' cellpadding='0' cellspacing='0' role='presentation' style='width:100%;'>
                                <tbody>
                                    <tr>
                                        <td style='direction:ltr;font-size:0px;padding:20px 0;text-align:center;vertical-align:top;'>
                                            <div class='dys-column-per-100 outlook-group-fix' style='direction:ltr;display:inline-block;font-size:13px;text-align:left;vertical-align:top;width:100%;'>
                                                <table border='0' cellpadding='0' cellspacing='0' role='presentation' style='vertical-align:top;' width='100%'>
                                                     <tr>
                                                        <td align='center' style='font-size:0px;padding:5px 25px;word-break:break-word;'>
                                                            <div style='color:#292929;font-family:Oxygen, Helvetica neue, sans-serif;font-size:15px;font-style:bold;line-height:1;text-align:left;'>
                                                                Kind Regards,
                                                            </div>
                                                        </td>
                                                    </tr>           
                                                    <tr>
                                                        <td align='center' style='font-size:0px;padding:5px 25px;word-break:break-word;'>
                                                            <div style='color:#292929;font-family:Oxygen, Helvetica neue, sans-serif;font-size:15px;font-style:bold;line-height:1;text-align:left;'>
                                                                Admission Department,
                                                            </div>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align='center' style='font-size:0px;padding:5px 25px;word-break:break-word;'>
                                                            <div style='color:#292929;font-family:Oxygen, Helvetica neue, sans-serif;font-size:15px;font-style:bold;line-height:1;text-align:left;'>
                                                                Skyline University Nigeria
                                                            </div>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align='center' style='font-size:0px;padding:5px 25px;word-break:break-word;'>
                                                            <div style='color:#292929;font-family:Oxygen, Helvetica neue, sans-serif;font-size:15px;font-style:bold;line-height:1;text-align:left;'>
                                                                2, Zaria Road Kano.
                                                            </div>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align='center' style='font-size:0px;padding:5px 25px;word-break:break-word;'>
                                                            <div style='color:#292929;font-family:Oxygen, Helvetica neue, sans-serif;font-size:15px;font-style:bold;line-height:1;text-align:left;'>
                                                                Kano, Nigeria.
                                                            </div>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align='center' style='font-size:0px;padding:5px 25px;word-break:break-word;'>
                                                            <div style='color:#292929;font-family:Oxygen, Helvetica neue, sans-serif;font-size:15px;font-style:bold;line-height:1;text-align:left;'>
                                                                Mobile: +2348181111113, +2348099000770
                                                            </div>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </div>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </td>
                </tr>
            </tbody>
        </table>
        <table align='center' border='0' cellpadding='0' cellspacing='0' role='presentation' style='background:#16173b;background-color:#16173b;width:100%;'>
            <tbody>
                <tr>
                    <td>
                        <div style='margin:0px auto;max-width:600px;'>
                            <table align='center' border='0' cellpadding='0' cellspacing='0' role='presentation' style='width:100%;'>
                                <tbody>
                                    <tr>
                                        <td style='direction:ltr;font-size:0px;padding:50px;text-align:center;vertical-align:top;'>
                                            <div class='dys-column-per-100 outlook-group-fix' style='direction:ltr;display:inline-block;font-size:13px;text-align:left;vertical-align:top;width:100%;'>
                                                <table border='0' cellpadding='0' cellspacing='0' role='presentation' style='vertical-align:top;' width='100%'>
                                                    <tr>
                                                        <td align='left' style='font-size:0px;padding:0px;word-break:break-word;'>
                                                            <table border='0' cellpadding='0' cellspacing='0' style='cellpadding:0;cellspacing:0;color:#000000;font-family:Helvetica, Arial, sans-serif;font-size:13px;line-height:22px;table-layout:auto;width:100%;' width='100%'>
                                                                <tr>
                                                                    <td align='left'>
                                                                        <div style='color:white;font-family:Helvetica, Arial, sans-serif;font-size:12px;line-height:28px;text-align:left;'>
                                                                            <p>
                                                                                <a href='https://www.sun.edu.edu.ng' target=""_blank"" style='color: #666;'>
                                                                                <h3>Skyline University Nigeria </h3> 
                                                                                </a>
                                                                                <br />
                                                                                2, Zaria Road Kano.
                                                                                <br />
                                                                                 Mobile: +2348181111113, +2348099000770
                                                                            </p>
                                                                        </div>
                                                                    </td>
                                                                    <td align='right' style='vertical-align:top; opacity: 0.35;' width='34px'>
                                                                        <table border='0' cellpadding='0' cellspacing='0' role='presentation' style='border-collapse:collapse;border-spacing:0px;'>
                                                                            <tbody>
                                                                                <tr>
                                                                                    <td style='width:30px;'>
                                                                                        <img alt='Facebook' height='auto' src='https://assets.opensourceemails.com/imgs/lifestyle/Fct0c2xMRUKPHBdMCcnf_icon-facebook.png' style='border:none;display:block;font-size:13px;height:auto;outline:none;text-decoration:none;width:100%;' width='30' />
                                                                                    </td>
                                                                                </tr>
                                                                            </tbody>
                                                                        </table>
                                                                    </td>
                                                                    <td align='right' style='vertical-align:top; opacity: 0.35;' width='34px'>
                                                                        <table border='0' cellpadding='0' cellspacing='0' role='presentation' style='border-collapse:collapse;border-spacing:0px;'>
                                                                            <tbody>
                                                                                <tr>
                                                                                    <td style='width:30px;'>
                                                                                        <img alt='Linked In' height='auto' src='https://assets.opensourceemails.com/imgs/lifestyle/BHraIlyShi7koHdeMEbD_icon-linkedin.png' style='border:none;display:block;font-size:13px;height:auto;outline:none;text-decoration:none;width:100%;' width='30' />
                                                                                    </td>
                                                                                </tr>
                                                                            </tbody>
                                                                        </table>
                                                                    </td>
                                                                    <td align='right' style='vertical-align:top; opacity: 0.35;' width='34px'>
                                                                        <table border='0' cellpadding='0' cellspacing='0' role='presentation' style='border-collapse:collapse;border-spacing:0px;'>
                                                                            <tbody>
                                                                                <tr>
                                                                                    <td style='width:30px;'>
                                                                                        <img alt='Twitter' height='auto' src='https://assets.opensourceemails.com/imgs/lifestyle/Rc7jq7J2ToyH0IGSptTY_icon-twitter.png' style='border:none;display:block;font-size:13px;height:auto;outline:none;text-decoration:none;width:100%;' width='30' />
                                                                                    </td>
                                                                                </tr>
                                                                            </tbody>
                                                                        </table>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </div>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
</body>
</html>";
            return body;
        }

        public static string ExamScheduleMail(string name, string date)
        {
            string body = $@"
<html lang=""en"" xmlns=""http://www.w3.org/1999/xhtml"" xmlns:v=""urn:schemas-microsoft-com:vml"" xmlns:o=""urn:schemas-microsoft-com:office:office"">
<head>
    <title>
    </title>
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta http-equiv=""Content-Type"" content=""text/html; charset=UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
</head>
<body>
    <div>
        <table align='center' background='https://portalapi.maaun.edu.ng/logo.png' border='0' cellpadding='0' cellspacing='0' role='presentation' style='background:url(https://s3.amazonaws.com/swu-filepicker/4E687TRe69Ld95IDWyEg_bg_top_02.jpg) top center / auto repeat;width:100%;'>
            <tbody>
                <tr>
                    <td>

                        <div style='margin:0px auto;max-width:600px;'>
                            <div style='font-size:0;line-height:0;'>
                                <table align='center' border='0' cellpadding='0' cellspacing='0' role='presentation' style='width:100%;'>
                                    <tbody>
                                        <tr>
                                            <td style='direction:ltr;font-size:0px;padding:20px 0px 30px 0px;text-align:center;vertical-align:top;'>

                                                <div class='dys-column-per-100 outlook-group-fix' style='direction:ltr;display:inline-block;font-size:13px;text-align:left;vertical-align:top;width:100%;'>
                                                    <table border='0' cellpadding='0' cellspacing='0' role='presentation' width='100%'>
                                                        <tbody>
                                                            <tr>
                                                                <td style='padding:0px 20px;vertical-align:top;'>
                                                                    <table border='0' cellpadding='0' cellspacing='0' role='presentation' style='' width='100%'>
                                                                        <tr>
                                                                            <td align='left' style='font-size:0px;padding:0px;word-break:break-word;'>
                                                                                <table border='0' cellpadding='0' cellspacing='0' style='cellpadding:0;cellspacing:0;color:#000000;font-family:Helvetica, Arial, sans-serif;font-size:13px;line-height:22px;table-layout:auto;width:100%;' width='100%'>
                                                                                    <tr>
                                                                                        <td align='left'>
                                                                                            <a href='#'>
                                                                                                <img align='left' alt='Logo' height='37' padding='5px' src='https://portalapi.maaun.edu.ng/logo.png' width='37' />
                                                                                            </a>
                                                                                        </td>
                                                                                        <td align='right' style='vertical-align:bottom;' width='34px'>
                                                                                            <a href='#'>
                                                                                                <img alt='Twitter' height='22' src='https://s3.amazonaws.com/swu-cs-assets/OSET/social/Twitter_grey.png' width='22' />
                                                                                            </a>
                                                                                        </td>
                                                                                        <td align='right' style='vertical-align:bottom;' width='34px'>
                                                                                            <a href='#'>
                                                                                                <img alt='Facebook' height='22' src='https://swu-cs-assets.s3.amazonaws.com/OSET/social/f_grey.png' width='22' />
                                                                                            </a>
                                                                                        </td>
                                                                                        <td align='right' style='vertical-align:bottom;' width='34px'>
                                                                                            <a href='#'>
                                                                                                <img alt='Instagram' height='22' src='https://swu-cs-assets.s3.amazonaws.com/OSET/social/instagrey.png' width='22' />
                                                                                            </a>
                                                                                        </td>
                                                                                    </tr>
                                                                                </table>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                </td>
                                                            </tr>
                                                        </tbody>
                                                    </table>
                                                </div>
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </td>
                </tr>
            </tbody>
        </table>
        <table align='center' border='0' cellpadding='0' cellspacing='0' role='presentation' style='background:#f7f7f7;background-color:#f7f7f7;width:100%;'>
            <tbody>
                <tr>
                    <td>
                        <div style='margin:0px auto;max-width:600px;'>
                            <table align='center' border='0' cellpadding='0' cellspacing='0' role='presentation' style='width:100%;'>
                                <tbody>
                                    <tr>
                                        <td style='direction:ltr;font-size:0px;padding:20px 0;text-align:center;vertical-align:top;'>
                                            <div class='dys-column-per-100 outlook-group-fix' style='direction:ltr;display:inline-block;font-size:13px;text-align:left;vertical-align:top;width:100%;'>
                                                <table border='0' cellpadding='0' cellspacing='0' role='presentation' style='vertical-align:top;' width='100%'>
                                                    <tr>
                                                        <td align='center' style='font-size:0px;padding:10px 25px;word-break:break-word;'>
                                                            <div style='color:#292929;font-family:Oxygen, Helvetica neue, sans-serif;font-size:15px;line-height:21px;text-align:left;'>
                                                                Dear {name},
                                                            </div>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align='center' style='font-size:0px;padding:10px 25px;word-break:break-word;'>
                                                            <div style='color:#292929;font-family:Oxygen, Helvetica neue, sans-serif;font-size:15px;line-height:21px;text-align:left;'>
                                                                Congratulations!!!
                                                            </div>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align='center' style='font-size:0px;padding:10px 25px;word-break:break-word;'>
                                                            <div style='color:#292929;font-family:Oxygen, Helvetica neue, sans-serif;font-size:15px;line-height:21px;text-align:left;'>
                                                                You have been shortlisted to participate in the Merit-based entrance examination. We are pleased to inform you that the scholarship entrance examination is scheduled to take place at Skyline University Nigeria, Number 2, Zaria Road, Kano, on {date}.The examination will start by 11:00 am till 2:00 pm.  We advise you to come an hour earlier with your hall ticket, a valid ID card for verification and registration processes on campus.
                                                            </div>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align='center' style='font-size:0px;padding:10px 25px;word-break:break-word;'>
                                                            <div style='color:#292929;font-family:Oxygen, Helvetica neue, sans-serif;font-size:15px;line-height:21px;text-align:left;'>
                                                               Once more, we want to use this opportunity to wish you all the best in your examination.
                                                            </div>
                                                        </td>
                                                       
                                                    </tr>
                                                </table>
                                            </div>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </td>
                </tr>
            </tbody>
        </table>
         <table align='center' border='0' cellpadding='0' cellspacing='0' role='presentation' style='background:#f7f7f7;background-color:#f7f7f7;width:100%;'>
            <tbody>
                <tr>
                    <td>
                        <div style='margin:0px auto;max-width:600px;'>
                            <table align='center' border='0' cellpadding='0' cellspacing='0' role='presentation' style='width:100%;'>
                                <tbody>
                                    <tr>
                                        <td style='direction:ltr;font-size:0px;padding:20px 0;text-align:center;vertical-align:top;'>
                                            <div class='dys-column-per-100 outlook-group-fix' style='direction:ltr;display:inline-block;font-size:13px;text-align:left;vertical-align:top;width:100%;'>
                                                <table border='0' cellpadding='0' cellspacing='0' role='presentation' style='vertical-align:top;' width='100%'>
                                                     <tr>
                                                        <td align='center' style='font-size:0px;padding:5px 25px;word-break:break-word;'>
                                                            <div style='color:#292929;font-family:Oxygen, Helvetica neue, sans-serif;font-size:15px;font-style:bold;line-height:1;text-align:left;'>
                                                                Kind Regards,
                                                            </div>
                                                        </td>
                                                    </tr>           
                                                    <tr>
                                                        <td align='center' style='font-size:0px;padding:5px 25px;word-break:break-word;'>
                                                            <div style='color:#292929;font-family:Oxygen, Helvetica neue, sans-serif;font-size:15px;font-style:bold;line-height:1;text-align:left;'>
                                                                Admission Department,
                                                            </div>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align='center' style='font-size:0px;padding:5px 25px;word-break:break-word;'>
                                                            <div style='color:#292929;font-family:Oxygen, Helvetica neue, sans-serif;font-size:15px;font-style:bold;line-height:1;text-align:left;'>
                                                                Skyline University Nigeria
                                                            </div>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align='center' style='font-size:0px;padding:5px 25px;word-break:break-word;'>
                                                            <div style='color:#292929;font-family:Oxygen, Helvetica neue, sans-serif;font-size:15px;font-style:bold;line-height:1;text-align:left;'>
                                                                2, Zaria Road Kano.
                                                            </div>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align='center' style='font-size:0px;padding:5px 25px;word-break:break-word;'>
                                                            <div style='color:#292929;font-family:Oxygen, Helvetica neue, sans-serif;font-size:15px;font-style:bold;line-height:1;text-align:left;'>
                                                                Kano, Nigeria.
                                                            </div>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align='center' style='font-size:0px;padding:5px 25px;word-break:break-word;'>
                                                            <div style='color:#292929;font-family:Oxygen, Helvetica neue, sans-serif;font-size:15px;font-style:bold;line-height:1;text-align:left;'>
                                                                Mobile: +2348181111113, +2348099000770
                                                            </div>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </div>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </td>
                </tr>
            </tbody>
        </table>
        <table align='center' border='0' cellpadding='0' cellspacing='0' role='presentation' style='background:#16173b;background-color:#16173b;width:100%;'>
            <tbody>
                <tr>
                    <td>
                        <div style='margin:0px auto;max-width:600px;'>
                            <table align='center' border='0' cellpadding='0' cellspacing='0' role='presentation' style='width:100%;'>
                                <tbody>
                                    <tr>
                                        <td style='direction:ltr;font-size:0px;padding:50px;text-align:center;vertical-align:top;'>
                                            <div class='dys-column-per-100 outlook-group-fix' style='direction:ltr;display:inline-block;font-size:13px;text-align:left;vertical-align:top;width:100%;'>
                                                <table border='0' cellpadding='0' cellspacing='0' role='presentation' style='vertical-align:top;' width='100%'>
                                                    <tr>
                                                        <td align='left' style='font-size:0px;padding:0px;word-break:break-word;'>
                                                            <table border='0' cellpadding='0' cellspacing='0' style='cellpadding:0;cellspacing:0;color:#000000;font-family:Helvetica, Arial, sans-serif;font-size:13px;line-height:22px;table-layout:auto;width:100%;' width='100%'>
                                                                <tr>
                                                                    <td align='left'>
                                                                        <div style='color:white;font-family:Helvetica, Arial, sans-serif;font-size:12px;line-height:28px;text-align:left;'>
                                                                            <p>
                                                                                <a href='https://www.sun.edu.edu.ng' target=""_blank"" style='color: #666;'>
                                                                                <h3>Skyline University Nigeria </h3> 
                                                                                </a>
                                                                                <br />
                                                                                2, Zaria Road Kano.
                                                                                <br />
                                                                                 Mobile: +2348181111113, +2348099000770
                                                                            </p>
                                                                        </div>
                                                                    </td>
                                                                    <td align='right' style='vertical-align:top; opacity: 0.35;' width='34px'>
                                                                        <table border='0' cellpadding='0' cellspacing='0' role='presentation' style='border-collapse:collapse;border-spacing:0px;'>
                                                                            <tbody>
                                                                                <tr>
                                                                                    <td style='width:30px;'>
                                                                                        <img alt='Facebook' height='auto' src='https://assets.opensourceemails.com/imgs/lifestyle/Fct0c2xMRUKPHBdMCcnf_icon-facebook.png' style='border:none;display:block;font-size:13px;height:auto;outline:none;text-decoration:none;width:100%;' width='30' />
                                                                                    </td>
                                                                                </tr>
                                                                            </tbody>
                                                                        </table>
                                                                    </td>
                                                                    <td align='right' style='vertical-align:top; opacity: 0.35;' width='34px'>
                                                                        <table border='0' cellpadding='0' cellspacing='0' role='presentation' style='border-collapse:collapse;border-spacing:0px;'>
                                                                            <tbody>
                                                                                <tr>
                                                                                    <td style='width:30px;'>
                                                                                        <img alt='Linked In' height='auto' src='https://assets.opensourceemails.com/imgs/lifestyle/BHraIlyShi7koHdeMEbD_icon-linkedin.png' style='border:none;display:block;font-size:13px;height:auto;outline:none;text-decoration:none;width:100%;' width='30' />
                                                                                    </td>
                                                                                </tr>
                                                                            </tbody>
                                                                        </table>
                                                                    </td>
                                                                    <td align='right' style='vertical-align:top; opacity: 0.35;' width='34px'>
                                                                        <table border='0' cellpadding='0' cellspacing='0' role='presentation' style='border-collapse:collapse;border-spacing:0px;'>
                                                                            <tbody>
                                                                                <tr>
                                                                                    <td style='width:30px;'>
                                                                                        <img alt='Twitter' height='auto' src='https://assets.opensourceemails.com/imgs/lifestyle/Rc7jq7J2ToyH0IGSptTY_icon-twitter.png' style='border:none;display:block;font-size:13px;height:auto;outline:none;text-decoration:none;width:100%;' width='30' />
                                                                                    </td>
                                                                                </tr>
                                                                            </tbody>
                                                                        </table>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </div>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
</body>
</html>";
            return body;
        }

        public static string PassingEntranceExaminationMail(string name, string date, string percentage)
        {
            string body = $@"
<html lang=""en"" xmlns=""http://www.w3.org/1999/xhtml"" xmlns:v=""urn:schemas-microsoft-com:vml"" xmlns:o=""urn:schemas-microsoft-com:office:office"">
<head>
    <title>
    </title>
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta http-equiv=""Content-Type"" content=""text/html; charset=UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
</head>
<body>
    <div>
        <table align='center' background='https://portalapi.maaun.edu.ng/logo.png' border='0' cellpadding='0' cellspacing='0' role='presentation' style='background:url(https://s3.amazonaws.com/swu-filepicker/4E687TRe69Ld95IDWyEg_bg_top_02.jpg) top center / auto repeat;width:100%;'>
            <tbody>
                <tr>
                    <td>

                        <div style='margin:0px auto;max-width:600px;'>
                            <div style='font-size:0;line-height:0;'>
                                <table align='center' border='0' cellpadding='0' cellspacing='0' role='presentation' style='width:100%;'>
                                    <tbody>
                                        <tr>
                                            <td style='direction:ltr;font-size:0px;padding:20px 0px 30px 0px;text-align:center;vertical-align:top;'>

                                                <div class='dys-column-per-100 outlook-group-fix' style='direction:ltr;display:inline-block;font-size:13px;text-align:left;vertical-align:top;width:100%;'>
                                                    <table border='0' cellpadding='0' cellspacing='0' role='presentation' width='100%'>
                                                        <tbody>
                                                            <tr>
                                                                <td style='padding:0px 20px;vertical-align:top;'>
                                                                    <table border='0' cellpadding='0' cellspacing='0' role='presentation' style='' width='100%'>
                                                                        <tr>
                                                                            <td align='left' style='font-size:0px;padding:0px;word-break:break-word;'>
                                                                                <table border='0' cellpadding='0' cellspacing='0' style='cellpadding:0;cellspacing:0;color:#000000;font-family:Helvetica, Arial, sans-serif;font-size:13px;line-height:22px;table-layout:auto;width:100%;' width='100%'>
                                                                                    <tr>
                                                                                        <td align='left'>
                                                                                            <a href='#'>
                                                                                                <img align='left' alt='Logo' height='37' padding='5px' src='https://portalapi.maaun.edu.ng/logo.png' width='37' />
                                                                                            </a>
                                                                                        </td>
                                                                                        <td align='right' style='vertical-align:bottom;' width='34px'>
                                                                                            <a href='#'>
                                                                                                <img alt='Twitter' height='22' src='https://s3.amazonaws.com/swu-cs-assets/OSET/social/Twitter_grey.png' width='22' />
                                                                                            </a>
                                                                                        </td>
                                                                                        <td align='right' style='vertical-align:bottom;' width='34px'>
                                                                                            <a href='#'>
                                                                                                <img alt='Facebook' height='22' src='https://swu-cs-assets.s3.amazonaws.com/OSET/social/f_grey.png' width='22' />
                                                                                            </a>
                                                                                        </td>
                                                                                        <td align='right' style='vertical-align:bottom;' width='34px'>
                                                                                            <a href='#'>
                                                                                                <img alt='Instagram' height='22' src='https://swu-cs-assets.s3.amazonaws.com/OSET/social/instagrey.png' width='22' />
                                                                                            </a>
                                                                                        </td>
                                                                                    </tr>
                                                                                </table>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                </td>
                                                            </tr>
                                                        </tbody>
                                                    </table>
                                                </div>
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </td>
                </tr>
            </tbody>
        </table>
        <table align='center' border='0' cellpadding='0' cellspacing='0' role='presentation' style='background:#f7f7f7;background-color:#f7f7f7;width:100%;'>
            <tbody>
                <tr>
                    <td>
                        <div style='margin:0px auto;max-width:600px;'>
                            <table align='center' border='0' cellpadding='0' cellspacing='0' role='presentation' style='width:100%;'>
                                <tbody>
                                    <tr>
                                        <td style='direction:ltr;font-size:0px;padding:20px 0;text-align:center;vertical-align:top;'>
                                            <div class='dys-column-per-100 outlook-group-fix' style='direction:ltr;display:inline-block;font-size:13px;text-align:left;vertical-align:top;width:100%;'>
                                                <table border='0' cellpadding='0' cellspacing='0' role='presentation' style='vertical-align:top;' width='100%'>
                                                    <tr>
                                                        <td align='center' style='font-size:0px;padding:10px 25px;word-break:break-word;'>
                                                            <div style='color:#292929;font-family:Oxygen, Helvetica neue, sans-serif;font-size:15px;line-height:21px;text-align:left;'>
                                                                Dear {name},
                                                            </div>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align='center' style='font-size:0px;padding:10px 25px;word-break:break-word;'>
                                                            <div style='color:#292929;font-family:Oxygen, Helvetica neue, sans-serif;font-size:15px;line-height:21px;text-align:left;'>
                                                                Congratulations!!!
                                                            </div>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align='center' style='font-size:0px;padding:10px 25px;word-break:break-word;'>
                                                            <div style='color:#292929;font-family:Oxygen, Helvetica neue, sans-serif;font-size:15px;line-height:21px;text-align:left;'>
                                                                We are pleased to inform you that your entrance examination towards your {percentage} has been affirmed.  Congratulations on this well-deserved feat. You are hereby required to visit Skyline University Nigeria by {date}, with all necessary documents in order to complete your admission process. 
                                                            </div>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align='center' style='font-size:0px;padding:10px 25px;word-break:break-word;'>
                                                            <div style='color:#292929;font-family:Oxygen, Helvetica neue, sans-serif;font-size:15px;line-height:21px;text-align:left;'>
                                                               Please confirm your acceptance of this scholarship.
                                                            </div>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                       <td align='center' style='font-size:0px;padding:10px 25px;word-break:break-word;'>
                                                            <div style='color:#292929;font-family:Oxygen, Helvetica neue, sans-serif;font-size:15px;line-height:21px;text-align:left;'>
                                                               Wishing you all the best and looking forward for your visit at our campus.
                                                            </div>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </div>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </td>
                </tr>
            </tbody>
        </table>
         <table align='center' border='0' cellpadding='0' cellspacing='0' role='presentation' style='background:#f7f7f7;background-color:#f7f7f7;width:100%;'>
            <tbody>
                <tr>
                    <td>
                        <div style='margin:0px auto;max-width:600px;'>
                            <table align='center' border='0' cellpadding='0' cellspacing='0' role='presentation' style='width:100%;'>
                                <tbody>
                                    <tr>
                                        <td style='direction:ltr;font-size:0px;padding:20px 0;text-align:center;vertical-align:top;'>
                                            <div class='dys-column-per-100 outlook-group-fix' style='direction:ltr;display:inline-block;font-size:13px;text-align:left;vertical-align:top;width:100%;'>
                                                <table border='0' cellpadding='0' cellspacing='0' role='presentation' style='vertical-align:top;' width='100%'>
                                                     <tr>
                                                        <td align='center' style='font-size:0px;padding:5px 25px;word-break:break-word;'>
                                                            <div style='color:#292929;font-family:Oxygen, Helvetica neue, sans-serif;font-size:15px;font-style:bold;line-height:1;text-align:left;'>
                                                                Kind Regards,
                                                            </div>
                                                        </td>
                                                    </tr>           
                                                    <tr>
                                                        <td align='center' style='font-size:0px;padding:5px 25px;word-break:break-word;'>
                                                            <div style='color:#292929;font-family:Oxygen, Helvetica neue, sans-serif;font-size:15px;font-style:bold;line-height:1;text-align:left;'>
                                                                Admission Department,
                                                            </div>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align='center' style='font-size:0px;padding:5px 25px;word-break:break-word;'>
                                                            <div style='color:#292929;font-family:Oxygen, Helvetica neue, sans-serif;font-size:15px;font-style:bold;line-height:1;text-align:left;'>
                                                                Skyline University Nigeria
                                                            </div>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align='center' style='font-size:0px;padding:5px 25px;word-break:break-word;'>
                                                            <div style='color:#292929;font-family:Oxygen, Helvetica neue, sans-serif;font-size:15px;font-style:bold;line-height:1;text-align:left;'>
                                                                2, Zaria Road Kano.
                                                            </div>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align='center' style='font-size:0px;padding:5px 25px;word-break:break-word;'>
                                                            <div style='color:#292929;font-family:Oxygen, Helvetica neue, sans-serif;font-size:15px;font-style:bold;line-height:1;text-align:left;'>
                                                                Kano, Nigeria.
                                                            </div>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align='center' style='font-size:0px;padding:5px 25px;word-break:break-word;'>
                                                            <div style='color:#292929;font-family:Oxygen, Helvetica neue, sans-serif;font-size:15px;font-style:bold;line-height:1;text-align:left;'>
                                                                Mobile: +2348181111113, +2348099000770
                                                            </div>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </div>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </td>
                </tr>
            </tbody>
        </table>
        <table align='center' border='0' cellpadding='0' cellspacing='0' role='presentation' style='background:#16173b;background-color:#16173b;width:100%;'>
            <tbody>
                <tr>
                    <td>
                        <div style='margin:0px auto;max-width:600px;'>
                            <table align='center' border='0' cellpadding='0' cellspacing='0' role='presentation' style='width:100%;'>
                                <tbody>
                                    <tr>
                                        <td style='direction:ltr;font-size:0px;padding:50px;text-align:center;vertical-align:top;'>
                                            <div class='dys-column-per-100 outlook-group-fix' style='direction:ltr;display:inline-block;font-size:13px;text-align:left;vertical-align:top;width:100%;'>
                                                <table border='0' cellpadding='0' cellspacing='0' role='presentation' style='vertical-align:top;' width='100%'>
                                                    <tr>
                                                        <td align='left' style='font-size:0px;padding:0px;word-break:break-word;'>
                                                            <table border='0' cellpadding='0' cellspacing='0' style='cellpadding:0;cellspacing:0;color:#000000;font-family:Helvetica, Arial, sans-serif;font-size:13px;line-height:22px;table-layout:auto;width:100%;' width='100%'>
                                                                <tr>
                                                                    <td align='left'>
                                                                        <div style='color:white;font-family:Helvetica, Arial, sans-serif;font-size:12px;line-height:28px;text-align:left;'>
                                                                            <p>
                                                                                <a href='https://www.sun.edu.edu.ng' target=""_blank"" style='color: #666;'>
                                                                                <h3>Skyline University Nigeria </h3> 
                                                                                </a>
                                                                                <br />
                                                                                2, Zaria Road Kano.
                                                                                <br />
                                                                                 Mobile: +2348181111113, +2348099000770
                                                                            </p>
                                                                        </div>
                                                                    </td>
                                                                    <td align='right' style='vertical-align:top; opacity: 0.35;' width='34px'>
                                                                        <table border='0' cellpadding='0' cellspacing='0' role='presentation' style='border-collapse:collapse;border-spacing:0px;'>
                                                                            <tbody>
                                                                                <tr>
                                                                                    <td style='width:30px;'>
                                                                                        <img alt='Facebook' height='auto' src='https://assets.opensourceemails.com/imgs/lifestyle/Fct0c2xMRUKPHBdMCcnf_icon-facebook.png' style='border:none;display:block;font-size:13px;height:auto;outline:none;text-decoration:none;width:100%;' width='30' />
                                                                                    </td>
                                                                                </tr>
                                                                            </tbody>
                                                                        </table>
                                                                    </td>
                                                                    <td align='right' style='vertical-align:top; opacity: 0.35;' width='34px'>
                                                                        <table border='0' cellpadding='0' cellspacing='0' role='presentation' style='border-collapse:collapse;border-spacing:0px;'>
                                                                            <tbody>
                                                                                <tr>
                                                                                    <td style='width:30px;'>
                                                                                        <img alt='Linked In' height='auto' src='https://assets.opensourceemails.com/imgs/lifestyle/BHraIlyShi7koHdeMEbD_icon-linkedin.png' style='border:none;display:block;font-size:13px;height:auto;outline:none;text-decoration:none;width:100%;' width='30' />
                                                                                    </td>
                                                                                </tr>
                                                                            </tbody>
                                                                        </table>
                                                                    </td>
                                                                    <td align='right' style='vertical-align:top; opacity: 0.35;' width='34px'>
                                                                        <table border='0' cellpadding='0' cellspacing='0' role='presentation' style='border-collapse:collapse;border-spacing:0px;'>
                                                                            <tbody>
                                                                                <tr>
                                                                                    <td style='width:30px;'>
                                                                                        <img alt='Twitter' height='auto' src='https://assets.opensourceemails.com/imgs/lifestyle/Rc7jq7J2ToyH0IGSptTY_icon-twitter.png' style='border:none;display:block;font-size:13px;height:auto;outline:none;text-decoration:none;width:100%;' width='30' />
                                                                                    </td>
                                                                                </tr>
                                                                            </tbody>
                                                                        </table>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </div>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
</body>
</html>";
            return body;
        }

        public static string FailingTheEntranceExamination(string name, string date)
        {
            string body = $@"
<html lang=""en"" xmlns=""http://www.w3.org/1999/xhtml"" xmlns:v=""urn:schemas-microsoft-com:vml"" xmlns:o=""urn:schemas-microsoft-com:office:office"">
<head>
    <title>
    </title>
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta http-equiv=""Content-Type"" content=""text/html; charset=UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
</head>
<body>
    <div>
        <table align='center' background='https://portalapi.maaun.edu.ng/logo.png' border='0' cellpadding='0' cellspacing='0' role='presentation' style='background:url(https://s3.amazonaws.com/swu-filepicker/4E687TRe69Ld95IDWyEg_bg_top_02.jpg) top center / auto repeat;width:100%;'>
            <tbody>
                <tr>
                    <td>

                        <div style='margin:0px auto;max-width:600px;'>
                            <div style='font-size:0;line-height:0;'>
                                <table align='center' border='0' cellpadding='0' cellspacing='0' role='presentation' style='width:100%;'>
                                    <tbody>
                                        <tr>
                                            <td style='direction:ltr;font-size:0px;padding:20px 0px 30px 0px;text-align:center;vertical-align:top;'>

                                                <div class='dys-column-per-100 outlook-group-fix' style='direction:ltr;display:inline-block;font-size:13px;text-align:left;vertical-align:top;width:100%;'>
                                                    <table border='0' cellpadding='0' cellspacing='0' role='presentation' width='100%'>
                                                        <tbody>
                                                            <tr>
                                                                <td style='padding:0px 20px;vertical-align:top;'>
                                                                    <table border='0' cellpadding='0' cellspacing='0' role='presentation' style='' width='100%'>
                                                                        <tr>
                                                                            <td align='left' style='font-size:0px;padding:0px;word-break:break-word;'>
                                                                                <table border='0' cellpadding='0' cellspacing='0' style='cellpadding:0;cellspacing:0;color:#000000;font-family:Helvetica, Arial, sans-serif;font-size:13px;line-height:22px;table-layout:auto;width:100%;' width='100%'>
                                                                                    <tr>
                                                                                        <td align='left'>
                                                                                            <a href='#'>
                                                                                                <img align='left' alt='Logo' height='37' padding='5px' src='https://portalapi.maaun.edu.ng/logo.png' width='37' />
                                                                                            </a>
                                                                                        </td>
                                                                                        <td align='right' style='vertical-align:bottom;' width='34px'>
                                                                                            <a href='#'>
                                                                                                <img alt='Twitter' height='22' src='https://s3.amazonaws.com/swu-cs-assets/OSET/social/Twitter_grey.png' width='22' />
                                                                                            </a>
                                                                                        </td>
                                                                                        <td align='right' style='vertical-align:bottom;' width='34px'>
                                                                                            <a href='#'>
                                                                                                <img alt='Facebook' height='22' src='https://swu-cs-assets.s3.amazonaws.com/OSET/social/f_grey.png' width='22' />
                                                                                            </a>
                                                                                        </td>
                                                                                        <td align='right' style='vertical-align:bottom;' width='34px'>
                                                                                            <a href='#'>
                                                                                                <img alt='Instagram' height='22' src='https://swu-cs-assets.s3.amazonaws.com/OSET/social/instagrey.png' width='22' />
                                                                                            </a>
                                                                                        </td>
                                                                                    </tr>
                                                                                </table>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                </td>
                                                            </tr>
                                                        </tbody>
                                                    </table>
                                                </div>
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </td>
                </tr>
            </tbody>
        </table>
        <table align='center' border='0' cellpadding='0' cellspacing='0' role='presentation' style='background:#f7f7f7;background-color:#f7f7f7;width:100%;'>
            <tbody>
                <tr>
                    <td>
                        <div style='margin:0px auto;max-width:600px;'>
                            <table align='center' border='0' cellpadding='0' cellspacing='0' role='presentation' style='width:100%;'>
                                <tbody>
                                    <tr>
                                        <td style='direction:ltr;font-size:0px;padding:20px 0;text-align:center;vertical-align:top;'>
                                            <div class='dys-column-per-100 outlook-group-fix' style='direction:ltr;display:inline-block;font-size:13px;text-align:left;vertical-align:top;width:100%;'>
                                                <table border='0' cellpadding='0' cellspacing='0' role='presentation' style='vertical-align:top;' width='100%'>
                                                    <tr>
                                                        <td align='center' style='font-size:0px;padding:10px 25px;word-break:break-word;'>
                                                            <div style='color:#292929;font-family:Oxygen, Helvetica neue, sans-serif;font-size:15px;line-height:21px;text-align:left;'>
                                                                Dear {name},
                                                            </div>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align='center' style='font-size:0px;padding:10px 25px;word-break:break-word;'>
                                                            <div style='color:#292929;font-family:Oxygen, Helvetica neue, sans-serif;font-size:15px;line-height:21px;text-align:left;'>
                                                                Greetings from Skyline University Nigeria!!
                                                            </div>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align='center' style='font-size:0px;padding:10px 25px;word-break:break-word;'>
                                                            <div style='color:#292929;font-family:Oxygen, Helvetica neue, sans-serif;font-size:15px;line-height:21px;text-align:left;'>
                                                                We thank you for applying for scholarship at Skyline University Nigeria. After thoroughly reviewing your result, our Academic Review Committee has rejected your application on ground of securing lesser than the desired grades in Entrance Examination.
                                                            </div>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align='center' style='font-size:0px;padding:10px 25px;word-break:break-word;'>
                                                            <div style='color:#292929;font-family:Oxygen, Helvetica neue, sans-serif;font-size:15px;line-height:21px;text-align:left;'>
                                                               We still advise you to visit our able academic counsellors at our campus, as they shall guide you on appropriate career path offered at Skyline University Nigeria.
                                                            </div>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align='center' style='font-size:0px;padding:10px 25px;word-break:break-word;'>
                                                            <div style='color:#292929;font-family:Oxygen, Helvetica neue, sans-serif;font-size:15px;line-height:21px;text-align:left;'>
                                                               Wishing you all the best and looking forward for your visit at our campus.
                                                            </div>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </div>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </td>
                </tr>
            </tbody>
        </table>
         <table align='center' border='0' cellpadding='0' cellspacing='0' role='presentation' style='background:#f7f7f7;background-color:#f7f7f7;width:100%;'>
            <tbody>
                <tr>
                    <td>
                        <div style='margin:0px auto;max-width:600px;'>
                            <table align='center' border='0' cellpadding='0' cellspacing='0' role='presentation' style='width:100%;'>
                                <tbody>
                                    <tr>
                                        <td style='direction:ltr;font-size:0px;padding:20px 0;text-align:center;vertical-align:top;'>
                                            <div class='dys-column-per-100 outlook-group-fix' style='direction:ltr;display:inline-block;font-size:13px;text-align:left;vertical-align:top;width:100%;'>
                                                <table border='0' cellpadding='0' cellspacing='0' role='presentation' style='vertical-align:top;' width='100%'>
                                                     <tr>
                                                        <td align='center' style='font-size:0px;padding:5px 25px;word-break:break-word;'>
                                                            <div style='color:#292929;font-family:Oxygen, Helvetica neue, sans-serif;font-size:15px;font-style:bold;line-height:1;text-align:left;'>
                                                                Kind Regards,
                                                            </div>
                                                        </td>
                                                    </tr>           
                                                    <tr>
                                                        <td align='center' style='font-size:0px;padding:5px 25px;word-break:break-word;'>
                                                            <div style='color:#292929;font-family:Oxygen, Helvetica neue, sans-serif;font-size:15px;font-style:bold;line-height:1;text-align:left;'>
                                                                Admission Department,
                                                            </div>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align='center' style='font-size:0px;padding:5px 25px;word-break:break-word;'>
                                                            <div style='color:#292929;font-family:Oxygen, Helvetica neue, sans-serif;font-size:15px;font-style:bold;line-height:1;text-align:left;'>
                                                                Skyline University Nigeria
                                                            </div>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align='center' style='font-size:0px;padding:5px 25px;word-break:break-word;'>
                                                            <div style='color:#292929;font-family:Oxygen, Helvetica neue, sans-serif;font-size:15px;font-style:bold;line-height:1;text-align:left;'>
                                                                2, Zaria Road Kano.
                                                            </div>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align='center' style='font-size:0px;padding:5px 25px;word-break:break-word;'>
                                                            <div style='color:#292929;font-family:Oxygen, Helvetica neue, sans-serif;font-size:15px;font-style:bold;line-height:1;text-align:left;'>
                                                                Kano, Nigeria.
                                                            </div>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align='center' style='font-size:0px;padding:5px 25px;word-break:break-word;'>
                                                            <div style='color:#292929;font-family:Oxygen, Helvetica neue, sans-serif;font-size:15px;font-style:bold;line-height:1;text-align:left;'>
                                                                Mobile: +2348181111113, +2348099000770
                                                            </div>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </div>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </td>
                </tr>
            </tbody>
        </table>
        <table align='center' border='0' cellpadding='0' cellspacing='0' role='presentation' style='background:#16173b;background-color:#16173b;width:100%;'>
            <tbody>
                <tr>
                    <td>
                        <div style='margin:0px auto;max-width:600px;'>
                            <table align='center' border='0' cellpadding='0' cellspacing='0' role='presentation' style='width:100%;'>
                                <tbody>
                                    <tr>
                                        <td style='direction:ltr;font-size:0px;padding:50px;text-align:center;vertical-align:top;'>
                                            <div class='dys-column-per-100 outlook-group-fix' style='direction:ltr;display:inline-block;font-size:13px;text-align:left;vertical-align:top;width:100%;'>
                                                <table border='0' cellpadding='0' cellspacing='0' role='presentation' style='vertical-align:top;' width='100%'>
                                                    <tr>
                                                        <td align='left' style='font-size:0px;padding:0px;word-break:break-word;'>
                                                            <table border='0' cellpadding='0' cellspacing='0' style='cellpadding:0;cellspacing:0;color:#000000;font-family:Helvetica, Arial, sans-serif;font-size:13px;line-height:22px;table-layout:auto;width:100%;' width='100%'>
                                                                <tr>
                                                                    <td align='left'>
                                                                        <div style='color:white;font-family:Helvetica, Arial, sans-serif;font-size:12px;line-height:28px;text-align:left;'>
                                                                            <p>
                                                                                <a href='https://www.sun.edu.edu.ng' target=""_blank"" style='color: #666;'>
                                                                                <h3>Skyline University Nigeria </h3> 
                                                                                </a>
                                                                                <br />
                                                                                2, Zaria Road Kano.
                                                                                <br />
                                                                                 Mobile: +2348181111113, +2348099000770
                                                                            </p>
                                                                        </div>
                                                                    </td>
                                                                    <td align='right' style='vertical-align:top; opacity: 0.35;' width='34px'>
                                                                        <table border='0' cellpadding='0' cellspacing='0' role='presentation' style='border-collapse:collapse;border-spacing:0px;'>
                                                                            <tbody>
                                                                                <tr>
                                                                                    <td style='width:30px;'>
                                                                                        <img alt='Facebook' height='auto' src='https://assets.opensourceemails.com/imgs/lifestyle/Fct0c2xMRUKPHBdMCcnf_icon-facebook.png' style='border:none;display:block;font-size:13px;height:auto;outline:none;text-decoration:none;width:100%;' width='30' />
                                                                                    </td>
                                                                                </tr>
                                                                            </tbody>
                                                                        </table>
                                                                    </td>
                                                                    <td align='right' style='vertical-align:top; opacity: 0.35;' width='34px'>
                                                                        <table border='0' cellpadding='0' cellspacing='0' role='presentation' style='border-collapse:collapse;border-spacing:0px;'>
                                                                            <tbody>
                                                                                <tr>
                                                                                    <td style='width:30px;'>
                                                                                        <img alt='Linked In' height='auto' src='https://assets.opensourceemails.com/imgs/lifestyle/BHraIlyShi7koHdeMEbD_icon-linkedin.png' style='border:none;display:block;font-size:13px;height:auto;outline:none;text-decoration:none;width:100%;' width='30' />
                                                                                    </td>
                                                                                </tr>
                                                                            </tbody>
                                                                        </table>
                                                                    </td>
                                                                    <td align='right' style='vertical-align:top; opacity: 0.35;' width='34px'>
                                                                        <table border='0' cellpadding='0' cellspacing='0' role='presentation' style='border-collapse:collapse;border-spacing:0px;'>
                                                                            <tbody>
                                                                                <tr>
                                                                                    <td style='width:30px;'>
                                                                                        <img alt='Twitter' height='auto' src='https://assets.opensourceemails.com/imgs/lifestyle/Rc7jq7J2ToyH0IGSptTY_icon-twitter.png' style='border:none;display:block;font-size:13px;height:auto;outline:none;text-decoration:none;width:100%;' width='30' />
                                                                                    </td>
                                                                                </tr>
                                                                            </tbody>
                                                                        </table>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </div>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
</body>
</html>";
            return body;
        }
    }

    public class Tenant
    {
        public string SchoolName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Contact { get; set; }
    }
    public class Bank
    {
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public string BankName { get; set; }
    }
}

