using System;

public class Average
{

    public static void Main()
    {
        int number = ReadAmount();

        float[] array = ReadDigit(number);   
        AverageValue(array);

    }

    private static int ReadAmount()
    {
        try
        {
            Console.WriteLine("Введите количество значений в последовательности n");
            int number = int.Parse(Console.ReadLine());
            return
    number;
        }
        catch
        {
            Console.WriteLine("Неверные данные");
            return
                0;
        }
        

    }

    public static float[] ReadDigit(int number)
    {
        Console.WriteLine($"Введите {number} чисел");
        float[] array = new float[(int)number];
        int counter = 0;
        while (counter != number)
        {
            try
            {
                array[counter] = int.Parse(Console.ReadLine());
                counter++;

            }
            catch
            {
                Console.WriteLine("Неправильный тип данных");
            }

        }
        return
                    array;

    }
    public static void AverageValue(float[] array)
    {

        float sum = 0;
        int counter = 0;

        while (counter != array.Length)
        {
            sum += array[counter];
            counter++;
        }

        float result = sum / counter;

        Console.WriteLine($"Среднее арифметическое последовательности = {result} ");
    }
}