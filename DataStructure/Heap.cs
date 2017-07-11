using System;
using console_app.Domain;

namespace console_app.DataStructure
{
    public class Heap
    {
        private int?[] heapData;
        private int currentPosition = -1;
        
        public Heap(int size) {
            this.heapData = new int?[size];
        }
        
        public void Insert(int item) {
            if (isFull()) 
                throw new Exception("Heap is full");
            this.heapData[++currentPosition] = item;
            FixUp(currentPosition);
        }
        
        public int? DeleteRoot() {
            int? result = heapData[0];
            heapData[0] = heapData[currentPosition--];
            heapData[currentPosition+1] = null;
            FixDown(0, -1);
            return result;
        }
        
        private void FixDown(int index, int upto) {
            if (upto < 0) upto = currentPosition;
            while (index <= upto) {
                int leftChild = 2 * index + 1;
                int rightChild = 2 * index + 2;
                if (leftChild <= upto) {
                    int childToSwap;
                    if (rightChild > upto)
                        childToSwap = leftChild;
                    else
                        childToSwap = (heapData[leftChild] > heapData[rightChild]) ? leftChild : rightChild;
                    
                    if (heapData[index] < heapData[childToSwap]) {
                        int? tmp = heapData[index];
                        heapData[index] = heapData[childToSwap];
                        heapData[childToSwap] = tmp;
                    } else {
                        break;
                    }
                    index = childToSwap;
                } else {
                    break;
                }
                
            }
        }
        
        private void FixUp(int index) {
            int i = (index-1)/2; //parent index
            while (i >= 0 && heapData[i] < heapData[index]) {
                int? tmp = heapData[i];
                heapData[i] = heapData[index];
                heapData[index] = tmp;
                index = i;
                i = (index-1)/2;
            }
        }
        
        private bool isFull() {
            return currentPosition == heapData.Length-1;
        }
        
        /**
        * Heap Sort could be called in a heap array, so we assume that this heap was
        * built up by calling insert repeatedly, and then we call heapSort on it.
        */
        public void heapSort() {
            for (int i=0; i < currentPosition; i++) {
                int? tmp = heapData[0]; // max element
                heapData[0] = heapData[currentPosition-i]; // bring last element to the root
                heapData[currentPosition-i] = tmp; // put max at the last of unsorted part
                FixDown(0, currentPosition-i-1);
            }
        }

        //This builds a heap from the given data array
        public static Heap Heapify(int[] data) {
            Heap heap = new Heap(data.Length);
            for (int i=0; i < data.Length; i++) {
                heap.Insert(data[i]);
            }
            return heap;
        }
    }
}