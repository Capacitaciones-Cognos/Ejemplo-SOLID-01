using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_SOLID_03.Solid
{
    public class OrderServiceSolid
    {
        public readonly IMailService mailService;
        public OrderServiceSolid(IMailService mailService)
        {
            this.mailService = mailService;
        }

        public void Create(OrderModelSolid orderModel)
        {
            // TODO: codigo para crear la orden

            // Enviar notificacion de la orden creada por email
            mailService.send("juanito@gmail.com", "Example");
        }

    }
}
