using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_massivy_3._1
{
    class Program
    {
        public static int[] Add(int[] array, int value)
        {
            Array.Resize<int>(ref array, array.Length + 1);
            for (int i = 0; i <= array.Length - 1; i++)
            {
                array[0] = value;
                Console.Write(array[i] + " ");
            }
            return array;
        }
    
        static void Main()
        {
            int[] massiv = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
            Add(massiv, 9);
            Console.ReadKey();
        }
    }
}
