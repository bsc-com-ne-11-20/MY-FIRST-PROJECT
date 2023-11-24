using System;

//search class
public class SearchClass{
    //creating the search method
    public static void SearchNode(BinaryTree<int> tree){
        //if condtion
            if (int.TryParse(Console.ReadLine(), out int searchValue)) {//if value exisits the code here executes

                //decreare the intger nodes variables and array node variable.
                Node<int> foundNode;
                Node<int> parentNode;
                Node<int>[] children;

                if (tree.Search(searchValue, out foundNode, out parentNode, out children))
                {
                    //display the value of the node, its parent node and children node if the node exit in the node list'
                    Console.WriteLine($"Node {searchValue} found.");
                    Console.WriteLine($"Parent Node: {parentNode?.Data}");
                    Console.WriteLine($"Children: {children[0]?.Data}, {children[1]?.Data}");
                }
                else
                {
                    //if the node searched not found
                    Console.WriteLine($"the node searched this one {searchValue} not found.\n");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. please enter choise from the options!!.....\n");
            }
    }
}
