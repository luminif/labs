using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class DeleteBegin : Form
    {

        public DeleteBegin()
        {
            InitializeComponent();

            DoubleNode p = Data.A.head;

            if (p != null)
            {
                p = p.Next;

                while (p != Data.A.head)
                {
                    listBox1.Items.Add(p.Info);
                    p = p.Next;
                }
            }

            DoubleNode q = Data.B.head;

            if (q != null)
            {
                q = q.Next;

                while (q != Data.B.head)
                {
                    listBox2.Items.Add(q.Info);
                    q = q.Next;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Data.A.DeleteFront();

            DoubleNode p = Data.A.head;

            if (p != null)
            {
                p = p.Next;

                while (p != Data.A.head)
                {
                    listBox1.Items.Add(p.Info);
                    p = p.Next;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            Data.B.DeleteFront();

            DoubleNode p = Data.B.head;

            if (p != null)
            {
                p = p.Next;

                while (p != Data.B.head)
                {
                    listBox2.Items.Add(p.Info);
                    p = p.Next;
                }
            }
        }
    }
}
