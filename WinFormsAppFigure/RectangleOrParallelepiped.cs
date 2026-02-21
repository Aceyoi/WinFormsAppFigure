// Код создан Сапожниковым Ю.С.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppFigure
{
    internal class RectangleOrParallelepiped
    {
        private double width;  // ширина
        private double height; // высота
        private double length; // длина

        // Конструктор без параметров
        public RectangleOrParallelepiped()
        {
            length = 0;
            width = 0;
            height = 0;
        }

        // Конструктор с параметрами
        public RectangleOrParallelepiped(double l, double w, double h)
        {
            SetFigL(l);
            SetFigW(w);
            SetFigH(h);
        }

        // Конструктор копирования
        public RectangleOrParallelepiped(RectangleOrParallelepiped other)
        {
            if (other == null)
                throw new ArgumentNullException(nameof(other));

            width = other.width;
            height = other.height;
            length = other.length;
        }

        // Метод заполнения ширины
        public void SetFigW(double w)
        {
            if (w > 0)
            {
                width = w;
            }
            else
            {
                Console.WriteLine("Ширина должна быть положительной.");
            }
        }

        // Метод заполнения высоты
        public void SetFigH(double h)
        {
            if (h >= 0)
            {
                height = h;
            }
            else
            {
                Console.WriteLine("Высота должна быть неотрицательной.");
            }
        }

        // Метод заполнения длины
        public void SetFigL(double l)
        {
            if (l > 0)
            {
                length = l;
            }
            else
            {
                Console.WriteLine("Длина должна быть положительной.");
            }
        }

        // Метод вывода ширины
        public double GetWidth() => width;

        // Метод вывода высоты
        public double GetHeight() => height;

        // Метод вывода длины
        public double GetLength() => length;

        // Метод нахождения периметра прямоугольника
        public double GetTwodPerimeter() => (length + width) * 2;

        // Метод нахождения площади прямоугольника
        public double GetTwodArea() => length * width;

        // Метод нахождения "периметра" параллелепипеда (суммы рёбер)
        public double GetTreedPerimeter() => 4 * (length + width + height);

        // Метод нахождения объёма параллелепипеда
        public double GetTreedVolume() => width * length * height;
    }
}
