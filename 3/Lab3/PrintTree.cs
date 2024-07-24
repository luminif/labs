using System.Drawing;
using System.Windows.Forms;

namespace Lab3
{
    public static class PrintTree
    {
        public const int X = 339;
        public const int Y = 42;

        public static void Print(Form form, DTreeNode root, int x, int y, int dx)
        {
            if (root != null)
            {
                Button label = new Button()
                {
                    Text = root.Key + "(" + root.Info + ")",
                    Location = new Point(x, y),
                    Size = new Size(60, 60),
                    TabIndex = 1
                };

                form.Controls.Add(label);
                Print(form, root.Left, x - dx / 2, y + 100, dx / 2);
                Print(form, root.Right, x + dx / 2, y + 100, dx / 2);
            }
        }
    }
}
