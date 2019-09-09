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
            int[] arrayToSort = { 45, 6, 12, 51, 4, 23, 31 };

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
                        i = 0;
                       
                    }
                    else
                    {

                    }

                }
                
            }
            //Prints arrToSort again
            Console.WriteLine("");
            for (int n = 0; n < arrayToSort.Length; n++)
            {
                Console.Write(arrayToSort[n] + " ");
            }

            Console.ReadKey();
        }
    }
}
