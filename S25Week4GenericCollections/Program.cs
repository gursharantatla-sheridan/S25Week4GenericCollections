using System.Collections;

namespace S25Week4GenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array
            // GOOD - type-safe
            // BAD - static in size

            int[] myArray = new int[4];
            myArray[0] = 10;
            myArray[1] = 20;
            myArray[2] = 30;
            myArray[3] = 40;

            //myArray[3] = "hello";
            //myArray[4] = 50;

            int sum = 0;

            for (int i=0; i<myArray.Length; i++)
            {
                int num = myArray[i];
                sum += num;
            }

            Console.WriteLine("Sum = " + sum);


            // ArrayList
            // GOOD - dynamic in size
            // BAD - performance issue - boxing/unboxing
            // BAD - not type-safe

            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(10);
            myArrayList.Add(20);
            myArrayList.Add(30);
            myArrayList.Add(40);

            //myArrayList.Add("hello");

            sum = 0;

            for (int i=0; i<myArrayList.Count; i++)
            {
                int num = (int)myArrayList[i];
                sum += num;
            }

            Console.WriteLine("\nSum = " + sum);
        }
    }
}
