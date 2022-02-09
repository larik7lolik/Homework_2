// Задача 10: Показать вторую цифру трёхзначного числа.
Console.WriteLine("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine();
int result = (num / 10) % 10;
Console.WriteLine(result);


