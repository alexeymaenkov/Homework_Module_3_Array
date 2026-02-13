namespace Homework_Module_3.Task8_Split;

public class Split
{
    public void Run()
    {
        //Дана строка с текстом, используя метод строки String.Split() получить массив слов,
        //которые разделены пробелом в тексте и вывести массив, каждое слово с новой строки.

        //Ссылка на документацию: [Документация о String.Split()](https://learn.microsoft.com/ru-ru/dotnet/api/system.string.split?view=net-8.0)

        string text = "В массиве чисел найдите самый длинный подмассив из одинаковых чисел";

        string[] words = text.Split();

        foreach (var word in words)
        {
            Console.WriteLine(word);
        }
    }
}