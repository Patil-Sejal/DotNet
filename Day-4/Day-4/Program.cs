using System;

namespace Day_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //reading array
            int[,] arr = new int[2, 2];
            for(int row=0;row<2;row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.WriteLine("Enter elements for ["+row+","+col+"] position : ");
                    arr[row, col] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //printing array
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write(arr[row,col]+ "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
