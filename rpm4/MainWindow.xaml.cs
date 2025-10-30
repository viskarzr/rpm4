using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace rpm4
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            OutPut();
        }
        /// <summary>
        /// Создание экземпляров
        /// </summary>
        Triangle tri = new Triangle();
        Equilateral equi = new Equilateral();

        /// <summary>
        /// кнопка выходв
        /// </summary>
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// кнопка о программе
        /// </summary>
        private void btnAbout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа №6\r\nНаследование. Иерархия классов.\r\nИспользовать класс Triangle (треугольник) с полями-сторонами. \r\nСоздать производный класс Equilateral (равносторонний), имеющий поле площади. \r\nОпределить метод вычисления площади.\r\nВыполнила:\r\nСтудентка гр.ИСП-31\r\nКирюшова Виктория");
        }
        /// <summary>
        /// кнопка расчета периметра
        /// </summary>
        private void btnPer_Click(object sender, RoutedEventArgs e)
        {
            if (tri)
            {
                tbPer.Text = tri.GetPerimeter().ToString();
            }
            else
            {
                MessageBox.Show("Данный треугольник не существует. И расчёт периметра не возможен!");
            }
        }
        /// <summary>
        /// кнопка очищения
        /// </summary>
        private void miCleanAll_Click(object sender, RoutedEventArgs e)
        {
            tbPer.Clear();
            tbASide.Clear();
            tbBSide.Clear();
            tbCSide.Clear();
        }

        /// <summary>
        /// кнопка для увеличения сторон в 2 раза
        /// </summary>
        private void btnDouble_Click(object sender, RoutedEventArgs e)
        {
            tri.SetParams();
            OutPut();
        }

        /// <summary>
        /// кнопка для установки сторон треугольника
        /// </summary>
        private void btnSet_Click(object sender, RoutedEventArgs e)
        {
            bool f1, f2, f3;
            f1 = Double.TryParse(tbASide.Text, out double a);
            f2 = Double.TryParse(tbBSide.Text, out double b);
            f3 = Double.TryParse(tbCSide.Text, out double c);
            if (f1 == true && f2 == true && f3 == true)
            {
                tri.SetParams(a, b, c);
            }
            else
            {
                MessageBox.Show("Введите корректные значения!");
            }
        }
        private void OutPut()
        {
            tbASide.Text = tri.a.ToString();
            tbBSide.Text = tri.b.ToString();
            tbCSide.Text = tri.c.ToString();
        }

        /// <summary>
        /// кнопка для увеличения сторон на 1
        /// </summary>
        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            tri++;
            OutPut();
        }

        /// <summary>
        /// кнопка для уменьшения сторон на 1
        /// </summary>
        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            tri--;
            OutPut();
        }
        /// <summary>
        /// кнопка для расчета площади равностороннего трегольника
        /// </summary>
        private void btnEquilateral_Click(object sender, RoutedEventArgs e)
        {
            bool f1, f2, f3;
            f1 = Double.TryParse(tbASide.Text, out double a);
            f2 = Double.TryParse(tbBSide.Text, out double b);
            f3 = Double.TryParse(tbCSide.Text, out double c);
            if (f1 == true && f2 == true && f3 == true)
            {
                if (a == b && b == c)
                {
                    equi.SetParams(a, b, c);
                    tbArea.Text = equi.CalcArea().ToString();
                }
                else
                {
                    MessageBox.Show("Треугольник не равносторонний");
                }
            }

        }
    }
}