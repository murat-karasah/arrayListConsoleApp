using System;
using System.Collections;

namespace arrayListConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = 0, count = 0;
            ArrayList A1 = new ArrayList();
            A1.Add("sınıf");
            A1.Add(5);
            A1.Add("değer");
            capacity = A1.Capacity;
            count = A1.Count;
            Console.WriteLine(capacity+"..."+count );

        }
    }
}
