﻿using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Authenticators;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.Json;

namespace SendGridMailTask
{
    //klpl dqex kbrw jjdw
    internal class Program
    {
        static async Task Main(string[] args)
        {
            int first = 0;
            string name = string.Empty;
            string surname = string.Empty;
            string email = string.Empty;
            string ext = string.Empty;
            int sedcond = 0;
            int ate = 0;
            string tre = new string('-', 40);
            //"isim@soyisim@gmail.com"
            string[] emails = { "isim.soyisim@gmail.com", "test.testov@gmail.com", "test.testovasdasd@gmail.com","rpirsoltanov@gmail.com" };

            for (int i = 0; i < emails.Length; i++)
            {

                if (!(emails[i].IndexOf('.') == emails[i].LastIndexOf('.')))
                {
                    first = emails[i].IndexOf('.');
                    name = emails[i].Substring(0, first);
                    sedcond = emails[i].LastIndexOf('.');
                    ate = emails[i].IndexOf('@');

                    surname = emails[i].Substring(first + 1, ate - 5);
                    email = emails[i];
                    ext = emails[i].Substring(sedcond);
                }
                else
                {
                    name = emails[i].Substring(0, emails[i].IndexOf('@'));
                    surname = "";
                    email = emails[i];
                }

                string rslt = $"" +
                    "\n" + $"{tre}" + "\n" +
             $"Name : " + $"{name}" + "\n" +
             $"Surname : " + $"{surname}" + "\n" +
             $"email : " + $"{email}" + "\n" +
             $"extension : " + $"{ext}" +
             "\n" + $"{tre}" + "\n";
                Console.WriteLine(rslt);
                SendEmail(email, name, surname);
            }
        }



