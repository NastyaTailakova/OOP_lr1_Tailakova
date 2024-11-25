using System;
using System.Linq;
using System.IO;

namespace _1lr
{
    class Program
    {
        // Класс продукта с несколькими полями
        class Product
        {
            public string Name { get; set; }
            public double Price { get; set; }
            public int Quantity { get; set; }
            public DateTime ExpirationDate { get; set; }

            // Конструктор для удобного создания продукта
            public Product(string name, double price, int quantity, DateTime expirationDate)
            {
                Name = name;
                Price = price;
                Quantity = quantity;
                ExpirationDate = expirationDate;
            }

            // Переопределяем метод ToString для формата строкового представления
            public override string ToString()
            {
                return $"Name: {Name}, Price: {Price}, Quantity: {Quantity}, Expiration Date: {ExpirationDate.ToShortDateString()}";
            }
        }
        static void Main(string[] args)
        {
            // Создание массива продуктов
            Product[] products = new Product[]
            {
                new Product("Orange", 1.00, 50, new DateTime(2024, 11, 01)),
                new Product("Apple", 0.85, 40, new DateTime(2024, 11, 02)),
                new Product("Potato", 0.70, 60, new DateTime(2024, 11, 20)),
                new Product("Juice", 1.35, 25, new DateTime(2024, 11, 21)),
                new Product("Meat", 2.70, 35, new DateTime(2024, 11, 20)),
                new Product("Milk", 1.20, 30, new DateTime(2024, 11, 24)),
                new Product("Bread", 0.80, 50, new DateTime(2024, 11, 25)),
                new Product("Eggs", 2.00, 20, new DateTime(2024, 11, 26)),
                new Product("Butter", 3.50, 25, new DateTime(2024, 11, 20)),
                new Product("Cheese", 2.50, 15, new DateTime(2024, 12, 25)),
                new Product("Yogurt", 1.00, 60, new DateTime(2024, 11, 30)),
                new Product("Chicken", 5.00, 10, new DateTime(2024, 11, 10))
            };

            // Сортировка продуктов по цене
            var sortedByPrice = products.OrderBy(product => product.Price).ToArray();
            Console.WriteLine("Список продуктов, отсортированных по цене:");
            using (StreamWriter writer = new StreamWriter("sortedByPrice.txt"))
            {
                writer.WriteLine("Список продуктов, отсортированных по цене:");
                foreach (var product in sortedByPrice)
                {
                    Console.WriteLine(product);
                    writer.WriteLine(product);
                }
            }

            Console.WriteLine($"Данные были записаны в файл: sortedByPrice.txt\n");

            // Сортировка продуктов по количеству
            var sortedByQuantity = products.OrderBy(product => product.Quantity).ToArray();
            Console.WriteLine("Список продуктов, отсортированных по количеству:");
            using (StreamWriter writer = new StreamWriter("sortedByQuantity.txt"))
            {
                writer.WriteLine("Список продуктов, отсортированных по количеству:");
                foreach (var product in sortedByQuantity)
                {
                    Console.WriteLine(product);
                    writer.WriteLine(product);
                }
            }

            Console.WriteLine($"Данные были записаны в файл: sortedByQuantity.txt\n");

            // Сортировка продуктов по дате истечения
            var sortedByDate = products.OrderBy(product => product.ExpirationDate).ToArray();
            Console.WriteLine("Список продуктов, отсортированных по истечению срока годности:");
            using (StreamWriter writer = new StreamWriter("sortedByDate.txt"))
            {
                writer.WriteLine("Список, отсортированных по истечению срока годности:");
                foreach (var product in sortedByDate)
                {
                Console.WriteLine(product);
                writer.WriteLine(product);
                }
            }

            Console.WriteLine($"Данные были записаны в файл: sortedByDate.txt\n");

            // Запись данных о продуктах в текстовый файл
            string filePath = "products.txt";
            Console.WriteLine("Список продуктов:");
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Список продуктов:");
                foreach (var product in products)
                {
                    Console.WriteLine(product);
                    writer.WriteLine(product);
                }
            }

            Console.WriteLine($"Данные были записаны в файл: {filePath}");
        }
    }
}

