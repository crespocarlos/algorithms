namespace console_app.Domain
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> NextNode { get; set; }

        public Node(T data)
        {
            this.Data = data;
        }
        
    }
}