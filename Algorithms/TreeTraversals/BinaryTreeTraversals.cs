using System.Collections.Generic;

public static class BinaryTreeTraversals
{
    public static List<int> TraverseInOrder(BinaryTreeIntNode node)
    {
        var treeOutput = new List<int>();

        var leftTreeOutput = new List<int>();
        if (node.Left != null)
        {
            leftTreeOutput = TraverseInOrder(node.Left);
        }
        treeOutput.AddRange(leftTreeOutput);

        treeOutput.Add(node.Data);

        var rightTreeOutput = new List<int>();
        if (node.Right != null)
        {
            rightTreeOutput = TraverseInOrder(node.Right);
        }
        treeOutput.AddRange(rightTreeOutput);

        return treeOutput;
    }

    public static List<int> TraversePreOrder(BinaryTreeIntNode node)
    {
        var treeOutput = new List<int>();

        treeOutput.Add(node.Data);
        var leftTreeOutput = new List<int>();
        if (node.Left != null)
        {
            leftTreeOutput = TraversePreOrder(node.Left);
        }
        treeOutput.AddRange(leftTreeOutput);

        var rightTreeOutput = new List<int>();
        if (node.Right != null)
        {
            rightTreeOutput = TraversePreOrder(node.Right);
        }
        treeOutput.AddRange(rightTreeOutput);

        return treeOutput;
    }

    public static List<int> TraversePostOrder(BinaryTreeIntNode node)
    {
        var treeOutput = new List<int>();

        var leftTreeOutput = new List<int>();
        if (node.Left != null)
        {
            leftTreeOutput = TraversePostOrder(node.Left);
        }
        treeOutput.AddRange(leftTreeOutput);

        var rightTreeOutput = new List<int>();
        if (node.Right != null)
        {
            rightTreeOutput = TraversePostOrder(node.Right);
        }
        treeOutput.AddRange(rightTreeOutput);

        treeOutput.Add(node.Data);

        return treeOutput;
    }
}