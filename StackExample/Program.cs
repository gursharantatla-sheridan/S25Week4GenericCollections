namespace StackExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            //int num = stack[1];

            foreach (var i in stack)
                Console.WriteLine(i);
            

            int num = stack.Pop();
            Console.WriteLine("\n\nTotal items: " + stack.Count);
            Console.WriteLine("num = " + num);


            num= stack.Peek();
            Console.WriteLine("\n\nTotal items: " + stack.Count);
            Console.WriteLine("num = " + num);
        }
    }
}
