using System;

namespace console_app.DataStructure
{
    public class CustomStack : IStack
    {
        private int[] items = new int[100];
        private int top = 1;

        public bool IsEmpty() {
            return top < 0;
        }

        public void Push(int item) {
            if (top == items.Length - 1) {
                throw new Exception("Stack is full");
            }

            items[++top] = item;
            
        }

        public int Pop() {
            if (this.IsEmpty()) {
                throw new Exception("Stack is empty");
            }

            return items[top--];
        }

        public int Peek() {
            if (this.IsEmpty()) {
                throw new Exception("Stack is empty");
            }

            return items[top];
        }
    }
}