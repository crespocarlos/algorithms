using System;

namespace console_app.DataStructure
{
    public class CustomQueue
    {
        private int[] items = new int[5];
        private int head = -1;
        private int tail = -1;
        private int numOfItems = 0;

        public CustomQueue(int size)
        {
            this.items = new int[size];
        }

        public void Enqueue(int item) {
            if (this.IsFull()) {
                throw new Exception("Queue is full");
            }

            if (this.tail == this.items.Length - 1) {
                this.tail = -1;
            }

            this.items[tail++] = item;
            this.numOfItems++;
            
        }

        public int Dequeue() {
            if (this.IsEmpty()) {
                throw new Exception("Queue is empty");
            }

            if (head == items.Length - 1) {
                this.head = -1;
            }
            
            this.numOfItems--;
            return this.items[++this.head];
            
        }

        public int Peek() {
            return items[this.head+1];
        }

        public bool IsFull() {
            return numOfItems == items.Length;
        }

        public bool IsEmpty() {
            return numOfItems == 0;
        }
        
    }
}