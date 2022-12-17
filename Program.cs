// Напишите программу,которая на вход принимает число и выдаёт его квадрат
// Например:
// 4 -> 16
// 9 -> 81
Console.WriteLine("Введите число");
int NumberA = Convert.ToInt32(Console.ReadLine());
// Так как по умалчанию в C# всё что мы вводим в Console.ReadLine для терминала является данными строки(string)
//Поэтому нужно крнвертировать данные из string в int (int number = Convert.ToInt32(Console.ReadLine);
int result = NumberA * NumberA;
System.Console.WriteLine("Квадрат числа " + NumberA + " будет " + result);







