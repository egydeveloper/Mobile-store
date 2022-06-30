using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WindowsFormsApp1
{
    public partial class mobiles : DevExpress.XtraEditors.XtraForm
    {
        mobiledetails mobform;
        mobilesimges imgform;
        public mobiles()
        {
            InitializeComponent();
        }

        private void Mobiles_Load(object sender, EventArgs e)
        {
            mobform = new mobiledetails();
            imgform = new mobilesimges();
            mobform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            mobform.TopLevel = false;
            mobform.AutoScroll = true;
            this.panel1.Controls.Add(mobform);
            mobform.Show();
        }

        private void Mobiles_Resize(object sender, EventArgs e)
        {
            mobform.Height = this.panel1.Height;
            mobform.Width = this.panel1.Width;
            imgform.Height = this.panel1.Height;
            imgform.Width = this.panel1.Width;
        }

        private void ToolStripLabel1_Click(object sender, EventArgs e)
        {
       
            this.panel1.Controls.Remove(imgform);
            mobform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            mobform.TopLevel = false;
            mobform.AutoScroll = true;
            this.panel1.Controls.Add(mobform);
            mobform.Show();
        }

        private void ToolStripLabel2_Click(object sender, EventArgs e)
        {
            
            this.panel1.Controls.Remove(mobform);
            imgform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            imgform.TopLevel = false;
            imgform.AutoScroll = true;
            this.panel1.Controls.Add(imgform);
            imgform.Show();
        }

        private void ToolStripLabel4_Click(object sender, EventArgs e)
        {

        }
    }
}