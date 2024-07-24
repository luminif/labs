using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class AddBegin : Form
    {
        private string _textBox1;
        private string _textBox2;

        public AddBegin()
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

        private void textBox1_TextChanged(object sender, EventArgs e) //ввод A
        {

            if (!int.TryParse(textBox1.Text, out int x))
            {
                MessageBox.Show("Введите число!");
            }

            _textBox1 = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            if (!int.TryParse(textBox2.Text, out int x))
            {
                MessageBox.Show("Введите число!");
            }

            _textBox2 = textBox2.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            Data.B.PushFront(int.Parse(_textBox2));

            Node p = Data.B.first;

            while (p != null)
            {
                listBox2.Items.Add(p.Info);
                p = p.Link;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Data.A.PushFront(int.Parse(_textBox1));

            Node p = Data.A.first;

            while (p != null)
            {
                listBox1.Items.Add(p.Info);
                p = p.Link;
            }
        }
    }
}
