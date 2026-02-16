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
        
        int minArrayElement = 1;
        int maxArrayElement = 9;
        
        int[] array = new int[30];
        
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(minArrayElement, maxArrayElement);
            Console.Write(array[i] + " ");
        }
        
        StringBuilder repeatsNumbers = new ();
        
        int currentLocalMax = 1;
        
        for (int i = 0; i < array.Length - 1; i++)
        {
            int repeatCount = 1;
            
            if (array[i] == array[i + 1])
            {
                repeatCount++;
                int repeatNumber = array[i];
                
                if (repeatCount > currentLocalMax)
                {
                    repeatsNumbers.Clear();
                    currentLocalMax = repeatCount;
                    repeatsNumbers.Append(repeatNumber);
                }
                else if (repeatCount == currentLocalMax)
                {
                    repeatsNumbers.Append(repeatNumber);
                }
            }
        }
        
        string resultStringRepeatNums = string.Empty;
        
        for (int i = 0; i < repeatsNumbers.Length; i++)
        {
            if (!resultStringRepeatNums.Contains(repeatsNumbers[i]))
            {
                resultStringRepeatNums += repeatsNumbers[i] + " ";
            }
        }
        
        Console.Write($"\nЧисло(а): {resultStringRepeatNums} повторяется(ются) {currentLocalMax} раз(а) подряд.");
    }
}