using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_Store
{
    public partial class Customer_Form : DevExpress.XtraEditors.XtraForm
    {
        CustomerContext context = new CustomerContext();
        Customer Custom;
        CustomerProduct CProduct;
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=mobilestore;Integrated Security=true ");
        string Cname;
        int Cphone;
        string Caddress;
        string product;
        int CPhone;
        int quantity;
        public Customer_Form()
        {
         
            InitializeComponent();
        }

        private void Customer_Form_Load(object sender, EventArgs e)
        {
            Custom = new Customer();
            CProduct = new CustomerProduct();
           
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void Add_customer_Click_1(object sender, EventArgs e)
        {
            Customer c = new Customer();
            if (Cname == " " || Cphone == 0 || textAddress.Text == " ")
            {
                MessageBox.Show("invalid inputs");
            }

            else
            {
                try
                {
                    int Phone;
                    Phone = int.Parse(textPhone.Text);
                    Customer dataobject = new Customer() { Name = Cname, Address = Caddress, Phone = Cphone };
                    context.Customers.Add(dataobject);
                    context.SaveChanges();
                    gridControl1.DataSource = context.Customers.ToList();
                    this.Customer_Form_Load(sender, e);
                    MessageBox.Show("Customer Added");
                }
                catch
                {
                    MessageBox.Show("invalid inputs");
                }
              


            }
        }

        private void Add_Product_Click(object sender, EventArgs e)
        {
            CustomerProduct cp = new CustomerProduct();
            if (product == " " || quantity == 0 || CPhone == 0)
            {
                MessageBox.Show("invalid inputs");

            }
            else
            {
                try
                {
                    var d = context.Customers.Where(n => n.Phone == CPhone).Select(n => n.ID).FirstOrDefault();

                    if(d == 0)
                    {
                        MessageBox.Show("Customer Not Found");

                    }
                    if (d == 1)
                    { 
                   
                    CustomerProduct customerProduct = new CustomerProduct() {ProductName = product, Quantity = quantity, CustomerPhone = CPhone, Customer_ID = d};
                    context.CustomerProducts.Add(customerProduct);
                    context.SaveChanges();
                    gridControl2.Refresh();
                    gridControl2.DataSource = context.CustomerProducts.ToList();
                    this.Customer_Form_Load(sender, e);
                    MessageBox.Show("Product Added Successfully..!");
                    }
                }
                catch
                {
                    MessageBox.Show("invalid inputs");

                }
            }
        }
        private void textName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textName.Text != "")
                {
                    Cname = textName.Text.ToString().ToLower();
                }

            }
            catch
            {
                MessageBox.Show("invalid name");
            }
        }

        private void textAddress_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textAddress.Text != "")
                {
                    Caddress = textAddress.Text.ToString().ToLower();
                }

            }
            catch
            {
                MessageBox.Show("invalid address");
            }
        }

        private void textPhone_TextChanged(object sender, EventArgs e)
        {
            try
            {
             if(textPhone.Text != "")
                {
                    Cphone = int.Parse(textPhone.Text);
                }
            }
           catch
            {
                MessageBox.Show("invalid Phone");

            }
        }

        private void textCustomerPhone_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textCustomerPhone.Text != "")
                {
                    CPhone = int.Parse(textCustomerPhone.Text);

                }

            }
            catch
            {
                MessageBox.Show("invalid phone number");

            }


        }

        private void textProductName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textProductName.Text != "")
                {
                    product = textProductName.Text.ToString().ToLower();
                }

            }
            catch
            {
                MessageBox.Show("invalid product name");
            }
        }

        private void textQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textQuantity.Text != "")
                {
                    quantity = int.Parse(textQuantity.Text);

                }

            }
            catch
            {
                MessageBox.Show("invalid Quantity");

            }
        }

      
    }
}