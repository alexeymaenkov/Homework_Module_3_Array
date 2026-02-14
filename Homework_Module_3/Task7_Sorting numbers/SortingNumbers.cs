namespace Homework_Module_3.Task7_Sorting_numbers;

public class SortingNumbers
{
    public void Run()
    {
        //Дан массив чисел (минимум 10 чисел). Надо вывести в консоль числа отсортированы,
        //от меньшего до большего.
        //Нельзя использовать Array.Sort. Используйте пузырьковую сортировку.
        
        Random random = new ();
        
        int arrayLength = 10;
        int minArrayElement = 1;
        int maxArrayElement = 99;
        int tempArrayElement;
        
        int[] array = new int[arrayLength];

        for (int index = 0; index < arrayLength; index++)
        {
            array[index] = random.Next(minArrayElement, maxArrayElement);
        }

        for (int index = 0; index < arrayLength - 2; index++)
        {
            for (int sortIndex = 0; sortIndex < arrayLength - 1; sortIndex++)
            {
                if (array[sortIndex] > array[sortIndex + 1])
                {
                    tempArrayElement = array[sortIndex];
                    array[sortIndex] = array[sortIndex + 1];
                    array[sortIndex + 1] = tempArrayElement;
                }
            }
        }

        Console.WriteLine("Отсортированные элементы:");
        
        foreach (int element in array)
            Console.Write(element + " ");
    }
}