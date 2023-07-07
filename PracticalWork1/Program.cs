using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            ExerciseSelection();
        }

        enum Weekday
        {
            Понедельник,
            Вторник,
            Среда,
            Четверг,
            Пятница,
            Суббота,
            Восресенье,
        }

        /// <summary>
        /// Выбор задания
        /// </summary>
        static private void ExerciseSelection()
        {
            byte exercise = 1;

            do
            {
                ListOfExercise();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Выберите номер задания: ");
                try
                {
                    exercise = Convert.ToByte(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;
                }
                catch
                {
                    ExerciseSelection();
                }
                switch (exercise)
                {
                    case 0: { return; }
                    case 1: { Exe1(); break; }
                    case 2: { Exe2(); break; }
                    case 3: { Exe3(); break; }
                    case 4: { Exe4(); break; }
                    case 5: { Exe5(); break; }
                    case 6: { Exe6(); break; }
                    case 7: { Exe7(); break; }
                    case 8: { Exe8(); break; }
                    case 9: { Exe9("The Internet was invented in the late 1960s by the US Defense Department's Advanced Research Projects Agency.", 'a'); break; }
                    case 10: { Exe10(); break; }
                    case 11: { Exe11(); break; }
                    case 12: { arrWrite(Exe12(10)); break; }
                    case 13: { arrWrite(Exe13(10)); break; }
                    case 14: { arrWrite(Exe14(5, 10)); break; }
                    case 15: { Exe15(); break; }
                    case 16: { arrWrite(Exe16(5, 10), 5, 10); break; }
                    case 17: { Exe17(); break; }
                    case 18: { Exe18(); break; }
                    case 19: { Exe19(); break; }
                    case 20: { Exe20(); break; }
                    case 21: { Exe21(); break; }
                    case 22: { Exe22(); break; }
                    case 23: { Exe23(); break; }
                    case 24: { Exe24(); break; }
                    case 25: { Exe25(); break; }
                }
                Console.Clear();
            }
            while (exercise != 0);
        }

        #region [ Вспомогательные методы ]
        /// <summary>
        /// Вывод заданий на экран
        /// </summary>
        static private void ListOfExercise()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("0. Выход; ");
            Console.WriteLine("1. Задание номер 1; ");
            Console.WriteLine("2. Задание номер 2; ");
            Console.WriteLine("3. Задание номер 3; ");
            Console.WriteLine("4. Задание номер 4; ");
            Console.WriteLine("5. Задание номер 5; ");
            Console.WriteLine("6. Задание номер 6; ");
            Console.WriteLine("7. Задание номер 7; ");
            Console.WriteLine("8. Задание номер 8; ");
            Console.WriteLine("9. Задание номер 9; ");
            Console.WriteLine("10. Задание номер 10; ");
            Console.WriteLine("11. Задание номер 11; ");
            Console.WriteLine("12. Задание номер 12; ");
            Console.WriteLine("13. Задание номер 13; ");
            Console.WriteLine("14. Задание номер 14; ");
            Console.WriteLine("15. Задание номер 15; ");
            Console.WriteLine("16. Задание номер 16; ");
            Console.WriteLine("17. Задание номер 17; ");
            Console.WriteLine("18. Задание номер 18; ");
            Console.WriteLine("19. Задание номер 19; ");
            Console.WriteLine("20. Задание номер 20; ");
            Console.WriteLine("21. Задание номер 21; ");
            Console.WriteLine("22. Задание номер 22; ");
            Console.WriteLine("23. Задание номер 23; ");
            Console.WriteLine("24. Задание номер 24; ");
            Console.WriteLine("25. Задание номер 25; ");
        }
        /// <summary>
        /// Ошибка ввода
        /// </summary>
        static private void InputError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\r\nВведённое значение некорректно! Нажмите Enter, чтобы начать заново");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
        /// <summary>
        /// Вывод результата массива целочисленных числе
        /// </summary>
        /// <param name="arr"></param>
        static private void arrWrite(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine((i + 1) + "= " + arr[i]);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\r\nМассив успешно заполнен! Нажмите Enter, чтобы вернуться к списку заданий");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
        /// <summary>
        /// Вывод результата массива чисел с плавающей запятой
        /// </summary>
        /// <param name="arr"></param>
        static private void arrWrite(double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine((i + 1) + "= " + arr[i]);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\r\nМассив успешно заполнен! Нажмите Enter, чтобы вернуться к списку заданий");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
        /// <summary>
        /// Вывод результата двумероного массива
        /// </summary>
        /// <param name="arr">Двумерный массив</param>
        /// <param name="quantityWidth">"Ширина" массива</param>
        /// <param name="quantityHeight">"Высота" массива</param>
        static private void arrWrite(int[,] arr, int quantityWidth, int quantityHeight)
        {
            Console.WriteLine();
            for (int i = 0; i < quantityWidth; i++)
            {
                for (int j = 0; j < quantityHeight; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\r\nМассив успешно заполнен! Нажмите Enter, чтобы вернуться к списку заданий");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
        #endregion

        #region [ Задания 1-5 ]
        /// <summary>
        /// Задание 1
        /// </summary>
        static private void Exe1()
        {
            Console.Clear();
            Console.WriteLine("1.Объявите переменную следующего вида:");
            Console.WriteLine("\ta. целочисленная переменная, обозначающая возраст.");
            Console.WriteLine("\tb. строковая переменная для обозначения имени.");
            Console.WriteLine("\tc. строковая переменная для обозначения названия компании.");
            Console.WriteLine("\td. переменная логического типа.");
            Console.WriteLine("\te. переменная типа с плавающей точкой для обозначения веса тела человека.");

            int age;
            string name;
            string companyName;
            bool trigger;
            double bodyWeight;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\r\n Объявление прошло успешно! Нажмите Enter, чтобы вернуться к списку заданий");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
        /// <summary>
        /// Задание 2
        /// </summary>
        static private void Exe2()
        {
            Console.Clear();
            Console.WriteLine("2.Объявите и инициализируйте переменную следующего вида:");
            Console.WriteLine("\ta. переменная для обозначения возраста человека, имеющая значение вашего возраста.");
            Console.WriteLine("\tb. переменная, обозначающая ваше имя.");
            Console.WriteLine("\tc. переменная для обозначения температуры за окном");
            Console.WriteLine("\td. переменная логического типа, обозначающая принадлежность к женскому полу");

            int myAge = 21;
            string myName = "Daniil";
            byte temperature = 25;
            bool woman = false;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\r\nВозраст автора: " + myAge);
            Console.WriteLine("Имя автора: " + myName);
            Console.WriteLine("Температура за окном: " + temperature);
            Console.WriteLine("Женский пол? : " + woman);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\r\nОбъявление и инициализация прошли успешно! Нажмите Enter, чтобы вернуться к списку заданий");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
        /// <summary>
        /// Задание 3
        /// </summary>
        static private void Exe3()
        {
            Console.Clear();
            Console.WriteLine("3.Напишите цикл следующего вида:");
            Console.WriteLine("\ta.цикл for. Пусть он выводит в консоль значение своего же счётчика.");
            Console.WriteLine("\tb.цикл while.Пусть он выводит в консоль значение своего же счётчика.");
            Console.WriteLine("\tc.цикл do while.Пусть он выводит в консоль значение своего же счётчика.");
            Console.WriteLine("\td.цикл for, в котором у пользователя запрашиваются слова, затем выводится полная фраза, слова в которой разделены пробелами.");
            Console.WriteLine("\te.цикл while, в котором у пользователя запрашиваются слова, затем выводится полная фраза, слова в которой разделены пробелами.");
            Console.WriteLine("\tf.цикл do while, в котором у пользователя запрашиваются слова, затем выводится полная фраза, слова в которой разделены пробелами.");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\r\nБуква а.");
            Console.ForegroundColor = ConsoleColor.White;
            int i = 0;
            for (; i < 10; i++) Console.Write(i + " ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\r\nБуква b.");
            Console.ForegroundColor = ConsoleColor.White;
            i = 0;
            while (i < 10) { Console.Write(i + " "); i++; }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\r\nБуква c.");
            Console.ForegroundColor = ConsoleColor.White;
            i = 0;
            do
            {
                Console.Write(i + " ");
                i++;
            }
            while (i < 10);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\r\nБуква d.");
            Console.ForegroundColor = ConsoleColor.White;
            string temporaryStr = "";
            i = 0;
            for (; i < 3; i++)
            {
                Console.WriteLine("Введите слово " + (i + 1) + " из 3:");
                temporaryStr += Console.ReadLine() + " ";
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(temporaryStr);
            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.White;
            temporaryStr = "";
            i = 0;
            while (i < 3)
            {
                Console.WriteLine("Введите слово " + (i + 1) + " из 3:");
                temporaryStr += Console.ReadLine() + " ";
                i++;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(temporaryStr);
            Console.ForegroundColor = ConsoleColor.White;

            i = 0;
            temporaryStr = "";
            do
            {
                Console.WriteLine("Введите слово " + (i + 1) + " из 3:");
                temporaryStr += Console.ReadLine() + " ";
                i++;
            }
            while (i < 3);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(temporaryStr);
            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\r\nРабота циклов завершена! Нажмите Enter, чтобы вернуться к списку заданий");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
        /// <summary>
        /// Задание 4
        /// </summary>
        static private void Exe4()
        {
            Console.Clear();
            Console.WriteLine("4.Напишите программу, которая переводит:");
            Console.WriteLine("\ta.метры в километры.");
            Console.WriteLine("\tb.километры в сантиметры.");
            Console.WriteLine("\tc.м / с в км/ ч.");
            Console.WriteLine("\td.градусы C в градусы F.");
            // Перевод из метров в километры
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\r\nБуква a.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\r\nВведите кол-во метров: ");
            int meter = 0;
            try
            {
                meter = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                InputError();
                Exe4();
                return;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            if (meter % 1000 != 0) Console.WriteLine("Это " + meter / 1000 + " км. и " + meter % 1000 + "м.");
            else Console.WriteLine("Это " + meter / 1000 + " км.");
            Console.ForegroundColor = ConsoleColor.White;
            // Перевод из километров в сантиметры
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\r\nБуква b.");
            Console.ForegroundColor = ConsoleColor.White;
            int kilometer = 0;
            Console.Write("Введите кол-во километров: ");
            try
            {
                kilometer = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                InputError();
                Exe4();
                return;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Это " + kilometer * 100000 + " см.");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\r\nБуква с.");
            Console.ForegroundColor = ConsoleColor.White;
            int speed = 0;
            Console.Write("Введите скорость в м/с: ");
            try
            {
                speed = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                InputError();
                Exe4();
                return;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Это " + (speed * 3.6) + " км/ч");
            Console.ForegroundColor = ConsoleColor.White;
            // Перевод из Цельсия в Фаренгейта
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\r\nБуква d.");
            Console.ForegroundColor = ConsoleColor.White;
            int temperature = 0;

            Console.Write("Введите кол-во градусов в C: ");
            try
            {
                temperature = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                InputError();
                Exe4();
                return; ;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Это " + (temperature * (9.0 / 5.0) + 32) + " градусов в F");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\r\nВсе расчёты проведены! Нажмите Enter, чтобы вернуться к списку заданий");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
        /// <summary>
        /// Задание 5
        /// </summary>
        static private void Exe5()
        {
            Console.Clear();
            Console.WriteLine("5.Напишите программу для вычисления теоремы Пифагора для разных вариаций:");
            Console.WriteLine("\a.дано два катета");
            Console.WriteLine("\b.дана гипотенуза и один катет");


            bool trigger = false;
            while (!trigger)
            {
                Console.WriteLine("Выберите один из вариантов:");
                Console.WriteLine("a. Дано два катета");
                Console.WriteLine("b. Дана гипотенуза и катет");
                char value = '0';
                try
                {
                    value = Convert.ToChar(Console.ReadLine());
                }
                catch
                {
                    Exe5();
                }

                if (value == 'a')
                {
                    Console.WriteLine("Введите значение первого катета: ");
                    int cathetus1 = 0;
                    try
                    {
                        cathetus1 = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        InputError();
                        Exe5();
                        return;
                    }
                    Console.WriteLine("Введите значение второго катета: ");
                    int cathetus2 = 0;
                    try
                    {
                        cathetus2 = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        InputError();
                        Exe5();
                        return;
                    }
                    Console.WriteLine("Гипотенуза равна: " + Math.Sqrt(Math.Pow(cathetus1, 2) + Math.Pow(cathetus2, 2)));
                    trigger = !trigger;
                }
                else if (value == 'b')
                {
                    Console.WriteLine("Введите значение гипотенузы: ");
                    int hypotenuse = 0;
                    try
                    {
                        hypotenuse = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        InputError();
                        Exe5();
                        return;
                    }
                    Console.WriteLine("Введите значение  катета: ");
                    int cathetus = 0;
                    try
                    {
                        cathetus = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        InputError();
                        Exe5();
                        return;
                    }
                    if (hypotenuse > cathetus) Console.WriteLine("Второй катет равен: " + (Math.Sqrt((Math.Pow(hypotenuse, 2) - Math.Pow(cathetus, 2)))));
                    else Console.WriteLine("Гипотенуза должна быть больше катета!");
                    trigger = !trigger;
                }
                else
                {
                    Console.WriteLine("К сожалению, выбранный вами вариант не поддерживается нашей системой. Повторите попытку...");
                }

                if (trigger)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\r\nВсе расчёты проведены! Нажмите Enter, чтобы вернуться к списку заданий");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
        #endregion

        #region [ Задания 6-10 ]
        /// <summary>
        /// Задание 6
        /// </summary>
        static private void Exe6()
        {
            Console.Clear();
            Console.WriteLine("6.Напишите программу для вычисления выражения(а + b — f / а) + f * a * a — (a + b).");
            Console.WriteLine("Все переменные задаются пользователем.Учтите деление на 0.");

            int a = 1;
            int b = 1;
            int f = 1;

            Console.Write("Введите значение a: ");
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                InputError();
                Exe6();
                return;
            }

            Console.Write("Введите значение b: ");
            try
            {
                b = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                InputError();
                Exe6();
                return;
            }

            Console.Write("Введите значение f: ");
            try
            {
                f = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                InputError();
                Exe6();
                return;
            }

            if (a == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("К сожалению, мы не можем посчитать выражение с заданными параметрами (деление на 0)");
                Console.WriteLine("Нажмите Enter, чтобы ввести значения заново...");
                Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                Exe6();
                return;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Значение выражения, с заданными параметрами, равно: " + ((a + b - f / a) + f * a * a - (a + b)));
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\r\nВсе расчёты проведены! Нажмите Enter, чтобы вернуться к списку заданий");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
        /// <summary>
        /// Задание 7
        /// </summary>
        static private void Exe7()
        {
            Console.Clear();
            Console.WriteLine("7.Нарисуйте прямоугольный треугольник звёздочками. Чтобы высоту");
            Console.WriteLine("треугольника можно было задавать программно.");

            int height = 0;
            Console.Write("\r\nВведите высоту треугольника: ");
            try
            {
                height = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                InputError();
                Exe7();
                return;
            }

            char symbol = '*';
            Console.Write("Введите отображаемый символ, при выводе треугольника: ");
            try
            {
                symbol = Convert.ToChar(Console.ReadLine());
            }
            catch
            {
                InputError();
                Exe7();
                return;
            }

            int dock = 0;
            Console.WriteLine("Выберите сторону пярмого угла");
            Console.WriteLine("1. Левая сторона");
            Console.WriteLine("2. Правая сторона");
            try
            {
                dock = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                InputError();
                Exe7();
                return;
            }

            if (dock == 1)
            {
                int quantityChar = 1;
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < quantityChar; j++)
                    {
                        if ((j + 1) != quantityChar) Console.Write(symbol);
                        else Console.WriteLine(symbol);
                    }
                    quantityChar++;
                }
            }
            else if (dock == 2)
            {
                int quantityChar = 1;
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < (height - quantityChar); j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < quantityChar; j++)
                    {
                        if ((j + 1) != quantityChar) Console.Write(symbol);
                        else Console.WriteLine(symbol);
                    }
                    quantityChar++;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\r\nТретьей стороны не существует! Нажмите Enter, чтобы начать заново");
                Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                Exe7();
                return;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\r\nВсе трегольники нарисованы! Нажмите Enter, чтобы вернуться к списку заданий");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
        /// <summary>
        /// Задание 8
        /// </summary>
        static private void Exe8()
        {
            Console.Clear();
            Console.WriteLine("8.Напишите программу для сравнения двух целых чисел.Ввод осуществляйте");
            Console.WriteLine("через консоль.");

            int a = 0, b = 0;
            Console.Write("\r\nВведите первое число:");
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                InputError();
                Exe8();
                return;
            }
            Console.Write("Введите второе число:");
            try
            {
                b = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                InputError();
                Exe8();
                return;
            }

            if (a > b) Console.WriteLine("\r\nПервое число(" + a + ") больше, чем второе число(" + b + ")");
            else if (a < b) Console.WriteLine("\r\nПервое число(" + a + ") меньше, чем второе число(" + b + ")");
            else Console.WriteLine("\r\nПервое число(" + a + ") равно второму числу(" + b + ")");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\r\nВсе сравнения сравнены! Нажмите Enter, чтобы вернуться к списку заданий");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
        /// <summary>
        /// Задание 9
        /// </summary>
        /// <param name="argumentStr">Входная строка</param>
        /// <param name="argumentChar">Искомый символ</param>
        static private void Exe9(string argumentStr, char argumentChar)
        {
            Console.Clear();
            Console.WriteLine("9.Введите с клавиатуры строку произвольной длины и подсчитайте процент");
            Console.WriteLine("вхождения заданного символа в строку.");
            Console.WriteLine("\ta.строка и символ указываются программно");
            Console.WriteLine("\tb.строка и символ указываются пользователем в консоли");
            Console.WriteLine("\tc.строка и символ указываются через аргументы командной строки");

            Console.WriteLine("\r\nБуква a.");
            string sourceString = "Hello, World!";
            char sourceSymbol = 'l';

            int entry = 0;
            for (int i = 0; i < sourceString.Length; i++)
            {
                if ((i = sourceString.IndexOf(sourceSymbol, i)) > -1) entry++;
                else break;
            }
            Console.WriteLine("Строка: \"" + sourceString + "\"");
            Console.WriteLine("Символ: \'" + sourceSymbol + "\'");
            Console.WriteLine("Количество вхождений: " + entry);

            Console.WriteLine("\r\nБуква b.");
            Console.Write("Введите строку: ");
            sourceString = Console.ReadLine();
            Console.Write("Введите символ: ");
            try
            {
                sourceSymbol = Convert.ToChar(Console.ReadLine());
            }
            catch
            {
                InputError();
                Exe9(argumentStr, argumentChar);
                return;
            }
            entry = 0;
            for (int i = 0; i < sourceString.Length; i++)
            {
                if ((i = sourceString.IndexOf(sourceSymbol, i)) > -1) entry++;
                else break;
            }
            Console.WriteLine("\r\nСтрока: \"" + sourceString + "\"");
            Console.WriteLine("Символ: \'" + sourceSymbol + "\'");
            Console.WriteLine("Количество вхождений: " + entry);

            Console.WriteLine("\r\nБуква с.");
            sourceString = argumentStr;
            sourceSymbol = argumentChar;
            Console.WriteLine("Первый входной аргумент командной строки: " + sourceString);
            Console.WriteLine("Второй входной аргумент командной строки: " + sourceSymbol);
            entry = 0;
            for (int i = 0; i < sourceString.Length; i++)
            {
                if ((i = sourceString.IndexOf(sourceSymbol, i)) > -1) entry++;
                else break;
            }
            Console.WriteLine("Строка: \"" + sourceString + "\"");
            Console.WriteLine("Символ: \'" + sourceSymbol + "\'");
            Console.WriteLine("Количество вхождений: " + entry);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\r\nВсе символы надены! Нажмите Enter, чтобы вернуться к списку заданий");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
        /// <summary>
        /// Задание 10
        /// </summary>
        static private void Exe10()
        {
            Console.Clear();
            Console.WriteLine("10.Напишите программу, которая переводит строку в разные регистры");
            Console.WriteLine("\ta.в верхний регистр: f->F");
            Console.WriteLine("\tb.в нижний регистр: F->f");
            Console.WriteLine("\tc.делает заглавную букву в слове: привет->Привет");

            Console.WriteLine("\r\nТак как не указано, что пользователь должен вводить какие-то данные, будем ипользовтаь фразу \"Hello, World!\"");
            string lowerCase = "hello, world!";
            string upperCase = lowerCase.ToUpper();
            Console.WriteLine("Смена регистра фразы(" + lowerCase + ") в верхний регистр(" + upperCase + ")");

            upperCase = "HELLO, WORLD!";
            lowerCase = lowerCase.ToLower();
            Console.WriteLine("Смена регистра фразы(" + upperCase + ") в нижний регистр(" + lowerCase + ")");

            lowerCase = "hello, world!";
            upperCase = lowerCase.ToUpper();
            Console.Write("Смена регистра первой буквы фразы (" + lowerCase + ") в верхний регистр(");
            Console.Write(upperCase[0]);
            for (int i = 1; i < lowerCase.Length; i++)
            {
                Console.Write(lowerCase[i]);
            }
            Console.WriteLine(")");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\r\nНужные нам символы сменили регистр! Нажмите Enter, чтобы вернуться к списку заданий");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
        #endregion

        #region [ Задания 11-15 ]
        /// <summary>
        /// Задание 11
        /// </summary>
        static private void Exe11()
        {
            Console.Clear();
            Console.WriteLine("11.Составить алгоритм увеличения всех трех, введенных с клавиатуры,");
            Console.WriteLine("переменных на 5,если среди них есть хотя бы две равные. В противном случае");
            Console.WriteLine("выдать ответ «равных нет».");

            int[] arr = new int[3];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Введите перменную под номером " + (i + 1) + ": ");
                try
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    InputError();
                    Exe11();
                    return;
                }
            }
            bool tr = false;
            if (arr[0] == arr[1]) tr = !tr;
            else if (arr[0] == arr[2]) tr = !tr;
            else if (arr[1] == arr[2]) tr = !tr;
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\r\nРавных нет! Нажмите Enter, чтобы вернуться к списку заданий");
                Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            if (tr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] += 5;
                    Console.WriteLine("Цифра под номером " + (i + 1) + "(" + (arr[i] - 5) + ") стала " + arr[i]);
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\r\nВсе расчёты проведены! Нажмите Enter, чтобы вернуться к списку заданий");
                Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        /// <summary>
        /// Задание 12
        /// </summary>
        /// <param name="quantity">Размер массива</param>
        /// <returns></returns>
        static private int[] Exe12(int quantity)
        {
            Console.Clear();
            Console.WriteLine("12.Напишите метод, который создаёт массив целых чисел и возвращает его.");
            Console.WriteLine("Размер массива нужно передавать в качестве аргумента.Вдобавок напишите");
            Console.WriteLine("метод, который выводит переданный массив на экран консоли");
            int[] arr = new int[quantity];
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 20);
            }
            return arr;
        }
        /// <summary>
        /// Задание 13
        /// </summary>
        /// <param name="quantity">Размер массива</param>
        /// <returns></returns>
        static private double[] Exe13(int quantity)
        {
            Console.Clear();
            Console.WriteLine("13. Напишите программу, в которой создаётся массив и выводится на экран");
            Console.WriteLine("консоли.Размер массива передавайте в качестве первого аргумента командной");
            Console.WriteLine("строки.");
            double[] arr = new double[quantity];
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(10, 30);
                arr[i] *= 0.2 * i;
            }
            return arr;
        }
        /// <summary>
        /// Задание 14
        /// </summary>
        /// <param name="quantity">Размер массива</param>
        /// <param name="number">Число, которым будет заполняться массив</param>
        /// <returns></returns>
        static private int[] Exe14(int quantity, int number)
        {
            Console.Clear();
            Console.WriteLine("14. Напишите программу, в которой создаётся массив и выводится на экран");
            Console.WriteLine("консоли.Размер массива передавайте в качестве первого аргумента командной");
            Console.WriteLine("строки.Число, которым будет заполняться массив передайте через второй");
            Console.WriteLine("аргумент командной строки.");

            int[] arr = new int[quantity];
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = number;
            }
            return arr;
        }
        /// <summary>
        /// Задание 15
        /// </summary>
        /// <returns></returns>
        static private void Exe15()
        {
            Console.Clear();
            Console.WriteLine("15. Напишите программу, в которой создаётся массив строк, который заполняется");
            Console.WriteLine("пользователем через консоль. Затем этот массив должен быть выведен на");
            Console.WriteLine("экран консоли.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Внимание!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Чтобы закончить ввод, оставьте пустую строку и нажмите Enter");
            Console.WriteLine("\r\n");
            string[] enteredLines = new string[0];
            List<string> listEnteredLines = new List<string>();
            string str = string.Empty;
            do
            {
                Console.Write("Введите строку: ");
                str = Console.ReadLine();
                if (str != string.Empty)
                {
                    Array.Resize(ref enteredLines, enteredLines.Length + 1);
                    enteredLines[enteredLines.Length - 1] = str;
                    listEnteredLines.Add(str);
                }
                else break;
            }
            while (str != string.Empty);

            for (int i = 0; i < enteredLines.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Строка " + (i + 1) + ": ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(enteredLines[i]);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\r\nВсе строки выведены на экран! Нажмите Enter, чтобы вернуться к списку заданий");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
        #endregion

        #region [ Задания 16-20 ]
        /// <summary>
        /// Задание 16
        /// </summary>
        /// <param name="quantityWidth">"Ширина" массива</param>
        /// <param name="quantityHeight">"Высота" массива</param>
        /// <returns></returns>
        static private int[,] Exe16(int quantityWidth, int quantityHeight)
        {
            Console.Clear();
            Console.WriteLine("16.Напишите метод, который создаёт двумерный массив(не зубчатый). Размеры");
            Console.WriteLine("массива передавайте через аргументы метода. Также напишите отдельный");
            Console.WriteLine("метод для вывода двумерного массива в виде матрицы на экран консоли.");
            Console.WriteLine("Массив заполните случайными числами.");

            int[,] arr = new int[quantityWidth, quantityHeight];
            Random random = new Random();
            for (int i = 0; i < quantityWidth; i++)
            {
                for (int j = 0; j < quantityHeight; j++)
                {
                    arr[i, j] = random.Next(0, 9);
                }
            }
            return arr;
        }
        /// <summary>
        /// Задание 17
        /// </summary>
        static private void Exe17()
        {
            Console.Clear();
            Console.WriteLine("17. Создайте одномерный массив целых чисел произвольной длины и заполните");
            Console.WriteLine("случайными числами от 1 до 100.Выведите на экран разницу максимального и");
            Console.WriteLine("минимального значений в нём.");
            Random random = new Random();
            int quantity = random.Next(5, 20);
            Console.WriteLine("\r\nДлина массива: " + quantity);
            int[] arr = new int[quantity];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 100);
            }
            int max = arr[0];
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max) max = arr[i];
                if (arr[i] < min) min = arr[i];
            }
            Console.Write("Исходный массив (зёлёным подсвечиваются минимальные и максимальные числа массива): ");
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] == min)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(arr[i] + " ");
                }
                else if (arr[i] == max)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(arr[i] + " ");
                }
                else
                {
                    Console.Write(arr[i] + " ");
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.Write("\r\nРазница между самым большим и самым маленьким числом: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(max - min);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\r\nРазница найдена! Нажмите Enter, чтобы вернуться к списку заданий");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
        /// <summary>
        /// Задание 18
        /// </summary>
        static private void Exe18()
        {
            Console.Clear();
            Console.WriteLine("18.Создайте двумерный массив целых чисел произвольной длины и заполните");
            Console.WriteLine("случайными числами от 1 до 100.Выведите на экран разницу максимального и");
            Console.WriteLine("минимального значений в каждой строке массива.");

            Random random = new Random();
            int quantity = random.Next(5, 20);
            Console.WriteLine("\r\nДлина массива: " + quantity);
            int[,] arr = new int[quantity, quantity];

            for (int i = 0; i < quantity; i++)
            {
                for (int j = 0; j < quantity; j++)
                {
                    arr[i, j] = random.Next(0, 100);
                }
            }

            int max = arr[0, 0];
            int min = arr[0, 0];
            for (int i = 1; i < quantity; i++)
            {
                for (int j = 0; j < quantity; j++)
                {
                    if (arr[i, j] > max) max = arr[i, j];
                    if (arr[i, j] < min) min = arr[i, j];
                }
            }
            Console.WriteLine("Исходный массив (зёлёным подсвечиваются минимальные и максимальные числа массива): ");
            for (int i = 0; i < quantity; i++)
            {
                for (int j = 0; j < quantity; j++)
                {
                    if (j != 0)
                    {
                        if (arr[i, j] == min)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("\t" + arr[i, j] + " ");
                        }
                        else if (arr[i, j] == max)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("\t" + arr[i, j] + " ");
                        }
                        else
                        {
                            Console.Write("\t" + arr[i, j] + " ");
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        if (arr[i, j] == min)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(arr[i, j] + " ");
                        }
                        else if (arr[i, j] == max)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(arr[i, j] + " ");
                        }
                        else
                        {
                            Console.Write(arr[i, j] + " ");
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                Console.WriteLine();
            }
            Console.Write("\r\nРазница между самым большим и самым маленьким числом: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(max - min);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\r\nРазница найдена! Нажмите Enter, чтобы вернуться к списку заданий");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
        /// <summary>
        /// Задание 19
        /// </summary>
        static private void Exe19()
        {
            Console.Clear();
            Console.WriteLine("19. Напишите игру Угадай число. Программа случайно генерирует число от 1 до");
            Console.WriteLine("100, а пользователь пытается угадать это число. При успешной догадке");
            Console.WriteLine("выводите поздравление пользователя.");
            Console.WriteLine("Введите '0', чтобы выйти");
            Random random = new Random();
            bool exit = false;
            int desiredNumber = random.Next(1, 100);
            int enterNumber = 0;
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Введите число: ");
                try
                {
                    enterNumber = Convert.ToInt32(Console.ReadLine());
                    if (enterNumber == 0) return;
                    if (enterNumber != desiredNumber)
                    {
                        Console.Write("Эх... ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Мимо!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(" Пробуй ещё");
                    }
                    else
                    {
                        Console.Write("Чуваааааак! Ровно в ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("цель");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(". Ты молодец!");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("\r\nИгра окончена! Нажмите Enter, чтобы вернуться к списку заданий");
                        Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Внимание! ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Похоже что вы не очень поняли правила игры. Нужно вводить ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ЧИСЛО!");
                }
            }
            while (!exit && enterNumber != desiredNumber);
        }
        /// <summary>
        /// Задание 20
        /// </summary>
        static private void Exe20()
        {
            Console.Clear();
            Console.WriteLine("20. Напишите игру Угадай число. Программа случайно генерирует число от 1 до");
            Console.WriteLine("100, а пользователь пытается угадать это число. При успешной догадке");
            Console.WriteLine("выводите поздравление пользователя. Также покажите количество попыток,");
            Console.WriteLine("принятых пользователем.");
            Console.WriteLine("a.Сделайте ограничение по попыткам. Например, если попыток больше 10,");
            Console.WriteLine("то пользователь проиграл");
            Console.WriteLine("b.Сделайте подсказки для пользователя. Если предположенное число");
            Console.WriteLine("больше загаданного, то писать в консоль об этом. Аналогично и для");
            Console.WriteLine("меньшего числа.");

            Random random = new Random();
            bool exit = false;
            int desiredNumber = random.Next(1, 100);
            int enterNumber = 0;
            byte attempt = 0;
            do
            {
                if (attempt == 10)
                {
                    Console.Write("Эх... Попытки ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("кончились(");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" Не расстраивайся) Ответ был: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(desiredNumber);

                    Console.WriteLine("Нажмите Enter, чтобы вернуться к списку заданий");
                    Console.ReadLine();
                    return;
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\r\nПопытка " + (attempt + 1) + ". Введите число: ");
                try
                {
                    enterNumber = Convert.ToInt32(Console.ReadLine());
                    if (enterNumber == 0) return;
                    if (enterNumber != desiredNumber)
                    {
                        if (attempt < 9)
                        {
                            Console.Write("Эх... ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Мимо!");
                            Console.ForegroundColor = ConsoleColor.White;
                            if (enterNumber > desiredNumber) Console.WriteLine("Число меньше, чем ты ввёл");
                            else if (enterNumber < desiredNumber) Console.WriteLine("Число больше, чем ты ввёл");
                        }
                    }
                    else
                    {
                        Console.Write("Чуваааааак! Ровно в ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("цель");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(". Ты молодец!");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("\r\nИгра окончена! Нажмите Enter, чтобы вернуться к списку заданий");
                        Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Внимание! ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Похоже что вы не очень поняли правила игры. Нужно вводить ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ЧИСЛО!");
                }
                attempt++;
            }
            while (!exit && enterNumber != desiredNumber);

        }
        #endregion
        #region [ Задания 21-25 ]
        /// <summary>
        /// Задание 21
        /// </summary>
        static private void Exe21()
        {
            Console.Clear();
            Console.WriteLine("21. Напишите программу для вычисления високосного года.");
            Console.WriteLine("● год, номер которого кратен 400, — високосный;");
            Console.WriteLine("остальные годы, номер которых кратен 100, — невисокосные");
            Console.WriteLine("остальные годы, номер которых кратен 4, — високосный;");
            Console.WriteLine("все остальные годы — невисокосные.");
            int year = 0;
            Console.Write("Введите год: ");
            try
            {
                year = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("МММ... Такого года не существует");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Нажмите Enter, чтобы вернуться к списку заданий");
                Console.ReadLine();
            }

            if (year % 4 == 0)
            {
                Console.WriteLine("Каждые 4 года мы сталкиваемся с тем, что в феврале вместо стандартных 28 дней бывает 29.Наступает високосный год. ");
                Console.WriteLine("Это связано с тем, что Земля вращается вокруг солнца немного быстрее, чем за 365 дней.Для компенсации этого явления ");
                Console.WriteLine("придуман и введен в практику високосный год, который продолжается 366 суток за счет добавления лишнего дня в феврале.");
                Console.Write("\r\nКак вы уже догадались, ваш год ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("високосный.");
                Console.ForegroundColor = ConsoleColor.White;

            }
            else
            {
                Console.Write("\r\nСожалею, но ваш год ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("невисокосный.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine("Нажмите Enter, чтобы вернуться к списку заданий");
            Console.ReadLine();
        }
        /// <summary>
        /// Задание 22
        /// </summary>
        static private void Exe22()
        {
            Console.Clear();
            Console.WriteLine("22. Создайте перечисление(enum) для дней недели.Напишите программу, которая");
            Console.WriteLine("выводит на экран дни недели по названиям");

            for (int i = 0; i < 7; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write((i + 1) + " день недели: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine((Weekday)i);
            }
            Console.WriteLine("\r\nВот мы и изучили дни недели). Нажмите Enter, чтобы вернуться к списку заданий");
            Console.ReadLine();
        }
        /// <summary>
        /// Задание 23
        /// </summary>
        static private void Exe23()
        {
            Console.Clear();
            Console.WriteLine("22. Создайте перечисление(enum) для дней недели.Напишите программу, которая");
            Console.WriteLine("выводит на экран дни недели по названиям");

            Console.Write("Введите число от 1 до 7:");
            int day = 0;
            Console.Write("Введите год: ");
            try
            {
                day = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Вы что-то напутали... Такого дня не существует... Я даже не увперен что это день");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Нажмите Enter, чтобы вернуться к списку заданий");
                Console.ReadLine();
            }

            if (day > 0 && day < 8)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(day + " день недели: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine((Weekday)(day-1));
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Вы что-то напутали... В неделе всего 7 дней. Правда если вы из будщего, то может быть всё поменялось.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Нажмите Enter, чтобы вернуться к списку заданий");
                Console.ReadLine();
            }

            Console.WriteLine("\r\nКак-то так... Нажмите Enter, чтобы вернуться к списку заданий");
            Console.ReadLine();
        }
        /// <summary>
        /// Задание 24
        /// </summary>
        static private void Exe24()
        {
            Console.Clear();
            Console.WriteLine("24. Создайте класс Person.Добавьте в него свойства");
            Console.WriteLine("a.FirstName, LastName, Age");
            Console.WriteLine("b.Добавьте свойство Gender - перечисление(enum) с двумя значениями");
            Console.WriteLine("c.Добавьте в класс метод для приветствия.");
            Console.WriteLine("d.Добавьте в класс статическое свойство - счётчик созданных людей.");
            Console.WriteLine("Свойство должно быть доступно только для чтения.");
            Console.WriteLine("\r\nПротестируем наш класс");
            Console.WriteLine("");
            Person personClass1 = new Person();
            personClass1.HelloPeople();
            personClass1.FirstName = "Daniil";
            personClass1.LastName = "Lukashin";
            personClass1.Age = 21;
            personClass1.Gender = Person.GenderStyle.Man;

            Person personClass2 = new Person();
            personClass2.FirstName = "Daniil";
            personClass2.LastName = "Lukashin";
            personClass2.Age = 21;
            personClass2.Gender = Person.GenderStyle.Man;
            Console.WriteLine("Создано " + Person.NumberOfPeople + " человек");

            Console.WriteLine("\r\nЗаписи успешно записаны) Нажмите Enter, чтобы вернуться к списку заданий");
            Console.ReadLine();
        }
        /// <summary>
        /// Задание 25
        /// </summary>
        static private void Exe25()
        {
            Console.Clear();
            Console.WriteLine("25. Создайте класс Animal.Добавьте в него свойства, соответствующие атрибутам");
            Console.WriteLine("животных(кличка, голос, предпочитаемая еда и тд).Создайте несколько");
            Console.WriteLine("экземпляров класса Animal, соответствующие разным животным.");
            Console.WriteLine("a.Добавьте в класс Animal конструктор с параметрами, которые соответствуют");
            Console.WriteLine("созданным свойствам.");
            Console.WriteLine("b.Сделайте все свойства только для чтения.");


            Console.WriteLine("\r\nПротестируем наш класс");
            Console.WriteLine("");

            Animals animalCat = new Animals("Кошачьи","Кот","Сёма",3,"сухой корм");
            Animals animalDog = new Animals("Псовык", "Собака", "Рекс",2,"мясо");
            Animals animalAnt = new Animals("Насекомые","Муравей", "Кроха", 3,"мясо");

            Console.WriteLine("Данные вида: Семейство, Вид, Кличка, Возраст, Предпочитаемая еда");
            Console.WriteLine("Запись (" + animalCat.Family + ", " + animalCat.TypeAnimal + ", " + animalCat.Name + ", " + animalCat.Age + ", " + animalCat.PreferredFood + ") успешно создана!");
            Console.WriteLine("Запись (" + animalDog.Family + ", " + animalDog.TypeAnimal + ", " + animalDog.Name + ", " + animalDog.Age + ", " + animalDog.PreferredFood + ") успешно создана!");
            Console.WriteLine("Запись (" + animalAnt.Family + ", " + animalAnt.TypeAnimal + ", " + animalAnt.Name + ", " + animalAnt.Age + ", " + animalAnt.PreferredFood + ") успешно создана!");

            Console.WriteLine("\r\nНажмите Enter, чтобы вернуться к списку заданий");
            Console.ReadLine();
        }

        #endregion


    }
}
