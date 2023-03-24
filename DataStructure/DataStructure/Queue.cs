using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class CQueue
    {
        private CNodeQueue mTail;
        private CNodeQueue mHead;

        public CNodeQueue Tail
        {
            get { return mTail; }
            set { mTail = value; }
        }

        public CNodeQueue Head
        {
            get { return mHead; }
            set { mHead = value; }
        }
  
        public object Enqueue(int insertValue)
        {
            lock(this)
            {
                if (this.Empty())
                {
                    this.Head = this.Tail = new CNodeQueue(insertValue, null);
                }
                else
                {
                    this.Head = new CNodeQueue(insertValue, this.Head);
                }
                return "Valore inserito alla coda: " + insertValue;
            }
        }

        public object Dequeue()
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
                    Value = this.Tail.Datum;
                    this.Tail = this.Tail.Next;
                    return "Valore tolto dalla coda: " + Value;
                }
            }
        }

        public bool Empty()
        {
            lock (this)
            {
                return this.Head == null;
            }
        }

        public void PrimaDispari()
        {

        }
    }

    class CNodeQueue
    {
        private int mDatum;
        private CNodeQueue mNext;

        public int Datum
        {
            get { return mDatum; }
            set { mDatum = value; }
        }

        public CNodeQueue Next
        {
            get { return mNext; }
            set { mNext = value; }
        }

        public CNodeQueue()
        {
            this.Datum = 0;
            this.Next = null;
        }

        public CNodeQueue(int Datum, CNodeQueue Next)
        {
            this.Datum = Datum;
            this.Next = Next;
        }
    }
}
