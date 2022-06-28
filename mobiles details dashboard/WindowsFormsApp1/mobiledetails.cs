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
    public partial class mobiledetails : DevExpress.XtraEditors.XtraForm
    {
        string mobname;
        double mobprice;
        double mobscreen;
        int mobstorage;
        int mobram;
        int mobbattery;
        int mobfrontcamera;
        int mobbackcamera;
        string mobprocessor;
        string mobandroid;
        string mobnetwork;
        int mobquantity;
        double mobwarrenty;
        string mobdate;
        entitystore context;
        mobildetaile objectmob;
        BindingSource bdata;
        mobilesimges objectimg;
        public mobiledetails()
        {
            InitializeComponent();
        }

        private void Mobiledetails_Load(object sender, EventArgs e)
        {
            context = new entitystore();
            objectmob = new mobildetaile();
            var datashows = context.mobdetailes.Select(n => new {n.id,n.name,n.price,n.screen,n.storage,n.ram,n.battery,n.front_camera,n.back_camera,n.processor,n.android,n.network,n.quantity,n.warranty,n.date}).ToList();
            bdata = new BindingSource();
            bdata.DataSource = datashows;
            griddatabase.DataSource = bdata;
            objectimg = new mobilesimges();
            griddatabase.DefaultCellStyle.SelectionBackColor = Color.PowderBlue;
            griddatabase.DefaultCellStyle.SelectionForeColor = Color.Red;
            griddatabase.DefaultCellStyle.Font = new Font("Tahoma", 12);


        }

        private void Textnm_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if(textnm.Text!="")
                {
                    mobname = textnm.Text.ToString().ToLower();
                }

            }
            catch
            {
                MessageBox.Show("invalid name");
            }

        }


        private void Textprice_EditValueChanged(object sender, EventArgs e)
        {
            if (textprice.Text != "")
            {
                mobprice = double.Parse(textprice.Text);
            }
            else
            {
                MessageBox.Show("invalid inputs");
            }
        }
        private void Textscreen_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (textscreen.Text !="")
                {
                    mobscreen = double.Parse(textscreen.Text);
                }

            }
            catch
            {
                MessageBox.Show("invalid screen");
            }
        }

        private void Textstorage_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (textstorage.Text != "")
                {
                    mobstorage =int.Parse( textstorage.Text);
                }

            }
            catch
            {
                MessageBox.Show("invalid storage");
            }
        }

        private void Textram_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (textram.Text != "")
                {
                    mobram =int.Parse( textram.Text);
                }

            }
            catch
            {
                MessageBox.Show("invalid ram");
            }
        }

        private void Textbattery_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (textbattery.Text != "")
                {
                    mobbattery =int.Parse( textbattery.Text);
                }

            }
            catch
            {
                MessageBox.Show("invalid battery");
            }
        }

        private void Textfrontcamera_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (textfrontcamera.Text != "")
                {
                    mobfrontcamera = int.Parse(textfrontcamera.Text);
                }

            }
            catch
            {
                MessageBox.Show("invalid front_camera");
            }
        }

        private void Textbackcamera_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (textbackcamera.Text != "")
                {
                    mobbackcamera =int.Parse( textbackcamera.Text);
                }

            }
            catch
            {
                MessageBox.Show("invalid back_camera");
            }
        }

        private void Textprocessor_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (textprocessor.Text != "")
                {
                    mobprocessor = textprocessor.Text.ToString().ToLower();
                }

            }
            catch
            {
                MessageBox.Show("invalid processor");
            }
        }

        private void Textandroid_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (textandroid.Text != "")
                {
                    mobandroid = textandroid.Text.ToString().ToLower();
                }

            }
            catch
            {
                MessageBox.Show("invalid android");
            }
        }

        private void Textnetwork_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (textnetwork.Text != "")
                {
                    mobnetwork = textnetwork.Text.ToString().ToLower();
                }

            }
            catch
            {
                MessageBox.Show("invalid network");
            }
        }

        private void Textquantity_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (textquantity.Text != "")
                {
                    mobquantity = int.Parse(textquantity.Text);
                }

            }
            catch
            {
                MessageBox.Show("invalid quantity");
            }
        }

        private void Textwarranty_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (textwarranty.Text != "")
                {
                    mobwarrenty =double.Parse( textwarranty.Text);
                }

            }
            catch
            {
                MessageBox.Show("invalid warrenty");
            }
        }

        private void Datetext_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (datetext.Text != "")
                {
                    mobdate = datetext.Text.ToString().ToLower();
                }

            }
            catch
            {
                MessageBox.Show("invalid date");
            }
        }

        private void Btnadd_Click(object sender, EventArgs e)
        {
            if (mobname == null && mobprice == 0 && mobquantity == 0)
            {
                MessageBox.Show("invalid inputs");
            }
            else
            {
                bool ad = objectmob.Add(mobname, mobprice, mobscreen, mobstorage, mobram, mobbattery, mobfrontcamera, mobbackcamera, mobprocessor, mobandroid, mobnetwork, mobquantity, mobwarrenty, mobdate);
                if (ad == true)
                {
                    griddatabase.Rows.Clear();
                    griddatabase.Refresh();
                    this.Mobiledetails_Load(sender, e);
                    MessageBox.Show("added");

                }
                else
                {
                    griddatabase.Rows.Clear();
                    griddatabase.Refresh();
                    this.Mobiledetails_Load(sender, e);
                    MessageBox.Show("the item already exist and increase quantity by= " + mobquantity);
                }

            }
          
        }

        private void Mobimg_Click(object sender, EventArgs e)
        {
            this.Hide();
            objectimg.Show();
        }

       
    }
}