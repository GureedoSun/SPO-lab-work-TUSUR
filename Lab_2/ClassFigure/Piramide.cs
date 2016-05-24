using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFigure
{
    public class Piramide : IFigure
    {
        public string Name
        {
            get
            {
                return "Пирамида";
            }
        }
        /// <summary>
        /// Значение площади 
        /// </summary>
        private double _S;

        /// <summary>
        /// Значение высоты 
        /// </summary>
        private double _H;


        /// <summary>
        /// Свойсвто площади
        /// </summary>
        public double S
        {
            get
            {
                return _S;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Введено неверное значение");
                _S = value;
            }
        }
        /// <summary>
        /// Свойство высоты 
        /// </summary>
        public double H
        {
            get
            {
                return _H;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Введено неверное значение");
                _H = value;
            }
        }
        /// <summary>
        /// Метод вычисления обьёма пирамиды
        /// </summary>
        /// <returns>Возвращает значение обьёма</returns>
        public double CalculateVolume()
        {
            return S * H * (1.0 / 3.0);
        }

        public Piramide(double S, double H)
        {
            _S = S;
            _H = H;
        }

        public Piramide()
        {

        }
    }
}
