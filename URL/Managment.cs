using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URL
{
  /// <summary>
  /// Взоимодействия с пользователем.
  /// </summary>
  internal class Managment
  {
    /// <summary>
    /// Ввод основных данных.
    /// </summary>
    public void Start()
    {
      string url = SetUrl();
      string pathFile = SetPathFile();
      string nameFile = SetNameFile();
      string expansionFile = url.Substring(url.LastIndexOf('.'), url.Length - (url.LastIndexOf('.')));
      Console.WriteLine($"Расширение файла: {expansionFile}");

      nameFile += expansionFile;

      Thread thread = new Thread(() => new DonloadFile().StartDownload(url, nameFile, pathFile));
      thread.Start();
      thread.Join();
    }

    /// <summary>
    /// Ввод URL файла.
    /// </summary>
    /// <returns></returns>
    private string SetUrl()
    {
      bool exit = false;
      string url = null;
      do
      {
        Console.Write("Введите URL файла: ");
        url = Console.ReadLine();
        if (url == null || url.Length == 0)
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("URL файла не может быть пустым!");
          Console.ForegroundColor = ConsoleColor.White;
          SetUrl();
          return url;
        }
        else
        {
          exit = true;
        }

      } while (!exit);

      return url;
    }

    /// <summary>
    /// Ввод пути сохранения файла.
    /// </summary>
    /// <returns></returns>
    private string SetPathFile()
    {
      bool exit = false;
      string pathFile = null;
      do
      {
        Console.Write("Выберите путь сохранения: ");
        pathFile = Console.ReadLine();
        if (pathFile == null || pathFile.Length == 0)
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("Путь сохранения файла не может быть пустым!");
          Console.ForegroundColor = ConsoleColor.White;
          SetPathFile();
          return pathFile;
        }
        else if (!Directory.Exists(pathFile))
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("Указанный путь не существует!");
          Console.ForegroundColor = ConsoleColor.White;
          SetPathFile();
          return pathFile;
        }
        else
        {
          exit = true;
        }
      } while (!exit);

      return pathFile;
    }

    /// <summary>
    /// Ввод имени файла.
    /// </summary>
    /// <returns></returns>
    private string SetNameFile()
    {
      bool exit = false;
      string nameFile = null;
      do
      {
        Console.Write("Введите имя файла: ");
        nameFile = Console.ReadLine();
        if (nameFile == null || nameFile.Length == 0)
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("Имя файла не может быть пустым!");
          Console.ForegroundColor = ConsoleColor.White;
          SetNameFile();
          return nameFile;
        }
        else
        {
          exit = true;
        }
      } while (!exit);

      return nameFile;
    }
  }
}
