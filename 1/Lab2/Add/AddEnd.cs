using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class AddEnd : Form
    {
        private string _textBox1; 
        private string _textBox2;

        public AddEnd()
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

        private void button1_Click(object sender, EventArgs e) //A
        {
            listBox1.Items.Clear();
            Data.A.PushBack(int.Parse(_textBox1));

            Node p = Data.A.first;

            while (p != null)
            {
                listBox1.Items.Add(p.Info);
                p = p.Link;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            _textBox2 = textBox2.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            Data.B.PushBack(int.Parse(_textBox2));

            Node p = Data.B.first;

            while (p != null)
            {
                listBox2.Items.Add(p.Info);
                p = p.Link;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) //A
        {
            _textBox1 = textBox1.Text;
        }
    }
}
