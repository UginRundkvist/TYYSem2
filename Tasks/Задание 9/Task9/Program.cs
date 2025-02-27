using System;

class Program
{
    static void Main(string[] args)
    {
        string input;
        int lenArr, arrElem, uniqueCount = 0;
        bool isValidInput, isUnique;
        int[] array = null;

        do{
            Console.Write("Введите длину массива:");
            input = Console.ReadLine();
            isValidInput = int.TryParse(input, out lenArr);

            if (!isValidInput)
            {
                Console.WriteLine("Ошибка: Введено некорректное значение необходимо ввести целое число. Пожалуйста, попробуйте еще раз:)");
            }
        } while (!isValidInput) ;

        array = new int[lenArr];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Введите {i + 1}-й элемент массива: ");
            input = Console.ReadLine();
            isValidInput = int.TryParse(input, out arrElem);

            if (!isValidInput)
            {
                Console.WriteLine("Ошибка: Введено некорректное значение необходимо ввести целое число. Пожалуйста, попробуйте еще раз:)");
                i--;
            } else
            {
                array[i] = arrElem;
            }
        }
        Console.WriteLine("-------------------------------------------------------------------------------------------------");
        Console.WriteLine("Нажмите любую кнопку, чтобы запуслить цикл");
        Console.ReadKey(true);
        if (array == null || array.Length == 0)
        {
            Console.WriteLine("Массив пустой");
        } else
        {

            for (int i = 0; i < lenArr; i++)
            {
                isUnique = true;

                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        isUnique = false;
                        break;
                    }
                }

                if (isUnique)
                {
                    uniqueCount++;
                }
            }
            Console.WriteLine($"Колличество уникальных чисел в массиве: {uniqueCount}");
        }
    }
}