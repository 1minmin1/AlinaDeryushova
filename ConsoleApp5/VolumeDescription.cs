namespace L
{
    public static class VolumeDescription
    {
        /// <summary>
        /// Описание к объему
        /// </summary>
        static Dictionary<double, string> _descriptions = new()
        {
            { 50, "Маленький объем" },

            { 100, "Средний объем" },

            { 150, "Большой объем" },
        };

        /// <summary>
        /// Получение описания в зависимости от числа
        /// </summary>
        /// <param name="Volume">Объем</param>
        /// <returns></returns>
        public static string GetVolumeDescription(double Volume)
        {

            foreach (var item in _descriptions)
            {
                if (Volume <= item.Key)
                {
                    return item.Value;
                }
            }

            return "Невозможное значение объема";
        }
    }
}
