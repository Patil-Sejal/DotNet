using System;

namespace Day4
{
    class Program
    {
        static void Main12(string[] args)
        {
            int[,] matrix =[2, 2];
            for(int row=0;row<2;row++)
            {
                for(int col=0;col<2;col++)
                {
                    Console.Write("Enter elements for matrix ["+row+" "+col+"] : ");
                    int mat=Convert.ToInt32 (Console.ReadLine());
                    //Console.WriteLine(matrix);
                }
            }
            Console.WriteLine(matrix);
        }
    }
}
