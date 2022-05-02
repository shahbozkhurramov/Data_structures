namespace Data_structures;

public class TreeNode
{
    public int Data { get; set; }
    
    public TreeNode Left { get; set; }
    
    public TreeNode Right { get; set; }
    
    public TreeNode(int data)
    {
        Data = data;
        Left = Right = null;
    }
}

public class BinaryTree
{
    public TreeNode Root { get; set; }
    
    public int Count { get; set; }
    
    public BinaryTree(int data)
    {
        Root = new TreeNode(data);
        Count = 1;
    }

    public BinaryTree()
    {
        Root = null;
    }

    public void AddNode(TreeNode treeNode, int data)
    {
        if(Root == null)
        {
            Root = new TreeNode(data);
            Count++;
        }
        else if(data < treeNode.Data)
        {
            treeNode.Left = new TreeNode(data);
            Count++;
        }
        else
        {
            treeNode.Right = new TreeNode(data);
            Count++;
        }
    }
}