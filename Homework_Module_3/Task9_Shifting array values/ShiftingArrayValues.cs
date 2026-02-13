namespace Homework_Module_3.Task9_Shifting_array_values;

public class ShiftingArrayValues
{
    public void Run()
    {
        //Дан массив чисел. Нужно его сдвинуть циклически на указанное пользователем значение
        //позиций влево, не используя других массивов.
        //Пример для сдвига один раз: {1, 2, 3, 4} => {2, 3, 4, 1}
        
        
        int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        int tempArrayElement;

        Console.WriteLine("Исходный массив: ");
        
        for (int index = 0; index < array.Length; index++)
        {
            Console.Write(array[index] + ", ");
        }

        Console.Write("\nНа сколь позиций вы хотите сдвинуть массив влево: ");
        int shiftLeft  = Convert.ToInt32(Console.ReadLine());
        
        for (int index = 0; index < shiftLeft; index++)
        {
            for (int sortIndex = 0; sortIndex < array.Length -1; sortIndex++)
            {
                tempArrayElement = array[sortIndex];
                array[sortIndex] = array[sortIndex + 1];
                array[sortIndex + 1] = tempArrayElement;
            }
        }
        
        for (int index = 0; index < array.Length; index++)
        {
            Console.Write(array[index] + ", ");
        }
    }
}