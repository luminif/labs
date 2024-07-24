using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class AddPos : Form
    {
        private string _textBox1;
        private string _textBox2;
        private string _textBox3;
        private string _textBox4;

        public AddPos()
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _textBox1 = textBox1.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            _textBox3 = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            _textBox4 = textBox4.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            Data.B.PushAt(int.Parse(_textBox4), int.Parse(_textBox3));

            Node p = Data.B.first;

            while (p != null)
            {
                listBox2.Items.Add(p.Info);
                p = p.Link;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            _textBox2 = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Data.A.PushAt(int.Parse(_textBox2), int.Parse(_textBox1));

            Node p = Data.A.first;

            while (p != null)
            {
                listBox1.Items.Add(p.Info);
                p = p.Link;
            }
        }
    }
}
