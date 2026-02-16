namespace Homework_Module_3.Task5_Dynamic_array;

public class DynamicArray
{
    public void Run()
    {
        //Пользователь вводит числа, и программа их запоминает.
        //Как только пользователь введёт команду sum, программа выведет сумму всех веденных чисел.
        //Выход из программы должен происходить только в том случае, если пользователь введет команду exit.
        //Если введено не sum и не exit, значит это число и его надо добавить в массив.
        //В начале цикла надо выводить в консоль все числа, которые содержатся в массиве, а значит их ввел пользователь ранее.
        //Программа должна работать на основе расширения массива.
        //Внимание, нельзя использовать List<T> и Array.Resize
        
        const string COMMAND_SUM = "sum";
        const string COMMAND_EXIT = "exit";
        
        int[] numbers = new int[1];
        int sum = 0;
        
        bool isWorking = true;

        while (isWorking)
        {
            Console.Write("Введенные числа: ");
            foreach (var num in numbers)
            {
                Console.Write(num + ", ");
            }
            
            Console.WriteLine($"\nДля вывода суммы всех веденных чисел введите команду: {COMMAND_SUM}");
            Console.WriteLine($"Для выхода из программы введите команду: {COMMAND_EXIT}");
            Console.Write("Введите целое число или команду:");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case COMMAND_SUM:
                    foreach (var num in numbers)
                    {
                        sum += num;
                    }

                    Console.WriteLine($"Сумма введенных чисел: {sum}");
                    break;

                case COMMAND_EXIT:
                    isWorking = false;
                    break;
                
                default:
                    if (Convert.ToInt32(userInput) < int.MaxValue && Convert.ToInt32(userInput) > int.MinValue)
                    {
                        int userNumber = Convert.ToInt32(userInput);
                        int[] tempNumbers = new int[numbers.Length + 1];
                        
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            tempNumbers[i] = numbers[i];
                        }
                        
                        tempNumbers[^1] = userNumber;
                        numbers = tempNumbers;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка ввода! Попробуйте еще раз:");
                    }

                    break;
            }
        }
    }
}