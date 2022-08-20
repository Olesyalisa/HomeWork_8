/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц. 
Например, заданы 2 массива: 
1 4 7 2 
5 9 2 3 
8 4 2 4 
5 2 6 7         и 
 
1 5 8 5 
4 9 4 2 
7 2 2 6 
2 3 4 7 
 
Их произведение будет равно следующему массиву: 
1 20 56 10 
20 81 8 6 
56 8 4 24 
10 6 24 49 */

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Matrica size = ");
        int sizeM = int.Parse(Console.ReadLine());

        int[,] OneArr = new int[sizeM, sizeM];
        int[,] TwoArr = new int[sizeM, sizeM];
        int[,] ResultProizvMatr = new int[sizeM, sizeM];

        // Ввод элементов первого массива, где пользователь сам задает элементы 

        Console.WriteLine("Enter first matr: ");
        for (int i = 0; i < sizeM; i++)
        {
            Console.Write("Enter the array elements(через пробел) " + i + ": ");
            string fir = Console.ReadLine();
            string[] strfir = fir.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int s = 0; s < sizeM; s++)
            {
                OneArr[s, i] = int.Parse(strfir[s]);
            }
        }

        // Ввод элементов второго массива, где пользователь сам задает элементы 

        Console.WriteLine("Enter second matr: ");
        for (int i = 0; i < sizeM; i++)
        {
            Console.Write("Enter the array elements(через пробел) " + i + ": ");
            string fir = Console.ReadLine();
            string[] strfir = fir.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int s = 0; s < sizeM; s++)
            {
                TwoArr[s, i] = int.Parse(strfir[s]);
            }
        }

        // Показываем первый массив в терминале 

        Console.WriteLine("First massive:");
        for (int i = 0; i < sizeM; i++)
        {
            for (int s = 0; s < sizeM; s++)
                Console.Write(OneArr[s, i] + "   ");
            Console.WriteLine();

        }

        // Показываем второй массив в терминале 

        Console.WriteLine("Second massive:");
        for (int i = 0; i < sizeM; i++)
        {
            for (int s = 0; s < sizeM; s++)
                Console.Write(TwoArr[s, i] + "   ");
            Console.WriteLine();

        }


        // Произведение (проводится само действие) 

        for (int i = 0; i < sizeM; i++)
        {
            for (int s = 0; s < sizeM; s++)
            {
                ResultProizvMatr[s, i] = OneArr[s, i] * TwoArr[s, i];
            }
        }

        // Вывод произведения двух массивов на экран  

        Console.WriteLine("Result massiva = ");
        for (int i = 0; i < sizeM; i++)
        {
            for (int s = 0; s < sizeM; s++)
                Console.Write(ResultProizvMatr[s, i] + "  ");
            Console.WriteLine();

        }

    }
}

