using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace basketball
{
    /// <summary>
    /// Логика взаимодействия для message.xaml
    /// </summary>
    public partial class message : Window
    {
        public message()
        {
            InitializeComponent();
        }
        private void close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        public void showMessage(string text, string text2)
        {
            messageText.Text = text;
            messageText2.Text = text2;
        }
    }
}
