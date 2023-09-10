using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
  /// <summary>
  /// Обработка игры.
  /// </summary>
  internal class Game
  {
    #region Константы

    /// <summary>
    ///  X - Ход со стороны крестиков.
    /// </summary>
    private const char CrossMove = 'X';

    /// <summary>
    ///  O - Ход со стороны ноликов.
    /// </summary>
    private const char ZeroMove = 'O';

    /// <summary>
    ///  W(winning) - Победа одной из сторон.
    /// </summary>
    private const char Winning = 'W';

    /// <summary>
    ///  D(draw) - Ничья.
    /// </summary>
    private const char Draw = 'D';

    /// <summary>
    ///  F(false) - На данный момент никто не победил.
    /// </summary>
    private const char Resume = 'R';

    #endregion

    #region Поля

    /// <summary>
    /// Массив ходов (поле 3 на 3).
    /// </summary>
    private char[,] arrayMoves = new char[3, 3];

    /// <summary>
    /// Ход игрока.
    /// X - ход крестиком.
    /// O - ход ноликом.
    /// </summary>
    private char activeMove = 'X';

    /// <summary>
    /// Остановка игры.
    /// true - Подведение результатов.
    /// false - Продолжение игры.
    /// </summary>
    private bool finishGame = false;

    /// <summary>
    /// Начало новой игры.
    /// true - Начать новую игру.
    /// false - Выход из программы.
    /// </summary>
    private bool startGame = true;

    /// <summary>
    /// Символ игрока, который победил.
    /// </summary>
    private char winChar = ' ';
    #endregion

    #region Методы

    /// <summary>
    /// Начало игры.
    /// </summary>
    public void StartGame()
    {
      while (startGame)
      {
        finishGame = false;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.White;
        DefaultSettings();
        PlayingField();
        ChooseMove();
      }
    }

    /// <summary>
    /// Настройки игры по умолчанию.
    /// </summary>
    private void DefaultSettings()
    {
      // Сбрасываем наши ходы
      for (int i = 0; i < 3; i++)
      {
        for (int j = 0; j < 3; j++)
        {
          arrayMoves[i, j] = ' ';
        }
      }
      // Переход хода крестикам
      activeMove = 'X';
    }

    /// <summary>
    /// Выбор хода.
    /// </summary>
    private void ChooseMove()
    {
      while (!finishGame)
      {
        Console.ForegroundColor = ConsoleColor.White;
        try
        {
          Console.Write("Выберите строку (от 1 до 3): ");
          int x = Convert.ToInt32(Console.ReadLine()) - 1;
          Console.Write("Выберите столбец (от 1 до 3): ");
          int y = Convert.ToInt32(Console.ReadLine()) - 1;

          if (arrayMoves[x, y] == ' ')
          {
            if (activeMove == 'X')
            {
              arrayMoves[x, y] = CrossMove;
              activeMove = 'O';
            }
            else
            {
              arrayMoves[x, y] = ZeroMove;
              activeMove = 'X';
            }
            PlayingField();
          }
          else
          {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Вы не можете сходить в данную клетку, так как она занята");

          }
        }
        catch
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("Координата введена неверно");
        }

        char temporaryChar = CheckFinishGame();

        if (temporaryChar == CrossMove)
        {
          Console.ForegroundColor = ConsoleColor.Green;
          Console.WriteLine("Победа крестиков!");
          finishGame = true;
        }
        else if (temporaryChar == ZeroMove)
        {
          Console.ForegroundColor = ConsoleColor.Green;
          Console.WriteLine("Победа ноликов!");
          finishGame = true;
        }
        else if (temporaryChar == Draw)
        {
          Console.ForegroundColor = ConsoleColor.Green;
          Console.WriteLine("Победила дружба!");
          finishGame = true;
        }
      }
      ReturnOrExitGame();
    }

    /// <summary>
    /// Проверка конца игры.
    /// </summary>
    /// <returns>
    /// F(false) - На данный момент никто не победил.
    /// X(cross) - Победа крестиков.
    /// O(zero) - Победа ноликов.
    /// D(draw) - ничья.
    /// </returns>
    private char CheckFinishGame()
    {
      // Проверка строк
      if (arrayMoves[0, 0] != ' ' && arrayMoves[0, 0] == arrayMoves[0, 1] && arrayMoves[0, 0] == arrayMoves[0, 2])
      {
        winChar = arrayMoves[0, 0];
        arrayMoves[0, 0] = arrayMoves[0, 1] = arrayMoves[0, 2] = Winning;
        PlayingField();
        return winChar;
      }
      else if (arrayMoves[1, 0] != ' ' && arrayMoves[1, 0] == arrayMoves[1, 1] && arrayMoves[1, 0] == arrayMoves[1, 2])
      {
        winChar = arrayMoves[1, 0];
        arrayMoves[1, 0] = arrayMoves[1, 1] = arrayMoves[1, 2] = Winning;
        PlayingField();
        return winChar;
      }
      else if (arrayMoves[2, 0] != ' ' && arrayMoves[2, 0] == arrayMoves[2, 1] && arrayMoves[2, 0] == arrayMoves[2, 2])
      {
        winChar = arrayMoves[2, 0];
        arrayMoves[2, 0] = arrayMoves[2, 1] = arrayMoves[2, 2] = Winning;
        PlayingField();
        return winChar;
      }
      // Проверка столбцов
      else if (arrayMoves[0, 0] != ' ' && arrayMoves[0, 0] == arrayMoves[1, 0] && arrayMoves[1, 0] == arrayMoves[2, 0])
      {
        winChar = arrayMoves[0, 0];
        arrayMoves[0, 0] = arrayMoves[1, 0] = arrayMoves[2, 0] = Winning;
        PlayingField();
        return winChar;
      }
      else if (arrayMoves[0, 1] != ' ' && arrayMoves[0, 1] == arrayMoves[1, 1] && arrayMoves[1, 1] == arrayMoves[2, 1])
      {
        winChar = arrayMoves[0, 1];
        arrayMoves[0, 1] = arrayMoves[1, 1] = arrayMoves[2, 1] = Winning;
        PlayingField();
        return winChar;
      }
      else if (arrayMoves[0, 2] != ' ' && arrayMoves[0, 2] == arrayMoves[1, 2] && arrayMoves[1, 2] == arrayMoves[2, 2])
      {
        winChar = arrayMoves[0, 2];
        arrayMoves[0, 2] = arrayMoves[1, 2] = arrayMoves[2, 2] = Winning;
        PlayingField();
        return winChar;
      }
      // Проверка диагоналей
      else if (arrayMoves[0, 0] != ' ' && arrayMoves[0, 0] == arrayMoves[1, 1] && arrayMoves[1, 1] == arrayMoves[2, 2])
      {
        winChar = arrayMoves[0, 0];
        arrayMoves[0, 0] = arrayMoves[1, 1] = arrayMoves[2, 2] = Winning;
        PlayingField();
        return winChar;
      }
      else if (arrayMoves[0, 2] != ' ' && arrayMoves[0, 2] == arrayMoves[1, 1] && arrayMoves[1, 1] == arrayMoves[2, 0])
      {
        winChar = arrayMoves[0, 2];
        arrayMoves[0, 2] = arrayMoves[1, 1] = arrayMoves[2, 0] = Winning;
        PlayingField();
        return winChar;
      }
      // Проверка на ничью
      else
      {
        for (int i = 0; i < 3; i++)
        {
          for (int j = 0; j < 3; j++)
          {
            if (arrayMoves[i, j] == ' ')
            {
              return Resume;
            }
          }
        }
      }
      return Draw;
    }

    /// <summary>
    /// Выбор между перезапускои игры и выходом из игры.
    /// </summary>
    private void ReturnOrExitGame()
    {
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("Хотите начать сначала? (Y/N)");
      string exitGame = Console.ReadLine();
      if (exitGame == "N" || exitGame == "n") startGame = false;
      else if (exitGame == "Y" || exitGame == "y") startGame = true;
      else
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Неизвестный параметр! ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Попробуйте ещё раз...");
        ReturnOrExitGame();
        return;
      }
    }

    /// <summary>
    /// Отрисовка поля.
    /// </summary>
    private void PlayingField()
    {
      Console.Clear();
      Console.WriteLine("     |     |      ");
      Console.Write("  ");
      if (ColorChar(arrayMoves[0, 0]))
      {
        Console.Write(winChar);
      }
      else
      {
        Console.Write(arrayMoves[0, 0]);
      }
      Console.ForegroundColor = ConsoleColor.White;
      Console.Write("  |  ");
      if (ColorChar(arrayMoves[0, 1]))
      {
        Console.Write(winChar);
      }
      else
      {
        Console.Write(arrayMoves[0, 1]);
      }
      Console.ForegroundColor = ConsoleColor.White;
      Console.Write("  |  ");
      if (ColorChar(arrayMoves[0, 2]))
      {
        Console.Write(winChar);
      }
      else
      {
        Console.WriteLine(arrayMoves[0, 2]);
      }
      Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine("_____|_____|_____ ");
      Console.WriteLine("     |     |      ");

      Console.Write("  ");
      if (ColorChar(arrayMoves[1, 0]))
      {
        Console.Write(winChar);
      }
      else
      {
        Console.Write(arrayMoves[1, 0]);
      }
      Console.ForegroundColor = ConsoleColor.White;
      Console.Write("  |  ");
      if (ColorChar(arrayMoves[1, 1]))
      {
        Console.Write(winChar);
      }
      else
      {
        Console.Write(arrayMoves[1, 1]);
      }
      Console.ForegroundColor = ConsoleColor.White;
      Console.Write("  |  ");
      if (ColorChar(arrayMoves[1, 2]))
      {
        Console.Write(winChar);
      }
      else
      {
        Console.WriteLine(arrayMoves[1, 2]);
      }
      Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine("_____|_____|_____ ");
      Console.WriteLine("     |     |      ");

      Console.Write("  ");
      if (ColorChar(arrayMoves[2, 0]))
      {
        Console.Write(winChar);
      }
      else
      {
        Console.Write(arrayMoves[2, 0]);
      }
      Console.ForegroundColor = ConsoleColor.White;
      Console.Write("  |  ");
      if (ColorChar(arrayMoves[2, 1]))
      {
        Console.Write(winChar);
      }
      else
      {
        Console.Write(arrayMoves[2, 1]);
      }
      Console.ForegroundColor = ConsoleColor.White;
      Console.Write("  |  ");
      if (ColorChar(arrayMoves[2, 2]))
      {
        Console.Write(winChar);
      }
      else
      {
        Console.WriteLine(arrayMoves[2, 2]);
      }
      Console.WriteLine("     |     |      ");
    }

    /// <summary>
    /// Цвет символа, в зависимости от входящего символа.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    private bool ColorChar(char value)
    {
      Console.ForegroundColor = ConsoleColor.White;
      if (value == CrossMove)
      {
        Console.ForegroundColor = ConsoleColor.Blue;
        return false;
      }
      else if (value == ZeroMove)
      {
        Console.ForegroundColor = ConsoleColor.Yellow;
        return false;
      }
      else if (value == Winning)
      {
        Console.ForegroundColor = ConsoleColor.Green;
        return  true;
      }
      return false;
    }
    #endregion
  }
}
