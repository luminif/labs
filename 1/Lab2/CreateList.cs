using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Lab2
{
    public partial class CreateList : Form
    {
        private string _textBox1; 
        private string _textBox2;

        public CreateList()
        {
            InitializeComponent();
        }

        private int[] ParseString(string str)
        {
            bool ok = true;

            foreach (char c in str)
            {
                if (!char.IsDigit(c) && !char.IsWhiteSpace(c))
                {
                    MessageBox.Show("Неверный ввод!");
                    _textBox2 = "";
                    ok = false;
                    break;
                }
            }

            if (ok)
                return str.Split(' ').Select(x => int.Parse(x)).ToArray();
            return new int[] { };
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e) //список A
        {
            _textBox2 = textBox2.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e) //список B
        {
            _textBox1 = textBox4.Text;
        }

        private void button2_Click(object sender, EventArgs e) //кнопка B
        {
            Data.b = ParseString(_textBox1);
            Data.B.Create(Data.b);

            for (int i = 0; i < Data.b.Length; i++)
            {
                listBox2.Items.Add(Data.b[i].ToString());
            }
        }

        private void button1_Click_1(object sender, EventArgs e) //кнопка A
        {
            Data.a = ParseString(_textBox2);
            Data.A.Create(Data.a);

            for (int i = 0; i < Data.a.Length; i++)
            {
                listBox1.Items.Add(Data.a[i].ToString());
            }
        }
    }
}
