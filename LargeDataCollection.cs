using System;
using System.Collections.Generic;


namespace ConAppAssignment11
{
    public class LargeDataCollection<T> : IDisposable
    {
        private List<T> dataCollection;
        private List<T> initialData;

        public LargeDataCollection(IEnumerable<T> initialData)
        {
            this.initialData = new List<T>(initialData);
            dataCollection = new List<T>(initialData);
        }

        public void Add(T item)
        {
            dataCollection.Add(item);
        }

        public bool Remove(T item)
        {
            return dataCollection.Remove(item);
        }

        public void PrintData()
        {
            foreach (T item in dataCollection)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Release managed resources
                if (dataCollection != null)
                {
                    dataCollection.Clear();
                    dataCollection = null;
                }
            }
            // No need to release unmanaged resources in this case, as we only have managed resources.
        }

        public void PrintInitialData()
        {
            foreach (T item in initialData)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
