using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

public class Mail : MonoBehaviour {

    public InputField youremail;
    public InputField theiremail;
    public InputField subject;
    public InputField message;
    public Text error;
    public InputField path;

    public void sendmail_start()
    {
        StartCoroutine(sendmail());
    }

    public IEnumerator sendmail()
    {
        yield return new WaitForSeconds(0.0f);
        if (message.text == "" || subject.text == "" || youremail.text == "")
        {
            error.text = "Vul alsjeblieft alle velden in.";
        }
        else {
            MailMessage mail = new MailMessage();

            mail.From = new MailAddress(youremail.text);
            mail.To.Add(theiremail.text);
            mail.Subject = subject.text;
            mail.Body = "Mail from : " + youremail.text + " \n =======================================================" + message.text;

            if (path.text != "")
            {
                Attachment attachment = null;
                attachment = new Attachment(path.text);
                mail.Attachments.Add(attachment);
            }

            SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
            smtpServer.Port = 587;
            smtpServer.Credentials = new System.Net.NetworkCredential("youremail", "yourpassword") as ICredentialsByHost;
            smtpServer.EnableSsl = true;
            ServicePointManager.ServerCertificateValidationCallback =
                delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
            smtpServer.Send(mail);
            error.text = "De email is succesvol verzonden.";
            //sofruitstoned
        }
    }

}
