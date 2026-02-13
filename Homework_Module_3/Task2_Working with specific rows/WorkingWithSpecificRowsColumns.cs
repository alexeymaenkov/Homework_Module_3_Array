namespace Homework_Module_3.Task2_Working_with_specific_rows;

public class WorkingWithSpecificRowsColumns
{
    public void Run()
    {
        //Дан двумерный массив.
        //Вычислить сумму второй строки и произведение первого столбца.
        //Вывести исходную матрицу и результаты вычислений.

        Random random = new();

        int arrayLengthX = 3;
        int arrayLengthY = 3;
        
        int minArrayElement = 1;
        int maxArrayElement = 10;
        
        int sumSecondRow = 0;
        int multiplyFirstColumn = 1;

        int[,] array = new int[arrayLengthY, arrayLengthX];

        for (int arrayY = 0; arrayY < arrayLengthY; arrayY++)
        {
            for (int arrayX = 0; arrayX < arrayLengthX; arrayX++)
            {
                array[arrayY, arrayX] = random.Next(minArrayElement, maxArrayElement);
                Console.Write(array[arrayY, arrayX] + " ");
            }
            Console.WriteLine();
        }
        
        for (int arrayX = 0; arrayX < arrayLengthX; arrayX++)
        {
            sumSecondRow += array[1, arrayX];
        }
        
        for (int arrayY = 0; arrayY < arrayLengthY; arrayY++)
        {
            multiplyFirstColumn *= array[arrayY, 0];
        }

        Console.WriteLine($"Сумма второй строки массива: {sumSecondRow}");
        Console.WriteLine($"Произведение первого столбца массива: {multiplyFirstColumn}");
    }
}