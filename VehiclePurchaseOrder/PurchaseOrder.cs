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

namespace VehiclePurchaseOrder
{
    public partial class PurchaseOrder : Form
    {
        Dictionary<TreeNode, Vehicle> map = new Dictionary<TreeNode, Vehicle>();
        ArrayList list = new ArrayList();
        public PurchaseOrder()
        {
            InitializeComponent();
        }

        private void PurchaseOrder_Load(object sender, EventArgs e)
        {
            //Load list
            list.Add(new Vehicle("Desmosedici RR", "Ducati", 2005, 125, 40000, 2));
            list.Add(new Vehicle("Desmosedici RR", "Ducati", 2006, 125, 42000, 2));
            list.Add(new Vehicle("YZF R1", "Yamaha", 2006, 150, 52000, 2));
            list.Add(new Vehicle("Accord", "Honda", 2006, 300, 75000, 4));
            list.Add(new Vehicle("Accord", "Honda", 2007, 400, 70000, 4));
            list.Add(new Vehicle("Accent", "Huyndai", 2006, 300, 80000, 4));
            list.Add(new Vehicle("Accent", "Huyndai", 2007, 400, 85000, 4));

            //Load Domain Feature
            domFeatureList.Items.Add("A/C System");
            domFeatureList.Items.Add("Stereo Deck System");
            domFeatureList.Items.Add("Insurance");
            domFeatureList.Items.Add("Service Contract");
            domFeatureList.SelectedIndex = 0;

            //Load tree view
            TreeNode root = new TreeNode("Vehicles");
            TreeNode node1 = new TreeNode("Two Wheeler");
            root.Nodes.Add(node1);
            TreeNode node2 = new TreeNode("Four Wheeler");
            root.Nodes.Add(node2);
            foreach (Vehicle car in list)
            {
                TreeNode leave = new TreeNode(car.Name);
                map.Add(leave, car);
                if (car.Wheeler == 2)
                {
                    node1.Nodes.Add(leave);
                }
                else if (car.Wheeler == 4)
                {
                    node2.Nodes.Add(leave);
                }
            }
            treeList.Nodes.Add(root);


        }
    }
}
