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
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAbout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа №4\r\nРабота с классами. Перегрузка методов.Создать класс Triangle (треугольник) с полями-сторонами.\r\n Создать необходимые методы и свойства. Определить метод вычисления периметра.\r\n Создать перегруженные методы SetParams, для установки параметров объекта,\r\n в том числе увеличения размеров треугольника в 2 раза.\r\nВыполнила:\r\nСтудентка гр.ИСП-31\r\nКирюшова Виктория");
        }

        private void btnPer_Click(object sender, RoutedEventArgs e)
        {
            bool f1, f2, f3;
            f1 = Double.TryParse(tbASide.Text, out double a);
            f2 = Double.TryParse(tbBSide.Text, out double b);
            f3 = Double.TryParse(tbCSide.Text, out double c);
            if (f1 == true && f2 == true && f3 == true)
            {
                tbPer.Text = tri.GetPerimeter().ToString();
            }
            else
            {
                MessageBox.Show("Введите корректные значения!");
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
                OutPut();
            }
        }
        private void OutPut()
        {
            tbASide.Text = tri.a.ToString();
            tbBSide.Text = tri.b.ToString();
            tbCSide.Text = tri.c.ToString();
        }
    }
}