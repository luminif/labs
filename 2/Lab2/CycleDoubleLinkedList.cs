namespace Lab2
{
    public class DoubleNode
    {
        private int info;
        private DoubleNode next;
        private DoubleNode prev;

        public int Info
        {
            get { return info; }
            set { info = value; }
        }

        public DoubleNode Next
        {
            get { return next; }
            set { next = value; }
        }

        public DoubleNode Prev
        {
            get { return prev; }
            set { prev = value; }
        }

        public DoubleNode()
        {

        }

        public DoubleNode(int info)
        {
            Info = info;
        }

        public DoubleNode(int info, DoubleNode next, DoubleNode prev)
        {
            Info = info;
            Next = next;
            Prev = prev;
        }
    }

    public class CycleDoubleLinkedList
    {
        public DoubleNode head;

        public CycleDoubleLinkedList()
        {
            head = new DoubleNode();
            head.Next = head;
            head.Prev = head;
        }

        public void Create(int[] data)
        {
            DoubleNode p;
            for (int i = 0; i < data.Length; i++)
            {
                p = new DoubleNode(data[i])
                {
                    Next = head,
                    Prev = head.Prev
                };

                head.Prev.Next = p;
                head.Prev = p;
            }
        }

        public void DeleteFromList(CycleDoubleLinkedList L)
        {
            if (head != null)
            {
                DoubleNode q = head.Next;

                if (L.head != null)
                {
                    while (q != head)
                    {
                        DoubleNode p = L.head.Next;

                        while (p != L.head && p.Info != q.Info)
                        {
                            p = p.Next;
                        }

                        if (p != L.head)
                        {
                            q.Prev.Next = q.Next;
                            q.Next.Prev = q.Prev;
                        }

                        p = null;
                        q = q.Next;
                    }
                }
            }
        }

        public void DeleteFront()
        {
            if (head != null)
            {
                head.Next = head.Next.Next;
                head.Next.Prev = head;
            }
        }

        public void DeleteBack()
        {
            if (head != null)
            {
                head.Prev = head.Prev.Prev;
                head.Prev.Next = head;
            }
        }

        public void DeleteAt(int pos)
        {
            if (head != null)
            {
                DoubleNode p;
                DoubleNode q = head.Next;

                if (pos == 1)
                {
                    DeleteFront();
                }

                else
                {
                    for (int i = 1; i < pos - 1 && q != head; i++)
                    {
                        q = q.Next;
                    }

                    if (q != head)
                    {
                        q.Next = q.Next.Next;
                        q.Next.Prev = head;
                    }
                }
            }
        }

        public void PushFront(int x)
        {
            if (head != null)
            {
                DoubleNode p = new DoubleNode(x)
                {
                    Prev = head,
                    Next = head.Next
                };

                head.Next.Prev = p;
                head.Next = p;
            }
        }

        public void PushBack(int x)
        {
            if (head != null)
            {
                DoubleNode p = new DoubleNode(x)
                {
                    Next = head,
                    Prev = head.Prev
                };

                head.Prev.Next = p;
                head.Prev = p;
            }
        }

        public void PushAt(int pos, int x)
        {
            if (head != null)
            {
                if (head.Next == head)
                {
                    PushFront(x);
                }

                else
                {
                    DoubleNode q = head.Next;

                    for (int i = 1; i < pos && q != head; i++)
                    {
                        q = q.Next;
                    }

                    if (q != head)
                    {
                        DoubleNode p = new DoubleNode(x, q, q.Prev);
                        q.Prev.Next = p;
                        q.Prev = p;
                    }

                    else
                    {
                        PushBack(x);
                    }
                }
            }
        }
    }
}
