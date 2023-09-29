using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceWork04
{
    struct Student
    {
        public string Name;
        public string GroupNumber; //номер группы
        public int[] Grades; //массив оценок
        public Student(string name, string groupNumber, int[] grades)
        {
            Name = name;
            GroupNumber = groupNumber;
            Grades = grades;
        }
    }
}