        public static void SendEmail(string email,string name,string surname)
        {
            string senderEmail = "resulresull510@gmail.com";
            string recipientEmail = email;
            string subject = "Test Email";
            StringBuilder body = new StringBuilder($@"<!DOCTYPE HTML PUBLIC ""-//W3C//DTD XHTML 1.0 Transitional //EN"" ""http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"">
<html xmlns=""http://www.w3.org/1999/xhtml"" xmlns:v=""urn:schemas-microsoft-com:vml"" xmlns:o=""urn:schemas-microsoft-com:office:office"">
<head>
<!--[if gte mso 9]>
<xml>
  <o:OfficeDocumentSettings>
    <o:AllowPNG/>
    <o:PixelsPerInch>96</o:PixelsPerInch>
  </o:OfficeDocumentSettings>
</xml>
<![endif]-->
  <meta http-equiv=""Content-Type"" content=""text/html; charset=UTF-8"">
  <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
  <meta name=""x-apple-disable-message-reformatting"">
  <!--[if !mso]><!--><meta http-equiv=""X-UA-Compatible"" content=""IE=edge""><!--<![endif]-->
  <title></title>
  
    <style type=""text/css"">
      @media only screen and (min-width: 620px) {{
  .u-row {{
    width: 600px !important;
  }}
  .u-row .u-col {{
    vertical-align: top;
  }}

  .u-row .u-col-33p33 {{
    width: 199.98px !important;
  }}

  .u-row .u-col-100 {{
    width: 600px !important;
  }}

}}

@media (max-width: 620px) {{
  .u-row-container {{
    max-width: 100% !important;
    padding-left: 0px !important;
    padding-right: 0px !important;
  }}
  .u-row .u-col {{
    min-width: 320px !important;
    max-width: 100% !important;
    display: block !important;
  }}
  .u-row {{
    width: 100% !important;
  }}
  .u-col {{
    width: 100% !important;
  }}
  .u-col > div {{
    margin: 0 auto;
  }}
}}
body {{
  margin: 0;
  padding: 0;
}}

table,
tr,
td {{
  vertical-align: top;
  border-collapse: collapse;
}}

p {{
  margin: 0;
}}

.ie-container table,
.mso-container table {{
  table-layout: fixed;
}}

* {{
  line-height: inherit;
}}

a[x-apple-data-detectors='true'] {{
  color: inherit !important;
  text-decoration: none !important;
}}

@media (max-width: 480px) {{
  .hide-mobile {{
    max-height: 0px;
    overflow: hidden;
    display: none !important;
  }}
}}

table, td {{ color: #ffffff; }} #u_body a {{ color: #0000ee; text-decoration: underline; }} @media (max-width: 480px) {{ #u_content_image_1 .v-src-width {{ width: auto !important; }} #u_content_image_1 .v-src-max-width {{ max-width: 31% !important; }} #u_content_menu_1 .v-font-size {{ font-size: 14px !important; }} #u_content_menu_1 .v-padding {{ padding: 5px 9px !important; }} #u_content_text_1 .v-container-padding-padding {{ padding: 20px 10px 10px !important; }} #u_content_text_1 .v-font-size {{ font-size: 14px !important; }} #u_content_button_2 .v-container-padding-padding {{ padding: 10px 10px 40px !important; }} #u_content_button_2 .v-size-width {{ width: 65% !important; }} #u_content_heading_1 .v-container-padding-padding {{ padding: 40px 10px 10px !important; }} #u_content_heading_1 .v-font-size {{ font-size: 35px !important; }} #u_content_text_2 .v-container-padding-padding {{ padding: 10px !important; }} #u_content_button_1 .v-container-padding-padding {{ padding: 10px 10px 40px !important; }} #u_content_button_1 .v-size-width {{ width: 65% !important; }} #u_row_8.v-row-padding--vertical {{ padding-top: 0px !important; padding-bottom: 0px !important; }} #u_content_text_24 .v-container-padding-padding {{ padding: 60px 10px 10px !important; }} #u_content_text_25 .v-container-padding-padding {{ padding: 30px 10px 60px !important; }} #u_content_text_26 .v-container-padding-padding {{ padding: 60px 10px 10px !important; }} #u_content_text_27 .v-container-padding-padding {{ padding: 30px 10px 60px !important; }} #u_content_text_28 .v-container-padding-padding {{ padding: 60px 10px 10px !important; }} #u_content_text_29 .v-container-padding-padding {{ padding: 30px 10px 60px !important; }} #u_content_social_1 .v-container-padding-padding {{ padding: 40px 10px 10px !important; }} #u_content_text_30 .v-container-padding-padding {{ padding: 10px 10px 20px !important; }} #u_content_image_3 .v-container-padding-padding {{ padding: 20px 10px 40px !important; }} }}
    </style>
  
  

<!--[if !mso]><!--><link href=""https://fonts.googleapis.com/css?family=Rubik:400,700&display=swap"" rel=""stylesheet"" type=""text/css""><link href=""https://fonts.googleapis.com/css?family=Open+Sans:400,700&display=swap"" rel=""stylesheet"" type=""text/css""><link href=""https://fonts.googleapis.com/css?family=Raleway:400,700&display=swap"" rel=""stylesheet"" type=""text/css""><link href=""https://fonts.googleapis.com/css?family=Open+Sans:400,700&display=swap"" rel=""stylesheet"" type=""text/css""><!--<![endif]-->

</head>

<body class=""clean-body u_body"" style=""margin: 0;padding: 0;-webkit-text-size-adjust: 100%;background-color: #ffffff;color: #ffffff"">
  <!--[if IE]><div class=""ie-container""><![endif]-->
  <!--[if mso]><div class=""mso-container""><![endif]-->
  <table id=""u_body"" style=""border-collapse: collapse;table-layout: fixed;border-spacing: 0;mso-table-lspace: 0pt;mso-table-rspace: 0pt;vertical-align: top;min-width: 320px;Margin: 0 auto;background-color: #ffffff;width:100%"" cellpadding=""0"" cellspacing=""0"">
  <tbody>
  <tr style=""vertical-align: top"">
    <td style=""word-break: break-word;border-collapse: collapse !important;vertical-align: top"">
    <!--[if (mso)|(IE)]><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0""><tr><td align=""center"" style=""background-color: #ffffff;""><![endif]-->
    
  
  
<div class=""u-row-container v-row-padding--vertical"" style=""padding: 0px;background-color: #03172f"">
  <div class=""u-row"" style=""margin: 0 auto;min-width: 320px;max-width: 600px;overflow-wrap: break-word;word-wrap: break-word;word-break: break-word;background-color: transparent;"">
    <div style=""border-collapse: collapse;display: table;width: 100%;height: 100%;background-color: transparent;"">
      <!--[if (mso)|(IE)]><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0""><tr><td style=""padding: 0px;background-color: #03172f;"" align=""center""><table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:600px;""><tr style=""background-color: transparent;""><![endif]-->
      
<!--[if (mso)|(IE)]><td align=""center"" width=""600"" style=""width: 600px;padding: 0px;border-top: 0px solid transparent;border-left: 0px solid transparent;border-right: 0px solid transparent;border-bottom: 0px solid transparent;border-radius: 0px;-webkit-border-radius: 0px; -moz-border-radius: 0px;"" valign=""top""><![endif]-->
<div class=""u-col u-col-100"" style=""max-width: 320px;min-width: 600px;display: table-cell;vertical-align: top;"">
  <div style=""height: 100%;width: 100% !important;border-radius: 0px;-webkit-border-radius: 0px; -moz-border-radius: 0px;"">
  <!--[if (!mso)&(!IE)]><!--><div style=""box-sizing: border-box; height: 100%; padding: 0px;border-top: 0px solid transparent;border-left: 0px solid transparent;border-right: 0px solid transparent;border-bottom: 0px solid transparent;border-radius: 0px;-webkit-border-radius: 0px; -moz-border-radius: 0px;""><!--<![endif]-->
  
<table id=""u_content_image_1"" style=""font-family:'Raleway',sans-serif;"" role=""presentation"" cellpadding=""0"" cellspacing=""0"" width=""100%"" border=""0"">
  <tbody>
    <tr>
      <td class=""v-container-padding-padding"" style=""overflow-wrap:break-word;word-break:break-word;padding:25px 10px 15px;font-family:'Raleway',sans-serif;"" align=""left"">
        
<table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0"">
  <tr>
    <td style=""padding-right: 0px;padding-left: 0px;"" align=""center"">
      
      <h2>Hi _ClinetUnique</h2>
      
    </td>
  </tr>
</table>

      </td>
    </tr>
  </tbody>
</table>

  <!--[if (!mso)&(!IE)]><!--></div><!--<![endif]-->
  </div>
</div>
<!--[if (mso)|(IE)]></td><![endif]-->
      <!--[if (mso)|(IE)]></tr></table></td></tr></table><![endif]-->
    </div>
  </div>
  </div>
  


  
  
<div class=""u-row-container v-row-padding--vertical"" style=""padding: 0px;background-color: #03172f"">
  <div class=""u-row"" style=""margin: 0 auto;min-width: 320px;max-width: 600px;overflow-wrap: break-word;word-wrap: break-word;word-break: break-word;background-color: transparent;"">
    <div style=""border-collapse: collapse;display: table;width: 100%;height: 100%;background-color: transparent;"">
      <!--[if (mso)|(IE)]><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0""><tr><td style=""padding: 0px;background-color: #03172f;"" align=""center""><table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:600px;""><tr style=""background-color: transparent;""><![endif]-->
      
<!--[if (mso)|(IE)]><td align=""center"" width=""598"" style=""width: 598px;padding: 0px;border-top: 1px solid #ffffff;border-left: 1px solid #ffffff;border-right: 1px solid #ffffff;border-bottom: 1px solid #ffffff;border-radius: 0px;-webkit-border-radius: 0px; -moz-border-radius: 0px;"" valign=""top""><![endif]-->
<div class=""u-col u-col-100"" style=""max-width: 320px;min-width: 600px;display: table-cell;vertical-align: top;"">
  <div style=""height: 100%;width: 100% !important;border-radius: 0px;-webkit-border-radius: 0px; -moz-border-radius: 0px;"">
  <!--[if (!mso)&(!IE)]><!--><div style=""box-sizing: border-box; height: 100%; padding: 0px;border-top: 1px solid #ffffff;border-left: 1px solid #ffffff;border-right: 1px solid #ffffff;border-bottom: 1px solid #ffffff;border-radius: 0px;-webkit-border-radius: 0px; -moz-border-radius: 0px;""><!--<![endif]-->
  
<table id=""u_content_menu_1"" style=""font-family:'Raleway',sans-serif;"" role=""presentation"" cellpadding=""0"" cellspacing=""0"" width=""100%"" border=""0"">
  <tbody>
    <tr>
      <td class=""v-container-padding-padding"" style=""overflow-wrap:break-word;word-break:break-word;padding:10px;font-family:'Raleway',sans-serif;"" align=""left"">
        
<div class=""menu"" style=""text-align:center"">
<!--[if (mso)|(IE)]><table role=""presentation"" border=""0"" cellpadding=""0"" cellspacing=""0"" align=""center""><tr><![endif]-->

  <!--[if (mso)|(IE)]><td style=""padding:5px 22px""><![endif]-->
  
    <a href=""https://www.unlayer.com"" target=""_self"" style=""padding:5px 22px;display:inline-block;color:#ffffff;font-size:14px;text-decoration:none""  class=""v-padding v-font-size"">
      Home
    </a>
  
  <!--[if (mso)|(IE)]></td><![endif]-->
  
    <!--[if (mso)|(IE)]><td style=""padding:5px 22px""><![endif]-->
    <span style=""padding:5px 22px;display:inline-block;color:#ffffff;font-size:14px;"" class=""v-padding v-font-size hide-mobile"">
      |
    </span>
    <!--[if (mso)|(IE)]></td><![endif]-->
  

  <!--[if (mso)|(IE)]><td style=""padding:5px 22px""><![endif]-->
  
    <a href=""https://www.unlayer.com"" target=""_self"" style=""padding:5px 22px;display:inline-block;color:#ffffff;font-size:14px;text-decoration:none""  class=""v-padding v-font-size"">
      Page
    </a>
  
  <!--[if (mso)|(IE)]></td><![endif]-->
  
    <!--[if (mso)|(IE)]><td style=""padding:5px 22px""><![endif]-->
    <span style=""padding:5px 22px;display:inline-block;color:#ffffff;font-size:14px;"" class=""v-padding v-font-size hide-mobile"">
      |
    </span>
    <!--[if (mso)|(IE)]></td><![endif]-->
  

  <!--[if (mso)|(IE)]><td style=""padding:5px 22px""><![endif]-->
  
    <a href=""https://www.unlayer.com"" target=""_self"" style=""padding:5px 22px;display:inline-block;color:#ffffff;font-size:14px;text-decoration:none""  class=""v-padding v-font-size"">
      About US
    </a>
  
  <!--[if (mso)|(IE)]></td><![endif]-->
  
    <!--[if (mso)|(IE)]><td style=""padding:5px 22px""><![endif]-->
    <span style=""padding:5px 22px;display:inline-block;color:#ffffff;font-size:14px;"" class=""v-padding v-font-size hide-mobile"">
      |
    </span>
    <!--[if (mso)|(IE)]></td><![endif]-->
  

  <!--[if (mso)|(IE)]><td style=""padding:5px 22px""><![endif]-->
  
    <a href=""https://www.unlayer.com"" target=""_self"" style=""padding:5px 22px;display:inline-block;color:#ffffff;font-size:14px;text-decoration:none""  class=""v-padding v-font-size"">
      Contact Us
    </a>
  
  <!--[if (mso)|(IE)]></td><![endif]-->
  

<!--[if (mso)|(IE)]></tr></table><![endif]-->
</div>

      </td>
    </tr>
  </tbody>
</table>

  <!--[if (!mso)&(!IE)]><!--></div><!--<![endif]-->
  </div>
</div>
<!--[if (mso)|(IE)]></td><![endif]-->
      <!--[if (mso)|(IE)]></tr></table></td></tr></table><![endif]-->
    </div>
  </div>
  </div>
  


  
  
<div class=""u-row-container v-row-padding--vertical"" style=""padding: 0px;background-color: #03172f"">
  <div class=""u-row"" style=""margin: 0 auto;min-width: 320px;max-width: 600px;overflow-wrap: break-word;word-wrap: break-word;word-break: break-word;background-color: transparent;"">
    <div style=""border-collapse: collapse;display: table;width: 100%;height: 100%;background-color: transparent;"">
      <!--[if (mso)|(IE)]><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0""><tr><td style=""padding: 0px;background-color: #03172f;"" align=""center""><table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:600px;""><tr style=""background-color: transparent;""><![endif]-->
      
<!--[if (mso)|(IE)]><td align=""center"" width=""600"" style=""width: 600px;padding: 0px;border-top: 0px solid transparent;border-left: 0px solid transparent;border-right: 0px solid transparent;border-bottom: 0px solid transparent;border-radius: 0px;-webkit-border-radius: 0px; -moz-border-radius: 0px;"" valign=""top""><![endif]-->
<div class=""u-col u-col-100"" style=""max-width: 320px;min-width: 600px;display: table-cell;vertical-align: top;"">
  <div style=""height: 100%;width: 100% !important;border-radius: 0px;-webkit-border-radius: 0px; -moz-border-radius: 0px;"">
  <!--[if (!mso)&(!IE)]><!--><div style=""box-sizing: border-box; height: 100%; padding: 0px;border-top: 0px solid transparent;border-left: 0px solid transparent;border-right: 0px solid transparent;border-bottom: 0px solid transparent;border-radius: 0px;-webkit-border-radius: 0px; -moz-border-radius: 0px;""><!--<![endif]-->
  
<table id=""u_content_text_1"" style=""font-family:'Raleway',sans-serif;"" role=""presentation"" cellpadding=""0"" cellspacing=""0"" width=""100%"" border=""0"">
  <tbody>
    <tr>
      <td class=""v-container-padding-padding"" style=""overflow-wrap:break-word;word-break:break-word;padding:20px 151px 10px 10px;font-family:'Raleway',sans-serif;"" align=""left"">
        
  <div class=""v-font-size"" style=""font-size: 18px; color: #95a5a6; line-height: 140%; text-align: left; word-wrap: break-word;"">
    <p style=""line-height: 140%;""><span data-metadata=""&lt;!--(figmeta)eyJmaWxlS2V5IjoiRWRXTDhVMlMxUDg3Y2JYM3pydDBxOSIsInBhc3RlSUQiOjEzNTM1MzEzMzcsImRhdGFUeXBlIjoic2NlbmUifQo=(/figmeta)--&gt;"" style=""line-height: 25.2px;""></span><span data-buffer=""&lt;!--(figma)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(/figma)--&gt;"" style=""line-height: 25.2px;""></span>Lorem ipsum is simply dummy text of the printing and type setting industry. Lorem Ipsum been the industry's standard dummy.</p>
  </div>

      </td>
    </tr>
  </tbody>
</table>

<table id=""u_content_button_2"" style=""font-family:'Raleway',sans-serif;"" role=""presentation"" cellpadding=""0"" cellspacing=""0"" width=""100%"" border=""0"">
  <tbody>
    <tr>
      <td class=""v-container-padding-padding"" style=""overflow-wrap:break-word;word-break:break-word;padding:10px 10px 60px;font-family:'Raleway',sans-serif;"" align=""left"">
        
  <!--[if mso]><style>.v-button {{background: transparent !important;}}</style><![endif]-->
<div align=""left"">
  <!--[if mso]><v:roundrect xmlns:v=""urn:schemas-microsoft-com:vml"" xmlns:w=""urn:schemas-microsoft-com:office:word"" href=""https://unlayer.com"" style=""height:37px; v-text-anchor:middle; width:174px;"" arcsize=""0%""  stroke=""f"" fillcolor=""#d7b030""><w:anchorlock/><center style=""color:#000000;""><![endif]-->
    <a href=""https://unlayer.com"" target=""_blank"" class=""v-button v-size-width v-font-size"" style=""box-sizing: border-box;display: inline-block;text-decoration: none;-webkit-text-size-adjust: none;text-align: center;color: #000000; background-color: #d7b030; border-radius: 0px;-webkit-border-radius: 0px; -moz-border-radius: 0px; width:30%; max-width:100%; overflow-wrap: break-word; word-break: break-word; word-wrap:break-word; mso-border-alt: none;font-size: 14px;"">
      <span class=""v-padding"" style=""display:block;padding:10px 20px;line-height:120%;""><strong><span style=""line-height: 16.8px;"">Read More</span></strong></span>
    </a>
    <!--[if mso]></center></v:roundrect><![endif]-->
</div>

      </td>
    </tr>
  </tbody>
</table>

  <!--[if (!mso)&(!IE)]><!--></div><!--<![endif]-->
  </div>
</div>
<!--[if (mso)|(IE)]></td><![endif]-->
      <!--[if (mso)|(IE)]></tr></table></td></tr></table><![endif]-->
    </div>
  </div>
  </div>
  


  
  
<div class=""u-row-container v-row-padding--vertical"" style=""padding: 0px;background-color: #062844"">
  <div class=""u-row"" style=""margin: 0 auto;min-width: 320px;max-width: 600px;overflow-wrap: break-word;word-wrap: break-word;word-break: break-word;background-color: transparent;"">
    <div style=""border-collapse: collapse;display: table;width: 100%;height: 100%;background-color: transparent;"">
      <!--[if (mso)|(IE)]><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0""><tr><td style=""padding: 0px;background-color: #062844;"" align=""center""><table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:600px;""><tr style=""background-color: transparent;""><![endif]-->
      
<!--[if (mso)|(IE)]><td align=""center"" width=""600"" style=""width: 600px;padding: 0px;border-top: 0px solid transparent;border-left: 0px solid transparent;border-right: 0px solid transparent;border-bottom: 0px solid transparent;border-radius: 0px;-webkit-border-radius: 0px; -moz-border-radius: 0px;"" valign=""top""><![endif]-->
<div class=""u-col u-col-100"" style=""max-width: 320px;min-width: 600px;display: table-cell;vertical-align: top;"">
  <div style=""height: 100%;width: 100% !important;border-radius: 0px;-webkit-border-radius: 0px; -moz-border-radius: 0px;"">
  <!--[if (!mso)&(!IE)]><!--><div style=""box-sizing: border-box; height: 100%; padding: 0px;border-top: 0px solid transparent;border-left: 0px solid transparent;border-right: 0px solid transparent;border-bottom: 0px solid transparent;border-radius: 0px;-webkit-border-radius: 0px; -moz-border-radius: 0px;""><!--<![endif]-->
  
<table id=""u_content_heading_1"" style=""font-family:'Raleway',sans-serif;"" role=""presentation"" cellpadding=""0"" cellspacing=""0"" width=""100%"" border=""0"">
  <tbody>
    <tr>
      <td class=""v-container-padding-padding"" style=""overflow-wrap:break-word;word-break:break-word;padding:60px 10px 10px;font-family:'Raleway',sans-serif;"" align=""left"">
        
  <!--[if mso]><table width=""100%""><tr><td><![endif]-->
    <h1 class=""v-font-size"" style=""margin: 0px; color: #d7b030; line-height: 110%; text-align: center; word-wrap: break-word; font-family: 'Open Sans',sans-serif; font-size: 45px; font-weight: 400;""><span><span><span><span><span><strong>Get 50% OFF! _EmailUnique</strong><br />New Year, New You, New Savings!<br /></span></span></span></span></span></h1>
  <!--[if mso]></td></tr></table><![endif]-->

      </td>
    </tr>
  </tbody>
</table>

<table id=""u_content_text_2"" style=""font-family:'Raleway',sans-serif;"" role=""presentation"" cellpadding=""0"" cellspacing=""0"" width=""100%"" border=""0"">
  <tbody>
    <tr>
      <td class=""v-container-padding-padding"" style=""overflow-wrap:break-word;word-break:break-word;padding:10px 50px;font-family:'Raleway',sans-serif;"" align=""left"">
        
  <div class=""v-font-size"" style=""font-size: 14px; color: #95a5a6; line-height: 160%; text-align: center; word-wrap: break-word;"">
    <p style=""line-height: 160%;""><span data-metadata=""&lt;!--(figmeta)eyJmaWxlS2V5IjoiRWRXTDhVMlMxUDg3Y2JYM3pydDBxOSIsInBhc3RlSUQiOjE4MTIxMDE2MzMsImRhdGFUeXBlIjoic2NlbmUifQo=(/figmeta)--&gt;"" style=""line-height: 22.4px;""></span><span data-buffer=""&lt;!--(figma)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(/figma)--&gt;"" style=""line-height: 22.4px;""></span>Lorem ipsum is simply dummy text of the printing and type setting industry. Lorem Ipsum been the industry's standard dummy.</p>
  </div>

      </td>
    </tr>
  </tbody>
</table>

<table id=""u_content_button_1"" style=""font-family:'Raleway',sans-serif;"" role=""presentation"" cellpadding=""0"" cellspacing=""0"" width=""100%"" border=""0"">
  <tbody>
    <tr>
      <td class=""v-container-padding-padding"" style=""overflow-wrap:break-word;word-break:break-word;padding:10px 10px 60px;font-family:'Raleway',sans-serif;"" align=""left"">
        
  <!--[if mso]><style>.v-button {{background: transparent !important;}}</style><![endif]-->
<div align=""center"">
  <!--[if mso]><v:roundrect xmlns:v=""urn:schemas-microsoft-com:vml"" xmlns:w=""urn:schemas-microsoft-com:office:word"" href=""https://unlayer.com"" style=""height:37px; v-text-anchor:middle; width:174px;"" arcsize=""0%""  stroke=""f"" fillcolor=""#d7b030""><w:anchorlock/><center style=""color:#000000;""><![endif]-->
    <a href=""https://unlayer.com"" target=""_blank"" class=""v-button v-size-width v-font-size"" style=""box-sizing: border-box;display: inline-block;text-decoration: none;-webkit-text-size-adjust: none;text-align: center;color: #000000; background-color: #d7b030; border-radius: 0px;-webkit-border-radius: 0px; -moz-border-radius: 0px; width:30%; max-width:100%; overflow-wrap: break-word; word-break: break-word; word-wrap:break-word; mso-border-alt: none;font-size: 14px;"">
      <span class=""v-padding"" style=""display:block;padding:10px 20px;line-height:120%;""><strong><span style=""line-height: 16.8px;"">Get Now</span></strong></span>
    </a>
    <!--[if mso]></center></v:roundrect><![endif]-->
</div>

      </td>
    </tr>
  </tbody>
</table>

  <!--[if (!mso)&(!IE)]><!--></div><!--<![endif]-->
  </div>
</div>
<!--[if (mso)|(IE)]></td><![endif]-->
      <!--[if (mso)|(IE)]></tr></table></td></tr></table><![endif]-->
    </div>
  </div>
  </div>
  


  
  
<div id=""u_row_8"" class=""u-row-container v-row-padding--vertical"" style=""padding: 60px 0px;background-color: #03172f"">
  <div class=""u-row"" style=""margin: 0 auto;min-width: 320px;max-width: 600px;overflow-wrap: break-word;word-wrap: break-word;word-break: break-word;background-color: transparent;"">
    <div style=""border-collapse: collapse;display: table;width: 100%;height: 100%;background-color: transparent;"">
      <!--[if (mso)|(IE)]><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0""><tr><td style=""padding: 60px 0px;background-color: #03172f;"" align=""center""><table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:600px;""><tr style=""background-color: transparent;""><![endif]-->
      
<!--[if (mso)|(IE)]><td align=""center"" width=""198"" style=""width: 198px;padding: 0px;border-top: 1px solid #95a5a6;border-left: 1px solid #95a5a6;border-right: 1px solid #95a5a6;border-bottom: 1px solid #95a5a6;border-radius: 0px;-webkit-border-radius: 0px; -moz-border-radius: 0px;"" valign=""top""><![endif]-->
<div class=""u-col u-col-33p33"" style=""max-width: 320px;min-width: 200px;display: table-cell;vertical-align: top;"">
  <div style=""height: 100%;width: 100% !important;border-radius: 0px;-webkit-border-radius: 0px; -moz-border-radius: 0px;"">
  <!--[if (!mso)&(!IE)]><!--><div style=""box-sizing: border-box; height: 100%; padding: 0px;border-top: 1px solid #95a5a6;border-left: 1px solid #95a5a6;border-right: 1px solid #95a5a6;border-bottom: 1px solid #95a5a6;border-radius: 0px;-webkit-border-radius: 0px; -moz-border-radius: 0px;""><!--<![endif]-->
  
<table id=""u_content_text_24"" style=""font-family:'Raleway',sans-serif;"" role=""presentation"" cellpadding=""0"" cellspacing=""0"" width=""100%"" border=""0"">
  <tbody>
    <tr>
      <td class=""v-container-padding-padding"" style=""overflow-wrap:break-word;word-break:break-word;padding:30px 10px 10px;font-family:'Raleway',sans-serif;"" align=""left"">
        
  <div class=""v-font-size"" style=""font-size: 14px; color: #ffffff; line-height: 140%; text-align: center; word-wrap: break-word;"">
    <p style=""font-size: 14px; line-height: 140%;""><span style=""background-color: #d7b030; line-height: 19.6px;""><strong><span style=""font-family: Rubik, sans-serif; font-size: 24px; line-height: 33.6px; background-color: #d7b030;"">      <span style=""font-size: 24px; line-height: 33.6px; background-color: #d7b030;""><span style=""font-size: 24px; line-height: 33.6px; background-color: #d7b030;"">Basic</span></span>      </span></strong></span></p>
  </div>

      </td>
    </tr>
  </tbody>
</table>

<table id=""u_content_text_25"" style=""font-family:'Raleway',sans-serif;"" role=""presentation"" cellpadding=""0"" cellspacing=""0"" width=""100%"" border=""0"">
  <tbody>
    <tr>
      <td class=""v-container-padding-padding"" style=""overflow-wrap:break-word;word-break:break-word;padding:30px 10px;font-family:'Raleway',sans-serif;"" align=""left"">
        
  <div class=""v-font-size"" style=""font-size: 14px; line-height: 180%; text-align: center; word-wrap: break-word;"">
    <p style=""font-size: 14px; line-height: 180%;"">This is a new Text block</p>
<p style=""font-size: 14px; line-height: 180%;"">This is a new Text block</p>
<p style=""font-size: 14px; line-height: 180%;"">This is a new Text block</p>
<p style=""font-size: 14px; line-height: 180%;"">This is a new Text block</p>
<p style=""font-size: 14px; line-height: 180%;""> </p>
<p style=""font-size: 14px; line-height: 180%;""><span style=""font-size: 20px; line-height: 36px; color: #d7b030; font-family: 'Open Sans', sans-serif;""><strong>$200.00</strong></span></p>
  </div>

      </td>
    </tr>
  </tbody>
</table>

  <!--[if (!mso)&(!IE)]><!--></div><!--<![endif]-->
  </div>
</div>
<!--[if (mso)|(IE)]></td><![endif]-->
<!--[if (mso)|(IE)]><td align=""center"" width=""200"" style=""width: 200px;padding: 0px;border-top: 1px solid #95a5a6;border-left: 0px solid transparent;border-right: 0px solid transparent;border-bottom: 1px solid #95a5a6;border-radius: 0px;-webkit-border-radius: 0px; -moz-border-radius: 0px;"" valign=""top""><![endif]-->
<div class=""u-col u-col-33p33"" style=""max-width: 320px;min-width: 200px;display: table-cell;vertical-align: top;"">
  <div style=""height: 100%;width: 100% !important;border-radius: 0px;-webkit-border-radius: 0px; -moz-border-radius: 0px;"">
  <!--[if (!mso)&(!IE)]><!--><div style=""box-sizing: border-box; height: 100%; padding: 0px;border-top: 1px solid #95a5a6;border-left: 0px solid transparent;border-right: 0px solid transparent;border-bottom: 1px solid #95a5a6;border-radius: 0px;-webkit-border-radius: 0px; -moz-border-radius: 0px;""><!--<![endif]-->
  
<table id=""u_content_text_26"" style=""font-family:'Raleway',sans-serif;"" role=""presentation"" cellpadding=""0"" cellspacing=""0"" width=""100%"" border=""0"">
  <tbody>
    <tr>
      <td class=""v-container-padding-padding"" style=""overflow-wrap:break-word;word-break:break-word;padding:30px 10px 10px;font-family:'Raleway',sans-serif;"" align=""left"">
        
  <div class=""v-font-size"" style=""font-size: 14px; color: #ffffff; line-height: 140%; text-align: center; word-wrap: break-word;"">
    <p style=""font-size: 14px; line-height: 140%;""><span style=""background-color: #d7b030; line-height: 19.6px;""><strong><span style=""font-family: Rubik, sans-serif; font-size: 24px; line-height: 33.6px; background-color: #d7b030;"">   Standard   </span></strong></span></p>
  </div>

      </td>
    </tr>
  </tbody>
</table>

<table id=""u_content_text_27"" style=""font-family:'Raleway',sans-serif;"" role=""presentation"" cellpadding=""0"" cellspacing=""0"" width=""100%"" border=""0"">
  <tbody>
    <tr>
      <td class=""v-container-padding-padding"" style=""overflow-wrap:break-word;word-break:break-word;padding:30px 10px;font-family:'Raleway',sans-serif;"" align=""left"">
        
  <div class=""v-font-size"" style=""font-size: 14px; line-height: 180%; text-align: center; word-wrap: break-word;"">
    <p style=""font-size: 14px; line-height: 180%;"">This is a new Text block</p>
<p style=""font-size: 14px; line-height: 180%;"">This is a new Text block</p>
<p style=""font-size: 14px; line-height: 180%;"">This is a new Text block</p>
<p style=""font-size: 14px; line-height: 180%;"">This is a new Text block</p>
<p style=""font-size: 14px; line-height: 180%;""> </p>
<p style=""font-size: 14px; line-height: 180%;""><span style=""font-size: 20px; line-height: 36px; color: #d7b030; font-family: 'Open Sans', sans-serif;""><strong>$300.00</strong></span></p>
  </div>

      </td>
    </tr>
  </tbody>
</table>

  <!--[if (!mso)&(!IE)]><!--></div><!--<![endif]-->
  </div>
</div>
<!--[if (mso)|(IE)]></td><![endif]-->
<!--[if (mso)|(IE)]><td align=""center"" width=""198"" style=""width: 198px;padding: 0px;border-top: 1px solid #95a5a6;border-left: 1px solid #95a5a6;border-right: 1px solid #95a5a6;border-bottom: 1px solid #95a5a6;border-radius: 0px;-webkit-border-radius: 0px; -moz-border-radius: 0px;"" valign=""top""><![endif]-->
<div class=""u-col u-col-33p33"" style=""max-width: 320px;min-width: 200px;display: table-cell;vertical-align: top;"">
  <div style=""height: 100%;width: 100% !important;border-radius: 0px;-webkit-border-radius: 0px; -moz-border-radius: 0px;"">
  <!--[if (!mso)&(!IE)]><!--><div style=""box-sizing: border-box; height: 100%; padding: 0px;border-top: 1px solid #95a5a6;border-left: 1px solid #95a5a6;border-right: 1px solid #95a5a6;border-bottom: 1px solid #95a5a6;border-radius: 0px;-webkit-border-radius: 0px; -moz-border-radius: 0px;""><!--<![endif]-->
  
<table id=""u_content_text_28"" style=""font-family:'Raleway',sans-serif;"" role=""presentation"" cellpadding=""0"" cellspacing=""0"" width=""100%"" border=""0"">
  <tbody>
    <tr>
      <td class=""v-container-padding-padding"" style=""overflow-wrap:break-word;word-break:break-word;padding:30px 10px 10px;font-family:'Raleway',sans-serif;"" align=""left"">
        
  <div class=""v-font-size"" style=""font-size: 14px; color: #ffffff; line-height: 140%; text-align: center; word-wrap: break-word;"">
    <p style=""font-size: 14px; line-height: 140%;""><span style=""background-color: #d7b030; line-height: 19.6px;""><strong><span style=""font-family: Rubik, sans-serif; font-size: 24px; line-height: 33.6px; background-color: #d7b030;"">   Premium   </span></strong></span></p>
  </div>

      </td>
    </tr>
  </tbody>
</table>

<table id=""u_content_text_29"" style=""font-family:'Raleway',sans-serif;"" role=""presentation"" cellpadding=""0"" cellspacing=""0"" width=""100%"" border=""0"">
  <tbody>
    <tr>
      <td class=""v-container-padding-padding"" style=""overflow-wrap:break-word;word-break:break-word;padding:30px 10px;font-family:'Raleway',sans-serif;"" align=""left"">
        
  <div class=""v-font-size"" style=""font-size: 14px; line-height: 180%; text-align: center; word-wrap: break-word;"">
    <p style=""font-size: 14px; line-height: 180%;"">This is a new Text block</p>
<p style=""font-size: 14px; line-height: 180%;"">This is a new Text block</p>
<p style=""font-size: 14px; line-height: 180%;"">This is a new Text block</p>
<p style=""font-size: 14px; line-height: 180%;"">This is a new Text block</p>
<p style=""font-size: 14px; line-height: 180%;""> </p>
<p style=""font-size: 14px; line-height: 180%;""><span style=""font-size: 20px; line-height: 36px; color: #d7b030; font-family: 'Open Sans', sans-serif;""><strong>$400.00</strong></span></p>
  </div>

      </td>
    </tr>
  </tbody>
</table>

  <!--[if (!mso)&(!IE)]><!--></div><!--<![endif]-->
  </div>
</div>
<!--[if (mso)|(IE)]></td><![endif]-->
      <!--[if (mso)|(IE)]></tr></table></td></tr></table><![endif]-->
    </div>
  </div>
  </div>
  


  
  
<div class=""u-row-container v-row-padding--vertical"" style=""padding: 0px;background-color: #f4f8ff"">
  <div class=""u-row"" style=""margin: 0 auto;min-width: 320px;max-width: 600px;overflow-wrap: break-word;word-wrap: break-word;word-break: break-word;background-color: transparent;"">
    <div style=""border-collapse: collapse;display: table;width: 100%;height: 100%;background-color: transparent;"">
      <!--[if (mso)|(IE)]><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0""><tr><td style=""padding: 0px;background-color: #f4f8ff;"" align=""center""><table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:600px;""><tr style=""background-color: transparent;""><![endif]-->
      
<!--[if (mso)|(IE)]><td align=""center"" width=""600"" style=""width: 600px;padding: 0px;border-top: 0px solid transparent;border-left: 0px solid transparent;border-right: 0px solid transparent;border-bottom: 0px solid transparent;border-radius: 0px;-webkit-border-radius: 0px; -moz-border-radius: 0px;"" valign=""top""><![endif]-->
<div class=""u-col u-col-100"" style=""max-width: 320px;min-width: 600px;display: table-cell;vertical-align: top;"">
  <div style=""height: 100%;width: 100% !important;border-radius: 0px;-webkit-border-radius: 0px; -moz-border-radius: 0px;"">
  <!--[if (!mso)&(!IE)]><!--><div style=""box-sizing: border-box; height: 100%; padding: 0px;border-top: 0px solid transparent;border-left: 0px solid transparent;border-right: 0px solid transparent;border-bottom: 0px solid transparent;border-radius: 0px;-webkit-border-radius: 0px; -moz-border-radius: 0px;""><!--<![endif]-->
  
<table id=""u_content_social_1"" style=""font-family:'Raleway',sans-serif;"" role=""presentation"" cellpadding=""0"" cellspacing=""0"" width=""100%"" border=""0"">
  <tbody>
    <tr>
      <td class=""v-container-padding-padding"" style=""overflow-wrap:break-word;word-break:break-word;padding:60px 10px 10px;font-family:'Raleway',sans-serif;"" align=""left"">
        
<div align=""center"">
  <div style=""display: table; max-width:167px;"">
  <!--[if (mso)|(IE)]><table width=""167"" cellpadding=""0"" cellspacing=""0"" border=""0""><tr><td style=""border-collapse:collapse;"" align=""center""><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0"" style=""border-collapse:collapse; mso-table-lspace: 0pt;mso-table-rspace: 0pt; width:167px;""><tr><![endif]-->
  
    
    <!--[if (mso)|(IE)]><td width=""32"" style=""width:32px; padding-right: 10px;"" valign=""top""><![endif]-->
    <table align=""left"" border=""0"" cellspacing=""0"" cellpadding=""0"" width=""32"" height=""32"" style=""width: 32px !important;height: 32px !important;display: inline-block;border-collapse: collapse;table-layout: fixed;border-spacing: 0;mso-table-lspace: 0pt;mso-table-rspace: 0pt;vertical-align: top;margin-right: 10px"">
      <tbody><tr style=""vertical-align: top""><td align=""left"" valign=""middle"" style=""word-break: break-word;border-collapse: collapse !important;vertical-align: top"">
        <a href=""https://www.facebook.com/unlayer"" title=""Facebook"" target=""_blank"">
          <span src=""images/image-2.png"" alt=""Facebook"" title=""Facebook"" width=""32"" style=""outline: none;text-decoration: none;-ms-interpolation-mode: bicubic;clear: both;display: block !important;border: none;height: auto;float: none;max-width: 32px !important"">
        </a>
      </td></tr>
    </tbody></table>
    <!--[if (mso)|(IE)]></td><![endif]-->
    
    <!--[if (mso)|(IE)]><td width=""32"" style=""width:32px; padding-right: 10px;"" valign=""top""><![endif]-->
    <table align=""left"" border=""0"" cellspacing=""0"" cellpadding=""0"" width=""32"" height=""32"" style=""width: 32px !important;height: 32px !important;display: inline-block;border-collapse: collapse;table-layout: fixed;border-spacing: 0;mso-table-lspace: 0pt;mso-table-rspace: 0pt;vertical-align: top;margin-right: 10px"">
      <tbody><tr style=""vertical-align: top""><td align=""left"" valign=""middle"" style=""word-break: break-word;border-collapse: collapse !important;vertical-align: top"">
        <a href=""https://www.linkedin.com/company/unlayer/mycompany/"" title=""LinkedIn"" target=""_blank"">
          <span src=""images/image-6.png"" alt=""LinkedIn"" title=""LinkedIn"" width=""32"" style=""outline: none;text-decoration: none;-ms-interpolation-mode: bicubic;clear: both;display: block !important;border: none;height: auto;float: none;max-width: 32px !important"">
        </a>
      </td></tr>
    </tbody></table>
    <!--[if (mso)|(IE)]></td><![endif]-->
    
    <!--[if (mso)|(IE)]><td width=""32"" style=""width:32px; padding-right: 10px;"" valign=""top""><![endif]-->
    <table align=""left"" border=""0"" cellspacing=""0"" cellpadding=""0"" width=""32"" height=""32"" style=""width: 32px !important;height: 32px !important;display: inline-block;border-collapse: collapse;table-layout: fixed;border-spacing: 0;mso-table-lspace: 0pt;mso-table-rspace: 0pt;vertical-align: top;margin-right: 10px"">
      <tbody><tr style=""vertical-align: top""><td align=""left"" valign=""middle"" style=""word-break: break-word;border-collapse: collapse !important;vertical-align: top"">
        <a href=""https://www.instagram.com/unlayer_official/"" title=""Instagram"" target=""_blank"">
          <span src=""images/image-3.png"" alt=""Instagram"" title=""Instagram"" width=""32"" style=""outline: none;text-decoration: none;-ms-interpolation-mode: bicubic;clear: both;display: block !important;border: none;height: auto;float: none;max-width: 32px !important"">
        </a>
      </td></tr>
    </tbody></table>
    <!--[if (mso)|(IE)]></td><![endif]-->
    
    <!--[if (mso)|(IE)]><td width=""32"" style=""width:32px; padding-right: 0px;"" valign=""top""><![endif]-->
    <table align=""left"" border=""0"" cellspacing=""0"" cellpadding=""0"" width=""32"" height=""32"" style=""width: 32px !important;height: 32px !important;display: inline-block;border-collapse: collapse;table-layout: fixed;border-spacing: 0;mso-table-lspace: 0pt;mso-table-rspace: 0pt;vertical-align: top;margin-right: 0px"">
      <tbody><tr style=""vertical-align: top""><td align=""left"" valign=""middle"" style=""word-break: break-word;border-collapse: collapse !important;vertical-align: top"">
        <a href=""https://twitter.com/unlayerapp"" title=""X"" target=""_blank"">
          <span src=""images/image-5.png"" alt=""X"" title=""X"" width=""32"" style=""outline: none;text-decoration: none;-ms-interpolation-mode: bicubic;clear: both;display: block !important;border: none;height: auto;float: none;max-width: 32px !important"">
        </a>
      </td></tr>
    </tbody></table>
    <!--[if (mso)|(IE)]></td><![endif]-->
    
    
    <!--[if (mso)|(IE)]></tr></table></td></tr></table><![endif]-->
  </div>
</div>

      </td>
    </tr>
  </tbody>
</table>

<table id=""u_content_text_30"" style=""font-family:'Raleway',sans-serif;"" role=""presentation"" cellpadding=""0"" cellspacing=""0"" width=""100%"" border=""0"">
  <tbody>
    <tr>
      <td class=""v-container-padding-padding"" style=""overflow-wrap:break-word;word-break:break-word;padding:10px 100px 30px;font-family:'Raleway',sans-serif;"" align=""left"">
        
  <div class=""v-font-size"" style=""font-size: 14px; color: #000000; line-height: 170%; text-align: center; word-wrap: break-word;"">
    <p style=""font-size: 14px; line-height: 170%;"">UNSUBSCRIBE   |   PRIVACY POLICY   |   WEB</p>
<p style=""font-size: 14px; line-height: 170%;""> </p>
<p style=""font-size: 14px; line-height: 170%;"">Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore.</p>
  </div>

      </td>
    </tr>
  </tbody>
</table>

<table style=""font-family:'Raleway',sans-serif;"" role=""presentation"" cellpadding=""0"" cellspacing=""0"" width=""100%"" border=""0"">
  <tbody>
    <tr>
      <td class=""v-container-padding-padding"" style=""overflow-wrap:break-word;word-break:break-word;padding:0px;font-family:'Raleway',sans-serif;"" align=""left"">
        
  <table height=""0px"" align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" width=""100%"" style=""border-collapse: collapse;table-layout: fixed;border-spacing: 0;mso-table-lspace: 0pt;mso-table-rspace: 0pt;vertical-align: top;border-top: 1px solid #BBBBBB;-ms-text-size-adjust: 100%;-webkit-text-size-adjust: 100%"">
    <tbody>
      <tr style=""vertical-align: top"">
        <td style=""word-break: break-word;border-collapse: collapse !important;vertical-align: top;font-size: 0px;line-height: 0px;mso-line-height-rule: exactly;-ms-text-size-adjust: 100%;-webkit-text-size-adjust: 100%"">
          <span>&#160;</span>
        </td>
      </tr>
    </tbody>
  </table>

      </td>
    </tr>
  </tbody>
</table>

<table id=""u_content_image_3"" style=""font-family:'Raleway',sans-serif;"" role=""presentation"" cellpadding=""0"" cellspacing=""0"" width=""100%"" border=""0"">
  <tbody>
    <tr>
      <td class=""v-container-padding-padding"" style=""overflow-wrap:break-word;word-break:break-word;padding:30px 10px;font-family:'Raleway',sans-serif;"" align=""left"">
        
<table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0"">
  <tr>
    <td style=""padding-right: 0px;padding-left: 0px;"" align=""center"">
      
      <span align=""center"" border=""0"" src=""images/image-4.png"" alt=""image"" title=""image"" style=""outline: none;text-decoration: none;-ms-interpolation-mode: bicubic;clear: both;display: inline-block !important;border: none;height: auto;float: none;width: 100%;max-width: 149px;"" width=""149"" class=""v-src-width v-src-max-width""/>
      
    </td>
  </tr>
</table>

      </td>
    </tr>
  </tbody>
</table>

  <!--[if (!mso)&(!IE)]><!--></div><!--<![endif]-->
  </div>
</div>
<!--[if (mso)|(IE)]></td><![endif]-->
      <!--[if (mso)|(IE)]></tr></table></td></tr></table><![endif]-->
    </div>
  </div>
  </div>
  


    <!--[if (mso)|(IE)]></td></tr></table><![endif]-->
    </td>
  </tr>
  </tbody>
  </table>
  <!--[if mso]></div><![endif]-->
  <!--[if IE]></div><![endif]-->
</body>

</html>
");
            body.Replace("_ClinetUnique", (name+"."+surname));
            body.Replace("_EmailUnique", email);

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(senderEmail, "pvzm xomn wahc jyyz"),
                EnableSsl = true,
            };

            using (var message = new MailMessage(senderEmail, recipientEmail)
            {
                Body = body.ToString(),
                IsBodyHtml = true
            })
            {
                try
                {
                    smtpClient.Send(message);
                    Console.WriteLine("Email sent successfully!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error sending email: {ex.Message}");
                }
            }
        }



        //public static async Task<HttpResponseMessage> SendSimpleMessageAsync()
        //{
        //    var apiUrl = "https://api.mailgun.net/v3/sandbox575d747be27743ef9fad7e171a480707.mailgun.org/messages";
        //    var apiKey = "238f8202ae914b7cf3205ea50b22d99c-07f37fca-1eae79d9";

        //    var from = "postmaster@sandbox575d747be27743ef9fad7e171a480707.mailgun.org";
        //    var to = "Rasul asdsad Rasul <resulresull510@gmail.com>";
        //    var subject = "Hello Rasul asdsad Rasul";
        //    var text = "Congratulations Rasul asdsad Rasul, you just sent an email with Mailgun! You are truly awesome!";

        //    using (var client = new HttpClient())
        //    {
        //        client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.ASCII.GetBytes($"api:{apiKey}")));

        //        var content = new FormUrlEncodedContent(new[]
        //        {
        //        new KeyValuePair<string, string>("from", from),
        //        new KeyValuePair<string, string>("to", to),
        //        new KeyValuePair<string, string>("subject", subject),
        //        new KeyValuePair<string, string>("text", text)
        //    });

        //        var response = await client.PostAsync(apiUrl, content);
        //        return response;
        //    }
        //}
        //public static async Task SendSimpleMessageAsync(string emailTo)
        //{
        //    var apiKey = "f216c8268b6c08cb6f8453cec0274569-07f37fca-ed059f81";
        //    var apiUrl = "https://api.mailgun.net/v3/sandbox575d747be27743ef9fad7e171a480707.mailgun.org/messages";

        //    var from = "Mailgun Sandbox <postmaster@sandbox575d747be27743ef9fad7e171a480707.mailgun.org>";
        //    var to = emailTo;
        //    var subject = "Subject of the email";
        //    var plainTextContent = "Plain text content of the email";
        //    var htmlContent = "<p>HTML content of the email</p>";

        //    var client = new HttpClient();
        //    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

        //    var content = new StringContent(
        //        $"{{\"personalizations\": [{{\"to\": [{{\"email\": \"{to}\"}}]}}], \"from\": {{\"email\": \"{from}\"}}, \"subject\": \"{subject}\", \"content\": [{{\"type\": \"text/plain\", \"value\": \"{plainTextContent}\"}}, {{\"type\": \"text/html\", \"value\": \"{htmlContent}\"}}]}}",
        //        Encoding.UTF8,
        //        "application/json"
        //    );

        //    var response = await client.PostAsync(apiUrl, content);

        //    Console.WriteLine(response.StatusCode);
        //    Console.WriteLine(response.Headers);
        //    Console.WriteLine(await response.Content.ReadAsStringAsync());

        //}

        // You can see a record of this email in your logs: https://app.mailgun.com/app/logs.

        // You can send up to 300 emails/day from this sandbox server.
        // Next, you should add your own domain so you can send 10000 emails/month for free.

    }
}