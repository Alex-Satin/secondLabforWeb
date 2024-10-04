using System;
using System.IO;

internal class Program
{
	private static void Main(string[] args)
	{
		bool flag = true;
		while (flag)
		{
			Console.WriteLine("Меню:");
			Console.WriteLine("1. Вивести кількість слів у тексті 'Lorem ipsum'");
			Console.WriteLine("2. Виконати математичну операцію");
			Console.WriteLine("3. Вийти");
			Console.Write("Оберіть пункт меню: ");
			switch (Console.ReadLine())
			{
			case "1":
				CountWords();
				break;
			case "2":
				PerformMathOperation();
				break;
			case "3":
				flag = false;
				break;
			default:
				Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
				break;
			}
		}
	}

	private static void CountWords()
	{
		string path = "lorem.txt";
		string text = File.ReadAllText(path);
		Console.Write("Введіть кількість слів для виведення: ");
		if (int.TryParse(Console.ReadLine(), out var result))
		{
			string[] array = text.Split(' ');
			for (int i = 0; i < result && i < array.Length; i++)
			{
				Console.Write(array[i] + " ");
			}
			Console.WriteLine();
		}
		else
		{
			Console.WriteLine("Невірний формат кількості.");
		}
	}

	private static void PerformMathOperation()
	{
		Console.Write("Введіть перше число: ");
		if (double.TryParse(Console.ReadLine(), out var result))
		{
			Console.Write("Введіть друге число: ");
			if (double.TryParse(Console.ReadLine(), out var result2))
			{
				Console.WriteLine($"Результат додавання: {result + result2}");
			}
			else
			{
				Console.WriteLine("Невірне число.");
			}
		}
		else
		{
			Console.WriteLine("Невірне число.");
		}
	}
}
