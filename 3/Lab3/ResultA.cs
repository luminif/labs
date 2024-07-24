using System.Windows.Forms;

namespace Lab3
{
    public partial class ResultA : Form
    {
        public ResultA()
        {
            InitializeComponent();
            PrintTree.Print(this, Data.DT.Root, PrintTree.X, PrintTree.Y, PrintTree.X / 2);
        }
    }
}
