using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFigure
{
    public class Spher : IFigure
    {
        public string Name
        {
            get
            {
                return "Шар";
            }
        }
        /// <summary>
        /// Значение радиус шара 
        /// </summary>
        private int _radius;

        /// <summary>
        /// Свойсвто радиуса 
        /// </summary>
        public int Radius
        {
            get
            {
                return _radius;

            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Введено неверное значение");
                _radius = value;
            }
        }

        /// <summary>
        /// Метод рассчёта обьёма шара 
        /// </summary>
        /// <returns>Возвращает значение обьёма</returns>

        public double CalculateVolume()
        {
            return (4 / 3) * Math.PI * (Math.Pow(Radius, 3));

        }

        public Spher(int radius)
        {
            _radius = radius;
        }

        public Spher()
        {

        }
    }
}
