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
            int sumElem(int[,] Mat) // Задание 1
            {
                int sum = 0;
                for (int i = 0; i < Mat.GetLength(0); i++)
                {
                    for (int j = 0; j < Mat.GetLength(1); j++)
                    {
                        sum += Mat[i,j];
                    }
                }
                return (sum);
            }
            float proizvElem(int[,] Mat) // Задание 2
            {
                int proizv = 1;
                for (int i = 0; i < Mat.GetLength(0); i++)
                {
                    for (int j = 0; j < Mat.GetLength(1); j++)
                    {
                        proizv *= Mat[i,j];
                    }
                }
                return (proizv);
            }
            int maxElem(int[,] Mat) //Задание 3
            {
                int max = 0;
                for (int i = 0; i < Mat.GetLength(0); i++)
                {
                    for (int j = 0; j < Mat.GetLength(1); j++)
                    {
                        if (Mat[i,j] > max) max = Mat[i,j];
                    }
                }
                return (max);
            }
            int minElem(int[,] Mat) //Задание 4
            {
                int min = 100000;
                for (int i = 0; i < Mat.GetLength(0); i++)
                {
                    for (int j = 0; j < Mat.GetLength(1); j++)
                    {
                        if (Mat[i,j] < min) min = Mat[i,j];
                    }
                }
                return (min);
            }
            int sumDiag(int[,] Mat) //Задание 5
            {
                int sum = 0;
                for (int i = 0; i < Mat.GetLength(0); i++)
                {
                    sum += Mat[i,i];
                }
                return (sum);
            }
            int proizvDiag(int[,] Mat) //Задание 6
            {
                int proizv = 1;
                for (int i = 0; i < Mat.GetLength(0); i++)
                {
                    proizv *= Mat[i,i];
                }
                return (proizv);
            }
            int maxDiag(int[,] Mat) //Задание 7
            {
                int max = 0;
                for (int i = 0; i < Mat.GetLength(0); i++)
                {
                    if (Mat[i,i] > max) max = Mat[i,i];
                }
                return (max);
            }
            int minDiag(int[,] Mat) //Задание 8
            {
                int min = 10000000;
                for (int i = 0; i < Mat.GetLength(0); i++)
                {
                    if (Mat[i,i] < min) min = Mat[i,i];
                }
                return (min);
            }
            int sumPobDiag(int[,] Mat) //Задание 9
            {
                int sum = 0;
                for (int i = 0; i < Mat.GetLength(0); i++)
                {
                    sum += Mat[i, Mat.GetLength(0) - i - 1];
                }
                return (sum);
            }
            int proizvPobDiag(int[,] Mat) //Задание 10
            {
                int proizv = 1;
                for (int i = 0; i < Mat.GetLength(0); i++)
                {
                    proizv *= Mat[i, Mat.GetLength(0) - i - 1];
                }
                return (proizv);
            }
            int maxPobDiag(int[,] Mat) //Задание 11
            {
                int max = 0;
                for (int i = 0; i < Mat.GetLength(0); i++)
                {
                    if (Mat[i, Mat.GetLength(0) - i - 1] > max) max = Mat[i, Mat.GetLength(0) - i - 1];
                }
                return (max);
            }
            int minPobDiag(int[,] Mat) //Задание 12
            {
                int min = 100000000;
                for (int i = 0; i < Mat.GetLength(0); i++)
                {
                    if (Mat[i, Mat.GetLength(0) - i - 1] < min) min = Mat[i, Mat.GetLength(0) - i - 1];
                }
                return (min);
            }
            int minMaxElem(int[,] Mat) //Задание 13
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
                return (minMax);
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
            Console.Write("Сумма равна ");
            Console.WriteLine(sumElem(mat));
            Console.Write($"Произведение равно ");
            Console.WriteLine(proizvElem(mat));
            Console.Write($"Максимальное число равно ");
            Console.WriteLine(maxElem(mat));
            Console.Write($"Минимальное число равно ");
            Console.WriteLine(minElem(mat));
            Console.Write($"Сумма главной диагонали равна ");
            Console.WriteLine(sumDiag(mat));
            Console.Write($"Произведение  на главной диагонале равно ");
            Console.WriteLine(proizvDiag(mat));
            Console.Write($"Максимальное число на диагонале равно ");
            Console.WriteLine(maxDiag(mat));
            Console.Write($"Минимальное число на диагонале равно ");
            Console.Write(minDiag(mat));
            Console.Write($"Сумма побочной диагонали равна ");
            Console.WriteLine(sumPobDiag(mat));
            Console.Write($"Произведение побочной диагонали равно ");
            Console.WriteLine(proizvPobDiag(mat));
            Console.Write($"Максимальное число побочной диагонали равно ");
            Console.WriteLine(maxPobDiag(mat));
            Console.Write($"Минимальное число побочной диагонали равно ");
            Console.WriteLine(minPobDiag(mat));
            Console.Write($"Минимальное число из максимальных равно ");
            Console.WriteLine(minMaxElem(mat));
            Console.WriteLine("Транспонированная матрица:");
            transMat(mat);
            Console.WriteLine("Сумма матриц равна:");
            sumMats(mat, mat2);

        }
    }
}