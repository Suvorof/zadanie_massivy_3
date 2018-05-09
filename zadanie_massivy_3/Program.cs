using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_massivy_3
{
    class Program
    {

        static void Main()
        {
            int[] array = new int[7] { 1, 2, 3, 4, 5, 6, 7 }; //создаем целый массив из 7-ми элементов
            for (int i = 0; i <= array.Length-1; i++)
                Console.Write(array[i] + " ");
            Console.WriteLine();

            Array.Resize<int>(ref array, array.Length + 1); //увеличиваем его размер на 1
            for (int i = 0; i <= array.Length-1; i++)
                Console.Write(array[i] + " ");
            Console.ReadKey();
        }
    }
}
