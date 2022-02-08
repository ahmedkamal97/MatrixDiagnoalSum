using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixSum
{
    class Program
    {

        static void Main(string[] args)
        {
            int matrixSize;
            int[,] arr = new int[100, 100];
            Functions obj = new Functions();

            Console.WriteLine("Enter The Size Of The Array !");
            matrixSize = Convert.ToInt32(Console.ReadLine());



            obj.ReadFromUser(matrixSize, arr);

            obj.ShowMatrix(matrixSize,arr);


            int sum = 0;
            sum = obj.CalculateSum(matrixSize, arr);



         



            Console.WriteLine("\n Sum = " + sum);
            Console.ReadLine();






        }


       
    }


    class Functions
    {
        public void ReadFromUser(int matrixSize,int[,] arr)
        {
            Console.WriteLine("Enter The Matrix");
            for (int i = 0; i < matrixSize; i++)
                for (int j = 0; j < matrixSize; j++)
                {
                    Console.Write("Element - [{0},{1}]: ", i, j);

                    arr[i, j] = Convert.ToInt32(Console.ReadLine());

                }
        }


        public void ShowMatrix(int matrixSize,int[,] arr)
        {
            Console.WriteLine("\n The Matrix Is");

            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                    Console.Write("{0} ", arr[i, j]);
                Console.Write("\n");
            }
        }


        public int CalculateSum(int matrixSize,int[,] arr)
        {
            int tempSize, sum = 0;
            tempSize = matrixSize;
            for (int i = 0; i < matrixSize; i++)
            {
                tempSize = tempSize - 1;
                for (int j = 0; j < matrixSize; j++)
                {
                    if (j == tempSize || i == j)
                        sum = sum + arr[i, j];
                }
            }

            return sum;

        }
    }



}
