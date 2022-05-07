using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Packages
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form2D_Click(object sender, EventArgs e)
        {
            Form1 Form2D =new Form1();
            Form2D.ShowDialog();
        }

        private void Form3D_Click(object sender, EventArgs e)
        {
            Form2 Form3D = new Form2();
            Form3D.ShowDialog();
        }
    }
}
