namespace BinarySearchTree1
{
    class program
    {
       public static void Main(string[] args)
       {
            Console.WriteLine("Welcome to Binary search treee");
             BinaryTree<int> binary = new BinaryTree<int>(56);
            binary.AddNode(30);
            binary.AddNode(70);
            binary.AddNode(22);
            binary.AddNode(40);
            binary.AddNode(60);
            binary.AddNode(95);
            binary.AddNode(11);
            binary.AddNode(65);
            binary.AddNode(31);
            binary.AddNode(16);
            binary.AddNode(63);
            binary.AddNode(67);
            binary.Display();
            binary.getSize();
        }
    }

}
