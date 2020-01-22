using System;

namespace dataStructsAndAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var root = new BinaryTreeIntNode(10);
            root.Left = new BinaryTreeIntNode(1);
            root.Right = new BinaryTreeIntNode(5);
            root.Left.Left = new BinaryTreeIntNode(2);
            root.Left.Right = new BinaryTreeIntNode(3);

            var inOrderValues = BinaryTreeTraversals.TraverseInOrder(root);
            System.Console.WriteLine("[" + string.Join(", ", inOrderValues) + "]");

            var preOrderValues = BinaryTreeTraversals.TraversePreOrder(root);
            System.Console.WriteLine("[" + string.Join(", ", preOrderValues) + "]");

            var postOrderValues = BinaryTreeTraversals.TraversePostOrder(root);
            System.Console.WriteLine("[" + string.Join(", ", postOrderValues) + "]");
        }
    }
}
