using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace LojaVirtual.Libraries.Email
{
    public class ContatoEmail
    {
        public static void EnviarContatoPorEmail(Contato contato)
        {
            /*
             * SMTP -> Servidor que vai enviar a mensagem.
             */
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("samuevicenca@gmail.com", "");
            smtp.EnableSsl = true;

            /*
             * MailMessage -> Contruir a mensagem 
             */
            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress("samuevicenca@gmail.com");
            mensagem.To.Add(new MailAddress("samuevicenca@gmail.com"));
        }
    }
}
