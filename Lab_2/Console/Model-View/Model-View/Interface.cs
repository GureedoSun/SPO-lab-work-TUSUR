using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Интерфейс фигур
    /// </summary>
    public interface IFigure
    {
        /// <summary>
        /// Вызов метода рассчёта обьёма
        /// </summary>
        /// <returns></returns>
        double CalculateVolume();
    }
}
