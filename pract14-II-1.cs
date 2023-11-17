using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
class Structures
{
    // Создаем структуру Student
    public struct Student : IComparable<Student>
    {
        // Поля структуры
        public string LastName;
        public string FirstName;
        public string MiddleName;
        public int BirthYear;
        public string Address;
        public string School;
        // Конструктор, принимающий входные данные через запятую
        public Student(string lastName, string firstName, string middleName, int birthYear, string address, string school)
        {
            LastName = lastName;
            FirstName = firstName;
            MiddleName = middleName;
            BirthYear = birthYear;
            Address = address;
            School = school;
        }

        // Конструктор, принимающий одну строковую переменную line
        public Student(string line)
        {
            string[] data = line.Split(' ');
            LastName = data[0];
            FirstName = data[1];
            MiddleName = data[2];
            BirthYear = int.Parse(data[3]);
            Address = data[4];
            School = data[5];
        }
        public string GetStudentData()
        {
            return $"{this.LastName} {this.FirstName} {this.MiddleName} {this.BirthYear} {this.Address} {this.School}";
        }
        // Метод для сравнения студентов на основе года рождения
        public int CompareTo(Student other)
        {
            return this.BirthYear.CompareTo(other.BirthYear);
        }
        static void Main()
        {
            string input_path = "input.txt";
            string output_path = "output.txt";
            using (StreamReader reader = new StreamReader(input_path))
            {
                using (StreamWriter writer = new StreamWriter(output_path, false))
                {
                    List<Student> StudentsList = new List<Student>();
                    string line;
                    Console.Write("Введите школу: ");
                    string school = Console.ReadLine();
                    while ((line = reader.ReadLine()) != null)
                    {
                        StudentsList.Add(new Student(line));
                    }
                    StudentsList.Sort();
                    foreach (Student student in StudentsList)
                    {
                        if (student.School == school)
                            writer.WriteLine(student.GetStudentData());
                    }
                }
            }
        }
    }
}
