using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinBox_GeometryLib
{
    public interface IFigure
    {
        public double GetSquare();
        public double GetSquare(params double[] sides);
    }
}
