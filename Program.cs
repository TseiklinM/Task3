using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
    Объявить одномерный (5 элементов) массив с именем A и 
двумерный массив (3 строки, 4 столбца) дробных чисел с именем B. 
    Заполнить одномерный массив А числами, введенными с клавиатуры пользователем, 
а двумерный массив В случайными числами с помощью циклов. 
    Вывести на экран значения массивов: массива А в одну строку, массива В — в виде матрицы. 
    Найти в данных массивах общий максимальный элемент, 
                            минимальный элемент, 
                            общую сумму всех элементов, 
                            общее произведение всех элементов, 
                            сумму четных элементов массива А, 
                            сумму нечетных столбцов массива В.
 */
namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Создание одномерного и двумергного массивов
            int[] arrayA = new int[5];
            double[][] arrayB = new double[3][];

            for (int i = 0; i < arrayB.Length; i++)
            {
                arrayB[i] = new double[4];
            }

            //2.Заполнение одномерного и двумерного массивов
            for (int i = 0; i < arrayA.Length; i++)
            {
                Console.Write($" Введите {i+1}-й элемент одномерного массива: ");
                arrayA[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();

            Random rand = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    arrayB[i][j] = Math.Round((rand.NextDouble()*10), 2) ;
                }
            }

            //3. Вывод полученных массивов на экран
            Console.WriteLine(" Массив А");
            foreach (int item in arrayA)
            {
                Console.Write($" {item}");
            }
            Console.WriteLine("\n Массив B");
            foreach (double[] row in arrayB)
            {
                foreach (double item in row)
                {
                    Console.Write($" {item}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            //4. Поиск max, min, суммы и произведеине элементов, суммы четных элементов массива А 
                                                                    //и нечетных столбцов массива B
            double max = 0, min = 0;
            double sumAllElements = 0, multipAllElements = 1;
            double sumEvenElementsArrayA = 0, sumOddColsArrayB = 0;

            max = arrayA[0];
            min = arrayA[0];
            for (int i = 1; i < arrayA.Length; i++)
            {
                if (max < arrayA[i])
                    max = arrayA[i];
                if (min > arrayA[i])
                    min = arrayA[i];
                sumAllElements += arrayA[i];
                multipAllElements *= arrayA[i];
                if (arrayA[i] % 2 == 0)
                    sumEvenElementsArrayA += arrayA[i];
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (max < arrayB[i][j])
                        max = arrayB[i][j];
                    if (min > arrayB[i][j])
                        min = arrayB[i][j];
                    sumAllElements += arrayB[i][j];
                    multipAllElements *= arrayB[i][j];
                    if (j % 2 == 0)
                        sumOddColsArrayB += arrayB[i][j];
                }
            }

            Console.WriteLine($" Максимальный элемент в двух массивах = {max}");
            Console.WriteLine($" Минимальный элемент в двух массивах = {min}");
            Console.WriteLine($" Сумма всех элементов двух массивов = {sumAllElements}");
            Console.WriteLine($" Произведение всех элементов двух массивов = {multipAllElements}");
            Console.WriteLine($" Сумма всех четных чисел массива А = {sumEvenElementsArrayA}");
            Console.WriteLine($" Сумма всех нечетных столбцов массива В = {sumOddColsArrayB}");

        }
    }
}
