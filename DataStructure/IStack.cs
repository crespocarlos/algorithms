namespace console_app.DataStructure
{
    public interface IStack
    {
        bool IsEmpty();
        
        void Push(int item);

        int Pop();

        int Peek();
    }
}