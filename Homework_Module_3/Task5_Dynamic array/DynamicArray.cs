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

        int[] numbers = new int[1];
        int[] tempNumbers = new int[1];
        
        const string COMMAND_SUM = "sum";
        const string COMMAND_EXIT = "exit";
        
        bool isWorking = true;
        int userNumber = 0;

        while (isWorking)
        {
            Console.WriteLine($"Для вывода суммы всех веденных чисел введите команду: {COMMAND_SUM}");
            Console.WriteLine($"Для выхода из программы введите команду: {COMMAND_EXIT}");
            Console.Write("Введите число или команду:");
            string userInput = Console.ReadLine();
            
            switch (userInput)
            {
                case "sum":
                    break;
                case "exit":
                    isWorking = false;
                    break;
                default:
                    userNumber = Convert.ToInt32(userInput);
                    Console.WriteLine(userInput);
                    break;
            }
        }
    }
}