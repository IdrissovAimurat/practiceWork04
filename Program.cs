using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceWork04
{
    /// <summary>
    /// 1.	Создайте структуру с именем student, содержащую поля: 
    ///     фамилия и инициалы, номер группы, успеваемость (массив из пяти элементов). 
    ///     Создать массив из десяти элементов такого типа, упорядочить записи по возрастанию среднего балла. 
    ///     Добавить возможность вывода фамилий и номеров групп студентов, имеющих оценки, равные только 4 или 5.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[4];

            students[0] = new Student("Идрисов А.Н.", "Группа 1", new int[] { 5, 4, 3, 5, 4 });
            students[1] = new Student("Адылханов О.К.", "Группа 2", new int[] { 4, 4, 5, 3, 4 });
            students[2] = new Student("Ислам Ш.А.", "Группа 1", new int[] { 3, 3, 4, 5, 5 });
            students[3] = new Student("Тамерлан Б.Т.", "Группа 2", new int[] { 5, 5, 5, 5, 5 });

            //LINQ для сортировки студентов по среднему баллу
            var sortedStudents = students.OrderBy(s => s.Grades.Average());

            foreach (var student in sortedStudents)
            {
                if (student.Grades.All(grade => grade == 4 || grade == 5))
                {
                    Console.WriteLine($"Фамилия: {student.Name}, Группа: {student.GroupNumber}");
                }
            }

        }
    }
}
