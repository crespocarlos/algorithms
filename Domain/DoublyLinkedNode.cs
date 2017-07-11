namespace console_app.Domain
{
    public class DoublyLinkedNode<T>
    {
        public T Data { get; set; }
        public DoublyLinkedNode<T> NextNode { get; set; }
        public DoublyLinkedNode<T> PreviousNode { get; set; }

        public DoublyLinkedNode(T data)
        {
            this.Data = data;
        }
    }
}