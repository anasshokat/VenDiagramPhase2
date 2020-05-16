using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRedAlert
{
    class Stack
    {
        char[] array;
        int top;
        int maxstk;
        public Stack(int capacity)
        {
            top = -1;
            maxstk = capacity;
            array = new char[maxstk];
        }
        public bool isEmpty() 
        {
            if (top == -1)
                return true;
            else
                return false;
        }
        public bool isFull()
        {
            if (top == maxstk - 1)
                return true;
            else
                return false;
        }
        public void Push(char element)
        {
            if (!isFull()) 
            {
                top++;
                array[top] = element;
            }
        }
        public char Pop()
        {
            char element = array[top];
            top--;
            return element;
        }
    }
}
