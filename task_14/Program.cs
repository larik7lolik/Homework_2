// Задача 14: Найти третью цифру числа или сообщить, что её нет.
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
if(num <= 99)
{
    Console.WriteLine("Нет третьей цифры");
    return;
}
int result = int.Parse(Convert.ToString(num)[2].ToString());
if(result == 0)
{ 
    Console.WriteLine("Цифра равна 0 ");
    return;
}
Console.WriteLine(result);
