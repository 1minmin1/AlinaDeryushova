namespace L
{
    public static class ValidationHelper
    {
        /// <summary>
        /// Проверка на минимальное значение
        /// </summary>
        /// <param name="value">Число для проверки</param>
        /// <param name="MinValue">Минимальное значение</param>
        /// <param name="message"></param>
        /// <exception cref="ArgumentOutOfRangeException">Если значение меньше или равно минимальному значению, выводится сообщение</exception>
        public static void CheckRangeValue(double value, int MinValue, string message)
        {
            if (value <= MinValue)
            {

                throw new ArgumentOutOfRangeException(nameof(value),

                string.Format(message, MinValue));
            }
        }
    }
}

