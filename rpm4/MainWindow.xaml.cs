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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

 

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAbout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа №4\r\nРабота с классами. Перегрузка методов.Создать класс Triangle (треугольник) с полями-сторонами.\r\n Создать необходимые методы и свойства. Определить метод вычисления периметра.\r\n Создать перегруженные методы SetParams, для установки параметров объекта,\r\n в том числе увеличения размеров треугольника в 2 раза.\r\nВыполнила:\r\nСтудентка гр.ИСП-31\r\nКирюшова Виктория");
        }
    }
}