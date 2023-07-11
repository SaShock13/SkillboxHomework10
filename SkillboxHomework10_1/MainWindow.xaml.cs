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

namespace SkillboxHomework10_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Consultant consultant;
        enum accessMode
        { 
            Consultant,
            Manager
        }
        
        public MainWindow()
        {
            InitializeComponent();
            consultant = new Consultant();

            dgClientsList.ItemsSource = consultant.Clients;
            passportColumn.Visibility = Visibility.Hidden;
            MessageBox.Show(accessMode.Consultant.ToString() ) ;
        }

        private void SaveBtnClick(object sender, RoutedEventArgs e)
        {
            consultant.SaveToFile();
        }

        private void ChangeBtnClick(object sender, RoutedEventArgs e)
        {
            
            Client man = dgClientsList.SelectedItem as Client;
            int index = dgClientsList.SelectedIndex;
            if (man != null)
            {
                EditWindow editWindow = new EditWindow();
                editWindow.tbLastName.Text = man.LastName;
                editWindow.tbName.Text = man.Name;
                editWindow.tbSurName.Text = man.SurName;
                editWindow.tbPhone.Text = man.PhoneNumber.ToString();
                editWindow.tbPassport.Text = "****-******";
                editWindow.ShowDialog();
                if (editWindow.DialogResult == true)
                {
                    consultant.Clients[index].PhoneNumber = int.Parse(editWindow.tbPhone.Text);
                    MessageBox.Show("Данные изменены!");
                    consultant.SaveToFile();
                }
            }
        }
    }
}
