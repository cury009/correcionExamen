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

namespace correcionExamen
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public User user;
        public UserHandler userHandler = new UserHandler();
        public MainWindow()
        {
            InitializeComponent();
            myCombo.DataContext = userHandler;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Ventana ventana = new Ventana(userHandler);
            ventana.Show();
        }

        private void myCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            user = (User)myCombo.SelectedItem;
            userGrid.DataContext = user;
        }
    }
}
