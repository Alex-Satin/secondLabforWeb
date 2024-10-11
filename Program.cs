using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Demonstrating Thread class:");

        // Виклик методів з класом Thread
        ThreadExample1();
        ThreadExample2();
        ThreadExample3();

        Console.WriteLine("\nDemonstrating Async-Await:");

        // Виклик асинхронних методів
        Task task1 = AsyncExample1();
        Task task2 = AsyncExample2();
        Task task3 = AsyncExample3();

        // Чекати завершення асинхронних методів
        Task.WaitAll(task1, task2, task3);

        Console.WriteLine("All tasks completed.");
    }

    // 1. Метод з класом Thread: робить паузу у 2 секунди
    static void ThreadExample1()
    {
        Thread thread = new Thread(() =>
        {
            Console.WriteLine("Thread 1 is starting...");
            Thread.Sleep(2000); // Затримка на 2 секунди
            Console.WriteLine("Thread 1 completed.");
        });
        thread.Start();
    }

    // 2. Метод з класом Thread: рахує до 5
    static void ThreadExample2()
    {
        Thread thread = new Thread(() =>
        {
            Console.WriteLine("Thread 2 is counting:");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(500); // Пауза між кожним кроком
            }
            Console.WriteLine("Thread 2 completed.");
        });
        thread.Start();
    }

    // 3. Метод з класом Thread: працює з параметром
    static void ThreadExample3()
    {
        Thread thread = new Thread((object name) =>
        {
            if (name != null) {
                Console.WriteLine($"Thread 3 is processing for {name}...");
            Thread.Sleep(1000);
            Console.WriteLine($"Thread 3 completed for {name}.");
            }
        });
        thread.Start("Alice");
    }

    // 1. Асинхронний метод: робить паузу у 1 секунду
    static async Task AsyncExample1()
    {
        Console.WriteLine("Async method 1 is starting...");
        await Task.Delay(1000); // Асинхронна пауза
        Console.WriteLine("Async method 1 completed.");
    }

    // 2. Асинхронний метод: рахує до 3 з паузами
    static async Task AsyncExample2()
    {
        Console.WriteLine("Async method 2 is counting:");
        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine(i);
            await Task.Delay(700); // Асинхронна пауза
        }
        Console.WriteLine("Async method 2 completed.");
    }

    // 3. Асинхронний метод: виконує асинхронне очікування зовнішнього завдання
    static async Task AsyncExample3()
    {
        Console.WriteLine("Async method 3 is starting...");
        await Task.Run(() =>
        {
            // Симуляція важкої операції
            Thread.Sleep(1500);
            Console.WriteLine("Heavy task in Async method 3 completed.");
        });
        Console.WriteLine("Async method 3 completed.");
    }
}
