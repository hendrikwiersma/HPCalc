using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HP_Calculator
{
    class ArrayStack:Stack
    {
        private int[] ArrayStack = null;
        private int Pointer;

        public ArrayStack(Stack b)
        {
            ArrayStack = new int[10];   //Tis the the Array where the Values will be stored. Max 10 items.
            Pointer = 0;    //A pointer to keep track of where to Pop or Push the next Value.

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
            ArrayStack[Pointer++] = elementToPush;
        }

        public override int Pop()
        {
            return ArrayStack[--Pointer];
        }

        public override int GetCount()
        {
            return Pointer;
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
                return ArrayStack[myElement];
            }
        }
    }
    }

