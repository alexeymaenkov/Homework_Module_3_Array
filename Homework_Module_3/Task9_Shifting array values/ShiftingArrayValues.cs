namespace Homework_Module_3.Task9_Shifting_array_values;

public class ShiftingArrayValues
{
    public void Run()
    {
        //Дан массив чисел. Нужно его сдвинуть циклически на указанное пользователем значение
        //позиций влево, не используя других массивов.
        //Пример для сдвига один раз: {1, 2, 3, 4} => {2, 3, 4, 1}
        
        int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        Console.WriteLine("Исходный массив: ");

        foreach (var element in array)
            Console.Write(element + ", ");
        
        Console.Write("\nНа сколько позиций вы хотите сдвинуть массив влево: ");
        int shiftLeft  = Convert.ToInt32(Console.ReadLine());
        
        int shift = shiftLeft % array.Length;
        
        for (int i = 0; i < shift; i++)
        {
            for (int j = 0; j < array.Length -1; j++)
            {
                (array[j], array[j + 1]) = (array[j + 1], array[j]);
            }
        }
        
        foreach (var element in array)
            Console.Write(element + ", ");
    }
}