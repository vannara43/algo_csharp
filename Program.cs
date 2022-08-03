Console.WriteLine("Hello, World!");

List<int> ar = new List<int>();
ar.Add(1);
ar.Add(1);
ar.Add(1);
ar.Add(1);

int total = 0;
foreach (int i in ar)
{
    total += i;
}
Console.WriteLine(total);
return total;
