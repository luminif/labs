using System.Windows.Forms;

namespace Lab3
{
    public partial class ResultB : Form
    {
        public ResultB()
        {
            PrintTree.Print(this, Data.DT2.Root, PrintTree.X, PrintTree.Y, PrintTree.X / 2);
            InitializeComponent();
        }
    }
}
