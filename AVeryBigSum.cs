namespace algo_csharp
{
    public class AVeryBigSum
    {

        public static void start()
        {
            Console.WriteLine("AVeryBigSum");
            List<long> ar = new List<long> { 10000, 400004, 200052, 1231231, 532332, 21314333 };
            ar.Add(1002);
            ar.Add(1300);
            ar.Add(10000);
            ar.Add(1900002);

            long totalSum = 0;

            for (int i = 0; i < ar.Count; i++)
            {
                totalSum = ar[i] + totalSum;
            }
            Console.WriteLine(totalSum);
            // return totalSum;
            // return total;
        }
    }
}