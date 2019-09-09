using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arrayToSort = { 45, 6, 12, 51, 4, 23, 31 };
            int[] arrayToSort = {14, 65, 63, 1 , 54, 89, 84, 9, 98, 57, 71, 18,
                21, 84, 69, 28, 11, 83, 13, 42, 64, 58, 78, 82, 13, 9, 96, 14, 39,
                89, 40, 32, 51, 85, 48, 40, 23, 15, 94, 93, 35, 81, 1, 9, 43, 39,
                15, 17, 97, 52};
            int swaps = 0;
            int loops = 0;

            //Print arrayToSort
            for (int i = 0; i < arrayToSort.Length; i++)
            {
                Console.Write(arrayToSort[i] + " ");
            }

            //Sorting
            bool sorted = false;
            while(!sorted)
            {
                sorted = true;
                for (int i = 0; i < arrayToSort.Length - 1; i++)
                {
                    if (arrayToSort[i] > arrayToSort[i + 1])
                    {
                        //Swap values
                        int swapValue = arrayToSort[i];
                        arrayToSort[i] = arrayToSort[i + 1];
                        arrayToSort[i + 1] = swapValue;
                        sorted = false;
                        swaps++;
                    }
                    loops++;
                }
            }
            //Prints arrToSort again
            Console.WriteLine("");
            for (int n = 0; n < arrayToSort.Length; n++)
            {
                Console.Write(arrayToSort[n] + " ");
            }
            Console.WriteLine("");
            Console.WriteLine(swaps);
            Console.WriteLine(loops);

            Console.ReadKey();
        }
    }
}
