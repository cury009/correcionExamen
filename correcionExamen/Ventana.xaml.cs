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

namespace correcionExamen
{
    /// <summary>
    /// Lógica de interacción para Ventana.xaml
    /// </summary>
    public partial class Ventana : Window
    {
        public UserHandler userHandler;
        public User user;
        public Ventana(UserHandler userHandler)
        {
            InitializeComponent();
            this.userHandler = userHandler;
            user = new User();
            this.myGrid.DataContext = user;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            userHandler.AddUser(user);
            this.Close();
        }
    }
}
