Console.WriteLine("Введите переменную а: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите переменную b: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b * b)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}