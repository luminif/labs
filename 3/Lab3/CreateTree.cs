using System;
using System.Windows.Forms;

namespace Lab3
{
    public partial class CreateTree : Form
    {
        private string _textBox1; 
        private string _textBox2;

        public CreateTree()
        {
            InitializeComponent();
        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            _textBox2 = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data.key = Data.ParseInt(_textBox1);
            Data.info = Data.ParseChar(_textBox2);
            Data.DT.Root = Data.DT.Ins(Data.DT.Root, Data.key, Data.info);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResultA vis = new ResultA();
            vis.Show();
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _textBox1 = textBox1.Text;
        }
    }
}
