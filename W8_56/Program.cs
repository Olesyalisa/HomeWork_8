/* Задача 56: Задайте прямоугольный двумерный массив.  
Напишите программу, которая будет находить строку с наименьшей суммой элементов. 
Например, задан массив: 
1 4 7 2 
5 9 2 3 
8 4 2 4 
5 2 6 7 
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Line = ");
        int lin = int.Parse(Console.ReadLine());
        Console.Write("Column = ");
        int col = int.Parse(Console.ReadLine());

        int[,] GetMass = new int[lin, col];

        for (int i = 0; i < col; i++)
        {
            Console.Write("Enter the array elements(через пробел) " + i + ": ");
            string first = (Console.ReadLine());
            string[] strfirst = first.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int s = 0; s < lin; s++)
            {
                GetMass[s, i] = int.Parse(strfirst[s]);
            }
        }

        Console.WriteLine("Massive:");
        for (int i = 0; i < col; i++)
        {
            for (int s = 0; s < lin; s++)
                Console.Write(GetMass[s, i] + "   ");
            Console.WriteLine();
        }

        // Вычисление суммы  

        int sum = 0, sum_i = -1;

        for (int i = 0; i < col; i++)
        {
            int arr = 0;
            for (int s = 0; s < lin; s++)
            {
                arr += GetMass[s, i];
            }

            if ((sum_i < 0) | (arr < sum))
            {
                sum = arr;
                sum_i = i;
            }
        }

        Console.WriteLine("Min line: " + sum_i + " with sum = " + sum);


    }
}

