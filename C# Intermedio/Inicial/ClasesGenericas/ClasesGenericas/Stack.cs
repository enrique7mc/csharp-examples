using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesGenericas
{
    public class Stack
    {
        private int position;
        private int[] data = new int[10];

        public void Push(int obj) 
        { 
            data[position++] = obj; 
        }

        public int Pop() 
        { 
            return data[--position]; 
        }
    }
}
