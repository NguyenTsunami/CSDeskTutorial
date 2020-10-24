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

namespace DemoToolboxDeskApp
{
    public partial class CarDetail : Form
    {
        ArrayList list = new ArrayList();
        public CarDetail()
        {
            InitializeComponent();
        }

        private void CarDetail_Load(object sender, EventArgs e)
        {
            list.Add(new Car("Lambogini", "LBGN", 90, 200, "E:\\FAL20\\PRN292\\DemoToolboxDeskApp\\images\\car01.jpg"));
            list.Add(new Car("Ferrari", "FRR", 90, 180, "E:\\FAL20\\PRN292\\DemoToolboxDeskApp\\images\\car02.jpg"));
            list.Add(new Car("Toyota", "TYT", 90, 200, "E:\\FAL20\\PRN292\\DemoToolboxDeskApp\\images\\car03.jpg"));
            list.Add(new Car("Suzuki", "SZK", 90, 200, "E:\\FAL20\\PRN292\\DemoToolboxDeskApp\\images\\car04.jpg"));
            list.Add(new Car("VinaFast", "VNF", 90, 200, "E:\\FAL20\\PRN292\\DemoToolboxDeskApp\\images\\car05.jpg"));

            cbxModel.DataSource = list;
            cbxModel.DisplayMember = "Model";
        }

        private void cbxModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            Car car = (Car)cbxModel.SelectedItem;
            txtEngine.Text = car.Engine;
            txtMileage.Text = car.Mileage.ToString();
            txtMxSpeed.Text = car.Mxspeed.ToString();
            picture.Image = Image.FromFile(car.Img);
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
