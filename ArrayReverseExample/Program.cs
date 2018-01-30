using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayReverseExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string[] arrayStored = new string[20];
            int length = arrayStored.Length;
            Console.WriteLine("Enter elements in array:");
            for (i = 0; i < length; i++)
            {
                Console.Write("Element[{0}]: ", i);
                arrayStored[i] = Console.ReadLine();
            }
            Console.WriteLine("The elements stored in the array are: ");
            for (i = 0; i < length; i++)
            {
                Console.Write("{0} ", arrayStored[i]);
            }
            Console.Write("\n");
            Console.WriteLine("Reversed array elements are: ");
            for (i = length - 1; i >= 0; i--)
            {
                Console.Write("{0} ", arrayStored[i]);
            }
            Console.Write("\n\n");
            Console.ReadKey();
        }
    }
}
