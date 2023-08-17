using Entities.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.File
{
  /// <summary>
  /// Данные для работы с файлом.
  /// </summary>
  public static class WorkingWithFileBase
  {
    /// <summary>
    /// Список абонентов.
    /// </summary>
    public static List<WorkingWithFile> data = new List<WorkingWithFile>();

    /// <summary>
    /// Считывание данных из файла и создание списка по считанным данным.
    /// </summary>
    public static void ReadData()
    {
      string[] temporary = System.IO.File.ReadAllLines(@"PhoneBook");
      foreach (string line in temporary)
      {
        string name;
        string phone;

        int indexFirst = line.IndexOf('$') + 1;
        int indexLast = line.IndexOf('$', indexFirst);
        name = line.Substring(indexFirst, indexLast - indexFirst);

        indexFirst = line.IndexOf('$', indexLast) + 1;
        indexLast = line.IndexOf('$', indexFirst);
        phone = line.Substring(indexFirst, indexLast - indexFirst);

        WorkingWithFile workingWithFile = new WorkingWithFile();
        workingWithFile.Name = name;
        workingWithFile.Phone = phone;

        data.Add(workingWithFile);
      }
    }

    /// <summary>
    /// Создаёт новый список абонентов, удаляя старый.
    /// </summary>
    public static void Create()
    {
      new WorkingWithFile().Create(new WorkingWithFile());
    }

    /// <summary>
    /// Вывод данных об абонентах на экран.
    /// </summary>
    public static void Read()
    {
      new WorkingWithFile().Read(new WorkingWithFile());
    }

    /// <summary>
    /// Добавить абоненета.
    /// </summary>
    public static void Update()
    {
      new WorkingWithFile().Update(new WorkingWithFile());
    }

    /// <summary>
    /// Удалить абонента.
    /// </summary>
    public static void Delete()
    {
      new WorkingWithFile().Delete(new WorkingWithFile());
    }

  
  }
}
