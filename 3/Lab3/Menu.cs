using System;
using System.Windows.Forms;

namespace Lab3
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

        private void созданиеДереваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTree create_tree = new CreateTree();
            create_tree.Show();
        }

        private void обработкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Solve solve = new Solve();
            solve.Show();
        }

        private void разрушениеДереваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Destruction dst = new Destruction();
            dst.Show();
        }
    }
}
