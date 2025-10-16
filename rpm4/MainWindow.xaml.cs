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
        Triangle tri = new Triangle();
        Equilateral equi = new Equilateral();
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAbout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа №5\r\nОпределение операций в классе.Использовать класс Triangle (треугольник) с полями-сторонами.\r\n Разработать операцию для определения возможности существование треугольника с заданными \r\nсторонами true/false. Разработать операции для увеличения/уменьшения сторон на 1.\r\nВыполнила:\r\nСтудентка гр.ИСП-31\r\nКирюшова Виктория");
        }

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

        private void miCleanAll_Click(object sender, RoutedEventArgs e)
        {
            tbPer.Clear();
            tbASide.Clear();
            tbBSide.Clear();
            tbCSide.Clear();
        }

        private void btnDouble_Click(object sender, RoutedEventArgs e)
        {
            tri.SetParams();
            OutPut();
        }
 
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
        }
        private void OutPut()
        {
            tbASide.Text = tri.a.ToString();
            tbBSide.Text = tri.b.ToString();
            tbCSide.Text = tri.c.ToString();
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            tri++;
            OutPut();
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            tri--;
            OutPut();
        }

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