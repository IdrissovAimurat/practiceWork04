using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace practiceWork04._2nd
{
    /// <summary>
    /// 2.	Построить три класса (базовый и 3 потомка), описывающих некоторых хищных животных (один из потомков), всеядных(второй потомок) и травоядных (третий потомок). 
    ///     Описать в базовом классе абстрактный метод для расчета количества и типа пищи, необходимого для пропитания животного в зоопарке.
    /// a.Упорядочить всю последовательность животных по убыванию количества пищи.
    ///         При совпадении значений – упорядочивать данные по алфавиту по имени. 
    ///         Вывести идентификатор животного, имя, тип и количество потребляемой пищи для всех элементов списка.
    /// b.Вывести первые 5 имен животных из полученного в пункте а) списка.
    /// c.Вывести последние 3 идентификатора животных из полученного в пункте а) списка.
    /// d.Организовать запись и чтение коллекции в/из файл.e.Организовать обработку некорректного формата входного файла.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>
        {
            new Predator { Id = 1, Name = "Лев" },
            new Predator { Id = 1, Name = "Тигр" },
            new Omnivore { Id = 2, Name = "Медведь" },
            new Omnivore { Id = 2, Name = "Панда" },
            new Herbivore { Id = 3, Name = "Зебра" },
            new Herbivore { Id = 3, Name = "Лошадь" },
            };
            // Добавьте другие животные по аналогии

            // Сортировка животных по убыванию количества пищи, а затем по имени
            var sortedAnimals = animals
            .OrderByDescending(a => a.CalculateFoodQuantity())
            .ThenBy(a => a.Name)
            .ToList();

            Console.WriteLine("Идентификатор | Имя         | Тип         | Кол-во пищи");
            foreach (var animal in sortedAnimals)
            {
                Console.WriteLine($"{animal.Id,-13} | {animal.Name,-12} | {animal.Type,-12} | {animal.CalculateFoodQuantity(),-12}");
            }

            var top5Names = sortedAnimals.Take(5).Select(a => a.Name).ToList();
            Console.WriteLine("\nПервые 5 имен животных:");
            Console.WriteLine(string.Join(", ", top5Names));

            var last3Ids = sortedAnimals.Skip(Math.Max(0, sortedAnimals.Count - 3)).Select(a => a.Id).ToList();
            Console.WriteLine("\nПоследние 3 идентификатора животных:");
            Console.WriteLine(string.Join(", ", last3Ids));

            using (StreamWriter writer = new StreamWriter("animals.txt"))
            {
                foreach (var animal in animals)
                {
                    writer.WriteLine($"{animal.Id},{animal.Name},{animal.Type}");
                }
            }

            List<Animal> loadedAnimals = new List<Animal>();
            try
            {
                using (StreamReader reader = new StreamReader("animals.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 3)
                        {
                            int id = int.Parse(parts[0]);
                            string name = parts[1];
                            string type = parts[2];
                            Animal animal;
                            if (type == "Хищник")
                                animal = new Predator();
                            else if (type == "Всеядное")
                                animal = new Omnivore();
                            else if (type == "Травоядное")
                                animal = new Herbivore();
                            else
                                throw new Exception("Некорректный тип животного в файле.");
                            animal.Id = id;
                            animal.Name = name;
                            loadedAnimals.Add(animal);
                        }
                        else
                        {
                            throw new Exception("Некорректный формат строки в файле.");
                        }
                    }
                }

                Console.WriteLine("\nЖивотные из файла:");
                foreach (var animal in loadedAnimals)
                {
                    Console.WriteLine($"Идентификатор: {animal.Id}, Имя: {animal.Name}, Тип: {animal.Type}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
            }
        }
    }
}
