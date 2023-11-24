using System;

public class BinaryTree<T> where T : IComparable<T>
{
    private Node<T>? root;

    public BinaryTree()
    {
        root = null;
    }

    public void Insert(T data)
    {
        root = InsertRec(root, data);
    }

    private Node<T>? InsertRec(Node<T>? root, T data)
    {
        if (root == null)
        {
            return new Node<T>(data);
        }

        int comparison = data.CompareTo(root.Data);

        if (comparison < 0)
        {
            root.Left = InsertRec(root.Left, data);
        }
        else if (comparison > 0)
        {
            root.Right = InsertRec(root.Right, data);
        }
        else
        {
            // Handle duplicate data (you may choose to update the existing node or skip)
            Console.WriteLine($"Duplicate data found: {data}. Skipping entry.");
        }

        return root;
    }

    public bool Search(T data, out Node<T> foundNode, out Node<T> parentNode, out Node<T>[] children)
    {
        foundNode = null;
        parentNode = null;
        children = new Node<T>[2]; // Assuming binary tree, hence 2 children

        return SearchRec(root, data, null, ref foundNode, ref parentNode, ref children);
    }

    private bool SearchRec(Node<T>? root, T data, Node<T>? parent, ref Node<T>? foundNode, ref Node<T>? parentNode, ref Node<T>[] children)
    {
        if (root == null)
        {
            parentNode = parent;
            return false;
        }

        int comparison = data.CompareTo(root.Data);

        if (comparison == 0)
        {
            foundNode = root;
            parentNode = parent;
            children[0] = root.Left;
            children[1] = root.Right;
            return true;
        }
        else if (comparison < 0)
        {
            return SearchRec(root.Left, data, root, ref foundNode, ref parentNode, ref children);
        }
        else
        {
            return SearchRec(root.Right, data, root, ref foundNode, ref parentNode, ref children);
        }
    }

    public bool Remove(T data)
    {
        return RemoveRec(root, data, null);
    }

    private bool RemoveRec(Node<T>? root, T data, Node<T>? parent)
    {
        if (root == null)
        {
            return false;
        }

        int comparison = data.CompareTo(root.Data);

        if (comparison == 0)
        {
            if (root.Left == null && root.Right == null)
            {
                // Node has no children
                if (parent == null)
                {
                    this.root = null; // Root node
                }
                else if (parent.Left == root)
                {
                    parent.Left = null;
                }
                else
                {
                    parent.Right = null;
                }
            }
            else if (root.Left == null)
            {
                // Node has only right child
                if (parent == null)
                {
                    this.root = root.Right;
                }
                else if (parent.Left == root)
                {
                    parent.Left = root.Right;
                }
                else
                {
                    parent.Right = root.Right;
                }
            }
            else if (root.Right == null)
            {
                // Node has only left child
                if (parent == null)
                {
                    this.root = root.Left;
                }
                else if (parent.Left == root)
                {
                    parent.Left = root.Left;
                }
                else
                {
                    parent.Right = root.Left;
                }
            }
            else
            {
                // Node has both left and right children
                Node<T>? successor = FindSuccessor(root.Right);
                root.Data = successor.Data;
                RemoveRec(root.Right, successor.Data, root);
            }

            return true;
        }
        else if (comparison < 0)
        {
            return RemoveRec(root.Left, data, root);
        }
        else
        {
            return RemoveRec(root.Right, data, root);
        }
    }

    private Node<T> FindSuccessor(Node<T> node)
    {
        while (node.Left != null)
        {
            node = node.Left;
        }
        return node;
    }

    public void InOrderTraversal()
    {
        Console.Write("Inorder Traversal: ");
        InOrderTraversal(root);
        Console.WriteLine();
    }

    private void InOrderTraversal(Node<T>? root)
    {
        if (root != null)
        {
            InOrderTraversal(root.Left);
            Console.Write($"{root.Data} ");
            InOrderTraversal(root.Right);
        }
    }

    public void PostOrderTraversal()
    {
        Console.Write("Postorder Traversal: ");
        PostOrderTraversal(root);
        Console.WriteLine();
    }

    private void PostOrderTraversal(Node<T>? root)
    {
        if (root != null)
        {
            PostOrderTraversal(root.Left);
            PostOrderTraversal(root.Right);
            Console.Write($"{root.Data} ");
        }
    }
}
