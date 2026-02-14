namespace Homework_Module_3.Task10_Parenthesized_expression;

public class ParenthesizedExpression
{
    public void Run()
    {
        //Дана строка из символов '(' и ')'. Определить, является ли она корректным скобочным выражением.
        //Определить максимальную глубину вложенности скобок.
        //Текущая глубина равняется разности открывающихся и закрывающихся скобок в момент подсчета каждого символа.
        //К символу в строке можно обратиться по индексу

        //Пример “(()(()))” - строка корректная и максимум глубины равняется 3.
        //Пример некорректных строк: "(()", "())", ")(", "(()))(()"

        string originStr = "()(())()";

        int openCount = 0;
        int closeCount = 0;
        
        foreach (var c in originStr)
            Console.Write(c);

        for (int i = 0; i < originStr.Length; i++)
        {
            if (originStr[i] == '(')
            {
                openCount++;
            }
            else if (originStr[i] == ')')
            {
                closeCount++;
            }
        }
            
        if (originStr.First() == ')' || originStr.Last() == '(' || openCount != closeCount)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nСтрока не является корректным скобочным выражением!");
            Console.ResetColor();
        }
        else
        {
            if (openCount == closeCount)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nСтрока является корректным скобочным выражением!");
                Console.ResetColor();
            }
        }
    }
}