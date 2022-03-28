namespace Data_structures;

public class Node<T>
{
    public Node<T> Next { get; set; }
    
    public T Data { get; set; }   

    public Node(T data)
    {
        Data = data;
        Next = null;
    }
}

public class LinkedListSample<T>
{
    public Node<T> Head { get; set; }
    
    public Node<T> Tail { get; set; }

    public int Count { get; set; }

    public void AddNode(T data)
    {
        Node<T> node = new(data);
        if(Head != null)
        {
            Tail.Next = node;
            Tail = node;
        }
        else
        {
            Head = node;
            Tail = node;
        }
        Count++;
    }
}