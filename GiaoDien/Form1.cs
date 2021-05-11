using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class HOME : Form
    {
        public HOME()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2D form2D = new Form2D();
            form2D.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3D form3D = new Form3D();
            form3D.Show();
        }
    }
}
