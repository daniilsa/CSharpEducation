using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace URL
{
  /// <summary>
  /// Скачка с файла по URL.
  /// </summary>
  internal class DonloadFile
  {
    /// <summary>
    /// Открывает ссылку с файлом и скачаивает её в указанное место.
    /// </summary>
    /// <param name="url">"Интернет" путь к файлу.</param>
    /// <param name="nameFile">Имя файла.</param>
    /// <param name="pathFile">Путь сохранения файла.</param>
    public void StartDownload(string url, string nameFile,string pathFile)
    {
      try
      {
        WebClient request = new WebClient();
        request.DownloadFile(url, nameFile);
        File.Move(nameFile, pathFile+ "\\"+nameFile);

        Console.Write("Файл успешно ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("скачан ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("на ваш компьютер!");
      }
      catch
      {
        Console.ForegroundColor= ConsoleColor.Red;
        Console.Write("Ошибка! ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Проверьте соединение с инетрнетом и повторите попытку!");
      }
    }
  }
}
