using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter m: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] mass = new int[m, n];

            Console.WriteLine("Enter elements of the matrix, each with a new line: ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mass[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mass[i, j] + "\t");
                }
                Console.WriteLine();
            }
           
            char r = 'r';
            while(r == 'r')
            {
                Console.WriteLine("_______________________________________________________________________");
                Console.WriteLine("                                Menu");
                Console.WriteLine(" Choose number!");
                Console.WriteLine("  1 - Find the number of positive and negative numbers in the matrix;");
                Console.WriteLine("  2 - Sorting the matrix elements is linearly;");
                Console.WriteLine("  3 - Inversion of the matrix elements is linearly.");
                Console.WriteLine("_______________________________________________________________________");
                int b = Convert.ToInt32(Console.ReadLine());
                switch(b)
                {
                    case 1:
                        int pos = 0;
                        int neg = 0;
                        for (int i=0; i < m; i++)
                        {
                            for (int j = 0; j < n; j++)
                            {
                                 
                                if(mass[i,j] < 0)
                                {
                                    neg++;
                                }
                                if (mass[i, j] > 0)
                                {
                                    pos++;
                                }
                            }
                        }
                        Console.WriteLine("Number of positive numbers: " + pos);
                        Console.WriteLine("Number of negative numbers: " + neg);
                        break;
                    case 2:
                        for (int i = 0; i < m; i++)
                        {
                            for (int j = 0; j < n; j++)
                            {
                                for (int k = 0; k < n - j - 1; k++)
                                {
                                    if (mass[i, k] > mass[i, k + 1])
                                    {
                                        int l = mass[i, k];
                                        mass[i, k] = mass[i, k + 1];
                                        mass[i, k + 1] = l;
                                    }
                                }
                            } 
                        }
                        for (int i = 0; i < m; i++)
                        {
                            for (int j = 0; j < n; j++)
                            {
                                Console.Write(mass[i, j] + "\t");
                            }
                            Console.WriteLine();
                        }

                        break;
                    case 3:
                        for (int i = 0; i < m; i++)
                        {
                            for (int j = 0; j < n; j++)
                            {
                                for (int k = 0; k < n - j - 1; k++)
                                {
                                    // if (mass[i, k] < mass[i, k + 1])
                                    // {
                                    int l = mass[i, k];
                                    mass[i, k] = mass[i, k + 1];
                                    mass[i, k + 1] = l;
                                }
                            }
                        }

                        for (int i = 0; i < m; i++)
                        {
                            for (int j = 0; j < n; j++)
                            {
                                Console.Write(mass[i, j] + "\t");
                            }
                            Console.WriteLine();
                        }
                        break;
                }
            }
        }
    }
}
