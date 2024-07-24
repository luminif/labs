using System;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Solve : Form
    {
        private string textBox;

        public Solve()
        {
            InitializeComponent();
            PrintTree.Print(this, Data.DT.Root, PrintTree.X, PrintTree.Y, PrintTree.X / 2);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox = textBox2.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResultB res = new ResultB();
            res.Show();
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Data.ParseInt(textBox);
            Data.DT2.Copy(Data.DT.Root, x, Data.DT2);
        }
    }
}
