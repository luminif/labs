﻿using System;
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

        private void textBox1_TextChanged(object sender, EventArgs e) //ввод A
        {
            if (!int.TryParse(textBox1.Text, out _))
            {
                MessageBox.Show("Введите число!");
            }

            _textBox1 = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox2.Text, out _))
            {
                MessageBox.Show("Введите число!");
            }

            _textBox2 = textBox2.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            Data.B.PushFront(int.Parse(_textBox2));

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

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Data.A.PushFront(int.Parse(_textBox1));

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
    }
}
