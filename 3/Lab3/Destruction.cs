using System;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Destruction : Form
    {
        public Destruction()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data.DT.Destruction(Data.DT);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Data.DT2.Destruction(Data.DT2);
        }
    }
}
