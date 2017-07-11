namespace console_app.Recursion
{
    public class TowerOfHanoi
    {
        public void Move(int numberOfItems, char from, char to, char inter) {
            if (numberOfItems == 1) {
                System.Console.WriteLine($"Moving disk {numberOfItems} from {from} to {to}");
            } else {
                this.Move(numberOfItems - 1, from, inter, to);
                System.Console.WriteLine($"Moving disk {numberOfItems} from {from} to {to}");
                this.Move(numberOfItems - 1, inter, to, from);  
            }
        }
    }
}