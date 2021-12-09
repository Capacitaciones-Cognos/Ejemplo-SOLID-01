using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_SOLID_03.Solid
{
    public interface IMailService
    {
        void send(string to, string subject);
    }
}
