namespace Data_structures;

public class Program
{
    public static void Main(string[] args)
    {
        LinkedListSample<int> list = new();
        list.AddNode(1);
        list.AddNode(4);
        list.AddNode(5);
        list.AddNode(7);
        list.InsertNode(4, 10);
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}