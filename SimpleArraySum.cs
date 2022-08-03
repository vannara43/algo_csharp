namespace algo_csharp
{
    public class SimpleArraySum
    {

        public static void start()
        {
            Console.WriteLine("SimpleArraySum");
            List<int> ar = new List<int>();
            ar.Add(12);
            ar.Add(13);
            ar.Add(1);
            ar.Add(192);

            int total = 0;
            foreach (int i in ar)
            {
                total += i;
            }
            Console.WriteLine(total);
            // return total;
        }
    }
}