using System;
namespace L
{
    class Program
    {
        /// <summary>
        /// Старт
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
            Console.Write("Длина: ");

            double a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ширина: ");

            double b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Высота: ");

            double c = Convert.ToInt32(Console.ReadLine());

            var Volume = VolumeCalculator.GetVolume(a, b, c);

            Console.WriteLine(Volume);

            Console.WriteLine(VolumeDescription.GetVolumeDescription(Volume));
        }
    }
}
