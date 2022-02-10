// Задача 16: Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine("Ввести число от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());
switch(num)
{
   case 1: Console.WriteLine("Понедельник");
   break;
   case 2: Console.WriteLine("Вторник");
   break;
   case 3: Console.WriteLine("Среда");
   break;
   case 4: Console.WriteLine("Четверг");
   break;
   case 5: Console.WriteLine("Пятница");
   break;
   case 6: Console.WriteLine("Суббота- выходной");
   break;
   case 7: Console.WriteLine("Воскресенье- выходной");
   break;

}


