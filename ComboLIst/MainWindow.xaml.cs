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

namespace ComboLIst
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Button button = new Button();
            button.Content = "gg4";
            comboBox.Items.Add("Hello");
            comboBox.Items.Add("World");
            comboBox.Items.Add("!");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Length == 0) return;
            string newItem = textBox.Text.Trim();
            if (comboBox.Items.Contains(newItem))
            {
                MessageBox.Show("элемент с таким именем уже существует");
                return;
            }
            comboBox.Items.Add(newItem);
            textBox.Text = "";

        }

        private void orty_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text.Length == 0) return;
            {
                textBox.Text = "";
            }

            ComboBox comboBox = sender as ComboBox;
            if (comboBox == null) return;
            {
                comboBox.Items.Clear();
            }
        }
    }
}

