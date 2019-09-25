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

namespace Calculadora
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            operador1TextBox.Text = "0";
            operador2TextBox.Text = "0";
            resultadoTextBox.Text = "0";
            sumaRadioButton.IsChecked = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (divisonRadioButton.IsChecked == true && operador1TextBox.Text == "0" && operador2TextBox.Text == "0")
                resultadoTextBox.Text = "Error";
        }

        private void ResultadoTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Operador1TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            double resultado = 0;

            if (sumaRadioButton.IsChecked == true && operador1TextBox.Text != "" && operador2TextBox.Text != "")
                resultado = double.Parse(operador1TextBox.Text) + double.Parse(operador2TextBox.Text);


            resultadoTextBox.Text = resultado.ToString();
        }
    }
}
