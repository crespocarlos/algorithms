using console_app.Domain;

namespace console_app.DataStructure
{
    public class DoublyLinkedList<T>
    {
        public DoublyLinkedNode<T> Head {get; set; }

        public bool IsHead(DoublyLinkedNode<T> node) {
            return this.Head == node;
        }

        public void InsertAtHead(T data) {
            var newNode = new DoublyLinkedNode<T>(data);
            newNode.NextNode = this.Head;
            if (this.Head != null) {
                this.Head.PreviousNode = newNode;
            }

            this.Head = newNode;
        }

         public DoublyLinkedNode<T> DeleteAtHead() {
            var nodeToDelete = this.Head;
            this.Head = nodeToDelete.NextNode;
            return nodeToDelete;
        }

        public int Length() {
            if (this.IsEmpty()) {
                return 0;
            }

            int length = 0;
            var current = this.Head;
            while (current != null) {
                length++;
                current = current.NextNode;
            }

            return length;
        }

        public bool IsEmpty() {
            return this.Head == null;
        }
    }
}