
//string[] names = { "Василий", "Петр", "Денис", "Николай", "Дмитрий", "Александр", "Евгений" };
//string[] names2 = { "Николай", "Константин", "Денис", "Денис", "Максим", "Андрей", "Алексей" };
//string[] result = new string[7];
//for (int index = 0; index < result.Length; index++)
//{
//    if (names[index] == names2[index])
//        continue;
//    result[index] = names[index] + "  " + names2[index];
//}
//foreach (var res in result)
//    Console.WriteLine(res);




#region Матрица в дабл
//class matrix
//{
//    int size;
//    double[,] arr;

//    public matrix(double[,] a, int n)
//    {
//        arr = a;
//        size = n;
//    }

//    public void swap()
//    {
//        double tmp;
//        for (int i = 0; i < size; i++)
//        {
//            for (int j = 0; j < i; j++)
//            {
//                tmp = arr[i, j];
//                arr[i, j] = arr[j, i];
//                arr[j, i] = tmp;
//            }
//        }
//    }

//    public void print()
//    {
//        for (int i = 0; i < size; i++)
//        {
//            for (int j = 0; j < size; j++)
//                Console.Write(arr[i, j] + " ");
//            Console.WriteLine();
//        }
//    }
//}

//class program
//{
//    public static void Main()
//    {
//        Console.Write("Введите размер матрицы: ");
//        int size = Convert.ToInt32(Console.ReadLine());
//        double[,] arr = new double[size, size];
//        Console.WriteLine("Заполните матрицу: ");

//        for (int i = 0; i < size; i++)
//        {
//            string[] str_arr = (Console.ReadLine()).Split(' ');
//            for (int j = 0; j < size; j++)
//                arr[i, j] = Convert.ToDouble(str_arr[j]);
//        }
//        matrix ob = new matrix(arr, size);

//        Console.WriteLine("\nИсходная матрица: ");

//        ob.print();

//        Console.WriteLine("\nТранспонированная матрица: ");
//        ob.swap();
//        ob.print();
//    }
//}

#endregion


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace proga
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность матрицы (nxn)");
            int n = Convert.ToInt16(Console.ReadLine());
            int[,] B = new int[n, n];
            Random rnd = new Random();
            Console.WriteLine("Исходная матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    B[i, j] = rnd.Next(-10, 10);
                    Console.Write("{0, 4}", B[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            int[] res1 = new int[n];  //массив для хранения сумм строк
            int summ1 = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    summ1 += B[i, j];   //суммируем элементы строки
                }
                res1[i] = summ1; //пишем сумму в массив
                summ1 = 0; //обнуляем переменную
            }

            int max = 0;    //индекс строки с максимальной суммой
            for (int j = 1; j < n; j++)
            {
                if (res1[j] > res1[max])   //если есть строка с суммой больше, то пишем в max её индекс
                    max = j;
            }
            Console.WriteLine("Номер строки с максимальной суммой элементов: " + max);
            Console.ReadLine();

            int[] res2 = new int[n];   //то же самое, только для столбцов
            int summ2 = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    summ2 += B[j, i];  // индексы меняем местами, чтобы просматривались не строки, а столбцы.
                }
                res2[i] = summ2;
                summ2 = 0;
            }

            int min = 0;
            for (int j = 1; j < n; j++)
            {
                if (res2[j] < res1[min])
                    min = j;
            }

            Console.WriteLine("Номер столбца с минимальной суммой элементов: " + min);
            Console.ReadLine();

        }
    }
}