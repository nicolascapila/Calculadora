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

namespace calculadora
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        int primeiro;
        int segundo;
        
        char op;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            TxtResut.Text += btn.Content.ToString();
            segundo = Int32.Parse(TxtResut.Text);

        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            primeiro = Int32.Parse(TxtResut.Text);
            op = '/';
            TxtResut.Clear();
        }

        private void Multiplica_Click(object sender, RoutedEventArgs e)
        {
            primeiro = Int32.Parse(TxtResut.Text);
            op = '*';
            TxtResut.Clear();
        }
        private void add_Click(object sender, RoutedEventArgs e)
        {
            primeiro = Int32.Parse(TxtResut.Text);
            op = '-';
            TxtResut.Clear();
        }

        private void Adcao_Click(object sender, RoutedEventArgs e)
        {
            primeiro = Int32.Parse(TxtResut.Text);
            op = '+';
            TxtResut.Clear();
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            segundo = Int32.Parse(TxtResut.Text);
            int resultado = 0;

            if(op == '+')
            {
                resultado = primeiro + segundo;
            }
            else if (op == '-')
            {
                resultado = primeiro - segundo;
            }
            else if (op == '*')
            {
                resultado = primeiro * segundo;
            }
            else if (op == '/')
            {
                resultado = primeiro / segundo;
            }
            if(TxtResut.Text == "0")
            {
                TxtResut.Clear();
            }
            TxtResut.Text = resultado.ToString();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            TxtResut.Clear();
        }
    }
}
