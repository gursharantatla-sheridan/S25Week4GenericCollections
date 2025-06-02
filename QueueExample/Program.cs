namespace QueueExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            //int num = queue[1];

            foreach(var i in queue)
                Console.WriteLine(i);


            int num = queue.Dequeue();
            Console.WriteLine("\n\nTotal items: " + queue.Count);
            Console.WriteLine("num = " + num);


            num = queue.Peek();
            Console.WriteLine("\n\nTotal items: " + queue.Count);
            Console.WriteLine("num = " + num);
        }
    }
}
