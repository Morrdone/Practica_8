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

namespace WpfApp39
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string str = listBox.SelectedItem.ToString();
                listBox.Items.Remove(str);
            }
            catch
            {
                MessageBox.Show("Вы точно выделили элемент для удаления?");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string fio = FIO.Text;
            string databoxx = Number.Text;
            string prboxx = Email.Text;
            string sosboxx = Snils.Text;
            Email.Text = Email.Text.ToLower();
            if (Email.Text.Contains("@") && Email.Text.Contains(".com") || Email.Text.Contains(".ru") || Email.Text.Contains(".net")|| Email.Text.Contains(".yandex")|| Email.Text.Contains(".ua"))
            {
            try
            {
                listBox.Items.Add($"ФИО:{fio}\nНомер телефона: {databoxx}\nПочта: {prboxx}\nСнилс: {sosboxx}");
            }
            catch
            {
                MessageBox.Show("Вы ввели не все элементы");
            }
            }
            else 
            {
                MessageBox.Show("Вы ввели неправильно почту");
            }
        }

        private void Number_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (Number.Text.Length > 11 )
            {
                e.Handled = true;
            }
            else
            {
                MessageBox.Show("Вы не ввели номер");
            }
            if (!Char.IsDigit(e.Text, 0 ))
            {
                e.Handled = true;
            }
        }

        private void Snils_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (Snils.Text.Length > 11)
            {
                e.Handled = true;
            }
            else if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }

        private void FIo_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            char lan = e.Text[0];
            if (lan < 'A' || lan > 'z')
            {
                e.Handled = true;
            }
            else
            {
                MessageBox.Show("Вы не ввели ФИО");
            }
        }
        private void Email_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            char lan1 = e.Text[0];
            if (lan1 < 'А' || lan1 > 'я')
            {
                e.Handled = true;
            }
        }
    }
}
