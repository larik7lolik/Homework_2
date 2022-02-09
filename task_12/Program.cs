// Задача 12: Удалить вторую цифру трёхзначного числа.
Console.WriteLine("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine());
if (num > 1000 || num < 99)
{
    Console.WriteLine("Неравильное число");
    return;
}
 int delete = 2;
 var str = num.ToString();
 num = int.Parse(str.Remove(str.Length - delete, 1));
 Console.WriteLine(num);
