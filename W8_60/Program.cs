/* Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.  
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента. 
массив размером 2 x 2 x 2 
12(0,0,0) 22(0,0,1) 
45(1,0,0) 53(1,0,1) */


class Program
{
    static void Main(string[] args)
    {
        Console.Write("One = ");
        int oneArr = int.Parse(Console.ReadLine());
        Console.Write("Two = ");
        int twoArr = int.Parse(Console.ReadLine());
        Console.Write("Three = ");
        int threeArr = int.Parse(Console.ReadLine());

        int count = 59;

        int[,,] PrintMass = new int[oneArr, twoArr, threeArr];

        // Формируем  

        for (int i = 0; i < threeArr; i++)
        {
            for (int s = 0; s < twoArr; s++)
                for (int j = 0; j < oneArr; j++) PrintMass[j, s, i] = count--;
        }

        for (int i = 0; i < threeArr; i++)
        {
            for (int s = 0; s < twoArr; s++)
            {
                for (int j = 0; j < oneArr; j++)
                    Console.Write(PrintMass[j, s, i] + " (" + j + ", " + s + ", " + i + ") ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}

