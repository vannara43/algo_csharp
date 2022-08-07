namespace algo_csharp
{
    public class SimpleArraySumV2
    {

        public static void start()
        {
            Console.WriteLine("SimpleArraySumV2");
            int[] ar = new int[] { 2, 42, 63, 9 };

            int total = 0;
            foreach (int i in ar)
            {
                total += i;
            }
            Console.WriteLine(total);
            //return total;
        }
    }
}