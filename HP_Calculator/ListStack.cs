using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HP_Calculator
{
    class ListStack:Stack
    {
        private List<int> listStack = null; //Create an empty List which can hold integers.

        private int stackPointer;

        public ListStack(Stack b)   //Use my Stack class.
        {
            listStack = new List<int>();    //Constructor for the List.
            stackPointer = 0;

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
            listStack.Add(elementToPush);
            stackPointer++;
        }

        public override int Pop()
        {
            int value;
            --stackPointer;
            value = listStack[stackPointer];
            listStack.Remove(stackPointer);
            return value;
        }

        public override int GetCount()
        {
            return stackPointer;
        }

        public override int GetElementOnNumber(int myElement)
        {
            if (myElement > stackPointer)
            {
                Console.WriteLine("Huh. The Element Number can't be bigger than the Pointer.\n");
                return 0;
            }
            else
            {
                return listStack.ElementAt(myElement);
            }
        }
    }
}
