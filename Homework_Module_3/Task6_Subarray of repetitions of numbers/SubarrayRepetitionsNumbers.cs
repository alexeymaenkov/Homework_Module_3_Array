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
        int maxArrayElement = 4;
        
        int[] array = new int[arrayLength];

        for (int arrayElement = 0; arrayElement < arrayLength; arrayElement++)
        {
            array[arrayElement] = random.Next(minArrayElement, maxArrayElement);
        }

        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        
        int repetCount = 1;
        int repetsNumber = 0;
        
        int tempRepetCount = 1;
        int tempRepetsNumber = 0;
        
        for (int index = 0; index < arrayLength - 1; index++)
        {
            if (array[index] == array[index + 1])
            {
                repetCount++;
                repetsNumber = array[index];
                
                if (repetCount > tempRepetCount)
                {
                    tempRepetCount = repetCount;
                    tempRepetsNumber = repetsNumber;
                }
            }
            else
            {
                repetCount = 1;
            }
        }
        
        Console.WriteLine($"\nЧисло {tempRepetsNumber} повторяется {tempRepetCount} раза подряд");
    }
}