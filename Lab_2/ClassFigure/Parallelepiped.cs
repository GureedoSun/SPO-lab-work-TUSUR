using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFigure
{
    public class Parallelepiped : IFigure
    {
        public string Name
        {
            get
            {
                return "Паралелепипед";
            }
        }
        /// <summary>
        /// Значеие Ширины
        /// </summary>
        private int _A;

        /// <summary>
        /// Значение длинны
        /// </summary>
        private int _B;

        /// <summary>
        /// Значение высоты
        /// </summary>
        private int _C;

        /// <summary>
        /// Свойство Ширины
        /// </summary>
        public int A
        {
            get
            {
                return _A;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Введено неверное значение");
                _A = value;
            }
        }

        /// <summary>
        /// Свойсвто длинны
        /// </summary>
        public int B
        {
            get
            {
                return _B;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Введено неверное значение");
                _B = value;
            }
        }

        /// <summary>
        /// Свойство высоты
        /// </summary>
        public int C
        {
            get
            {
                return _C;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Введено неверное значение");
                _C = value;
            }
        }

        /// <summary>
        /// Метод вычисления обьёма паралепипида
        /// </summary>
        /// <returns>Возвращает значение обьёма</returns>
        public double CalculateVolume()
        {
            return A * B * C;
            // return System.Convert.ToDouble(A) * System.Convert.ToDouble(B) * System.Convert.ToDouble(C);
        }

        public Parallelepiped(int A, int B, int C)
        {
            _A = A;
            _B = B;
            _C = C;
        }

        public Parallelepiped()
        {

        }
    }
}
