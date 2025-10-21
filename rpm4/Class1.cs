using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace rpm4
{ 
    /// <summary>
    /// класс Triangle для расчёта периметра с применением полями-сторонами и увеличением полей в два раза
    /// </summary>
    public class Triangle
    {    
        private double _a;
        private double _b;
        private double _c;

        /// <summary>
        /// Проверка на четность первой стороны
        /// </summary>
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

        /// <summary>
        /// Проверка на четность второй стороны
        /// </summary>
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

        /// <summary>
        /// Проверка на четность третьей стороны
        /// </summary>
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

        /// <summary>
        /// Изначальные значения сторон треугольника
        /// </summary>
        public Triangle()
        {
            _a = 1;
            _b = 1;
            _c = 1;
        }

        /// <summary>
        /// Назначение сторон треугольника пользователем
        /// </summary>
        /// <param name="a">первая сторона</param>
        /// <param name="b">вторая сторона</param>
        /// <param name="c">третья сторона</param>
        public Triangle(double a, double b, double c)
        {
            SetParams(a, b, c);
        }

        /// <summary>
        /// Проверка на существование треугольника
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public bool TrueTriandle(double a, double b, double c)
        {
            return a > 0 && b > 0 && c > 0 && a + b > c && b + c > a && a + c > b;
        }

        /// <summary>
        /// Метод для назначения сторон треугольника
        /// </summary>
        /// <param name="a">Первая сторона треугольника</param>
        /// <param name="b">Вторая сторона треугольника</param>
        /// <param name="c">Третья сторона треугольника</param>
        public void SetParams(double a, double b, double c)
        {
            if (!TrueTriandle(a, b, c))
                MessageBox.Show("Данный треугольник не существует");
            _a = a;
            _b = b;
            _c = c;

        }

        /// <summary>
        /// Метод для расчета периметра
        /// </summary>
        /// <returns></returns>
        public double GetPerimeter()
        {

            return _a + _b + _c;
        }

        /// <summary>
        /// Метод для увеличения сторон треугльника в 2 раза
        /// </summary>
        public void SetParams()
        {
            _a *= 2;
            _b *= 2;
            _c *= 2;
        }

        /// <summary>
        /// Перегруженный оператор true для проверки треугольника на существование
        /// </summary>
        /// <param name="tri"> экземпляр класса - треугольник </param>
        /// <returns></returns>
        public static bool operator true(Triangle tri)
        {
            return tri.TrueTriandle(tri._a, tri._b, tri._c);
        }

        /// <summary>
        /// Перегруженный оператор false для проверки треугольника на существование
        /// </summary>
        /// <param name="tri"> экземпляр класса - треугольник </param>
        /// <returns></returns>
        public static bool operator false(Triangle tri)
        {
            return !tri.TrueTriandle(tri._a, tri._b, tri._c);
        }

        /// <summary>
        /// Перегруженный оператора для увеличения сторон треугольника на 1
        /// </summary>
        /// <param name="tri"></param>
        /// <returns></returns>
        public static Triangle operator ++(Triangle tri)
        {
            tri._a += 1;
            tri._b += 1;
            tri._c += 1;
            return tri;
        }

        /// <summary>
        /// Перегруженный оператора для уменьшения сторон треугольника на 1
        /// </summary>
        /// <param name="tri"></param>
        /// <returns></returns>
        public static Triangle operator --(Triangle tri)
        {
            tri._a -= 1;
            tri._b -= 1;
            tri._c -= 1;
           ч
        }
    }
}
