using System;

namespace PersonLibrary
{
    public class Person
    {
        string name = "Daniil";
        int age = 21;

        /// <summary>
        /// Возвращает имя и возраст студента
        /// </summary>
        public void GetInfo()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Имя: " + name);
            Console.WriteLine("Возраст: " + age);
        }
    }
}
