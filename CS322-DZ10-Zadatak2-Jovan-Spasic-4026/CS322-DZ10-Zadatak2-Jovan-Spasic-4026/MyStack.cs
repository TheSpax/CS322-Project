using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS322_DZ10_Zadatak2_Jovan_Spasic_4026
{
    internal class MyStack
    {
        private ArrayList arr;

        public MyStack() {
            arr = new ArrayList();
        }

        public void push(object? element)
        {
            arr.Add(element);
        }

        public void pop()
        {
            arr.RemoveAt(arr.Count - 1);
        }

        public int size()
        {
            return arr.Count;
        }

        public void print()
        {
            foreach(Object i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
