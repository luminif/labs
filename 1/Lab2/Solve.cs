using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Solve : Form
    {
        public Solve()
        {
            InitializeComponent();

            Node p = Data.A.first;

            while (p != null)
            {
                listBox1.Items.Add(p.Info);
                p = p.Link;
            }

            Node q = Data.B.first;

            while (q != null)
            {
                listBox2.Items.Add(q.Info);
                q = q.Link;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Data.A.DeleteFromList(Data.B);
            Node p = Data.A.first;

            while (p != null)
            {
                listBox1.Items.Add(p.Info);
                p = p.Link;
            }
        }
    }
}
