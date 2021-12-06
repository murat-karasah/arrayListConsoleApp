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
            //ArrayList A2 = new ArrayList();
            //A2.Add("sınıf");
            //A2.Add(5);
            //A2.Add("değer");
            //A2.AddRange(A1);
            //Console.WriteLine(A2.Count);
            ////object o1 = A1[2];
            ////Console.WriteLine(o1);
            //////A1.RemoveAt(2);
            //////Console.WriteLine(A1.Count);

            ////////A1.Reverse(); //indexleri değerler ile ters çevirir
            
             


        }
    }
}
