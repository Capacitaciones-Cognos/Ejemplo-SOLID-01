using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test_SOLID_03.Normal;
using Test_SOLID_03.Solid;

namespace Test_SOLID_03
{
    public partial class Form1 : Form
    {
        public OrderService orderService;
        public OrderServiceSolid orderServiceSolid;
        public Form1()
        {
            InitializeComponent();

            orderService = new OrderService(new MailGmailService());
            //orderServiceSolid = new OrderServiceSolid(new MailGmailServiceSolid());
            orderServiceSolid = new OrderServiceSolid(new MailOutlookServiceSolid());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            orderService.Create(new OrderModel());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            orderServiceSolid.Create(new OrderModelSolid());
        }
    }
}
