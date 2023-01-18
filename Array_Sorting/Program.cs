using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {3,2,1,5,4};

            sortArray(arr);
            Console.ReadLine();
        }

        public static void sortArray(int[] arr)
        {
            for(int i=0; i<arr.Length-1;i++) 
            { 
                for(int j=0; j<arr.Length-1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }
                }
            }

            Console.Write("Sorted Array is: ");
            foreach(int i in arr)
            {
                Console.Write(i+" ");
            }
        }
    }
}
