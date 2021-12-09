using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_SOLID_03.Solid
{
    public class MailOutlookServiceSolid : IMailService
    {
        // atributos propios de este proveedor 
        
        public void send(string to, string subject)
        {
            // logica para envio desde outlook
        }
    }
}
