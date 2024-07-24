namespace Lab2
{
    public class Node
    {
        private int info;
        private Node link;

        public int Info
        {
            get { return info; }
            set { info = value; }
        }

        public Node Link
        {
            get { return link; }
            set { link = value; }
        }

        public Node() { }

        public Node(int info)
        {
            Info = info;
        }

        public Node(int info, Node link)
        {
            Info = info;
            Link = link;
        }
    }

    public class SingleLinkedList
    {
        public Node first;

        public SingleLinkedList()
        {
            first = null;
        }

        public void Create(int[] data)
        {
            Node last;

            if (data.Length == 0)
            {
                first = null;
            }

            else
            {
                first = new Node(data[0], null);
                last = first;

                for (int i = 1; i < data.Length; i++)
                {
                    Node p = new Node(data[i], null);
                    last.Link = p;
                    last = p;
                }
            }
        }

        public Node Find(int x)
        {
            Node ptr = first;

            while (ptr != null && ptr.Info != x)
            {
                ptr = ptr.Link;
            }

            return ptr;
        }

        public void Delete(ref Node p)
        {
            if (p != null)
            {
                Node q;

                if (p == first)
                {
                    first = first.Link;
                }

                else
                {
                    q = first;

                    while (q.Link != p)
                    {
                        q = q.Link;
                    }

                    q.Link = p.Link;
                }

                p = null;
            }
        }

        public void DeleteFromList(SingleLinkedList L)
        {
            Node q = first;

            while (q != null)
            {
                Node p = L.first;
                Node x = null;
                Node s = q;

                while (p != null)
                {
                    x = L.Find(q.Info);
                    p = p.Link;
                }

                if (x != null)
                {
                    Delete(ref s);
                }

                q = q.Link;
            }
        }

        public void DeleteFront()
        {
            if (first != null)
            {
                first = first.Link;
            }
        }

        public void DeleteBack()
        {
            Node p = first;

            if (p != null && p.Link != null)
            {
                while (p.Link.Link != null)
                {
                    p = p.Link;
                }

                p.Link = null;
            }

            else
            {
                first = null;
            }
        }

        public void DeleteAt(int pos)
        {
            Node ptr;
            Node p = first;

            for (int i = 1; i < pos && p != null; i++)
            {
                p = p.Link;
            }

            if (p != null)
            {
                if (p == first)
                {
                    first = first.Link;
                    p = null;
                    p = first;
                }

                else
                {
                    ptr = first;

                    while (ptr.Link != p)
                    {
                        ptr = ptr.Link;
                    }

                    ptr.Link = p.Link;
                    p = null;
                    p = ptr;
                }
            }
        }

        public void PushFront(int x)
        {
            Node p = new Node
            {
                Link = first
            };

            first = p;
            p.Info = x;
        }

        public void PushBack(int x)
        {
            Node p = first;

            if (p != null)
            {
                while (p.Link != null)
                {
                    p = p.Link;
                }

                p.Link = new Node(x);
            }

            else
            {
                first = new Node(x);
            }
        }

        public void PushAt(int pos, int x)
        {
            pos--;
            Node p = new Node(x, null);

            if (first == null)
            {
                first = p;
            }

            else
            {
                Node q = first;

                for (int i = 1; i < pos && q.Link != null; i++)
                {
                    q = q.Link;
                }

                if (x == 0)
                {
                    p.Link = first;
                    first = p;
                }

                else
                {
                    if (q.Link != null)
                    {
                        p.Link = q.Link;
                    }

                    q.Link = p;
                }
            }
        }
    }
}
