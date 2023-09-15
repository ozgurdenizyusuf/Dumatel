// See https://aka.ms/new-console-template for more information

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Задайте мне вопрос:");
while (true)
{
    string вопрос = Console.ReadLine();
    string Ответ = "Ответ: 42";
    Console.WriteLine(Ответ);
    Console.WriteLine("Задайте еще один вопрос:");
}
