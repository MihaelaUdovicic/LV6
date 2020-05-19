using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace LV6
{
    class CareTaker
    {
        public Memento PreviousState { get; set; }
        Stack<Memento> stack = new Stack<Memento>();

        public void PushStack(Memento memento)
        {
            stack.Push(memento);
        }
        public Memento PopStack()
        {
            return stack.Pop();
        }

    }
}
