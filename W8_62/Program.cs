/* Задача 62. Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7 */

class Program
{

    static int[,] Massive = new int[4, 2]
    {
            { 1, 0 },
            { 0, 1 },
            {-1, 0 },
            { 0, -1},
    };

    static int mass;

    static bool inside(int first, int second)
    {
        return (0 <= first) & (first < mass) & (0 <= second) & (second < mass);
    }

    static void Main(string[] args)
    {
        // Ввод размера 
        Console.Write("Enter massive = ");
        mass = int.Parse(Console.ReadLine());



        // Строим спираль против часовой стрелки 
        int one = 0;
        int two = 0;
        int three = 0;
        int four = 1;

        int[,] PrintArr = new int[mass, mass];

        while (four <= mass * mass)
        {
            PrintArr[one, two] = four++;

            // Следующая точка 

            int arr, arrTwo;

            arr = one + Massive[three, 0];
            arrTwo = two + Massive[three, 1];

            // А не наткнулись ли мы на край или на другую точку? проверка

            if (!inside(arr, arrTwo) || (PrintArr[arr, arrTwo] != 0))
            {
                three = (three + 1) % 4;
                arr = one + Massive[three, 0];
                arrTwo = two + Massive[three, 1];
            };

            one = arr;
            two = arrTwo;
        }


        for (two = 0; two < mass; two++)
        {
            for (one = 0; one < mass; one++)
                Console.Write(string.Format("{0,3} ", PrintArr[one, two]));
            Console.WriteLine();
        }
    }
}