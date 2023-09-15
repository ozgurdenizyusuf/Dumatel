// See https://aka.ms/new-console-template for more information

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Задайте мне вопрос:");
while (true)
{
    string вопрос = Console.ReadLine();
    string ответ = "Ответ: 42";
    Console.WriteLine(ответ);
    Console.WriteLine("Задайте еще один вопрос:");
}
