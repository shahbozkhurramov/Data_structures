using System.Collections;

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

public class LinkedListSample<T> : IEnumerable<T>
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

    public void InsertNode(int index, T data)
    {
        Node<T> node = new(data);
        if(index == 0)
        {
            node.Next = Head;
            Head = node;
        }

        if(index < Count)
        {
            var temp = Head;
            int index1 = 1;
            while(temp != null)
            {
                if(index == index1)
                {
                    var temp1 = temp.Next;
                    temp.Next = node;
                    node.Next = temp1;
                }

                index1++;
                temp  = temp.Next;
            }
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        var node = Head;
        while(node != null)
        {
            var data = node.Data;
            node  = node.Next;
            yield return data;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
        => GetEnumerator();
}