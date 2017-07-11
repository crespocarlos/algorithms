using console_app.Domain;

namespace console_app.DataStructure
{
    public class DoubleEndedList<T>
    {
        public Node<T> Tail { get; private set; }

        public void AddAtEnd(T data) {
            var newNode = new Node<T>(data);
            this.Tail.NextNode = newNode;
            this.Tail = newNode;
        }

    }
}