using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Interfaces;

namespace Entities.Memory
{
  /// <summary>
  /// Реализация работы с данными из памяти.
  /// </summary>
  public class WorkingWithMemory : IEntity<WorkingWithMemory>
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
    /// <param name="entity">Экзкмпляр класса WorkingWithMemory</param>
    public void Create(WorkingWithMemory entity)
    {
      WorkingWithMemoryBase.data = new List<WorkingWithMemory>();
      Console.WriteLine("Список успешно создан! Нажмите Enter для продолжения!");
      Console.ReadLine();
    }

    /// <summary>
    /// Вывод данных об абонентах на экран.
    /// </summary>
    /// <param name="entity">Экзкмпляр класса WorkingWithMemory</param>
    public void Read(WorkingWithMemory entity)
    {
      if (WorkingWithMemoryBase.data.Count == 0)
      {
        Console.WriteLine("Список пуст(");
      }
      for (int i = 0; i < WorkingWithMemoryBase.data.Count; i++)
      {
        Console.WriteLine($"{WorkingWithMemoryBase.data[i].Name} {WorkingWithMemoryBase.data[i].Phone}");
      }
      Console.WriteLine("Нажмите Enter для продолжения!");
      Console.ReadLine();
    }

    /// <summary>
    /// Добавить абонента.
    /// </summary>
    /// <param name="entity">Экзкмпляр класса WorkingWithMemory</param>
    public void Update(WorkingWithMemory entity)
    {
      Console.Write("Введите имя: ");
      entity.Name = Console.ReadLine();
      Console.Write("Введите телефон: ");
      entity.Phone = Console.ReadLine();
      WorkingWithMemoryBase.data.Add(entity);
      Console.WriteLine("Запись успешно добавлена! Нажмите Enter для продолжения!");
      Console.ReadLine();
    }

    /// <summary>
    /// Удалить абонента.
    /// </summary>
    /// <param name="entity">Экзкмпляр класса WorkingWithMemory</param>
    public void Delete(WorkingWithMemory entity)
    {
      bool delete = false;
      Console.Write("Введите телефон: ");
      entity.Phone = Console.ReadLine();
      for (int i = 0; i < WorkingWithMemoryBase.data.Count; i++)
      {
        if (WorkingWithMemoryBase.data[i].Phone == entity.Phone)
        {
          delete = true;
          WorkingWithMemoryBase.data.Remove(WorkingWithMemoryBase.data[i]);
          Console.WriteLine("Запись успешно удалена. Нажмите Enter для продолжения!");
          Console.ReadLine();
        }
      }
      if (!delete) Console.WriteLine("Запись не найдена! Нажмите Enter для продолжения!");
      Console.ReadLine();
    }
  }
}
