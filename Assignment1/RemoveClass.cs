using System;

public class RemoveClass
{
    public static void RemoveNode(BinaryTree<int> tree)
    {
        if (int.TryParse(Console.ReadLine(), out int removeValue))
        {
            if (tree.Remove(removeValue))
            {
                Console.WriteLine($"Node {removeValue} removed successfully.\n");

                Console.WriteLine("Inorder Traversal after removal\n");
                tree.InOrderTraversal();

                Console.WriteLine("Postorder Traversal after removal\n");
                tree.PostOrderTraversal();
            }
            else
            {
                Console.WriteLine($"Node {removeValue} not found.\n");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid value.\n");
        }
    }
}
