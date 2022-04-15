using System.Linq;
namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            void fillMat(int[,] Mat)
            {
                for(int i = 0; i < Mat.GetLength(0); i++)
                {
                    for(int j = 0; j < Mat.GetLength(1); j++)
                    {
                        Mat[i,j] = new Random().Next(1,31);
                    }
                }
            }
            void sumElem(int[,] Mat) // Задание 1
            {
                int sum = 0;
                for (int i = 0; i < Mat.GetLength(0); i++)
                {
                    for (int j = 0; j < Mat.GetLength(1); j++)
                    {
                        sum += Mat[i,j];
                    }
                }
                Console.WriteLine($"Сумма равна {sum}");
            }
            void proizvElem(int[,] Mat) // Задание 2
            {
                int proizv = 1;
                for (int i = 0; i < Mat.GetLength(0); i++)
                {
                    for (int j = 0; j < Mat.GetLength(1); j++)
                    {
                        proizv *= Mat[i,j];
                    }
                }
                Console.WriteLine($"Произведение равно {proizv}");
            }
            void maxElem(int[,] Mat) //Задание 3
            {
                int max = 0;
                for (int i = 0; i < Mat.GetLength(0); i++)
                {
                    for (int j = 0; j < Mat.GetLength(1); j++)
                    {
                        if (Mat[i,j] > max) max = Mat[i,j];
                    }
                }
                Console.WriteLine($"Максимальное число равно {max}");
            }
            void minElem(int[,] Mat) //Задание 4
            {
                int min = 100000;
                for (int i = 0; i < Mat.GetLength(0); i++)
                {
                    for (int j = 0; j < Mat.GetLength(1); j++)
                    {
                        if (Mat[i,j] < min) min = Mat[i,j];
                    }
                }
                Console.WriteLine($"Минимальное число равно {min}");
            }
            void sumDiag(int[,] Mat) //Задание 5
            {
                int sum = 0;
                for (int i = 0; i < Mat.GetLength(0); i++)
                {
                    sum += Mat[i,i];
                }
                Console.WriteLine($"Сумма главной диагонали равна {sum}");
            }
            void proizvDiag(int[,] Mat) //Задание 6
            {
                int proizv = 1;
                for (int i = 0; i < Mat.GetLength(0); i++)
                {
                    proizv *= Mat[i,i];
                }
                Console.WriteLine($"Произведение  на главной диагонале равно {proizv}");
            }
            void maxDiag(int[,] Mat) //Задание 7
            {
                int max = 0;
                for (int i = 0; i < Mat.GetLength(0); i++)
                {
                    if (Mat[i,i] > max) max = Mat[i,i];
                }
                Console.WriteLine($"Максимальное число на диагонале равно {max}");
            }
            void minDiag(int[,] Mat) //Задание 8
            {
                int min = 10000000;
                for (int i = 0; i < Mat.GetLength(0); i++)
                {
                    if (Mat[i,i] < min) min = Mat[i,i];
                }
                Console.WriteLine($"Минимальное число на диагонале равно {min}");
            }
            void sumPobDiag(int[,] Mat) //Задание 9
            {
                int sum = 0;
                for (int i = 0; i < Mat.GetLength(0); i++)
                {
                    sum += Mat[i, Mat.GetLength(0) - i - 1];
                }
                Console.WriteLine($"Сумма побочной диагонали равна {sum}");
            }
            void proizvPobDiag(int[,] Mat) //Задание 10
            {
                int proizv = 1;
                for (int i = 0; i < Mat.GetLength(0); i++)
                {
                    proizv *= Mat[i, Mat.GetLength(0) - i - 1];
                }
                Console.WriteLine($"Произведение побочной диагонали равно {proizv}");
            }
            void maxPobDiag(int[,] Mat) //Задание 11
            {
                int max = 0;
                for (int i = 0; i < Mat.GetLength(0); i++)
                {
                    if (Mat[i, Mat.GetLength(0) - i - 1] > max) max = Mat[i, Mat.GetLength(0) - i - 1];
                }
                Console.WriteLine($"Максимальное число побочной диагонали равно {max}");
            }
            void minPobDiag(int[,] Mat) //Задание 12
            {
                int min = 100000000;
                for (int i = 0; i < Mat.GetLength(0); i++)
                {
                    if (Mat[i, Mat.GetLength(0) - i - 1] < min) min = Mat[i, Mat.GetLength(0) - i - 1];
                }
                Console.WriteLine($"Минимальное число побочной диагонали равно {min}");
            }
            void minMaxElem(int[,] Mat) //Задание 13
            {
                int max = 0;
                int minMax = 10000000;
                for (int i = 0; i < Mat.GetLength(0); i++)
                {
                    for(int j = 0; j < Mat.GetLength(1); j++)
                    {
                        if (Mat[i,j] > max) max = Mat[i,j];
                    }
                    if (max < minMax) minMax = max;
                    max = 0;
                }
                Console.WriteLine($"Минимальное число из максимальных равно {minMax}");
            }
            void transMat (int[,] Mat) //Задание 14
            {
                int [,] transmat = new int [Mat.GetLength(1), Mat.GetLength(0)];
                for (int i = 0; i < Mat.GetLength(1); i++)
                {
                    for (int j = 0; j < Mat.GetLength(0); j++)
                    {
                        transmat[i,j] = Mat[j,i];
                    }
                }
                Console.WriteLine("Транспонированная матрица: ");
                printMat(transmat);
            }
            void sumMats (int[,] Mat1, int[,] Mat2) //Задание 15
            {
                int [,] matsum = new int [Mat1.GetLength(0), Mat1.GetLength(1)];
                for (int i = 0; i < Mat1.GetLength(0); i++)
                {
                    for(int j = 0; j < Mat1.GetLength(1); j++)
                    {
                        matsum[i,j] = Mat1[i,j] + Mat2[i,j];
                    }
                }
                Console.WriteLine("Сумма матриц равна:");
                printMat(matsum);
            }
            void printMat (int[,] Mat) //Задание 16
            {
                for (int i = 0; i < Mat.GetLength(0); i++)
                {
                    for (int j = 0; j < Mat.GetLength(1); j++)
                    {
                        Console.Write($"{Mat[i,j]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            Console.WriteLine("Введите количество строк и столбцов");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int [,] mat = new int [a,b];
            int [,] mat2 = new int [a,b];
            Console.WriteLine("Даны матрицы: ");
            fillMat(mat);
            printMat(mat);
            fillMat(mat2);
            printMat(mat2);
            sumElem(mat);
            proizvElem(mat);
            maxElem(mat);
            minElem(mat);
            sumDiag(mat);
            proizvDiag(mat);
            maxDiag(mat);
            minDiag(mat);
            sumPobDiag(mat);
            proizvPobDiag(mat);
            maxPobDiag(mat);
            minPobDiag(mat);
            minMaxElem(mat);
            transMat(mat);
            sumMats(mat, mat2);

        }
    }
}