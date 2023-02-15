namespace BinarySearchTree1
{
    class program
    {
       public static void Main(string[] args)
       {
            Console.WriteLine("Welcome to Binary search treee");
             BinaryTree<int> search = new BinaryTree<int>(56);
            search.AddNode(30);
            search.AddNode(70);
            search.AddNode(22);
            search.AddNode(40);
            search.AddNode(60);
            search.AddNode(95);
            search.AddNode(11);
            search.AddNode(65);
            search.AddNode(31);
            search.AddNode(16);
            search.AddNode(63);
            search.AddNode(67);
            search.Display();
            search.getSize();

            bool result = search.ifExist(63, search);
            Console.WriteLine(result);
        }
    }

}
