using System;
using System.Collections.Generic;

namespace CSharpEssentials
{
    public class Student
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public Student(string firstName, string lastName, int Age)
        {
            FirstName = firstName;
            LastName = lastName;
            this.Age = Age;
        }
    }
	
    public class School
    {
        public string Name;
        public List<Student> Students;

        public School(string name)
        {
            Name = name;
            Students = new List<Student>();
        }
        public void BanStudents(int ban)
        {
            Students.RemoveAt(ban-1);
            PrintStudents();
        }

        public void PrintStudents()
        {
            if (Students.Count == 0)
            {
                Console.WriteLine($"В школе {Name} пока нет учеников!");
            }
            else
            {
                Console.WriteLine("{0, -10} {1, -10} {2, -10} {3, -10}", "Номер", "Имя", "Фамилия", "Возраст");
                for (int i = 0; i < Students.Count; i++) 
                {
                    Console.WriteLine("{0, -10} {1, -10} {2, -10} {3, -10}", (i+1), Students[i].FirstName, Students[i].LastName, Students[i].Age);
                }
            }
        }

        public void AddNewStudent(Student student)
        {
            Students.Add(student);
            Console.WriteLine($"Студент {student.FirstName} успешно добавлен в школу {Name}.");
        }
    }

    class Program
    {
        static void Main()
        {
            int ban = 0;
            Console.WriteLine("Здравствуйте! Введите название вашей школы");
            string schoolName = Console.ReadLine();
            School school = new School(schoolName);
            Console.WriteLine($"Школа {school.Name} успешна создана");

            while (true)
            {
                Console.WriteLine($"Хотите посмотреть список учеников школы {school.Name}? Введите да или нет. ");
                string userAnswer = Console.ReadLine();
                bool yes = GetAnswer(userAnswer);
                if (yes)
                {
                    school.PrintStudents();
                }

                Console.WriteLine($"Хотите добавить нового ученика в школу {school.Name}? Введите да или нет. ");
                userAnswer = Console.ReadLine();
                yes = GetAnswer(userAnswer);
                if (yes)
                {
                    Console.WriteLine($"Введите имя ученика");
                    string firstName = Console.ReadLine();
                    Console.WriteLine($"Введите фамилию ученика");
                    string lastName = Console.ReadLine();
                    Console.WriteLine("Введите возраст ученика");
                    int age = Convert.ToInt32(Console.ReadLine());
                    
                    Student student = new Student(firstName, lastName, age);
                    school.AddNewStudent(student);
                }
                else
                {
                    Console.WriteLine($"Хотите удалить ученика из школы {school.Name}?Введите да или нет.");
                    userAnswer = Console.ReadLine();
                    yes = GetAnswer(userAnswer);
                    if(yes)
                    {
                        school.PrintStudents();
                        Console.WriteLine($"Под каким порядковым номером хотите удалить студента из школы {school.Name}?");
                        while(true)
                        {
                            ban = Convert.ToInt32(Console.ReadLine());
                            if(ban > school.Students.Count || ban < 0)
                            {
                                Console.WriteLine("Введите в диапазоне учеников");
                            }
                            else
                            {
                                break;
                            }
                        }
                        school.BanStudents(ban);
                    }

                }
            }
        }
        static bool GetAnswer(string answer)
        {
            
            if(answer.ToLower()=="да")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}