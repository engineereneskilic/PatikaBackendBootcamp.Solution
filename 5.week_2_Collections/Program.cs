using System;

namespace _5.week_2_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            int[] numbers2 = { 1, 2, 3 };

            string[] friuts = new string[] { "Apple", "Banana" };

            Console.WriteLine(friuts[0]);


            for(int i = 0; i < friuts.Length; i++)
            {
                Console.WriteLine(friuts[i]);

            }

            int[,] matrix = new int[2,3]; // virgül sayısını arttır

            int[,] grid = {  { 1,2,3 } , { 4,5,6 }  };

            int value = grid[0, 1] = 2;

            // JUDGET ARRAY

            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[2] { 1, 2 };
            jaggedArray[1] = new int[3] { 3,4,5 };
            jaggedArray[2] = new int[2] { 6,7 };

            Console.WriteLine(jaggedArray[1][2]);


            jaggedArray[0][1] = 10;

            Console.WriteLine(jaggedArray[0][1]);



            Console.ReadKey();


        }
    }
}
