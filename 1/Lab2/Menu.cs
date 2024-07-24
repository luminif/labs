using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Выйти?", "Выход", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void созданиеСпискаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateList cr_list = new CreateList();
            cr_list.Show();
        }

        private void вНачалоToolStripMenuItem_Click(object sender, EventArgs e) //добавление в начало
        {
            AddBegin addBegin = new AddBegin();
            addBegin.Show();
        }

        private void вКонецToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEnd addEnd = new AddEnd();
            addEnd.Show();
        }

        private void вПроизвольнуюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPos addPos = new AddPos();
            addPos.Show();
        }

        private void вНачалеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteBegin deleteBegin = new DeleteBegin();
            deleteBegin.Show();
        }

        private void вКонцеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteBack deleteBack = new DeleteBack();
            deleteBack.Show();
        }

        private void вПроизвольнойТочкеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeletePos deletePos = new DeletePos();
            deletePos.Show();
        }

        private void обработкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Solve solve = new Solve();
            solve.Show();
        }

        private void разрушениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Destruction destruction = new Destruction();
            destruction.Show();
        }
    }
}
