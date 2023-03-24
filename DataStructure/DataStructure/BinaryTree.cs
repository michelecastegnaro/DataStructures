using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class CBinaryTree
    {
        private CTreeNode mRoot;

        public CTreeNode Root
        {
            get { return mRoot; }
            set { mRoot = value; }
        }

        public object Insert(int insertValue)
        {
            lock (this)
            {
                if (this.Empty())
                {
                    this.Root = new CTreeNode(insertValue);
                    return "Primo nodo albero: " + insertValue;
                }
                else
                {
                    this.Root.InsertNode(insertValue);
                    return Convert.ToString(this.Root.InsertNode(insertValue));
                }
            }
        }

        public bool Empty()
        {
            lock (this)
            {
                return this.Root == null;
            }
        }

        public List<CTreeNode> LevelOrder()
        {
            Queue<CTreeNode> Queue = new Queue<CTreeNode>();
            List<CTreeNode> List = new List<CTreeNode>();

            if (this.Root != null)
                Queue.Enqueue(this.Root);
            while (Queue.Count > 0)
            {
                CTreeNode Node = Queue.Dequeue();
                List.Add(Node);
                if (Node.Left != null)
                    Queue.Enqueue(Node.Left);
                if (Node.Right != null)
                    Queue.Enqueue(Node.Right);
            }
            return List;
        }

        public void PreOrder()
        {
            if (!this.Empty())
            {
                this.Root.PreOrder();
            }
        }

        public void PostOrder()
        {
            if (!this.Empty())
            {
                this.Root.PostOrder();
            }
        }

        public void InOrder()
        {
            if (!this.Empty())
            {
                this.Root.InOrder();
            }
        }
    }

    class CTreeNode
    {
        private int mDatum;
        private CTreeNode mLeft;
        private CTreeNode mRight;

        public int Datum
        {
            get { return mDatum; }
            set { mDatum = value; }
        }
        public CTreeNode Left
        {
            get { return mLeft; }
            set { mLeft = value; }
        }
        public CTreeNode Right
        {
            get { return mRight; }
            set { mRight = value; }
        }

        public CTreeNode()
        {
            this.Datum = 0;
            this.Right = null;
            this.Left = null;
        }
        public CTreeNode(int Datum)
        {
            this.Datum = Datum;
            this.Right = null;
            this.Left = null;
        }

        public object InsertNode(int insertValue)
        {
            lock (this)
            {
                if (insertValue < this.Datum)
                {
                    if (this.Left == null)
                    {
                        this.Left = new CTreeNode(insertValue);
                    }
                    else
                    {
                        this.Left.InsertNode(insertValue);
                    }
                    return "Nodo sinistro albero: " + insertValue;
                }
                else if (insertValue > this.Datum)
                {
                    if (this.Right == null)
                    {
                        this.Right = new CTreeNode(insertValue);
                    }
                    else
                    {
                        this.Right.InsertNode(insertValue);
                    }
                    return "Nodo destro albero: " + insertValue;
                }
                else
                {
                    return new Exception("Error");
                }
            }
        }

        public void PreOrder()
        {
            Console.WriteLine(this.Datum);
            if (this.Left != null)
            {
                this.Left.PreOrder();
            }
            if (this.Right != null)
            {
                this.Right.PreOrder();
            }
        }

        public void PostOrder()
        {
            if (this.Left != null)
            {
                this.Left.PostOrder();
            }
            if (this.Right != null)
            {
                this.Right.PostOrder();
            }
            Console.WriteLine(this.Datum);
        }

        public void InOrder()
        {
            if (this.Left != null)
            {
                this.Left.InOrder();
            }
            Console.WriteLine(this.Datum);
            if (this.Right != null)
            {
                this.Right.InOrder();
            }
        }
    }
}
