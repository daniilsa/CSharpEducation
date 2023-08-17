using Entities.File;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Entities.DataBase
{
  /// <summary>
  /// Данные для работы с файлом.
  /// </summary>
  public static class WorkingWithDataBase
  {
    /// <summary>
    /// Список абонентов.
    /// </summary>
    public static List<WorkingWithData> data = new List<WorkingWithData>();

    /// <summary>
    /// Считывание данных из файла и создание списка по считанным данным.
    /// </summary>
    public static void ReadData()
    {
      data.Clear();
      string connect = "Provider=Microsoft.ACE.Oledb.12.0;Data Source=PhoneBook.mdb";
      OleDbConnection dbConnection = new OleDbConnection(connect);

      dbConnection.Open();
      string query = "SELECT * FROM Data_Base";
      OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
      OleDbDataReader dbReader = dbCommand.ExecuteReader();

      if (dbReader.HasRows)
      {
        while (dbReader.Read())
        {
          WorkingWithData workingWithData = new WorkingWithData();
          workingWithData.ID = dbReader[0].ToString();
          workingWithData.Name = dbReader[1].ToString();
          workingWithData.Phone = dbReader[2].ToString();
          data.Add(workingWithData);
        }
      }
      dbReader.Close();
      dbConnection.Close();
    }

    /// <summary>
    /// Создаёт новый список абонентов, удаляя старый.
    /// </summary>
    public static void Create()
    {
      new WorkingWithData().Create(new WorkingWithData());
    }

    /// <summary>
    /// Вывод данных об абонентах на экран.
    /// </summary>
    public static void Read()
    {
      new WorkingWithData().Read(new WorkingWithData());
    }

    /// <summary>
    /// Добавить абоненета.
    /// </summary>
    public static void Update()
    {
      new WorkingWithData().Update(new WorkingWithData());
    }

    /// <summary>
    /// Удалить абонента.
    /// </summary>
    public static void Delete()
    {
      new WorkingWithData().Delete(new WorkingWithData());
    }
  }
}
