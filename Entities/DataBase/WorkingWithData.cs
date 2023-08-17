using Entities.File;
using Entities.Interfaces;
using System.Data.OleDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Data.Common;

namespace Entities.DataBase
{
  public class WorkingWithData : IEntity<WorkingWithData>
  {
    /// <summary>
    /// Задаёт или возвращает порядковый номер абонента.
    /// </summary>
    public string? ID { get; set; }

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
    /// <param name="entity">Экзкмпляр класса WorkingWithFile.</param>
    public void Create(WorkingWithData entity)
    {
      string deleteStr = $"Delete From Data_Base";
      string connect = "Provider=Microsoft.ACE.Oledb.12.0;Data Source=PhoneBook.mdb";
      OleDbConnection dbConnection = new OleDbConnection(connect);
      OleDbCommand dbCommand = new OleDbCommand(deleteStr, dbConnection);

      dbConnection.Open();
      dbCommand.ExecuteNonQuery();
      dbConnection.Close();

      Console.WriteLine("Список успешно создан! Нажмите Enter для продолжения!");
      Console.ReadLine();
    }

    /// <summary>
    /// Вывод данных об абонентах на экран.
    /// </summary>
    /// <param name="entity">Экзкмпляр класса WorkingWithFile.</param>
    public void Read(WorkingWithData entity)
    {
      WorkingWithDataBase.ReadData();

      if (WorkingWithDataBase.data.Count == 0)
      {
        Console.WriteLine("Список пуст(");
      }
      for (int i = 0; i < WorkingWithDataBase.data.Count; i++)
      {
        Console.WriteLine($"{WorkingWithDataBase.data[i].Name} {WorkingWithDataBase.data[i].Phone}");
      }

      Console.WriteLine("Нажмите Enter для продолжения!");
      Console.ReadLine();
    }

    /// <summary>
    /// Добавить абонента.
    /// </summary>
    /// <param name="entity">Экзкмпляр класса WorkingWithFile.</param>
    public void Update(WorkingWithData entity)
    {
      Console.Write("Введите имя: ");
      entity.Name = Console.ReadLine();
      Console.Write("Введите телефон: ");
      entity.Phone = Console.ReadLine();

      string connect = "Provider=Microsoft.ACE.Oledb.12.0;Data Source=PhoneBook.mdb";
      OleDbConnection dbConnection = new OleDbConnection(connect);

      string addStr = "Insert into Data_Base (UserName, UserPhone) values (@UserName,@UserPhone)";
      OleDbCommand dbCommand = new OleDbCommand(addStr, dbConnection);

      dbCommand.Parameters.AddWithValue("@UserName", entity.Name);
      dbCommand.Parameters.AddWithValue("@UserPhone", entity.Phone);

      dbConnection.Open();
      dbCommand.ExecuteNonQuery();
      dbConnection.Close();
      WorkingWithDataBase.ReadData();

      Console.WriteLine("Запись успешно добавлена! Нажмите Enter для продолжения!");
      Console.ReadLine();
    }

    /// <summary>
    /// Удалить абонента.
    /// </summary>
    /// <param name="entity">Экзкмпляр класса WorkingWithFile.</param>
    public void Delete(WorkingWithData entity)
    {
      WorkingWithDataBase.ReadData();
      bool delete = false;
      Console.Write("Введите телефон: ");
      entity.Phone = Console.ReadLine();
      for (int i = 0; i < WorkingWithDataBase.data.Count; i++)
      {
        if (WorkingWithDataBase.data[i].Phone == entity.Phone)
        {
          delete = true;

          string connect = "Provider=Microsoft.ACE.Oledb.12.0;Data Source=PhoneBook.mdb";
          string deleteStr = $"Delete From Data_Base Where id= {WorkingWithDataBase.data[i].ID}";

          OleDbConnection dbConnection = new OleDbConnection(connect);
          OleDbCommand dbCommand = new OleDbCommand(deleteStr, dbConnection);

          dbConnection.Open();
          dbCommand.ExecuteNonQuery();
          dbConnection.Close();

          WorkingWithDataBase.ReadData();
          Console.WriteLine("Запись успешно удалена! Нажмите Enter для продолжения!");
          break;
        }
      }
      if (!delete) Console.WriteLine("Запись не найдена! Нажмите Enter для продолжения!");
      Console.ReadLine();
    }
  }
}
