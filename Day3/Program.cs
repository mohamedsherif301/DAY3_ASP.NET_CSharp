using System.Diagnostics;

namespace Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region  multiplication table 
            /*
             
             
            Console.Write("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter number of columns: ");
            int columns = int.Parse(Console.ReadLine());

            // Declare and initialize the array
            int[,] table = new int[rows, columns];

            // Fill the array
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    table[i, j] = (i + 1) * (j + 1);
                }
            }

            // Print the multiplication table
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(table[i, j].ToString().PadLeft(4));
                }
                Console.WriteLine();
            }
             
             */
            #endregion

            #region store student age for many tracks
            /*
             
            Console.WriteLine("Enter Number of Students :");
            int studentsAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Number of Traks :");
            int Tracks = int.Parse(Console.ReadLine());

            int[,] arr2 = new int[studentsAge, Tracks];

           
            
            for (int i = 0 ; i < Tracks; i++)
            {
               
                Console.WriteLine($"Enter Your Students in Track {i + 1}");
                for(int j = 0 ; j < studentsAge ; j++)
                {
                    Console.Write($"Age of Student {j + 1}: ");
                    arr2[i, j] = int.Parse(Console.ReadLine());
                    

                }
            


            }
            Console.WriteLine("\n Students Ages Array:");
            for (int i = 0; i < Tracks; i++)
            {
                Console.Write($"Track {i + 1}: ");
                for (int j = 0; j < studentsAge; j++)
                {
                    Console.Write($"student:- {j + 1}: ");
                    Console.Write(arr2[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i= 0 ; i < Tracks; i++)
            {
                int sum = 0;
                for (int j = 0; j < studentsAge; j++)
                {
                    sum += arr2[i, j];
                }
                double average = (double)sum / studentsAge;
                Console.WriteLine($"Track {i + 1}: {average:F2}");
            }
             */
            #endregion

        }
    }
}
