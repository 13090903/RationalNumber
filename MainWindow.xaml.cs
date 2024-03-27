using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RationalNumberApp.Model;

namespace RationalNumberApp
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
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            if (numerator1.Text == "" || denominator1.Text == "" || numerator2.Text == "" || denominator2.Text == "")
            {
                MessageBox.Show("Введите все необходимые данные!");
            }
            else
            {
                long numeratorFirst = Convert.ToInt64(numerator1.Text);
                long denominatorFirst = Convert.ToInt64(denominator1.Text);
                long numeratorSecond = Convert.ToInt64(numerator2.Text);
                long denominatorSecond = Convert.ToInt64(denominator2.Text);
                if (denominatorFirst == 0 || denominatorSecond == 0)
                {
                    result.Text = "Бесконечность";
                }
                else
                {
                    RationalNumber r1 = new(numeratorFirst, denominatorFirst);
                    RationalNumber r2 = new(numeratorSecond, denominatorSecond);
                    RationalNumber res = r1 + r2;
                    result.Text = res.ToString();
                }
            }
        }
        private void Subtract(object sender, RoutedEventArgs e)
        {
            if (numerator1.Text == "" || denominator1.Text == "" || numerator2.Text == "" || denominator2.Text == "")
            {
                MessageBox.Show("Введите все необходимые данные!");
            }
            else
            {
                long numeratorFirst = Convert.ToInt64(numerator1.Text);
                long denominatorFirst = Convert.ToInt64(denominator1.Text);
                long numeratorSecond = Convert.ToInt64(numerator2.Text);
                long denominatorSecond = Convert.ToInt64(denominator2.Text);
                if (denominatorFirst == 0 || denominatorSecond == 0)
                {
                    result.Text = "Бесконечность";
                }
                else
                {
                    RationalNumber r1 = new(numeratorFirst, denominatorFirst);
                    RationalNumber r2 = new(numeratorSecond, denominatorSecond);
                    RationalNumber res = r1 - r2;
                    result.Text = res.ToString();
                }
            }
        }
        private void Multiply(object sender, RoutedEventArgs e)
        {
            if (numerator1.Text == "" || denominator1.Text == "" || numerator2.Text == "" || denominator2.Text == "")
            {
                MessageBox.Show("Введите все необходимые данные!");
            }
            else
            {
                long numeratorFirst = Convert.ToInt64(numerator1.Text);
                long denominatorFirst = Convert.ToInt64(denominator1.Text);
                long numeratorSecond = Convert.ToInt64(numerator2.Text);
                long denominatorSecond = Convert.ToInt64(denominator2.Text);
                if (denominatorFirst == 0 || denominatorSecond == 0)
                {
                    result.Text = "Бесконечность";
                }
                else
                {
                    RationalNumber r1 = new(numeratorFirst, denominatorFirst);
                    RationalNumber r2 = new(numeratorSecond, denominatorSecond);
                    RationalNumber res = r1 * r2;
                    result.Text = res.ToString();
                }
            }
        }
        private void Divide(object sender, RoutedEventArgs e)
        {
            if (numerator1.Text == "" || denominator1.Text == "" || numerator2.Text == "" || denominator2.Text == "")
            {
                MessageBox.Show("Введите все необходимые данные!");
            }
            else
            {
                long numeratorFirst = Convert.ToInt64(numerator1.Text);
                long denominatorFirst = Convert.ToInt64(denominator1.Text);
                long numeratorSecond = Convert.ToInt64(numerator2.Text);
                long denominatorSecond = Convert.ToInt64(denominator2.Text);
                if (denominatorFirst == 0 || denominatorSecond == 0)
                {
                    result.Text = "Бесконечность";
                }
                else
                {
                    RationalNumber r1 = new(numeratorFirst, denominatorFirst);
                    RationalNumber r2 = new(numeratorSecond, denominatorSecond);
                    RationalNumber res = r1 / r2;
                    result.Text = res.ToString();
                }
            }
        }

        private void Normalize(object sender, RoutedEventArgs e)
        {
            if (numerator1.Text == "" || denominator1.Text == "")
            {
                MessageBox.Show("Введите все необходимые данные!");
            }
            else
            {
                long numeratorFirst = Convert.ToInt64(numerator1.Text);
                long denominatorFirst = Convert.ToInt64(denominator1.Text);
                if (denominatorFirst == 0)
                {
                    result.Text = "Бесконечность";
                }
                else
                {
                    RationalNumber r1 = new(numeratorFirst, denominatorFirst);
                    result.Text = r1.ToString();
                }
            }
        }

        private void Compare(object sender, RoutedEventArgs e)
        {
            if (numerator1.Text == "" || denominator1.Text == "" || numerator2.Text == "" || denominator2.Text == "")
            {
                MessageBox.Show("Введите все необходимые данные!");
            }
            else
            {
                long numeratorFirst = Convert.ToInt64(numerator1.Text);
                long denominatorFirst = Convert.ToInt64(denominator1.Text);
                long numeratorSecond = Convert.ToInt64(numerator2.Text);
                long denominatorSecond = Convert.ToInt64(denominator2.Text);
                if (denominatorFirst == 0 || denominatorSecond == 0)
                {
                    result.Text = "Неопределенность";
                }
                else
                {
                    RationalNumber r1 = new(numeratorFirst, denominatorFirst);
                    RationalNumber r2 = new(numeratorSecond, denominatorSecond);
                    result.Text = RationalNumber.Compare(r1, r2);
                }
            }
        }

        private void Convertation(object sender, RoutedEventArgs e)
        {
            if (numerator1.Text == "" || denominator1.Text == "" || amount.Text == "")
            {
                MessageBox.Show("Введите все необходимые данные!");
            }
            else
            {
                long numeratorFirst = Convert.ToInt64(numerator1.Text);
                long denominatorFirst = Convert.ToInt64(denominator1.Text);
                RationalNumber r1 = new(numeratorFirst, denominatorFirst);
                double res = RationalNumber.AsDouble(r1, Convert.ToInt32(amount.Text));
                result.Text = res.ToString();
            }
        }

        private void ConvertationRev(object sender, RoutedEventArgs e)
        {
            if (doubleNum.Text == "" || amount1.Text == "")
            {
                MessageBox.Show("Введите все необходимые данные!");
            }
            else
            {
                double number = Convert.ToDouble(doubleNum.Text);
                RationalNumber res = RationalNumber.AsDecimal(number, Convert.ToInt32(amount1.Text));
                result.Text = res.ToString();
            }
        }
    }
}