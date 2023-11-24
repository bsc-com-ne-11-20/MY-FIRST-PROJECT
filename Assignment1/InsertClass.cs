using System;

public class InsertClass
{
    public static void InsertNode(BinaryTree<int> tree)
    {
        if (int.TryParse(Console.ReadLine(), out int insertValue))
        {
            tree.Insert(insertValue);
            Console.WriteLine($"Node {insertValue} inserted successfully.\n");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.\n");
        }
    }
}
