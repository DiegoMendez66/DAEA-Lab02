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

namespace WpfApp1
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

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            string contraseñaCorrecta = "12345";
            string usuarioCorrecto = "admin";

            string usuario = txtUsername.Text;
            string contraseña = txtPassword.Password;

            if (contraseña == contraseñaCorrecta && usuario == usuarioCorrecto)
            {
                Window1 window1 = new Window1();
                window1.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Contraseña o usuario incorrecto. Inténtalo de nuevo.");
            }
        }
    }
}
