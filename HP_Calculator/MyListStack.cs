using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HP_Calculator
{
    class MyListStack : Stack
    {
        private LinkedList<int> linkedListStack = null;
        private int Pointer;

        public MyListStack(Stack b)
        {
            linkedListStack = new LinkedList<int>();
            Pointer = 0;

            if (b != null)
            {
                int pointer2;
                int i = 0;

                int[] array = new int[10];

                pointer2 = b.GetCount();
                if (pointer2 > 0)
                {
                    i = 1;
                }

                while (pointer2 > 0)
                {
                    array[i] = b.Pop();
                    pointer2--;
                    i++;
                }
                i--;
                while (i > 0)
                {
                    this.Push(array[i]);
                    i--;
                }
            }
        }

        public override void Push(int elementToPush)
        {
            if (Pointer == 0)
            {
                linkedListStack.AddFirst(elementToPush);
            }
            else
            {
                linkedListStack.AddAfter(linkedListStack.Last, elementToPush);
            }
            Pointer++;
        }

        public override int Pop()
        {
            int value;

            value = linkedListStack.Last.Value;
            linkedListStack.RemoveLast();
            Pointer--;

            return value;
        }

        public override int GetCount()
        {
            return linkedListStack.Count();
        }

        public override int GetElementOnNumber(int myElement)
        {
            if (myElement > Pointer)
            {
                Console.WriteLine("Huh. The Element Number can't be bigger than the Pointer.\n");
                return 0;
            }
            else
            {
                return linkedListStack.ElementAt(myElement);
            }
        }
    }
}
