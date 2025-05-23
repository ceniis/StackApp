using System.ComponentModel;

namespace StackApp
{
    public class StackNode
    {
        public int Data { get; set; } // Значення вузла
        public StackNode? Next; // Вказівник на наступний вузол


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
        private StackNode? top;
        private BindingList<StackNode> nodes; // Колекція вузлів
        public BindingList<StackNode> Nodes => nodes;

        public Stack()
        {
            top = null;
            nodes = new BindingList<StackNode>();
        }

        /// <summary>
        /// Додає елемент на вершину стека.
        /// </summary>
        public void Push(int data)
        {
            StackNode newNode = new StackNode(data);
            newNode.Next = top;
            top = newNode;
            nodes.Insert(0, newNode); // Додаємо на початок списку
        }

        /// <summary>
        /// Повертає елемент з вершини стека без видалення.
        /// </summary>
        public StackNode Peek()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Stack is empty.");
            return top!;
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
            if (IsEmpty)
                throw new InvalidOperationException("Stack is empty.");

            int poppedData = top!.Data;
            nodes.RemoveAt(0); // Видаляємо з колекції
            top = top.Next;
            return returnValue ? poppedData : 0;
        }

        /// <summary>
        /// Перевіряє, чи порожній стек.
        /// </summary>
        public bool IsEmpty => top == null;


        /// <summary>
        /// Видаляє всі елементи зі стека.
        /// </summary>
        public void FreeStack()
        {
            top = null;
            nodes.Clear();
        }

        /// <summary>
        /// Повертає кількість елементів у стеці.
        /// </summary>
        public int Count => nodes.Count;

        /// <summary>
        /// Повертає колекцію всіх вузлів (копія списку).
        /// </summary>
        public List<StackNode> GetAllNodes()
        {
            return new List<StackNode>(nodes);
        }

        public StackNode? Top => top;
    }
}

