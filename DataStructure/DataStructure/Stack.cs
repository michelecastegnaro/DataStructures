using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class CStack
    {
        private CNodeStack mLastNode;
        private CNodeStack mFirstNode;

        public CNodeStack LastNode
        {
            get { return mLastNode; }
            set { mLastNode = value; }
        }

        public CNodeStack FirstNode
        {
            get { return mFirstNode; }
            set { mFirstNode = value; }
        }

        public object Pop(int insertValue)
        {
            lock (this)
            {
                if (this.Empty())
                {
                    this.FirstNode = this.LastNode = new CNodeStack(insertValue, null);
                }
                else
                {
                    this.FirstNode = new CNodeStack(insertValue, this.FirstNode);
                }
                return "Valore inserito alla pila: " + insertValue;
            }
        }

        public object Push()
        {
            lock (this)
            {
                int Value = 0;
                if (this.Empty())
                {
                    return new Exception("Error");
                }
                else
                {
                    Value = this.FirstNode.Datum;
                    this.FirstNode = this.FirstNode.Next;
                    return "Valore tolto dalla pila: " + Value;
                }
            }
        }

        public bool Empty()
        {
            lock (this)
            {
                return this.FirstNode == null;
            }
        }
    }

    class CNodeStack
    {
        private int mDatum;
        private CNodeStack mNext;

        public int Datum
        {
            get { return mDatum; }
            set { mDatum = value; }
        }

        public CNodeStack Next
        {
            get { return mNext; }
            set { mNext = value; }
        }

        public CNodeStack()
        {
            this.Datum = 0;
            this.mNext = null;
        }

        public CNodeStack(int Datum, CNodeStack Next)
        {
            this.Datum = Datum;
            this.Next = Next;
        }
    }
}
