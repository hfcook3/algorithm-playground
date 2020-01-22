public class BinaryTreeIntNode
{
    public int Data { get; set; }
    public BinaryTreeIntNode Right { get; set; }
    public BinaryTreeIntNode Left { get; set; }

    public BinaryTreeIntNode(int data)
    {
        Data = data;
    }
}