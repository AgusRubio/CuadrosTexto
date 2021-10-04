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

namespace CuadrosTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            NombreTextBox.Tag = AyudaNombreTextBlock;
            ApellidoTextBox.Tag = AyudaApellidoTextBlock;
        }

        private void F1Up(object sender, KeyEventArgs e)
        {
            TextBox texto = (TextBox)sender;
            TextBlock bloque = (TextBlock)texto.Tag;

            if(e.Key == Key.F1 && bloque.Visibility == Visibility.Hidden)
            {
                bloque.Visibility = Visibility.Visible;
            }else bloque.Visibility = Visibility.Hidden;
        }

        private void F2Up(object sender, KeyEventArgs e)
        {
            TextBox texto = (TextBox)sender;
            int numero;

            if(e.Key == Key.F2 && int.TryParse(texto.Text, out numero) == false)
            {
                EdadTextBlock.Text = "No es un numero valido";
                EdadTextBlock.Foreground = Brushes.Red;
            }else
            {
                EdadTextBlock.Text = "";
            }
        }
    }
}
