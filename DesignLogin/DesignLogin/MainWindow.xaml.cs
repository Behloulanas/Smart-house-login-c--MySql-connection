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

namespace DesignLogin
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Btn_Salir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        


        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            string usuario = this.txt_Usuario.Text;
            string password = this.txt_Password.Password;

          
            if(usuario=="" && password == "")
            {
                FormError formError = new FormError();
                formError.lbl_Usuario.Content = "Faltan ingresar datos";
                formError.Show();
            }else
             if(usuario=="fivecod" && password == "123")
            {
                FormBienvenida formBienvenida = new FormBienvenida();
                formBienvenida.lbl_Usuario.Content = usuario;
                formBienvenida.Show();
            }
            else
            {
                FormError formError = new FormError();
                formError.lbl_Usuario.Content = usuario + " " + password;
                formError.Show();
                    }
        }
    }
    
}
