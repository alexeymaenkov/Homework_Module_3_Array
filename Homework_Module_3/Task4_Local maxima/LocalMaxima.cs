namespace Homework_Module_3.Task4_Local_maxima;

public class LocalMaxima
{
    public void Run()
    {
        //Дан одномерный массив целых чисел из 30 элементов.
        //Найдите все локальные максимумы и вывести их.
        //(Элемент является локальным максимумом, если он больше своих соседей)
        //Крайний элемент является локальным максимумом, если он больше своего соседа.
        //Программа должна работать с массивом любого размера.
        //Массив всех локальных максимумов не нужен.
        
        Random random = new ();
        
        int minArrayElement = 10;
        int maxArrayElement = 99;
        
        int[] array = new int[30];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(minArrayElement, maxArrayElement);
            Console.Write(array[i] + " ");
        }

        Console.Write("\nЛокальные максимумы: ");
        
        if (array[0] > array[0 + 1])
        {
            Console.Write(array[0] + " ");
        }

        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i] >= array[i + 1] && array[i] >= array[i - 1])
            {
                Console.Write(array[i] + " ");
            }
        }
        
        if (array[array.Length - 1] > array[array.Length - 2])
        {
            Console.Write(array[array.Length - 1]);
        }
    }
}