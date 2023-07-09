using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork2
{
    class Student
    {
        string name="Daniil";
        int age=21;
        int averageScore = -1;
        /// <summary>
        /// Средний бал
        /// </summary>
        public int AverageScore 
        {
            get 
            { 
                return averageScore; 
            }
            set 
            {
                if (value > -0 && value <= 5) averageScore = value;
                else 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Ошибка! ");
                    Console.WriteLine("Средний балл не может быть: " + value);
                }
            } 
        }
        /// <summary>
        /// Возвращает имя и возраст студента
        /// </summary>
        public void GetInfo()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Имя: " + name);
            Console.WriteLine("Возраст: " + age);
        }
        /// <summary>
        /// Переимновать имя в "Аноним"
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public Student Rename(Student student)
        {
            student.name = "Аноним";
            return student;
        }
    }
}
