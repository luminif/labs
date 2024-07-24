using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Destruction : Form
    {
        public Destruction()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data.A.first = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Data.B.first = null;
        }
    }
}
