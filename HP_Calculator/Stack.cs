using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HP_Calculator
{
    public abstract class Stack
    {
        public Stack()
        {
            
        }
        public enum Modifiers { Add, Subtract, Multiply, Divide };
        public abstract int Pop();
        public abstract void Push(int NumberToPush);
        public abstract int GetCount();
        public abstract int GetElementOnNumber(int Number);

        public void EmptyStack(Stack stack)
        {
            for (stack.){

            }
        }
    }
}
