using System;
using System.Linq;

namespace ArrayLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[]{1,2,3};

            array.ToList().ForEach(i => Console.WriteLine(i.ToString()));
            array[1] = 10;
            array.ToList().ForEach(i => Console.WriteLine(i.ToString()));

            try
            { 
                array[3] = 10;
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }

            // A multideminsional array
            //basically a table

            int[,] a = {
                {1,2,3},
                {4,5,6}
            };

            Console.WriteLine (
                $"A multidimensional array lenth: {a.Length}"
            );

            //A jagged array. Its an arrau or arrays, so you
            // need to initialixe nested arrays afterwards
            int[][] b = {
                new int[] {1,2,3},
                new int[] {10,20,30,40,50},
                new int[] {5,6}
            };

            Console.WriteLine($"the jagged array length:{b.Length}"); //because it contains 3 arrays
            Console.WriteLine($"the nested array length:{b[1].Length}");

            // an element from the first row, first column
            a[0,0] = 10;

            // the first element's first element
            b[0][0] = 10;

            int[][][] c = new int[2][][];
            //int[2][2][2] or int[2][2][] is not possible - 
            //you cna initilize only the first rank
            //also, nested arrays are not initialized,
            //c[0].Length will give a null reference exception.
        }
    }
}
