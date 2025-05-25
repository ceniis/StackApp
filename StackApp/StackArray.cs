using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackApp
{
    public class StackArray
    {
        public static int StackSize = 100;
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
        public static void ClearsStack()
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
        public static void DeleteTopElement()
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
        public static void InsertTopElement(int element)
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
        public static bool FillmentCheck()
        {
            bool filment;
            if (MyStack.Length == 0) return filment = true; // empty
            else return filment = false; // not empty
        }

        /// <summary>
        /// Method that displays number of elements in the stack
        /// </summary>
        public static int NumberOfElements()
        {
            return Top + 1;
        }

        public static List<StackItem> GetStackItems()
        {
            List<StackItem> items = new List<StackItem>();
            for (int i = Top; i >= 0; i--)
            {
                items.Add(new StackItem { Data = MyStack[i] });
            }
            return items;
        }

        // Helper class to bind data
        public class StackItem
        {
            public int Data { get; set; }
        }

    }
}
