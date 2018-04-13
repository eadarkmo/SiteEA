using System;
using System.Net.Mail;
using System.Net;

/// <summary>
/// Summary description for Email_
/// </summary>
namespace SiteEA.AppCode.Funcao
{
    public class Mail
    {
        public Mail()
        {
        }
        public void enviarEmail(string strEmail, string strNome, string strAssunto, string strMensagem, bool bIsHTML)
        {
            string emailFrom = AppCode.Funcao.Utilitarios.PegarParametroCodificado("EmailServidor");
            string nomeFrom = AppCode.Funcao.Utilitarios.PegarParametroCodificado("ServerName");
            string senhaEmail = AppCode.Funcao.Utilitarios.PegarParametroCodificado("EmailSenha");
            string servidorSMTP = AppCode.Funcao.Utilitarios.PegarParametroCodificado("ServidorSMTP");
            string sServidorPorta = AppCode.Funcao.Utilitarios.PegarParametroCodificado("ServidorPorta");
            int iServidorPorta = 25;
            if (DMFramework.Validacao.IsNumeric(sServidorPorta))
                iServidorPorta = int.Parse(sServidorPorta);


            MailAddress from = new MailAddress(emailFrom, nomeFrom, System.Text.Encoding.GetEncoding("iso-8859-1"));
            MailAddress to = new MailAddress(strEmail, strNome);
            MailMessage message = new MailMessage(from, to);
            message.Subject = strAssunto;
            message.SubjectEncoding = System.Text.Encoding.GetEncoding("iso-8859-1");
            message.Body = strMensagem;
            message.IsBodyHtml = bIsHTML;
            message.BodyEncoding = System.Text.Encoding.GetEncoding("iso-8859-1");
            message.Priority = MailPriority.Normal;

            SmtpClient client = new SmtpClient();
            client.Host = servidorSMTP;
            client.Port = iServidorPorta;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential(emailFrom, senhaEmail);
            client.EnableSsl = true;
            client.Send(message);
        }

        #region Ajustar
        public void enviarEmail(string de, string para, string assunto, string copia, string mensagem, bool emHtml)
        {
            System.Net.Mail.MailMessage email = new System.Net.Mail.MailMessage();
            email.From = new System.Net.Mail.MailAddress(de);


            if (para == "" && copia == "")
            {
                throw new ArgumentException("Destinatário e Cópia não informados. Favor informar ao menos um.");
            }
            //if (para != "")
            //{

            //    ValidarEmail(para);
            //}
            //if (copia != "")
            //{

            //    ValidarEmail(copia);
            //}

            this.prepararLista(email.To, para);
            email.Subject = assunto;

            email.IsBodyHtml = emHtml;
            if (copia != "")
            {
                this.prepararLista(email.CC, copia);
            }
            email.Body = mensagem;

            email.BodyEncoding = System.Text.Encoding.UTF8;
            email.SubjectEncoding = System.Text.Encoding.UTF8;

            System.Net.Mail.SmtpClient emailCliente = new System.Net.Mail.SmtpClient();

            emailCliente.Host = "mail.lunamarcoline.com";
            emailCliente.Port = 25;

            // Include credentials if the server requires them.
            emailCliente.UseDefaultCredentials = false;

            //CredentialCache cc = new CredentialCache();
            NetworkCredential nc = new NetworkCredential("ppkgm@hotmail.com", "motorola6");
            //cc.Add("mail.contasabertas.org", 25, "Negotiate", nc);
            emailCliente.Credentials = nc;

            //client.DeliveryMethod = SmtpDeliveryMethod.SpecifiedPickupDirectory
            //client.DeliveryMethod = SmtpDeliveryMethod.Network;
            //client.Credentials = CredentialCache.DefaultNetworkCredentials;

            //emailCliente.Send(message);
        }

        private void prepararLista(System.Net.Mail.MailAddressCollection colecao, string lista)
        {
            string[] arrayLista = lista.Split(';');
            for (int i = 0; i <= (arrayLista.Length - 1); i++)
            {
                colecao.Add(arrayLista[i]);
            }
        }
        #endregion
    }
}