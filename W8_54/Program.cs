/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию  
элементы каждой строки двумерного массива. 
Например, задан массив: 
1 4 7 2 
5 9 2 3 
8 4 2 4 
В итоге получается вот такой массив: 
1 2 4 7 
2 3 5 9 
2 4 4 8 */


// Ввод размера  

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Line = ");
        int lin = int.Parse(Console.ReadLine());
        Console.Write("Column = ");
        int col = int.Parse(Console.ReadLine());

        int[,] GetMass = new int[lin, col];

        // Ввод элементов массива (элементы в массиве вносит сам пользователь) 

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

        // Вывод начальный массива в терминале 

        Console.WriteLine("Massive: ");
        for (int i = 0; i < col; i++)
        {
            for (int s = 0; s < lin; s++)
                Console.Write(GetMass[s, i] + "  ");
            Console.WriteLine();
        }

        // Сортируем с min по max 

        for (int i = 0; i < col; i++)
        {
            for (int s = 0; s < lin; s++)
                for (int j = s + 1; j < lin; j++)
                    if (GetMass[s, i] > GetMass[j, i])
                    {
                        int arr = GetMass[s, i];
                        GetMass[s, i] = GetMass[j, i];
                        GetMass[j, i] = arr;
                    }
        }

        // Вывод нового массива в терминале 

        Console.WriteLine("New massive: ");
        for (int i = 0; i < col; i++)
        {
            for (int s = 0; s < lin; s++)
                Console.Write(GetMass[s, i] + "  ");
            Console.WriteLine();
        }
    }
}

