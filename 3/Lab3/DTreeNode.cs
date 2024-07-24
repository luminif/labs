using System;

namespace Lab3
{
    public class DTreeNode
    {
        private char info;
        private int key;
        private DTreeNode left;
        private DTreeNode right;

        public char Info
        {
            get { return info; }
            set { info = value; }
        }

        public DTreeNode Left
        {
            get { return left; }
            set { left = value; }
        }

        public DTreeNode Right
        {
            get { return right; }
            set { right = value; }
        }

        public int Key
        {
            get { return key; }
            set { key = value; }
        }

        public DTreeNode()
        {

        }

        public DTreeNode(char info, int key)
        {
            Info = info;
            Key = key;
        }

        public DTreeNode(char info, int key, DTreeNode left, DTreeNode right)
        {
            Info = info;
            Key = key;
            Left = left;
            Right = right;
        }
    }

    public class DichotomyTree
    {
        private DTreeNode root;
        public DTreeNode Root
        {
            get { return root; }
            set { root = value; }
        }

        public DichotomyTree()
        {
            root = null;
        }

        DTreeNode Find(DTreeNode p, int key)
        {
            DTreeNode q = null;

            if (p == null)
            {
                q = null;
            }

            else
            {
                if (key > q.Key)
                {
                    q = Find(q.Left, key);
                }

                else if (key < q.Key)
                {
                    q = Find(q.Right, key);
                }

                q = root;
            }

            return q;
        }

        public DTreeNode Ins(DTreeNode p, int key, char info)
        {
            if (p == null)
            {
                p = new DTreeNode(info, key, null, null);
            }

            else
            {
                if (key > p.Key)
                {
                    p.Right = Ins(p.Right, key, info);
                }

                else if (key < p.Key)
                {
                    p.Left = Ins(p.Left, key, info);
                }
            }

            return p;
        }

        public void KLP(DTreeNode root)
        {
            if (root != null)
            {
                Console.Write(root.Info + " ");
                KLP(root.Right);
                KLP(root.Left);
            }
        }

        public void Destruction(DichotomyTree DT)
        {
            DT.root = null;
        }

        public void Copy(DTreeNode root, int key, DichotomyTree DT)
        {
            if (root != null)
            {
                if (root.Key == key)
                {
                    DT.Root = Ins(DT.Root, key, root.Info);
                }

                Copy(root.Right, key, DT);
                Copy(root.Left, key, DT);
            }
        }
    }
}
