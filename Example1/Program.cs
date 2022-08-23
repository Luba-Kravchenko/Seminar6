/* Задайте одномерный массив из 123 случайных чисел.
   Найдите количество элементов массива значения которых лежат в отрезке [10,99].
   [5, 18, 123, 6, 2] -> 1
   [1, 2, 3, 6, 2] -> 0
 */
class Program
{
    static int[] CreaterArray(int number)
    {
        int[] array = new int[number];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(1, 200);
        }
        return array;
    }

    static void WriteArray(int[] array)
    {
        Console.WriteLine("Массив случайных чисел:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }

    static void QuantityElements(int[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 10)
            {
                if (array[i] < 99)

                {
                    count++;
                }
            }
        }
        Console.WriteLine(" ");
        Console.WriteLine("Количество элементов, лежащих в отрезке от 10 до 99: " + count);
    }



    static void Main(string[] args)
    {
        int[] array = CreaterArray(123);
        WriteArray(array);
        QuantityElements(array);
    }
} 


