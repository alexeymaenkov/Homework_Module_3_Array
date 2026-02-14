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
        
        const int arrayLength = 30;
        
        int minArrayElement = 10;
        int maxArrayElement = 99;
        
        int[] array = new int[arrayLength];

        for (int index = 0; index < arrayLength; index++)
        {
            array[index] = random.Next(minArrayElement, maxArrayElement);
            Console.Write(array[index] + " ");
        }

        Console.Write("\nЛокальные максимумы: ");

        for (int index = 0; index < array.Length; index++)
        {
            switch (index)
            {
                case 0:
                    if (array[index] > array[index + 1])
                    {
                        Console.Write(array[index] + " ");
                    }
                    break;
                
                case arrayLength - 1:
                    if (array[index] > array[index - 1])
                    {
                        Console.Write(array[index]);
                    }
                    break;
                
                default:
                    if (array[index] >= array[index + 1] && array[index] >= array[index - 1])
                    {
                        Console.Write(array[index] + " ");
                    }
                    break;
            }
        }
    }
}