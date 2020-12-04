using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter No of batches:: ");
            int batch = int.Parse(Console.ReadLine());
            int[][][] arr = new int[batch][][];
           // arr[0] = new int[4][5];
            for(int i = 0; i < batch; i++)
            {
                Console.Write("Enter No of students for batch {0} :: ", i+1);
                int noOfStudent = int.Parse(Console.ReadLine());
                arr[i] = new int[noOfStudent][];

                for (int j = 0; j < noOfStudent; j++)
                {
                    Console.Write("Enter No of subject for student   {0} :: ", j+1);
                    int marks = int.Parse(Console.ReadLine());
                    arr[i][j] = new int[marks];

                    for(int k = 0; k < arr[i][j].Length; k++)
                    {
                        Console.Write("Enter Marks   {0} :: ", k + 1);

                        arr[i][j][k] = int.Parse(Console.ReadLine());
                    }
                }
            }

            Console.WriteLine("-------------------------");

            for (int i = 0; i < batch; i++)
            {
                Console.WriteLine("batch {0} :: ", i + 1);

                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.WriteLine("for subject {0} :: ",j+1);

                    for (int k = 0; k < arr[i][j].Length; k++)
                    {

                        Console.WriteLine(arr[i][j][k]);
                       
                    }
                    Console.WriteLine();
                }
                
            }




        }
    }
}
