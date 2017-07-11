namespace console_app.Recursion
{
    public class MathRecursive
    {
        public int Sum(int number, int addNumber) {
            if(addNumber == 0) {
                return number;
            }

            return Sum(number + 1, addNumber - 1);
        }

        public int SumOfSquares(int number) {
            if (number == 1) {
                return number;
            }

            return number * number + SumOfSquares(number - 1);
        }
    }
}