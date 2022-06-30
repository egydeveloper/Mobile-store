using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mobile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BCheckout_Click(object sender, EventArgs e)
        {
            MobileContext context = new MobileContext();
            Bill bill = new Bill();
            context.Bills.Add(bill);
            context.SaveChanges();
        }
    }
}
