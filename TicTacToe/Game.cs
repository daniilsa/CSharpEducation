using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    /// <summary>
    /// Обработка игры
    /// </summary>
    class Game
    {
        #region Константы
        /// <summary>
        ///  X - Ход со стороны крестиков
        /// </summary>
        private const char crossMove = 'X';

        /// <summary>
        ///  O - Ход со стороны ноликов
        /// </summary>
        private const char zeroMove = 'O';

        /// <summary>
        ///  W(winning) - Победа одной из сторон
        /// </summary>
        private const char winning = 'W';

        /// <summary>
        ///  D(draw) - Ничья
        /// </summary>
        private const char draw = 'D';

        /// <summary>
        ///  F(false) - На данный момент никто не победил
        /// </summary>
        private const char resume = 'R';
        #endregion
  
        #region Поля
        /// <summary>
        /// Массив ходов (поле 3 на 3).
        /// </summary>
        private char[,] arrMoves = new char[3, 3];

        /// <summary>
        /// Ход игрока
        /// true - ход крестиком
        /// false - ход ноликом
        /// </summary>
        private bool boolActiveMove = true;

        /// <summary>
        /// Остановка игры
        /// true - Подведение результатов
        /// false - Продолжение игры
        /// </summary>
        private bool boolFinishGame = false;

        /// <summary>
        /// Начало новой игры
        /// true - Начатть новую игру
        /// false - Выход из программы
        /// </summary>
        private bool boolStartGame = true;

        /// <summary>
        /// Игровое поле
        /// </summary>
        private string[] stringArrPlayingField = new string[9];

        /// <summary>
        /// Символ игрока, который победил
        /// </summary>
        private char charWin = ' ';
        #endregion

        #region Методы
        /// <summary>
        /// Начало игры
        /// </summary>
        public void StartGame()
        {
            while (boolStartGame)
            {
                boolFinishGame = false;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                DefaultSettings();
                PlayingField();
                ChoosingMove();
            }
        }
        /// <summary>
        /// Настройки игры по умолчанию
        /// </summary>
        private void DefaultSettings()
        {
            // Сбрасываем наши ходы
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arrMoves[i, j] = ' ';
                }
            }
            // Переход хода крестикам
            boolActiveMove = true;
        }
        /// <summary>
        /// Выбор хода
        /// </summary>
        private void ChoosingMove()
        {
            while (!boolFinishGame)
            {
                Console.ForegroundColor = ConsoleColor.White;
                try
                {
                    Console.Write("Выберите строку (от 1 до 3): ");
                    int x = Convert.ToInt32(Console.ReadLine()) - 1;
                    Console.Write("Выберите столбец (от 1 до 3): ");
                    int y = Convert.ToInt32(Console.ReadLine()) - 1;

                    if (arrMoves[x, y] == ' ')
                    {
                        if (boolActiveMove) arrMoves[x, y] = crossMove;
                        else arrMoves[x, y] = zeroMove;
                        boolActiveMove = !boolActiveMove;
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

                if (CheckFinishGame() == crossMove)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Победа крестиков!");
                    boolFinishGame = true;
                }
                else if (CheckFinishGame() == zeroMove)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Победа ноликов!");
                    boolFinishGame = true;
                }
                else if (CheckFinishGame() == draw)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Победила дружба!");
                    boolFinishGame = true;
                }
            }
            ReturnOrExitGame();
        }
        /// <summary>
        /// Проверка конца игры
        /// </summary>
        /// <returns>
        /// F(false) - На данный момент никто не победил
        /// X(cross) - Победа крестиков
        /// O(zero) - Победа ноликов
        /// D(draw) - ничья
        /// </returns>
        private char CheckFinishGame()
        {
            // Проверка строк
            if (arrMoves[0, 0] != ' ' && arrMoves[0, 0] == arrMoves[0, 1] && arrMoves[0, 0] == arrMoves[0, 2])
            {
                charWin = arrMoves[0, 0];
                arrMoves[0, 0] = arrMoves[0, 1] = arrMoves[0, 2] = winning;
                PlayingField();
                return charWin;
            }
            else if (arrMoves[1, 0] != ' ' && arrMoves[1, 0] == arrMoves[1, 1] && arrMoves[1, 0] == arrMoves[1, 2])
            {
                charWin = arrMoves[1, 0];
                arrMoves[1, 0] = arrMoves[1, 1] = arrMoves[1, 2] = winning;
                PlayingField();
                return charWin;
            }
            else if (arrMoves[2, 0] != ' ' && arrMoves[2, 0] == arrMoves[2, 1] && arrMoves[2, 0] == arrMoves[2, 2])
            {
                charWin = arrMoves[2, 0];
                arrMoves[2, 0] = arrMoves[2, 1] = arrMoves[2, 2] = winning;
                PlayingField();
                return charWin;
            }
            // Проверка столбцов                                                                                                                                                                                                       
            else if (arrMoves[0, 0] != ' ' && arrMoves[0, 0] == arrMoves[1, 0] && arrMoves[1, 0] == arrMoves[2, 0])
            {
                charWin = arrMoves[0, 0];
                arrMoves[0, 0] = arrMoves[1, 0] = arrMoves[2, 0] = winning;
                PlayingField();
                return charWin;
            }
            else if (arrMoves[0, 1] != ' ' && arrMoves[0, 1] == arrMoves[1, 1] && arrMoves[1, 1] == arrMoves[2, 1])
            {
                charWin = arrMoves[0, 1];
                arrMoves[0, 1] = arrMoves[1, 1] = arrMoves[2, 1] = winning;
                PlayingField();
                return charWin;
            }
            else if (arrMoves[0, 2] != ' ' && arrMoves[0, 2] == arrMoves[1, 2] && arrMoves[1, 2] == arrMoves[2, 2])
            {
                charWin = arrMoves[0, 2];
                arrMoves[0, 2] = arrMoves[1, 2] = arrMoves[2, 2] = winning;
                PlayingField();
                return charWin;
            }
            // Проверка диагоналей                                                                                                                                                                                                    
            else if (arrMoves[0, 0] != ' ' && arrMoves[0, 0] == arrMoves[1, 1] && arrMoves[1, 1] == arrMoves[2, 2])
            {
                charWin = arrMoves[0, 0];
                arrMoves[0, 0] = arrMoves[1, 1] = arrMoves[2, 2] = winning;
                PlayingField();
                return charWin;
            }
            else if (arrMoves[0, 2] != ' ' && arrMoves[0, 2] == arrMoves[1, 1] && arrMoves[1, 1] == arrMoves[2, 0])
            {
                charWin = arrMoves[0, 2];
                arrMoves[0, 2] = arrMoves[1, 1] = arrMoves[2, 0] = winning;
                PlayingField();
                return charWin;
            }
            // Проверка на ничью                                                                                                        
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (arrMoves[i, j] == ' ')
                        {
                            return resume;
                        }
                    }
                }
            }
            return draw;
        }
        /// <summary>
        /// Выбор между перезапускои игры и выходом из игры
        /// </summary>
        private void ReturnOrExitGame()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Хотите начать сначала? (Y/N)");
            string exitGame = Console.ReadLine();
            if (exitGame == "N" || exitGame == "n") boolStartGame = false;
            else if (exitGame == "Y" || exitGame == "y") boolStartGame = true;
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
        /// Отрисовка поля
        /// </summary>
        private void PlayingField()
        {
            Console.Clear();
            stringArrPlayingField[0] = "     |     |      ";
            stringArrPlayingField[1] = "  " + arrMoves[0, 0] + "  |  " + arrMoves[0, 1] + "  |  " + arrMoves[0, 2];
            stringArrPlayingField[2] = "_____|_____|_____ ";
            stringArrPlayingField[3] = "     |     |      ";
            stringArrPlayingField[4] = "  " + arrMoves[1, 0] + "  |  " + arrMoves[1, 1] + "  |  " + arrMoves[1, 2];
            stringArrPlayingField[5] = "_____|_____|_____ ";
            stringArrPlayingField[6] = "     |     |      ";
            stringArrPlayingField[7] = "  " + arrMoves[2, 0] + "  |  " + arrMoves[2, 1] + "  |  " + arrMoves[2, 2];
            stringArrPlayingField[8] = "     |     |      ";

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < stringArrPlayingField[i].Length; j++)
                {
                    bool charTemporaryWin = false;
                    Console.ForegroundColor = ConsoleColor.White;
                    if (stringArrPlayingField[i][j] == crossMove)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    else if (stringArrPlayingField[i][j] == zeroMove)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else if (stringArrPlayingField[i][j] == 'W')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        charTemporaryWin = true;
                    }
                    if (charTemporaryWin)
                    {
                        if ((j + 1) != stringArrPlayingField[i].Length) Console.Write(charWin);
                        else Console.WriteLine(charWin);
                    }
                    else
                    {
                        if ((j + 1) != stringArrPlayingField[i].Length) Console.Write(stringArrPlayingField[i][j]);
                        else Console.WriteLine(stringArrPlayingField[i][j]);
                    }
                }
            }
        }
        #endregion
    }
}
