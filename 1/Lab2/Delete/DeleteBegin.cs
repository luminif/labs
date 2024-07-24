using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class DeleteBegin : Form
    {
        public DeleteBegin()
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
            Data.A.DeleteFront();

            Node p = Data.A.first;

            while (p != null)
            {
                listBox1.Items.Add(p.Info);
                p = p.Link;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            Data.B.DeleteFront();

            Node p = Data.B.first;

            while (p != null)
            {
                listBox2.Items.Add(p.Info);
                p = p.Link;
            }
        }
    }
}
