namespace Homework_Module_3.Task3_The_largest_element;

public class LargestElement
{
    public void Run()
    {
        //Найти наибольший элемент матрицы A(10,10) и записать ноль в те ячейки,
        //где он находятся. Вывести наибольший элемент, исходную и полученную матрицу.
        //Массив под измененную версию не нужен.
        
        Random random = new();

        int arrayALengthX = 10;
        int arrayALengthY = 10;
        int minArrayAElement = 10;
        int maxArrayAElement = 99;
        int maxElement = Int32.MinValue;
        
        int[,] arrayA = new int[arrayALengthY, arrayALengthX];

        for (int arrayY = 0; arrayY < arrayALengthY; arrayY++)
        {
            for (int arrayX = 0; arrayX < arrayALengthX; arrayX++)
            {
                arrayA[arrayY, arrayX] = random.Next(minArrayAElement, maxArrayAElement);
                Console.Write(arrayA[arrayY, arrayX] + " ");
            }
            Console.WriteLine();
        }

        foreach (int element in arrayA)
        {
            if (element > maxElement)
                maxElement = element;
        }
        
        Console.WriteLine($"\nМаксимальный элемент массива равен: {maxElement}\n");
        
        for (int arrayY = 0; arrayY < arrayALengthY; arrayY++)
        {
            for (int arrayX = 0; arrayX < arrayALengthX; arrayX++)
            {
                if (arrayA[arrayY, arrayX] == maxElement)
                {
                    arrayA[arrayY, arrayX] = 0;
                }
                Console.Write(arrayA[arrayY, arrayX] + " ");
            }
            Console.WriteLine();
        }
    }
}