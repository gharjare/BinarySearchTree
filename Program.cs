namespace BinarySearchTree1
{
    class program
    {
       public static void Main(string[] args)
       {
            Console.WriteLine("Welcome to Binary search treee");
             BinaryTree<int> tree = new BinaryTree<int>(56);
            tree.AddNode(30);
            tree.AddNode(70);
            tree.Display();
        }
    }

}
