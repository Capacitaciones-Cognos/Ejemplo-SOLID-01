using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_SOLID_03.Normal
{
    public class OrderService
    {
        public readonly MailGmailService mailGmailService;

        public OrderService(MailGmailService mailGmailService)
        {
            this.mailGmailService = mailGmailService;
        }

        public void Create(OrderModel orderModel)
        {
            // TODO: codigo para crear la orden

            // Enviar notificacion de la orden creada por email
            mailGmailService.send("juanito@gmail.com", "Example");
        }
    }
}
