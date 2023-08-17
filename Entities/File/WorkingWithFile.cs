using Entities.Interfaces;
using Entities.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.File
{
  /// <summary>
  /// Реализация работы с данными из файла.
  /// </summary>
  public class WorkingWithFile : IEntity<WorkingWithFile>
  {
    /// <summary>
    /// Задаёт или возвращает имя абонента.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Задаёт или возвращает телефон абонента.
    /// </summary>
    public string? Phone { get; set; }

    /// <summary>
    /// Создаёт новый список абонентов, удаляя старый.
    /// </summary>
    /// <param name="entity">Экзкмпляр класса WorkingWithFile</param>
    public void Create(WorkingWithFile entity)
    {
      System.IO.File.Create(@"PhoneBook");
      WorkingWithFileBase.data.Clear();

      Console.WriteLine("Список успешно создан! Нажмите Enter для продолжения!");
      Console.ReadLine();
    }

    /// <summary>
    /// Вывод данных об абонентах на экран.
    /// </summary>
    /// <param name="entity">Экзкмпляр класса WorkingWithFile</param>
    public void Read(WorkingWithFile entity)
    {
      if (WorkingWithFileBase.data.Count == 0)
      {
        Console.WriteLine("Список пуст(");
      }
      for (int i = 0; i < WorkingWithFileBase.data.Count; i++)
      {
        Console.WriteLine($"{WorkingWithFileBase.data[i].Name} {WorkingWithFileBase.data[i].Phone}");
      }
      Console.WriteLine("Нажмите Enter для продолжения!");
      Console.ReadLine();
    }

    /// <summary>
    /// Добавить абонента.
    /// </summary>
    /// <param name="entity">Экзкмпляр класса WorkingWithFile</param>
    public void Update(WorkingWithFile entity)
    {
      Console.Write("Введите имя: ");
      entity.Name = Console.ReadLine();
      Console.Write("Введите телефон: ");
      entity.Phone = Console.ReadLine();
      WorkingWithFileBase.data.Add(entity);

      OverwriteFile();

      Console.WriteLine("Запись успешно добавлена! Нажмите Enter для продолжения!");
      Console.ReadLine();
    }

    /// <summary>
    /// Удалить абонента.
    /// </summary>
    /// <param name="entity">Экзкмпляр класса WorkingWithFile</param>
    public void Delete(WorkingWithFile entity)
    {
      bool delete = false;
      Console.Write("Введите телефон: ");
      entity.Phone = Console.ReadLine();
      for (int i = 0; i < WorkingWithFileBase.data.Count; i++)
      {
        if (WorkingWithFileBase.data[i].Phone == entity.Phone)
        {
          delete = true;
          WorkingWithFileBase.data.Remove(WorkingWithFileBase.data[i]);
          OverwriteFile();
          Console.WriteLine("Запись успешно удалена33! Нажмите Enter для продолжения!");
          Console.ReadLine();
        }
      }
      if (!delete) Console.WriteLine("Запись не найдена! Нажмите Enter для продолжения!");
      Console.ReadLine();
    }

    /// <summary>
    /// Перезапись файла.
    /// </summary>
    private void OverwriteFile()
    {
      string[] temporary = new string[WorkingWithFileBase.data.Count];
      for (int i = 0; i < WorkingWithFileBase.data.Count; i++)
      {
        temporary[i] = "$" + WorkingWithFileBase.data[i].Name + "$" + WorkingWithFileBase.data[i].Phone + "$";
      }
      System.IO.File.WriteAllLines(@"PhoneBook", temporary);
    }
  }
}
