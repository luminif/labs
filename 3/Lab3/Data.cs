using System.Windows.Forms;

namespace Lab3
{
    static class Data
    {
        public static char info;
        public static int key;
        public static DichotomyTree DT = new DichotomyTree();
        public static DichotomyTree DT2 = new DichotomyTree();

        public static int ParseInt(string c)
        {

            if (!int.TryParse(c, out int x))
            {
                MessageBox.Show("Неверный формат!");
            }

            return x;
        }

        public static char ParseChar(string c)
        {

            if (!char.TryParse(c, out char x))
            {
                MessageBox.Show("Неверный формат! (нужно ввести символ)");
            }

            return x;
        }
    }
}
