using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackApp
{
    public class StackNode
    {
        public int Data; // Значення вузла
        public StackNode Next; // Вказівник на наступний вузол


        public StackNode(int data)
        {
            this.Data = data;
            this.Next = null; // За замовчуванням наступний вузол не існує
        }
    }

    /// <summary>
    /// Клас для представлення стека.
    /// </summary>
    public class Stack
    {
        private StackNode top; // Вказівник на вершину стека
        public Stack()
        {
            this.top = null; // Стек порожній при ініціалізації
        }

        /// <summary>
        /// Додає елемент на вершину стека.
        /// </summary>
        public void Push(int data)
        {
            StackNode newNode = new StackNode(data);
            newNode.Next = top; // Новий вузол вказує на старий верхній елемент
            top = newNode; // Встановлюємо новий вузол як вершину стека
        }

        /// <summary>
        /// Повертає елемент з вершини стека без видалення.
        /// </summary>
        public int Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            return top.Data;
        }

        /// <summary>
        /// Видаляє елемент без повернення.
        /// </summary>
        public void Pop()
        {
            Pop(false);
        }

        /// <summary>
        /// Повертає і видаляє елемент з вершини стека.
        /// </summary>
        public int Pop(bool returnValue = true)
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            int poppedData = top.Data;
            top = top.Next;
            // Якщо returnValue дорівнює true, повертаємо значення.
            return returnValue ? poppedData : 0;
        }

        /// <summary>
        /// Перевіряє, чи порожній стек.
        /// </summary>
        public bool IsEmpty()
        {
            return top == null;
        }

        /// <summary>
        /// Видаляє всі елементи зі стека.
        /// </summary>
        public void FreeStack()
        {
            top = null;
        }

        /// <summary>
        /// Повертає кількість елементів у стеці.
        /// </summary>
        public int Count()
        {
            int count = 0;
            StackNode current = top;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }

        /// <summary>
        /// Виводить усі елементи стека.
        /// </summary>
    }
}
