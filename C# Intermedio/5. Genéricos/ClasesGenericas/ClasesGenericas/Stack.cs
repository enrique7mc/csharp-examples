using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesGenericas
{
    public class Stack<T>
    {
        private int position;
        private T[] data = new T[10];

        public void Push(T obj) 
        { 
            data[position++] = obj; 
        }

        public T Pop() 
        { 
            return data[--position]; 
        }
    }
}
