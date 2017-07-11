namespace console_app
{
    public class CodilityDemoTest
    {
         public int solution(int[] A) {
            long lower = 0;
            long upper = 0;

            foreach(long item in A){
                upper += item;
            }

            for(int i = 0; i < A.Length; i++) {
                upper -= A[i];

                if (lower == upper) {
                    
                    return i;
                } 
                else 
                {
                    lower += A[i];   
                }
            }
            
            return -1;

        }
    }
}