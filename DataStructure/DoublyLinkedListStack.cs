using System;
using console_app.DataStructure;
using console_app.Domain;

namespace console_app.DataStructure
{
    public class DoublyLinkedListStack : IStack
    {
        private DoublyLinkedNode<int> top = null;

        public bool IsEmpty() {
            return this.top == null;
        }

        public void Push(int item) {
            var newItem = new DoublyLinkedNode<int>(item);
            newItem.PreviousNode = this.top;

            if (top != null) {
                top.NextNode = newItem;
            }
           
            top = newItem;
        }

        public int Pop() {
            int data = this.top.Data;
            if (this.top.PreviousNode != null) {
                this.top.NextNode = null;
            }

            this.top = this.top.PreviousNode;
            return data;
        }

        public int Peek() {
            return this.top.Data;
        }
    }
}