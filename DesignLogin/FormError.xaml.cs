using System.Windows;

namespace DesignLogin
{
    /// <summary>
    /// Lógica de interacción para FormError.xaml
    /// </summary>
    public partial class FormError : Window
    {
        public FormError()
        {
            InitializeComponent();
        }

        private void Btn_Salir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
