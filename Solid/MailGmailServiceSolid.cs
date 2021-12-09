using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_SOLID_03.Solid
{
    public class MailGmailServiceSolid : IMailService
    {
        // atributos para conectarse al servidor SMTP por Gmail

        public void send(string to, string subject)
        {
            // logica para enviar el correo por gmail
        }
    }
}
