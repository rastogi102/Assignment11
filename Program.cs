using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment11
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of LargeDataCollection
            LargeDataCollection<int> dataCollection = new LargeDataCollection<int>(new List<int> { 10, 20, 30, 40, 50 });

            // Print initial data
            Console.Write("Initial data in the collection: ");
            dataCollection.PrintInitialData();

            // Adding elements to the collection
            dataCollection.Add(60);
            dataCollection.Add(70);

            // Removing an element from the collection
            bool removed = dataCollection.Remove(30);
            Console.WriteLine("Item 30 is removed: " + removed);

            // Accessing elements from the collection
            Console.Write("Updated data in the collection: ");
            dataCollection.PrintData();

            // Dispose the LargeDataCollection object to release resources and free up memory
            dataCollection.Dispose();

        }
    }
}


