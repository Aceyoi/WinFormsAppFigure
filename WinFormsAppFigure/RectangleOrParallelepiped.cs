// Код создан Сапожниковым Ю.С.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppFigure
{
    // Название класса Прямоугольник Или Параллелепипед
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
                throw new ArgumentException("Ширина должна быть положительной");
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
                throw new ArgumentException("Высота должна быть неотрицательной");
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
                throw new ArgumentException("Длина должна быть положительной");
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

        public static void Test()// статический метод
        {
            try
            {
                // Тест конструктора с некорректными отрицательными значениями
                var bedtest = new RectangleOrParallelepiped(-3, -4, -2);
                System.Diagnostics.Debug.Assert(bedtest.GetWidth() == 0);
                System.Diagnostics.Debug.Assert(bedtest.GetHeight() == 0);
                System.Diagnostics.Debug.Assert(bedtest.GetLength() == 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка валидации: {ex.Message}");
            }

            var twotest = new RectangleOrParallelepiped(5, 5, 0);
            var treetest = new RectangleOrParallelepiped(5, 5, 5);

            var twotest1 = new RectangleOrParallelepiped(3.5, 7.25, 0);
            var treetest1 = new RectangleOrParallelepiped(4.37, 0.5, 1.9); 

            System.Diagnostics.Debug.Assert(twotest.GetWidth() == 5);
            System.Diagnostics.Debug.Assert(twotest.GetHeight() == 0);
            System.Diagnostics.Debug.Assert(twotest.GetLength() == 5);
            System.Diagnostics.Debug.Assert(twotest.GetTwodPerimeter() == 20);
            System.Diagnostics.Debug.Assert(twotest.GetTwodArea() == 25);

            System.Diagnostics.Debug.Assert(treetest.GetWidth() == 5);
            System.Diagnostics.Debug.Assert(treetest.GetHeight() == 5);
            System.Diagnostics.Debug.Assert(treetest.GetLength() == 5);

            //MessageBox.Show("Все тесты прошли успешно!");// Убрать
            // Тесты работают в более фоновом режиме
        }

    }
}
