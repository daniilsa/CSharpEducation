using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork2
{
    class Program
    {
        /// <summary>
        /// Перечесление дней в кадом месяце
        /// </summary>
        public enum MonthStyle
        {
            Январь = 31,
            Февраль = 28,
            Март = 31,
            Апрель = 30,
            Май = 31,
            Июнь = 30,
            Июль = 31,
            Август = 31,
            Сентябрь = 30,
            Октябрь = 31,
            Ноябрь = 30,
            Декабрь = 31,
        }
        /// <summary>
        /// Запуск заданий
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Exe1();
            Exe3();
            Exe6();
            Exe7();
            Exe8();
            Exe9();
            Exe10();
            Exe11();
            Exe12();
            Exe14();

            Console.ReadLine();
        }
        /// <summary>
        /// Задание 1-2.
        /// </summary>
        static void Exe1()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\r\nЗадание 1-2.");
            Student student = new Student();
            student.AverageScore = 6;
            student.GetInfo();
        }
        /// <summary>
        /// Задание 3
        /// </summary>
        static void Exe3()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\r\nЗадание 3.");
            Calculator calculator = new Calculator();
            int a = 5;
            int b = 4;
            Console.WriteLine(a + "+" + b + "= " + calculator.GetSumm(a, b));
            Console.WriteLine(a + "-" + b + "= " + calculator.GetSubtraction(a, b));
            Console.WriteLine(a + "*" + b + "= " + calculator.GetMultiplication(a, b));
            Console.WriteLine(a + "/" + b + "= " + calculator.GetDivision(a, b));
        }
        /// <summary>
        /// Задание 6
        /// </summary>
        static void Exe6()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\r\nЗадание 6.");
            Point point = new Point();
            int a = 20;
            int b = 40;
            Console.WriteLine("Расстояние между точками A(" + a + ") и B(" + b + ") равно: " + point.GetDistance(a, b));
        }
        /// <summary>
        /// Задание 7
        /// </summary>
        static void Exe7()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\r\nЗадание 7.");

            MonthStyle monthStyle = MonthStyle.Февраль;
           // Month month = new Month();
            Console.WriteLine("Кол-во дней в \"" + monthStyle.ToString()+"\": "+ (int)monthStyle);
        }
        /// <summary>
        /// Задание 8
        /// </summary>
        static void Exe8()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\r\nЗадание 8.");

            double width = 5;
            double height = 20;
            Rectangle rectangle = new Rectangle(width, height);
            Console.WriteLine("Площадь прямоугольника при длине " + width + " и ширине " + height + " равна: " + rectangle.GetSquare());
        }
        /// <summary>
        /// Задание 9
        /// </summary>
        static void Exe9()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\r\nЗадание 9.");

            Student student = new Student();
            student.Rename(student);
            student.GetInfo();
        }
        /// <summary>
        /// Задание 10
        /// </summary>
        static void Exe10()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\r\nЗадание 10.");

            Car car = new Car("Subaru");
            car.GetInfo(car);
        }
        /// <summary>
        /// Задание 11
        /// </summary>
        static void Exe11()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\r\nЗадание 11.");

            Book book = new Book();
            book.GetInfo(book);
        }
        /// <summary>
        /// Задание 12-13
        /// </summary>
        static void Exe12()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\r\nЗадание 12.");
            int a = 5;
            int b = 4;
            HelpLibrary.MathHelper help = new HelpLibrary.MathHelper();
            Console.WriteLine(a + "+" + b + "= " + help.GetSumm(a, b));
            Console.WriteLine(a + "-" + b + "= " + help.GetSubtraction(a, b));
            Console.WriteLine(a + "*" + b + "= " + help.GetMultiplication(a, b));
            Console.WriteLine(a + "/" + b + "= " + help.GetDivision(a, b));
        }
        /// <summary>
        /// Задание 14
        /// </summary>
        static void Exe14()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\r\nЗадание 14.");
            int a = 5;
            int b = 4;
            PersonLibrary.Person person = new PersonLibrary.Person();
            person.GetInfo();
        }
    }
}
