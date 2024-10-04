using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Dapper;
using Moq;
using AutoMapper;
using System.Data.SqlClient;

namespace LibrariesApp
{
    class APIExample
    {
        // API Example
        public static async Task CallHttpClientAPI()
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetStringAsync("https://api.agify.io?name=michael");
                Console.WriteLine("Response from API (Agify): " + response);
            }
        }

        // JSON Serialization Example using Newtonsoft.Json
        public static void JsonSerializationExample()
        {
            var data = new { Name = "Alex", Age = 20 };
            string jsonData = JsonConvert.SerializeObject(data);
            Console.WriteLine("Serialized JSON: " + jsonData);
        }

        // AutoMapper Example
        public static void UseAutoMapper()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Source, Destination>());
            var mapper = config.CreateMapper();

            var source = new Source { Name = "Kate", Age = 30 };
            var destination = mapper.Map<Destination>(source);

            Console.WriteLine($"Mapped Name: {destination.Name}, Mapped Age: {destination.Age}");
        }

        public class Source
        {
            public string Name { get; set; } = string.Empty; // Ініціалізація властивості
            public int Age { get; set; }
        }

        public class Destination
        {
            public string Name { get; set; } = string.Empty;
            public int Age { get; set; }
        }

        // Dapper Example
        public static void UseDapper()
        {
            // Встановіть правильний рядок підключення до бази даних
            string connectionString = "Server=localhost;Database=TestDb;User Id=your_username;Password=your_password;";

            using (var connection = new SqlConnection(connectionString))
            {
                var result = connection.Query("SELECT * FROM Users");
                foreach (var row in result)
                {
                    Console.WriteLine($"User: {row.Name}, Age: {row.Age}");
                }
            }
        }

        // Moq Example
        public static void UseMoq()
        {
            var mock = new Mock<IService>();
            mock.Setup(service => service.GetData()).Returns("Mocked Data");

            Console.WriteLine("Moq Result: " + mock.Object.GetData());
        }

        public interface IService
        {
            string GetData();
        }
    }
}
