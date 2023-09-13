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
using System.Windows.Forms.Integration;
using System.Windows.Forms;

namespace UserAutorisation
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WindowsFormsHost _host;
        MaskedTextBox _maskedTextBox;
        public MainWindow()
        {
            InitializeComponent();
        }

      
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            WindowsFormsHost host = new WindowsFormsHost();
            _host = host;
            MaskedTextBox maskedTextBoxPassword = new MaskedTextBox();
            _maskedTextBox = maskedTextBoxPassword;            
            maskedTextBoxPassword.PasswordChar = '*';
            maskedTextBoxPassword.Font = new System.Drawing.Font(System.Drawing.FontFamily.GenericMonospace, 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            maskedTextBoxPassword.Size = new System.Drawing.Size(253, 38);
            maskedTextBoxPassword.BackColor = System.Drawing.Color.OrangeRed;
            host.Child = maskedTextBoxPassword;            
            myGrid.Children.Add(host);
            Grid.SetColumn(host, 2);
            Grid.SetRow(host, 1);
        }

        private void showPassword_Click(object sender, RoutedEventArgs e)
        {
            inputPassword.Text = _maskedTextBox.Text;
        }
              

        private void eye_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            inputPassword.Text = _maskedTextBox.Text;    
            _maskedTextBox.PasswordChar = '\0';
        }

        private void eye_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {            
            _maskedTextBox.PasswordChar = '*';
            inputPassword.Text = "\0";
        }
    }
}
