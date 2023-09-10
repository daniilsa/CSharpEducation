using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
  /// <summary>
  /// "Панель управления". Предназаечно для выбора и отработки функций программы.
  /// </summary>
  public class ControlPoint
  {
    private readonly WorkingWithUsersData workingWithUsersData = new WorkingWithUsersData();

    /// <summary>
    /// Список функций.
    /// </summary>
    private void ListActions()
    {
      Console.WriteLine("1. Добавить новую запись");
      Console.WriteLine("2. Удалить запись");
      Console.WriteLine("3. Поиск по имени");
      Console.WriteLine("4. Поиск по телефону");
      Console.WriteLine("0. Выход");
    }
    /// <summary>
    /// Выбор функции.
    /// </summary>
    public void CallingActions()
    {
     
      do
      {
        Console.Clear();
        ListActions();
        Console.Write("Выберите действие:");
        int i;
        try
        {
          i = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
          Console.Clear();
          Console.ForegroundColor = ConsoleColor.Red;
          Console.Write("Некорректный ввод данных!");
          Console.ForegroundColor = ConsoleColor.White;
          Console.WriteLine("Попробуйте снова");
          CallingActions();
          return;
        }
        switch (i)
        {
          case 1:
            {
              NewSubscriber();
              break;
            }
          case 2:
            {
              DeleteSubscriber();
              break;
            }
          case 3:
            {
              SearchName();
              break;
            }
          case 4:
            {
              SearchPhone();
              break;
            }
          case 0: return;
          default:
            {
              Console.Clear();
              Console.ForegroundColor = ConsoleColor.Red;
              Console.Write("Некорректный ввод данных!");
              Console.ForegroundColor = ConsoleColor.White;
              Console.WriteLine("Попробуйте снова");
              CallingActions();
              return;
            }
        }
      }
      while (true);
    }
    /// <summary>
    /// Запись нового пользователя.
    /// </summary>
    public void NewSubscriber()
    {
      Console.Write("Введите имя: ");
      string name = Console.ReadLine();

      string phone;
      do
      {
        Console.Write("Введите номер: ");
        phone = Console.ReadLine();

        if (phone != string.Empty)
        {
          if (name != string.Empty)
          {
            Abonent abonent = new Abonent(name, phone);
            workingWithUsersData.CreateNewSubscriber(abonent.Name, abonent.Phone);
          }
          else
          {
            Abonent abonent = new Abonent(name, phone);
            workingWithUsersData.CreateNewSubscriber(abonent.Name, abonent.Phone);
          }
          break;
        }
        else
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("Поле телефон не может быть пустым!");
          Console.ForegroundColor = ConsoleColor.White;
        }
      }
      while (true);
    }
    /// <summary>
    /// Удаление пользователя.
    /// </summary>
    public void DeleteSubscriber()
    {
      Console.ForegroundColor = ConsoleColor.Green;
      Console.Write("ВНИМАНИЕ! ");
      Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine("Корректно указывайте номер телефона, иначе можете удалить другую запись!");
      string phone;
      do
      {
        Console.Write("Введите номер: ");
        phone = Console.ReadLine();

        if (phone != string.Empty)
        {
          workingWithUsersData.DeleteSubscriber(phone);
          break;
        }
        else
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("Поле телефон не может быть пустым!");
          Console.ForegroundColor = ConsoleColor.White;
        }
      }
      while (true);

      Console.ReadKey();
    }
    /// <summary>
    /// Поиск записи по имени.
    /// </summary>
    public void SearchName()
    {
      Console.Write("Введите имя: ");
      string name = Console.ReadLine();
      workingWithUsersData.SearchName(name);

    }
    /// <summary>
    /// Поиск записи по номеру телефона.
    /// </summary>
    public void SearchPhone()
    {
      Console.Write("Введите номер телефона: ");
      string phone = Console.ReadLine();
      workingWithUsersData.SearchPhone(phone);
    }
  }
}
