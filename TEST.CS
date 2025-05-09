/* Лабораторная 7. Упражнение 6 (контрольное). Реализация сортировки объектов класса */
using System;
using System.Collections.Generic;

public class Test
{
	public static void Main()
	{
		// insert testing code here
		BankAccount b1 = new BankAccount();
		b1.Populate(100);

		BankAccount b2 = new BankAccount();
		b2.Populate(100);

		Console.WriteLine("Before Transfer");
		Console.WriteLine("{0} {1} {2}", b1.Type(), b1.Number(), b1.Balance());
		Console.WriteLine("{0} {1} {2}", b2.Type(), b2.Number(), b2.Balance());

		b1.TransferFrom(b2, 10);

		Console.WriteLine("After Transfer");
		Console.WriteLine("{0} {1} {2}", b1.Type(), b1.Number(), b1.Balance());
		Console.WriteLine("{0} {1} {2}", b2.Type(), b2.Number(), b2.Balance());


        // Создаем список счетов и сортируем
        List<BankAccount> banks = new List<BankAccount>();
        banks.Add(b1);
        banks.Add(b2);
        banks.Sort(); // Сортировка по балансу

        // Выводим отсортированный список
        foreach (var item in banks)
        {
            Console.WriteLine($"{item.Number()}: {item.Balance()}");
        }
    }
}
