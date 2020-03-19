using System;
namespace SortApp
{
    class Program
    {
        public static void Main(string[] args)
        {


            int[] numbers = new int[10];
            Console.WriteLine("Введите 10 чисел");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0}-е число: ", i + 1);
                var consoleNumber = Console.ReadLine().ToString();
                int parsedNumber;
                var tempNumber = Int32.TryParse(consoleNumber, out parsedNumber);
                if (tempNumber == false)
                {
                    Console.WriteLine("Вы ввели не число.");
                }
                else
                {
                    numbers[i] = parsedNumber;
                }
            }
            ArrSort(numbers);
            ArrayShow(numbers);

        }
        public static void ArrSort(int[] numbers)
        {
            int temp;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
        }

        public static void ArrayShow(int[] numbers)
        {
            Console.WriteLine("Вывод отсортированного массива");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.ReadLine();
        }



    }
}
