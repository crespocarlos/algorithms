using System;
using console_app.Domain;

namespace console_app.DataStructure
{
    public class SortedLinkedList<T> where T : IComparable
    {
        public Node<T> Head { get; private set; }

        public void Insert(T data) {
            var newNode = new Node<T>(data);

            if (this.Head != null && this.Head.Data.CompareTo(newNode) > 0)
            {
                newNode.NextNode = this.Head;
                this.Head = newNode;
                return;
            }

            var current = this.Head;
            while(current != null && current.NextNode != null && this.Head.Data.CompareTo(newNode) < 0) {
                current = current.NextNode;
            }

            newNode.NextNode = current;
            current.NextNode = newNode;
        }
    }
}