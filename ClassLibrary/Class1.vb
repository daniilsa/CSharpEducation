Class MathHelper

        /// <summary>
        /// Возвращает сумму двух чисел
        /// </summary>
        /// <param name="a">Первое слагаемое</param>
        /// <param name="b">Второе слагаемое </param>
        /// <returns>Сумма</returns>
        Public int GetSumm(int a, int b)
        {
            Return a + b;
        }
        /// <summary>
        /// Возвращает разницу двух чисел
        /// </summary>
        /// <param name="a">Уменьшаемое</param>
        /// <param name="b">Вычитаемое</param>
        /// <returns>Разность</returns>
        Public int GetSubtraction(int a, int b)
        {
            Return a - b;
        }
        /// <summary>
        /// Возвращает результат деления
        /// </summary>
        /// <param name="a">Делитель</param>
        /// <param name="b">Делимое</param>
        /// <returns>Частное</returns>
        Public Double GetDivision(int a, int b)
        { 
            Return Convert.ToDouble(a) / Convert.ToDouble(b);
        }
        /// <summary>
        /// Возвращает результат умножения
        /// </summary>
        /// <param name="a">Первый множитель</param>
        /// <param name="b">Второй множитель</param>
        /// <returns></returns>
        Public int GetMultiplication(int a, int b)
        {
            Return a * b;
        }

End Class