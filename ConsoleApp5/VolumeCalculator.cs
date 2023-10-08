namespace L
{
    public static class VolumeCalculator
    {
        /// <summary>
        /// Минимальное значение объема
        /// </summary>

        public const int Min = 0;

        /// <summary>
        /// Вычисляем объем по 3 параметрам
        /// </summary>
        /// <param name="a">Длина</param>
        /// <param name="b">Ширина</param>
        /// <param name="c">Высота</param>
        /// <returns>Объём</returns>
        public static double GetVolume(double a, double b, double c)
        {
            ValidationHelper.CheckRangeValue(a, Min, "Длина не может быть меньше 0");

            ValidationHelper.CheckRangeValue(b, Min, "Ширина не может быть меньше 0");

            ValidationHelper.CheckRangeValue(c, Min, "Высота не может быть меньше 0");

            double Volume = a * b * c;

            return Volume;
        }
    }
}
