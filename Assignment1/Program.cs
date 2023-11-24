using System;

//Creating the program class for testing the program-----------------------------------------------------------------
class Program {

    //create the main method of the program--------------------------------------------------------------------------
    static void Main()
    {
        BinaryTree<int> tree = new BinaryTree<int>();

        //while loop for the options 
        while (true){
            //creating  the options 
            Console.WriteLine("\t\tChoose Your Operation\t\n");
            Console.WriteLine("1 Insertion");
            Console.WriteLine("2 Searching the Node");
            Console.WriteLine("3 RemovalNode");
            Console.WriteLine("4 For Inorder Traversal");
            Console.WriteLine("5 Postorder Traversal");
            Console.WriteLine("6 Exit");//allow the user to exit the code when choose the option 6

            //if statement for the choise that the user choise that allow 
            //the user to enter the choise again if it is invalid options etc
            Console.Write("Enter Your Choice:\t\n");
            if (int.TryParse(Console.ReadLine(), out int userChoice)){

                //create the switch statement to handle the cases of each option.
                switch (userChoice)
                {
                    case 1:
                        // Insertion code
                        Console.Write("Enter value for  insertion:\t\n");

                        //calling the insertion method from the class insert
                        InsertClass.InsertNode(tree);
                        break;

                    case 2:
                        // Search or the node
                        //prompt the user to enter the value to search
                        Console.Write("Enter value to search:\t\n");

                        //calling the search method from search class
                        SearchClass.SearchNode(tree);
                        break;

                    case 3:
                        //prompt the user to enter the  value  to remove into the node list
                        Console.Write("Enter value to remove:\t");

                        //calling the method remove from class remove
                        RemoveClass.RemoveNode(tree);
                        break;

                    case 4:
                        // Display Inorder Traversal
                        tree.InOrderTraversal();
                        break;

                    case 5:
                        // Display Postorder Traversal
                        tree.PostOrderTraversal();
                        break;

                    case 6:
                        //Closing the program
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid option, Please select the choice from the menu below.\n");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.\n");
            }//the end of if statement condition----------------------------------------------------------------------

        }//End of the main method----------------------------------------------------------------------------------------
    }
}
