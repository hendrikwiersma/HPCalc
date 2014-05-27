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
        public enum Modifier { Add, Subtract, Multiply, Divide };
        public abstract int Pop();
        public abstract void Push(int NumberToPush);
        public abstract int GetCount();
        public abstract int GetElementOnNumber(int Number);
        public Form1 form;
        public bool ApplyModifiers(Stack stack, Modifier mod){
            int firstValue = stack.Pop();
            form.listBox1.Items.Add("FirstValue is removed from stack.");
            int secondValue = stack.Pop();
            form.listBox1.Items.Add("SecondValue is removed from stack.");
            if (mod == Modifier.Add){
                Push(firstValue+secondValue);
                form.listBox1.Items.Add("Pushed "+(firstValue+secondValue)+" to stack.");
            }
            else if (mod == Modifier.Divide){
                if(secondValue == 0){
                    form.listBox1.Items.Add("Can't devide by zero.");
                    return false;
                }
                Push(firstValue/secondValue);
                form.listBox1.Items.Add("Pushed "+(firstValue/secondValue)+" to stack.");
            }
            else if (mod == Modifier.Multiply){
                Push(firstValue*secondValue);
                form.listBox1.Items.Add("Pushed "+ (firstValue*secondValue)+ " to stack.");
            }
            else if (mod == Modifier.Subtract){
                Push(firstValue-secondValue);
                form.listBox1.Items.Add("Pushed "+(firstValue-secondValue)+ " to stack.");
            }
            else{
                form.listBox1.Items.Add("Unknown modifier: "+ mod); //Just to be sure.
                return false;
            }
            return true;
        }

        public void EmptyStack(Stack stack){
        //To clear the stack just Pop every item in the stack.
            int max = stack.GetCount();
            for (int i = 0;i < max; i++){
                stack.Pop();
            }
        }
    }
}
