namespace Homework_Module_3.Task2_Working_with_specific_rows;

public class WorkingWithSpecificRowsColumns
{
    public void Run()
    {
        //Дан двумерный массив.
        //Вычислить сумму второй строки и произведение первого столбца.
        //Вывести исходную матрицу и результаты вычислений.

        Random random = new();
        
        int minArrayElement = 1;
        int maxArrayElement = 10;
        
        int sumSecondRow = 0;
        int multiplyFirstColumn = 1;

        int[,] array = new int[3, 3];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = random.Next(minArrayElement, maxArrayElement);
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
        
        for (int i = 0; i < array.GetLength(1); i++)
        {
            sumSecondRow += array[array.GetLength(1) - 2, i];
        }
        
        for (int j = 0; j < array.GetLength(0); j++)
        {
            multiplyFirstColumn *= array[j, array.GetLength(0) - 3];
        }

        Console.WriteLine($"Сумма второй строки массива: {sumSecondRow}");
        Console.WriteLine($"Произведение первого столбца массива: {multiplyFirstColumn}");
    }
}