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
        #region [ ПЕРЕМЕННЫЕ ]
        // Создадим массив ходов (поле 3 на 3).
        char[,] charArrMoves = new char[3, 3];
        // Переменная, отвечающая за код игрока
        // true - ход крестиком
        // false - ход ноликом
        bool boolActiveMove = true;
        // Переменная для остановки игры
        bool boolFinishGame = false;
        // Переменная для начала новой игры
        bool boolStartGame = true;
        // Игровое поле
        string[] stringArrPlayingField = new string[9];
        // Победные координаты
        char charWin = ' ';
        #endregion

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
                ChoosingAMove();
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
                    charArrMoves[i, j] = ' ';
                }
            }
            // Переход хода крестикам
            boolActiveMove = true;
        }
        /// <summary>
        /// Выбор хода
        /// </summary>
        private void ChoosingAMove()
        {
            while (!boolFinishGame)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Выберите строку и столбец для хода (через пробел от 1 до 3)");
                string str = Console.ReadLine();
                try
                {
                    int x = (str[0] - '0') - 1;
                    int y = (str[2] - '0') - 1;

                    if (charArrMoves[x, y] == ' ')
                    {
                        if (boolActiveMove) charArrMoves[x, y] = 'X';
                        else charArrMoves[x, y] = 'O';
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

                if (CheckFinishGame() == 'X') { Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Победа крестиков!"); boolFinishGame = true; }
                else if (CheckFinishGame() == 'O') { Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Победа ноликов!"); boolFinishGame = true; }
                else if (CheckFinishGame() == 'D') { Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Победила дружба!"); boolFinishGame = true; }
            }
            RetutnGame();
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
            if (charArrMoves[0, 0] != ' ' && charArrMoves[0, 0] == charArrMoves[0, 1] && charArrMoves[0, 0] == charArrMoves[0, 2])/*  */{ charWin = charArrMoves[0, 0]; charArrMoves[0, 0] = charArrMoves[0, 1] = charArrMoves[0, 2] = 'W'; PlayingField(); return charWin; }
            else if (charArrMoves[1, 0] != ' ' && charArrMoves[1, 0] == charArrMoves[1, 1] && charArrMoves[1, 0] == charArrMoves[1, 2]) { charWin = charArrMoves[1, 0]; charArrMoves[1, 0] = charArrMoves[1, 1] = charArrMoves[1, 2] = 'W'; PlayingField(); return charWin; }
            else if (charArrMoves[2, 0] != ' ' && charArrMoves[2, 0] == charArrMoves[2, 1] && charArrMoves[2, 0] == charArrMoves[2, 2]) { charWin = charArrMoves[2, 0]; charArrMoves[2, 0] = charArrMoves[2, 1] = charArrMoves[2, 2] = 'W'; PlayingField(); return charWin; }
            // Проверка столбцов                                                                                        
            else if (charArrMoves[0, 0] != ' ' && charArrMoves[0, 0] == charArrMoves[1, 0] && charArrMoves[1, 0] == charArrMoves[2, 0]) { charWin = charArrMoves[0, 0]; charArrMoves[0, 0] = charArrMoves[1, 0] = charArrMoves[2, 0] = 'W'; PlayingField(); return charWin; }
            else if (charArrMoves[0, 1] != ' ' && charArrMoves[0, 1] == charArrMoves[1, 1] && charArrMoves[1, 1] == charArrMoves[2, 1]) { charWin = charArrMoves[0, 1]; charArrMoves[0, 1] = charArrMoves[1, 1] = charArrMoves[2, 1] = 'W'; PlayingField(); return charWin; }
            else if (charArrMoves[0, 2] != ' ' && charArrMoves[0, 2] == charArrMoves[1, 2] && charArrMoves[1, 2] == charArrMoves[2, 2]) { charWin = charArrMoves[0, 2]; charArrMoves[0, 2] = charArrMoves[1, 2] = charArrMoves[2, 2] = 'W'; PlayingField(); return charWin; }
            // Проверка диагоналей                                                                                     
            else if (charArrMoves[0, 0] != ' ' && charArrMoves[0, 0] == charArrMoves[1, 1] && charArrMoves[1, 1] == charArrMoves[2, 2]) { charWin = charArrMoves[0, 0]; charArrMoves[0, 0] = charArrMoves[1, 1] = charArrMoves[2, 2] = 'W'; PlayingField(); return charWin; }
            else if (charArrMoves[0, 2] != ' ' && charArrMoves[0, 2] == charArrMoves[1, 1] && charArrMoves[1, 1] == charArrMoves[2, 0]) { charWin = charArrMoves[0, 2]; charArrMoves[0, 2] = charArrMoves[1, 1] = charArrMoves[2, 0] = 'W'; PlayingField(); return charWin; }
            // Проверка на ничью                                                                                                        
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (charArrMoves[i, j] == ' ')
                        {
                            return 'F';
                        }
                    }
                }
            }
            return 'D';
        }
        /// <summary>
        /// Перезапуск игры
        /// </summary>
        private void RetutnGame()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Хотите начать сначала? (Y/N)");
            string exitGame = Console.ReadLine();
            if (exitGame == "N") boolStartGame = false;
            else if (exitGame == "Y") boolStartGame = true;
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Неизвестный параметр! ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Попробуйте ещё раз...");
                RetutnGame();
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
            stringArrPlayingField[1] = "  " + charArrMoves[0, 0] + "  |  " + charArrMoves[0, 1] + "  |  " + charArrMoves[0, 2];
            stringArrPlayingField[2] = "_____|_____|_____ ";
            stringArrPlayingField[3] = "     |     |      ";
            stringArrPlayingField[4] = "  " + charArrMoves[1, 0] + "  |  " + charArrMoves[1, 1] + "  |  " + charArrMoves[1, 2];
            stringArrPlayingField[5] = "_____|_____|_____ ";
            stringArrPlayingField[6] = "     |     |      ";
            stringArrPlayingField[7] = "  " + charArrMoves[2, 0] + "  |  " + charArrMoves[2, 1] + "  |  " + charArrMoves[2, 2];
            stringArrPlayingField[8] = "     |     |      ";

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < stringArrPlayingField[i].Length; j++)
                {
                    bool charTemporaryWin = false;
                    Console.ForegroundColor = ConsoleColor.White;
                    if (stringArrPlayingField[i][j] == 'X')
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    else if (stringArrPlayingField[i][j] == 'O')
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
    }
}
