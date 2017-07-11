
using System.Collections.Generic;
using console_app.Domain;

namespace console_app.DataStructure
{
    public class CustomLinkedList<T>
    {
        public Node<T> Head { get; private set; }

        public void AddAtStart(T data) {
            var newNode = new Node<T>(data);
            newNode.NextNode = this.Head;
            this.Head = newNode;

        }

        public Node<T> DeleteAtStart() {
            var nodeToDelete = this.Head;
            this.Head = nodeToDelete.NextNode;
            return nodeToDelete;
        }

        public Node<T> Find(T data) {
            Node<T> current = this.Head;
            while (current != null) {
                if (current.Data.Equals(data)) {
                    return current;
                }

                current = current.NextNode;
            }

            return null;
        }

        public void Reverse() {
            Node<T> previous = null;
            Node<T> current = this.Head;
            Node<T> next;
            while(current != null) {
                next = current.NextNode;
                current.NextNode = previous;
                previous = current;
                current = next;
            }

            this.Head = previous;
            
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

        public void DeleteDuplicates() {
            var set = new HashSet<T>();
            var current = this.Head;
            Node<T> after = null;

            while (current != null) {
                if (current != null && set.Contains(current.Data)) {
                   after.NextNode = current.NextNode;
                    
                } else {
                    set.Add(current.Data);
                    after = current;
                }

                current = current.NextNode;
            }
        }

        public void DeleteElement(Node<T> node) {
            if (node != null && node.NextNode != null) {
                node.Data = node.NextNode.Data;
                node.NextNode = node.NextNode.NextNode;
            }
        }

        public bool IsCircular()
        {
            if (this.Head == null || this.Head.NextNode == null) {
                return false;
            } 

            Node<T> slow = this.Head;
            Node<T> fast = this.Head.NextNode;

            while (true) {
                if (fast == null || fast.NextNode == null) {
                    return false;
                }

                if (fast.Data.Equals(slow.Data) || fast.NextNode.Data.Equals(slow.Data)) {
                    return true;
                }

                slow = slow.NextNode;
                fast = fast.NextNode.NextNode;

            }
        }
        public bool IsEmpty() {
            return this.Head == null;
        }

        public override string ToString() {
            string res = string.Empty;
            Node<T> curr = this.Head;
            while (curr != null) {
                res += curr.Data + ", ";
                curr = curr.NextNode;
            }

            return res;
        }
        
    }
}