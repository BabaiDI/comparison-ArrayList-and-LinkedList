internal partial class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Collection collection = new();

            Console.WriteLine(collection.AddLast(100000));
            Console.WriteLine(collection.getLength());
            Console.WriteLine(collection.SequentialAccess());
            Console.WriteLine(collection.RandomAccess());
            Console.WriteLine(collection.AddFirst (1000));
            Console.WriteLine(collection.getLength());
            Console.WriteLine(collection.AddCenter(1000));
            Console.WriteLine(collection.getLength());
            Console.WriteLine(collection.AddLast  (1000));

            Console.WriteLine(collection.getLength());

            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}