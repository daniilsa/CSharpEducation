using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    /// <summary>
    /// Работы с данными
    /// </summary>
    static public class WorkingWithData
    {
        static public string[] abononets = null;

        /// <summary>
        /// Считывание данных из файла
        /// </summary>
        static WorkingWithData()
        {
            abononets = File.ReadAllLines(@"phonebook.txt");
        }
        /// <summary>
        /// Запись нового абонента в базу
        /// </summary>
        /// <param name="name">Имя абонента</param>
        /// <param name="phone">Номер абонента</param>
        static public void NewSubscriber(string name, string phone)
        {
            bool error = false;
            for (int i = 0; i < name.Length; i++)
            {
                if (Char.IsDigit(name[i]))
                {
                    goto errorDataName;
                }
            }
            for (int i = 0; i < phone.Length; i++)
            {
                if (Char.IsLetter(phone[i]))
                {
                    goto errorDataPhone;
                }
            }
            string temporayString = name + "$" + phone;
            Array.Resize(ref WorkingWithData.abononets, WorkingWithData.abononets.Length + 1);
            WorkingWithData.abononets[WorkingWithData.abononets.Length - 1] = temporayString;
            File.WriteAllLines("phonebook.txt", WorkingWithData.abononets);
            Console.WriteLine("Пользователь успешно создан. Нажмите Enter для продолжения");
            Console.ReadKey();
            return;

            errorDataName:
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Ошибка! ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Имя не может содержать цифр!");
                Console.WriteLine("Нажмите Enter для продолжения");
                Console.ReadKey();
                return;
            }
            errorDataPhone:
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Ошибка! ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Телефон не может содержать букв!");
                Console.WriteLine("Нажмите Enter для продолжения");
                Console.ReadKey();
                return;
            }
        }
        /// <summary>
        /// Удаление абонента из базы
        /// </summary>
        /// <param name="name">Имя абонента</param>
        /// <param name="phone">Номер абонента</param>
        static public void DeleteSubscriber(string phone)
        {
            int index = 0;
            string deleteString = null;
            bool search = false;
            for (; index < WorkingWithData.abononets.Length; index++)
            {
                if (WorkingWithData.abononets[index].IndexOf(phone) > -1)
                {
                    for (int i = 0; i < WorkingWithData.abononets[index].Length; i++)
                    {
                        if (WorkingWithData.abononets[index][i] == '$') Console.Write(' ');
                        else Console.Write(WorkingWithData.abononets[index][i]);
                    }
                    Console.Write("\r\nЕсли эта нужная вам запись, то введите номер тефона ещё раз для удаления записи (для поиска следующей записи нажмите Enter): ");
                    deleteString = Console.ReadLine();
                    if (deleteString == phone)
                    {
                        search = true;
                        string[] temporaryList = new string[WorkingWithData.abononets.Length - 1];
                        int j = 0;
                        for (int i = 0; i < WorkingWithData.abononets.Length; i++)
                        {
                            if (WorkingWithData.abononets[i] != WorkingWithData.abononets[index])
                            {
                                temporaryList[j] = WorkingWithData.abononets[i];
                                j++;
                            }
                        }
                        Array.Resize(ref WorkingWithData.abononets, WorkingWithData.abononets.Length - 1);
                        WorkingWithData.abononets = temporaryList;
                        File.WriteAllLines("phonebook.txt", WorkingWithData.abononets);
                        Console.Write("Запись успешно удалена. Нажмите Enter для продолжения...");
                        return;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Подтвержение не пройдено! Ищем другую запись\r\n");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }
            if (!search)
            {
                Console.Write("Запись с номером: " + phone + " не найдена");
                return;
            }
        }
        /// <summary>
        /// Поиск записи по имени
        /// </summary>
        /// <param name="name"></param>
        static public void SearchName(string name)
        {
            int index = 0;
            bool search = false;
            if (Char.IsLetter(name[0]))
            {
                for (; index < WorkingWithData.abononets.Length; index++)
                {
                    if (WorkingWithData.abononets[index].IndexOf(name) > -1)
                    {
                        search = true;
                        for (int i = 0; i < WorkingWithData.abononets[index].Length; i++)
                        {
                            if (WorkingWithData.abononets[index][i] == '$') Console.Write(' ');
                            else Console.Write(WorkingWithData.abononets[index][i]);
                        }
                        Console.WriteLine("");
                    }
                }
                if (!search)
                {
                    Console.Write("Запись с именем: " + name + " не найдена");
                }
            }
            else
            {
                Console.Write("Похоже вы ввели номер телефона, а это другая функция.");

            }
            Console.WriteLine("\r\nНажмите Enter для продолжения...");
            Console.ReadLine();
        }
        /// <summary>
        /// Поиск записи по номеру телефона
        /// </summary>
        /// <param name="phone"></param>
        static public void SearchPhone(string phone)
        {
            int index = 0;
            bool search = false;
            if (Char.IsDigit(phone[0]))
            {
                for (; index < WorkingWithData.abononets.Length; index++)
                {
                    if (WorkingWithData.abononets[index].IndexOf(phone) > -1)
                    {
                        search = true;
                        for (int i = 0; i < WorkingWithData.abononets[index].Length; i++)
                        {
                            if (WorkingWithData.abononets[index][i] == '$') Console.Write(' ');
                            else Console.Write(WorkingWithData.abononets[index][i]);
                        }
                        Console.WriteLine("");
                    }
                }
                if (!search)
                {
                    Console.Write("Запись с именем: " + phone + " не найдена");
                }
            }
            else
            {
                Console.Write("Похоже вы ввели имя, а это другая функция.");

            }
            Console.WriteLine("\r\nНажмите Enter для продолжения...");
            Console.ReadLine();
        }
    }
}
