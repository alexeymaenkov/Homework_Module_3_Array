namespace Homework_Module_3.Task3_The_largest_element;

public class LargestElement
{
    public void Run()
    {
        //Найти наибольший элемент матрицы A(10,10) и записать ноль в те ячейки,
        //где он находятся. Вывести наибольший элемент, исходную и полученную матрицу.
        //Массив под измененную версию не нужен.
        
        Random random = new();
        
        int minMatrixElement = 10;
        int maxMatrixElement = 99;
        int maxElement = Int32.MinValue;
        
        int[,] matrix = new int[10, 10];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = random.Next(minMatrixElement, maxMatrixElement);
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        foreach (int element in matrix)
        {
            if (element > maxElement)
                maxElement = element;
        }
        
        Console.WriteLine($"\nМаксимальный элемент массива равен: {maxElement}\n");
        
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == maxElement)
                {
                    matrix[i, j] = 0;
                }
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}