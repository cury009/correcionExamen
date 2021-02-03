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
            if(Validation())
            {
                userHandler.AddUser(user);
                this.Close();
            }
            

        }

        private bool Validation()
        {
            bool validation = true;

            foreach(UIElement element in myGrid.Children)
            {
                if(element is TextBox)
                {
                    TextBox textbox = (TextBox)element;
                    if(textbox.Text.Equals(""))
                    {
                        textbox.BorderBrush = new SolidColorBrush(Colors.Red);
                        validation = false;
                    }
                    else
                    {
                        textbox.BorderBrush = new SolidColorBrush(Colors.LightGray);
                    }
                }
            }

            return validation;
        }
    }
}
