using System.Windows;

namespace DesignLogin
{
    /// <summary>
    /// Lógica de interacción para FormBienvenida.xaml
    /// </summary>
    public partial class FormBienvenida : Window
    {
        public FormBienvenida()
        {
            InitializeComponent();
        }

        private void Btn_Salir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //btnLogin

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("hello ");
        }


    }
}
