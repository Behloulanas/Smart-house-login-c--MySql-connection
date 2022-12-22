using MySql.Data.MySqlClient;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using MessageBox = System.Windows.Forms.MessageBox;

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
            string password = txt_Password.Password;


            if (usuario == "" && password == "")
            {
                FormError formError = new FormError();
                formError.lbl_Usuario.Content = "Missing data entry";
                formError.Show();
            }
            else
            {
                MySqlConnection con = new MySqlConnection("datasource= localhost; database=smarthouse;port=3306; username = root; password="); //open connection
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from persons where user = '" + txt_Usuario.Text + "' AND pass = '" + txt_Password.Password + "'", con);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    FormBienvenida formBienvenida = new FormBienvenida();
                    formBienvenida.lbl_Usuario.Content = usuario;
                    //formBienvenida.Show();
                    Form1 f1 = new Form1();
                    f1.Show();
                }
                else
                {
                    MessageBox.Show("Username And Password Not Match!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }

}
