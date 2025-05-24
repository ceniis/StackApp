using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackApp
{
    class StackArray
    {
        public static int StackSize { set; get; }
        private static int Top = -1;
        private static int[]? MyStack;


        /// <summary>
        /// Method that creates a stack
        /// </summary>
        private static void CreateStack()
        {
            Top = -1;
            MyStack = new int[Top + 1];
        }

        /// <summary>
        /// Method that clears a stack
        /// </summary>
        private static void ClearsStack()
        {
            Top = -1;
            MyStack = new int[Top + 1];
        }

        /// <summary>
        /// Method that displays the top element of a stack
        /// </summary>
        private static int TopElement()
        {
            if (MyStack.Length == 0)
                throw new InvalidOperationException("Stack is empty.");
            else return MyStack[Top];
        }

        /// <summary>
        /// Method that deletes the top elementf of a stack
        /// </summary>
        private static void DeleteTopElement()
        {
            if (MyStack.Length == 0)
                throw new InvalidOperationException("Stack is already empty.");
            else
            {
                Array.Resize(ref MyStack, Top);
                Top--;
            }
        }

        /// <summary>
        /// Method that inserts a new top element to stack
        /// </summary>
        private static void InsertTopElement(int element)
        {
            if (Top == StackSize - 1)
                throw new InvalidOperationException("Stack is full.");
            else
            {
                Top++;
                Array.Resize(ref MyStack, Top + 1);
                MyStack[Top] = Convert.ToInt32(element);
            }
        }

        /// <summary>
        /// Method that checks if our stack is empty or not
        /// </summary>
        private static bool FillmentCheck()
        {
            bool filment;
            if (MyStack.Length == 0) return filment = true; // emptu
            else return filment = false; // not empty
        }

        /// <summary>
        /// Method that displays number of elements in the stack
        /// </summary>
        public static string NumberOfElements()
        {
            return MyStack.Length == 0 ? "Stack is empty" : $"{Top + 1} elements in the stack";
        }

        private void UpdateListBox(DataGridView dataGridView)
        {
           // dataGridView.();
            for (int i = Top; i >= 0; i--)
            {
               //dataGridView.Add(MyStack[i]);
            }
        }

    }
}
