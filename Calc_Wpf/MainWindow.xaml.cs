using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Lab4CalcDll;

namespace Calc_Wpf
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
        private void Clear_Box()
        {
            TextBox_1.Clear();
            TextBox_2.Clear();
            Result.Clear();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Result.Text = Calculator.addition(Double.Parse(TextBox_1.Text), Double.Parse(TextBox_2.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Вводите только числа!!!\nДробную часть отделяйте запятой");
                Clear_Box();
            }
        }

        private void Dif_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Result.Text = Calculator.difference(Double.Parse(TextBox_1.Text), Double.Parse(TextBox_2.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Вводите только числа!!!\nДробную часть отделяйте запятой");
                Clear_Box();
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Clear_Box();
        }
    }
}
