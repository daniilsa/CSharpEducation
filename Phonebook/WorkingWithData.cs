using Microsoft.Azure.Amqp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
  /// <summary>
  /// Считывание и изменения данных.
  /// </summary>
  public sealed class WorkingWithUsersData
  {
    /// <summary>
    /// База абонентов.
    /// </summary>
    public string[] abononets = null;

    /// <summary>
    /// Экземпляр данного класса.
    /// </summary>
    private static WorkingWithUsersData workingWithUsersData;

    /// <summary>
    /// Создаёт единый экземпляр класса для всей программы.
    /// </summary>
    /// <returns></returns>
    public static WorkingWithUsersData GetInstance
    {
      get { return workingWithUsersData; }
      private set { workingWithUsersData = new WorkingWithUsersData(); } 
    }

    /// <summary>
    /// Считывание данных из файла.
    /// </summary>
    public WorkingWithUsersData()
    {
      abononets = File.ReadAllLines(@"phonebook.txt");
    }

    /// <summary>
    /// Запись нового абонента в базу.
    /// </summary>
    /// <param name="name">Имя абонента</param>
    /// <param name="phone">Номер абонента</param>
    public void CreateNewSubscriber(string name, string phone)
    {
      for (int i = 0; i < name.Length; i++)
      {
        if (Char.IsDigit(name[i]))
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.Write("Ошибка! ");
          Console.ForegroundColor = ConsoleColor.White;
          Console.WriteLine("Имя не может содержать цифр!");
          Console.WriteLine("Нажмите Enter для продолжения");
          Console.ReadKey();
          return;
        }
      }
      for (int i = 0; i < phone.Length; i++)
      {
        if (Char.IsLetter(phone[i]))
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
      string temporayString = name + "$" + phone;
      Array.Resize(ref this.abononets, this.abononets.Length + 1);
      this.abononets[this.abononets.Length - 1] = temporayString;
      File.WriteAllLines("phonebook.txt", this.abononets);
      Console.WriteLine("Пользователь успешно создан. Нажмите Enter для продолжения");
      Console.ReadKey();
      return;
    }

    /// <summary>
    /// Удаление абонента из базы.
    /// </summary>
    /// <param name="name">Имя абонента</param>
    /// <param name="phone">Номер абонента</param>
    public void DeleteSubscriber(string phone)
    {
      int index = 0;
      string deleteString;
      for (; index < this.abononets.Length; index++)
      {
        if (this.abononets[index].IndexOf(phone) > -1)
        {
          for (int i = 0; i < this.abononets[index].Length; i++)
          {
            if (this.abononets[index][i] == '$') Console.Write(' ');
            else Console.Write(this.abononets[index][i]);
          }
          Console.Write("\r\nЕсли эта нужная вам запись, то введите номер тефона ещё раз для удаления записи (для поиска следующей записи нажмите Enter): ");
          deleteString = Console.ReadLine();
          if (deleteString == phone)
          {
            string[] temporaryList = new string[this.abononets.Length - 1];
            int j = 0;
            for (int i = 0; i < this.abononets.Length; i++)
            {
              if (this.abononets[i] != this.abononets[index])
              {
                temporaryList[j] = this.abononets[i];
                j++;
              }
            }
            Array.Resize(ref this.abononets, this.abononets.Length - 1);
            this.abononets = temporaryList;
            File.WriteAllLines("phonebook.txt", this.abononets);
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
      Console.Write("Запись с номером: " + phone + " не найдена");
      return;
    }

    /// <summary>
    /// Поиск записи по имени.
    /// </summary>
    /// <param name="name"></param>
    public void SearchName(string name)
    {
      int index = 0;
      bool search = false;
      if (Char.IsLetter(name[0]))
      {
        for (; index < this.abononets.Length; index++)
        {
          if (this.abononets[index].IndexOf(name) > -1)
          {
            search = true;
            for (int i = 0; i < this.abononets[index].Length; i++)
            {
              if (this.abononets[index][i] == '$') Console.Write(' ');
              else Console.Write(this.abononets[index][i]);
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
    /// Поиск записи по номеру телефона.
    /// </summary>
    /// <param name="phone"></param>
    public void SearchPhone(string phone)
    {
      int index = 0;
      bool search = false;
      if (Char.IsDigit(phone[0]))
      {
        for (; index < this.abononets.Length; index++)
        {
          if (this.abononets[index].IndexOf(phone) > -1)
          {
            search = true;
            for (int i = 0; i < this.abononets[index].Length; i++)
            {
              if (this.abononets[index][i] == '$') Console.Write(' ');
              else Console.Write(this.abononets[index][i]);
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
