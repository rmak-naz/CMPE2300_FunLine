using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;

namespace ICA6_FunLine
{
    class FunLine : IComparable
    {
        public int _length;
        public int _width;
        public bool _flag;

        public FunLine(int length, int width)
        {
            _length = length;
            _width = width;
            _flag = false;
        }

        public void Render(CDrawer canvas, Point lPoint)
        {
            if (_flag == false)
                canvas.AddLine(lPoint, _length, Math.PI, Color.Red, _width);
            else
                canvas.AddLine(lPoint, _length, Math.PI, Color.Yellow, _width);
        }

        public int CompareTo(object lineObj)
        {
            if (!(lineObj is FunLine))
            {
                throw new ArgumentException("Incorrect type in CompareTo!");
            }
            FunLine objCopy = (FunLine)lineObj;

            return _length.CompareTo(objCopy._length);
        }

        public static int DecComp(FunLine lineA, FunLine lineB)
        {
            return (-1 * lineA._length.CompareTo(lineB._length));
        }

        public static int WidthThenHeightComp(FunLine lineA, FunLine lineB)
        {
            if (lineA._width.CompareTo(lineB._width) == 0)
            {
                return (lineA._length.CompareTo(lineB._length));
            }
            else
            {
                return (lineA._width.CompareTo(lineB._width));
            }
        }
    }
}
