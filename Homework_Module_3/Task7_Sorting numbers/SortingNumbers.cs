namespace Homework_Module_3.Task7_Sorting_numbers;

public class SortingNumbers
{
    public void Run()
    {
        //Дан массив чисел (минимум 10 чисел). Надо вывести в консоль числа отсортированы,
        //от меньшего до большего.
        //Нельзя использовать Array.Sort. Используйте пузырьковую сортировку.
        
        Random random = new ();
        
        int minArrayElement = 1;
        int maxArrayElement = 99;
        int tempArrayElement;
        
        int[] array = new int[10];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(minArrayElement, maxArrayElement);
        }

        for (int i = 0; i < array.Length - 2; i++)
        {
            for (int j = 0; j < array.Length - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    tempArrayElement = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = tempArrayElement;
                }
            }
        }

        Console.WriteLine("Отсортированные элементы:");
        
        foreach (int element in array)
            Console.Write(element + " ");
    }
}