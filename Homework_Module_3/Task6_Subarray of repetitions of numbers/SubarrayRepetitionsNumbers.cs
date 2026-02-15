using System.Text;
namespace Homework_Module_3.Task6_Subarray_of_repetitions_of_numbers;

public class SubarrayRepetitionsNumbers
{
    public void Run()
    {
        //В массиве чисел найдите самый длинный подмассив из одинаковых чисел.
        //Дано 30 чисел. Вывести в консоль сам массив, число,
        //которое само больше раз повторяется подряд и количество повторений.
        //Дополнительный массив не надо создавать.
        //Пример 1: {5, 5, 9, 9, 9, 5, 5} - число 9 повторяется 3 раза подряд.
        //Пример 2: {5, 5, 5, 3, 3, 3, 3} - число 3 повторяется 4 раза подряд.
        
        Random random = new ();
        
        const int arrayLength = 30;
        
        int minArrayElement = 1;
        int maxArrayElement = 9;
        int repetCount = 1;
        int repetNumber;
        int tempRepetCount = 1;
        
        StringBuilder repeatsNumbers = new ();
        
        string resultStringRepetNums = string.Empty;
        
        int[] array = new int[arrayLength];
        
        for (int arrayElement = 0; arrayElement < arrayLength; arrayElement++)
        {
            array[arrayElement] = random.Next(minArrayElement, maxArrayElement);
            Console.Write(array[arrayElement] + " ");
        }

        foreach (int element in array)
            Console.Write(element + " ");
        
        for (int index = 0; index < array.Length - 1; index++)
        {
            if (array[index] == array[index + 1])
            {
                repetCount++;
                repetNumber = array[index];
                
                if (repetCount > tempRepetCount)
                {
                    repeatsNumbers.Clear();
                    tempRepetCount = repetCount;
                    repeatsNumbers.Append(repetNumber);
                }
                else if (repetCount == tempRepetCount)
                {
                    repeatsNumbers.Append(repetNumber);
                }
            }
            else
            {
                repetCount = 1;
            }
        }
        
        for (int i = 0; i < repeatsNumbers.Length; i++)
        {
            if (!resultStringRepetNums.Contains(repeatsNumbers[i]))
            {
                resultStringRepetNums += repeatsNumbers[i] + " ";
            }
        }
        
        Console.Write($"\nЧисло(а): {resultStringRepetNums} повторяется(ются) {tempRepetCount} раз(а) подряд.");
    }
}