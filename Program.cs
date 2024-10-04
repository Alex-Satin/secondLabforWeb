using System;

namespace LibrariesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Оберіть платформу для перегляду бібліотек:");
            Console.WriteLine("1. .NET Standard");
            Console.WriteLine("2. .NET Framework");
            Console.WriteLine("3. Xamarin");
            Console.WriteLine("4. Продемонструвати роботу з API");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    DescribeDotNetStandardLibraries();
                    break;
                case "2":
                    DescribeDotNetFrameworkLibraries();
                    break;
                case "3":
                    DescribeXamarinLibraries();
                    break;
                case "4":
                    DemonstrateAPI();
                    break;
                default:
                    Console.WriteLine("Невірний вибір");
                    break;
            }
            
            // Затримка перед виходом з програми
            Console.WriteLine("Натисніть будь-яку клавішу для завершення...");
            Console.ReadLine();  // Затримує завершення програми
        }

        static void DescribeDotNetStandardLibraries()
        {
            Console.WriteLine("Огляд бібліотек .NET Standard:");
            Console.WriteLine("1. System.Net.Http - бібліотека для виконання HTTP запитів.");
            Console.WriteLine("2. Newtonsoft.Json - популярна бібліотека для серіалізації/десеріалізації JSON.");
            Console.WriteLine("3. Moq - інструмент для створення mock-об'єктів у тестах.");
            Console.WriteLine("4. AutoMapper - інструмент для мапінгу даних між об'єктами різних типів.");
            Console.WriteLine("5. Dapper - мікро ORM для виконання SQL запитів і мапінгу результатів на об'єкти.");
        }


        static void DescribeDotNetFrameworkLibraries()
        {
            Console.WriteLine("Огляд бібліотек .NET Framework:");
            Console.WriteLine("1. Entity Framework - ORM для баз даних");
            Console.WriteLine("2. NUnit - Юніт-тести");
            Console.WriteLine("3. Serilog - Логування");
            Console.WriteLine("4. Quartz.NET - Планування завдань");
            Console.WriteLine("5. SignalR - Реальний час комунікацій");
        }

        static void DescribeXamarinLibraries()
        {
            Console.WriteLine("Огляд бібліотек Xamarin:");
            Console.WriteLine("1. Xamarin.Essentials - Доступ до функцій пристроїв");
            Console.WriteLine("2. SkiaSharp - Графіка");
            Console.WriteLine("3. Xamarin.Forms - Інтерфейс користувача");
            Console.WriteLine("4. FFImageLoading - Кешування зображень");
            Console.WriteLine("5. ReactiveUI - Реактивний інтерфейс");
        }

        static void DemonstrateAPI()
        {
            Console.WriteLine("Демонстрація роботи з API для .NET Standard:");
            APIExample.JsonSerializationExample();
            APIExample.CallHttpClientAPI().Wait();
            APIExample.UseAutoMapper();
            APIExample.UseDapper();
            APIExample.UseMoq();
        }
    }
}
