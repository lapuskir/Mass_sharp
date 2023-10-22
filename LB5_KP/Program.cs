using System.Reflection.Metadata;

class Program
{   /* Дан массив из n целых чисел. Написать программу,которая определяет, каких
    чисел в этом массиве больше: положительных или отрицательных. */
    static void Main(string[] args)
    {
        Console.Write("Введите количестов элементов массива:  ");
        int n = int.Parse(Console.ReadLine());
        int[] mas = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите {i} элемент массива:  ");
            mas[i] = int.Parse(Console.ReadLine());
            Console.WriteLine($"{i} элемент массива равен:  " + mas[i]);
        }
        Console.Write("Исходный массив - "); Console.WriteLine(String.Join(',', mas));
        int plus = 0;
        int minus = 0;

        for (int i = 0; i < n; ++i)
        {
            if (mas[i] > 0)
            {
                plus++;
            }
            else if (mas[i] < 0) 
            {
                minus++;
            }
        }
        Console.WriteLine($"положительных: {plus} \nОтрицательных: {minus}");
        if ( plus > minus ) { Console.WriteLine("больше положительных"); }
        else if (plus < minus)
            { Console.WriteLine("больше отрицательных");}
        else { Console.WriteLine("положительных и отрицательных чисел равное количество");}
    }
}






