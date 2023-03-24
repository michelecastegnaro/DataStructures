using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace ConsoleApp1
{
    class CMaxHeap
    {
        private int[] mInfos;
        private int mPosition;

        public CMaxHeap()
        {
            mInfos = new int[15];
            mPosition = 0;
        }
        public CMaxHeap(int[] vettore)
        {
            foreach (int e in vettore)
                insert(e);
        }

        private int left(int node)
        {
            return ((2 * node) + 1);
        }

        private int right(int node)
        {
            return ((2 * node) + 2);
        }

        private int parent(int node)
        {
            return (node - 1) / 2;
        }

        public int max()
        {

            return mInfos[0];
        }

        public void insert(int elemento)
        {
            if (mPosition == mInfos.Lenght)
            {
                //expand vector
            }
            else
            {
                int current = mPosition;
                mInfos[current] = elemento;
                //upstairs element
                while (elemento > mInfos[parent(current)])
                {
                    mInfos[current] = mInfos[parent(current)];
                    mInfos[parent(current)] = elemento;
                    current = parent(current);
                }
                mPosition++;
            }

        }

        public int delete()
        {
            

        }
    }
}
