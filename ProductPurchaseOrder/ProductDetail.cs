using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductPurchaseOrder
{
    public partial class ProductDetail : Form
    {
        ArrayList productList = new ArrayList();
        public ProductDetail()
        {
            InitializeComponent();
        }

        public GroupBox GroupboxOrder { get => groupboxOrder; set => groupboxOrder = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public TextBox TxtAmount { get => txtAmount; set => txtAmount = value; }
        public TextBox TxtPrice { get => txtPrice; set => txtPrice = value; }
        public ComboBox CbxProduct { get => cbxProduct; set => cbxProduct = value; }
        public Button BtnOke { get => btnOke; set => btnOke = value; }
        public Button BtnCancle { get => btnCancle; set => btnCancle = value; }
        public NumericUpDown NumQuantity { get => numQuantity; set => numQuantity = value; }

        private void btnOke_Click(object sender, EventArgs e)
        {

        }

        private void ProductDetail_Load(object sender, EventArgs e)
        {
            //Load product list
            productList.Add(new Product("Synthetic White", 1500));
            productList.Add(new Product("Bennzoic Acid", 2000));
            productList.Add(new Product("beta-Pinene", 1450));
            productList.Add(new Product("Brown FK", 1700));

            //Load combobox
            foreach (Product p in productList)
            {
                cbxProduct.Items.Add(p);
            }
            cbxProduct.SelectedIndex = 0;

            //Default value of txt
            txtAmount.Text = "0";
            numQuantity.Value = 0;
            Product ptemp = (Product)cbxProduct.SelectedItem;
            txtPrice.Text = ptemp.Price + "";
            btnOke.Enabled = false;
        }

        private void cbxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product p = (Product)cbxProduct.SelectedItem;
            txtPrice.Text = p.Price + "";
            txtAmount.Text = (p.Price * numQuantity.Value) + "";
        }

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {
            if (numQuantity.Value == 0)
            {
                btnOke.Enabled = false;
            }
            else
            {
                btnOke.Enabled = true;
            }

            Product p = (Product)cbxProduct.SelectedItem;
            txtAmount.Text = (p.Price * numQuantity.Value) + "";
        }
    }
}
