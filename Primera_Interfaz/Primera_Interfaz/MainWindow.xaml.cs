using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Primera_Interfaz
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            /*
            // creamos el grid
            Grid grid = new Grid();

            // metemos el grid dentro de la ventana
            this.Content = grid;

            // creamos el button
            Button miBoton = new Button();


            // agregamos el boton al grid
            grid.Children.Add(miBoton);

            WrapPanel miWrap = new WrapPanel();

            TextBlock txt1 = new TextBlock();
            txt1.Text = "Hola";
            txt1.Background = Brushes.Pink;
            miWrap.Children.Add(txt1);

            TextBlock txt2 = new TextBlock();
            txt2.Text = "Mundo";
            txt2.Foreground = Brushes.Pink;
            miWrap.Children.Add(txt2);

            TextBlock txt3 = new TextBlock();
            txt3.Text = "Cruel";
            miWrap.Children.Add(txt3);

            miBoton.Content = (miWrap);

            miBoton.Width = 200;
            miBoton.Height = 80;
            miBoton.Background = Brushes.SlateBlue;
            */


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Console.WriteLine("Saludos desde el button");
            // ventana emergente
            // MessageBox.Show("Le has dado al boton de nuevo!");

            Console.WriteLine("Saludos desde el button");

        }

        private void Panel_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Saludos desde el panel");

        }

        private void Panel_PreviewMouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

            Console.WriteLine("Saludos desde el panel con tunneling");
        }
    }
}
