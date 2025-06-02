using ListExample;

namespace DictionaryExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Employee class is in project ListExample
            // it is being referenced in this project
            // ListExample namespace is included at the top

            Employee emp1 = new Employee(101, "John", 5000);
            Employee emp2 = new Employee(102, "Anne", 7000);
            Employee emp3 = new Employee(103, "Mark", 3000);

            Dictionary<int, Employee> dictEmps = new Dictionary<int, Employee>();
            dictEmps.Add(emp1.Id, emp1);
            dictEmps.Add(emp2.Id, emp2);
            dictEmps.Add(emp3.Id, emp3);

            //Console.Write("Enter key: ");
            //int key = int.Parse(Console.ReadLine());

            //if (dictEmps.ContainsKey(key))
            //{
            //    var emp = dictEmps[key];
            //    Console.WriteLine(emp);
            //}
            //else
            //    Console.WriteLine("Invalid key. Please try again.");


            //foreach(KeyValuePair<int, Employee> kvp in dictEmps)
            foreach(var kvp in dictEmps)
            {
                int key = kvp.Key;
                Employee emp = kvp.Value;

                Console.WriteLine("Key = " + key + "\n");
                Console.WriteLine(emp);
            }
        }
    }
}
