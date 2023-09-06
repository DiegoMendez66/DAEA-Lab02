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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Ingresos_Click(object sender, RoutedEventArgs e)
        {
            FormIngresos formIngresos = new FormIngresos();
            formIngresos.Show();
            this.Close();
        }

        private void Salidas_Click(object sender, RoutedEventArgs e)
        {
            FormIngresos formIngresos = new FormIngresos();
            formIngresos.Show();
            this.Close();
        }

        private void Conductores_Click(object sender, RoutedEventArgs e)
        {
            FormConductores formConductores = new FormConductores();
            formConductores.Show();
            this.Close();
        }

        private void Reporte_Click(object sender, RoutedEventArgs e)
        {
            Reportes reportes = new Reportes();
            reportes.Show();
            this.Close();
        }
    }
}
