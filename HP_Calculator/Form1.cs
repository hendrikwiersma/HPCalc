using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HP_Calculator
{
    public partial class Form1 : Form
    {
        public Stack currentStack;
        public int selectedStack = 1;
        public Form1()
        {
            currentStack = new ArrayStack(null);
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += button1.Text;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            currentStack.EmptyStack(currentStack);
            textBox1.Text = "";
            listBox1.Items.Add("Stack has been cleared.");
            UpdateStackDisplay();
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += button3.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += button8.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += button11.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += button10.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += button9.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int newStackValue = 0;
            if (!Int32.TryParse(textBox1.Text, out newStackValue))
            {
                MessageBox.Show("Input string was not in a correct format.", "Exception found.");
                return;
            }

            currentStack.Push(newStackValue);

            listBox1.Items.Insert(0, "Pushed " + textBox1.Text + " on stack.");
            UpdateStackDisplay();
            listBox1.SelectedIndex = listBox1.Items.Count - 1;  //Focus on the last item added in the Eventbox.
            // Also remove the current text from the textbox.
            textBox1.Text = "";
        }
        public void UpdateStackDisplay()
        {
            textBox2.Text = "";
            for (int i = 0; i < currentStack.GetCount(); i++)
            {
                textBox2.Text += "[" + (i + 1) + "]             ->        " + currentStack.GetElementOnNumber(i) + "\r\n";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (currentStack.GetCount() < 2)
            {
                MessageBox.Show("Not enough items on stack to perform operation.");
                return;
            }
            listBox1.Items.Add("FirstValue is removed from stack.");
            currentStack.ApplyModifiers(currentStack, Stack.Modifier.Add);
            UpdateStackDisplay();
            listBox1.SelectedIndex = listBox1.Items.Count - 1;  //Focus on the last item added in the Eventbox.
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (currentStack.GetCount() < 2)
            {
                MessageBox.Show("Not enough items on stack to perform operation.");
                return;
            }
            currentStack.ApplyModifiers(currentStack, Stack.Modifier.Subtract);
            UpdateStackDisplay();
            listBox1.SelectedIndex = listBox1.Items.Count - 1;  //Focus on the last item added in the Eventbox.
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (currentStack.GetCount() < 2)
            {
                MessageBox.Show("Not enough items on stack to perform operation.");
                return;
            }
            currentStack.ApplyModifiers(currentStack, Stack.Modifier.Multiply);
            UpdateStackDisplay();
            listBox1.SelectedIndex = listBox1.Items.Count - 1;  //Focus on the last item added in the Eventbox.
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (currentStack.GetCount() < 2)
            {
                MessageBox.Show("Not enough items on stack to perform operation.");
                return;
            }
            listBox1.Items.Add("FirstValue is removed from stack.");
            currentStack.ApplyModifiers(currentStack, Stack.Modifier.Divide);
            UpdateStackDisplay();
            listBox1.SelectedIndex = listBox1.Items.Count - 1;  //Focus on the last item added in the Eventbox.
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {   //The dropdown Menu is used to select the right Stack Type.
            if (comboBox1.SelectedIndex == 0)
            {
                currentStack = new ArrayStack(currentStack);
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                currentStack = new ListStack(currentStack);
            }
            else
            {
                currentStack = new MyListStack(currentStack);
            }

        }
    }
}
