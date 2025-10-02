using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace rpm4
{
    public class Triangle
    {
        //стороны треугольника
        private double _a;
        private double _b;
        private double _c;
        public double a
        {
            get { return _a; }
            private set {
                if (value <= 0)
                {
                    MessageBox.Show("Сторона треугольника должна быть положительной и больше нуля");
                }
            }
        }
        public double b
        {
            get { return _b; }
            private set
            {
                if (value <= 0)
                {
                    MessageBox.Show("Сторона треугольника должна быть положительной и больше нуля");
                }
            }
        }
        public double c
        {
            get { return _c; }
            private set
            {
                if (value <= 0)
                {
                    MessageBox.Show("Сторона треугольника должна быть положительной и больше нуля");
                }
            }
        }
        public Triangle() // проверить на необходимость
        {
            _a = 1;
            _b = 1;
            _c = 1;

        }
        public Triangle(double a, double b, double c)
        {
            SetParams(a, b, c);
        }

        private bool TrueTriandle(double a, double b, double c)
        {
            return a > 0 && b > 0 && c > 0 && a + b > c && b + c > a && a + c > b;
        }
        public void SetParams(double a, double b, double c)
        {
            if (!TrueTriandle(a, b, c))
                MessageBox.Show("Данный треугольник не существует");
            _a = a;
            _b = b;
            _c = c;

        }
        public double GetPerimeter()
        {
            return _a + _b + _c;
        }
        public void SetParams()
        {
            _a *= 2;
            _b *= 2;
            _c *= 2;
        }        
    }
}
