using System;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        class Element
        {
            public Element Next;
            object value;
            public object Value
            {
                get
                {
                    return value;
                }
            }
            public Element(object value)
            {
                this.value = value;
            }
        }
        class Stack
        {
            Element top = null;
            int lenght = 0;
            public void Add(object value)
            {
                if (top == null)
                {
                    top = new Element(value);
                }
                else
                {
                    Element newElement = new Element(value); ;
                    newElement.Next = top;
                    top = newElement;
                }
                lenght++;
            }
            public void Show()
            {
                Element tempTop = top;
                for(int i = 0; i < lenght; i++)
                {
                    Console.WriteLine(tempTop.Value);
                    tempTop = tempTop.Next;
                }
            }
        }
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Add(1);
            stack.Add(2);
            stack.Add(3);
            stack.Show();
            
        }
    }
}
