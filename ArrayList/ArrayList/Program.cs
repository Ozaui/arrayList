using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] strings = new string[10];
            //strings[0] = "test";
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add(3);
            arrayList.Add(4);
            arrayList.Add(5);
            arrayList.Add(6);
            arrayList.Remove(5);

            Console.WriteLine(arrayList[1]);
            
            foreach (int i in arrayList)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
