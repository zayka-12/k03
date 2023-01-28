/* Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

Console.WriteLine($"Ряд чисел преобразует в мвссив");
Console.Write("Введите ряд чисел, разделенных запятой :  ");
string? seriesOfNumbers = Console.ReadLine();

seriesOfNumbers = seriesOfNumbers + ",";

string RemovingSpaces (String series)
{
   string seriesNew = "";
   for (int i = 0; i < series.Length; i++)
  {
     if (series[i] != ' ')
     {
       seriesNew += seriesOfNumbers[i];
     }
  }
return seriesNew;   
}
