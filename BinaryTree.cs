namespace Data_structures;

public class TreeNode<T>
{
    public T Data { get; set; }
    
    public Node<T> Left { get; set; }
    
    public Node<T> Right { get; set; }
    
    public TreeNode(T data)
    {
        Data = data;
        Left = Right = null;
    }
}

public class BinaryTree<T>
{
    public Node<T> Root { get; set; }
    
    public int Count { get; set; }
    
    public BinaryTree(T data)
    {
        Root = new Node<T>(data);
    }

    public BinaryTree()
    {
        Root = null;
    }

}