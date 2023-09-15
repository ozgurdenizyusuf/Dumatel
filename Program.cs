// See https://aka.ms/new-console-template for more information

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Задайте мне вопрос:");
while (true)
{
    string soru = Console.ReadLine();
    string cevap = "Ответ: 42";
    Console.WriteLine(cevap);
    Console.WriteLine("Задайте еще один вопрос:");
}
