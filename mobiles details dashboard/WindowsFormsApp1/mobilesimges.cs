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
using System.IO;

namespace WindowsFormsApp1
{
    public partial class mobilesimges : DevExpress.XtraEditors.XtraForm
    {
        entitystore context;
        mobiledetails objmob;
        mobile_images objimg;
        string mobnm;
        BindingSource bdata;

        public mobilesimges()
        {
            InitializeComponent();
        }
        private byte[] converttobyte(string path)
        {
            byte[] data = null;
            FileInfo finfo = new FileInfo(path);
            long numbytes = finfo.Length;
            FileStream fstream = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            data = br.ReadBytes((int)numbytes);
            return data;

        }
        private void Btnimg1_Click(object sender, EventArgs e)
        {
            dialogimg1.Title = "please select a photo";
            dialogimg1.Filter = "JPG|*.jpg|PNG|*.png|GIF|*gif";
            dialogimg1.Multiselect = false;
            if (dialogimg1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.img1.ImageLocation = dialogimg1.FileName;
            }
        }

        private void Btnimage2_Click(object sender, EventArgs e)
        {
            dialogimg2.Title = "please select a photo";
            dialogimg2.Filter = "JPG|*.jpg|PNG|*.png|GIF|*gif";
            dialogimg2.Multiselect = false;
            if (dialogimg2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.img2.ImageLocation = dialogimg2.FileName;
            }
        }

        private void Btnimg3_Click(object sender, EventArgs e)
        {
            dialogimg3.Title = "please select a photo";
            dialogimg3.Filter = "JPG|*.jpg|PNG|*.png|GIF|*gif";
            dialogimg3.Multiselect = false;
            if (dialogimg3.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                this.img3.ImageLocation = dialogimg3.FileName;
            }
        }

        private void Btn1add_Click(object sender, EventArgs e)
        {
            try
            {
                var d = context.mobdetailes.Where(n => n.name == mobnm).Select(n => n.id).FirstOrDefault();
                mobile_images itm = new mobile_images() { mobildetaileId=d, nameproduct = mobnm, productimg1 = converttobyte(this.img1.ImageLocation), productimg2 = converttobyte(this.img2.ImageLocation), productimg3 = converttobyte(this.img3.ImageLocation) };

                context.mobimages.Add(itm);
                context.SaveChanges();
                dataimages.Rows.Clear();
                dataimages.Refresh();
                this.Mobilesimges_Load(sender, e);
                MessageBox.Show("added");
            }
            catch
            {
                MessageBox.Show("can't added");

            }
        }

        private void Mobilesimges_Load(object sender, EventArgs e)
        {
            context = new entitystore();
            objmob = new mobiledetails();
            objimg = new mobile_images();
            var datashows = context.mobimages.Select(n => new { n.mobildetaileId,n.nameproduct, n.productimg1,n.productimg2,n.productimg3 }).ToList();
            bdata = new BindingSource();
            bdata.DataSource = datashows;
            dataimages.DataSource = bdata;
            dataimages.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataimages.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataimages.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataimages.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            for (int i=0;i<dataimages.Columns.Count-1;i++)
            {
                int clow = dataimages.Columns[i].Width;
                dataimages.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dataimages.Columns[i].Width = clow;
            }
            dataimages.DefaultCellStyle.SelectionBackColor = Color.Black;
            dataimages.DefaultCellStyle.Font = new Font("Tahoma", 14);
        }

        private void Textname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textname.Text != "")
                {
                    mobnm = textname.Text.ToString().ToLower();
                }

            }
            catch
            {
                MessageBox.Show("invalid name");
            }
        }

        private void Mobdetail_Click(object sender, EventArgs e)
        {
            this.Hide();
            objmob.Show();
        }

       
    }
}