using Entities.DataBase;
using Entities.File;
using Entities.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
  /// <summary>
  /// Панель управления.
  /// </summary>
  public class Managment
  {
    /// <summary>
    /// Воводит в консоль список разделов.
    /// </summary>
    private void ListFunction()
    {
      Console.Clear();
      Console.WriteLine("1. Работа с памятью");
      Console.WriteLine("2. Работа с файлом");
      Console.WriteLine("3. Работа с БД");
      Console.WriteLine("0. Выход");
    }

    /// <summary>
    /// Выводит в консоль список функций работы со стэком сущностей.
    /// </summary>
    private void CRUD()
    {
      Console.Clear();
      Console.WriteLine("1. Создать новый список");
      Console.WriteLine("2. Вывести список в консоль");
      Console.WriteLine("3. Добавить запись в список");
      Console.WriteLine("4. Удалить запись из списка");
      Console.WriteLine("0. Выход");
    }

    /// <summary>
    /// Запуск программы и выбор раздела.
    /// </summary>
    public void Start()
    {
      bool startProgramm = true;
      do
      {
        ListFunction();
        Console.Write("Введите номер раздела: ");
        int number = 0;
        try
        {
          number = Convert.ToInt32(Console.ReadLine());
          switch (number)
          {
            case 0: { startProgramm = false; break; }
            case 1: { ManagmentMemory(); break; }
            case 2: { ManagmentFile(); break; }
            case 3: { ManagmentDB(); break; }
          }
        }
        catch
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.Write("Ошибка! ");

          Console.ForegroundColor = ConsoleColor.White;
          Console.WriteLine("Чтобы начать заново, введите Y, иначе введите что хотите))");

          if (Console.ReadLine() == "Y")
          {
            Start();
            return;
          }
          else
          {
            startProgramm = false;
          }
        }
      } while (startProgramm);
    }

    /// <summary>
    /// Работа с памятью.
    /// </summary>
    private void ManagmentMemory()
    {
      bool start = true;
      do
      {
        CRUD();
        Console.Write("Введите номер раздела: ");
        int number = 0;
        try
        {
          number = Convert.ToInt32(Console.ReadLine());
          switch (number)
          {
            case 0: { start = false; break; }
            case 1: { WorkingWithMemoryBase.Create(); break; }
            case 2: { WorkingWithMemoryBase.Read(); break; }
            case 3: { WorkingWithMemoryBase.Update(); break; }
            case 4: { WorkingWithMemoryBase.Delete(); break; }

          }
        }
        catch
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.Write("Ошибка! ");
          Console.ForegroundColor = ConsoleColor.White;
          Console.WriteLine("Чтобы начать заново, введите Y, иначе введите что хотите))");
          if (Console.ReadLine() == "Y")
          {
            ManagmentMemory();
            return;
          }
          else
          {
            start = false;
          }
        }
      } while (start);


    }

    /// <summary>
    /// Работа с памятью.
    /// </summary>
    private void ManagmentFile()
    {
      WorkingWithFileBase.ReadData();
      bool start = true;
      do
      {
        CRUD();
        Console.Write("Введите номер раздела: ");
        int number = 0;
        try
        {
          number = Convert.ToInt32(Console.ReadLine());
          switch (number)
          {
            case 0: { start = false; break; }
            case 1: { WorkingWithFileBase.Create(); break; }
            case 2: { WorkingWithFileBase.Read(); break; }
            case 3: { WorkingWithFileBase.Update(); break; }
            case 4: { WorkingWithFileBase.Delete(); break; }

          }
        }
        catch
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.Write("Ошибка! ");
          Console.ForegroundColor = ConsoleColor.White;
          Console.WriteLine("Чтобы начать заново, введите Y, иначе введите что хотите))");
          if (Console.ReadLine() == "Y")
          {
            ManagmentMemory();
            return;
          }
          else
          {
            start = false;
          }
        }
      } while (start);

    }

    /// <summary>
    /// Работа с памятью.
    /// </summary>
    private void ManagmentDB()
    {
      WorkingWithFileBase.ReadData();
      bool start = true;
      do
      {
        CRUD();
        Console.Write("Введите номер раздела: ");
        int number = 0;
        try
        {
          number = Convert.ToInt32(Console.ReadLine());
          switch (number)
          {
            case 0: { start = false; break; }
            case 1: { WorkingWithDataBase.Create(); break; }
            case 2: { WorkingWithDataBase.Read(); break; }
            case 3: { WorkingWithDataBase.Update(); break; }
            case 4: { WorkingWithDataBase.Delete(); break; }

          }
        }
        catch
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.Write("Ошибка! ");
          Console.ForegroundColor = ConsoleColor.White;
          Console.WriteLine("Чтобы начать заново, введите Y, иначе введите что хотите))");
          if (Console.ReadLine() == "Y")
          {
            ManagmentMemory();
            return;
          }
          else
          {
            start = false;
          }
        }
      } while (start);

    }
  }
}
