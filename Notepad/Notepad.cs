using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Notepad : Form
    {
        public Notepad()
        {
            InitializeComponent();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Notepad_Load(object sender, EventArgs e)
        {
            
           
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            demo d = new demo();
            d.WindowState = FormWindowState.Maximized;
            d.MdiParent = this;
            d.Show();
        }
    }
}
