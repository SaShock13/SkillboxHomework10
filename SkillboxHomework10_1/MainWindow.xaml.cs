using SkillboxHomework10_1.BankWorkers;
using SkillboxHomework10_1;
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



//Удаление Консультантом выкидывает
//

namespace SkillboxHomework10_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Consultant consultant;
        BankWorker bankWorker;
        IEditClientData workerEditMode;
        string info = "dsfdsdfsd";
       
        public MainWindow()
        {
            AccessWindow accessWindow = new AccessWindow(); //Создание и Запуск окна выбора Прав доступа
            accessWindow.ShowDialog();

            InitializeComponent();

            if (accessWindow.DialogResult == true) // Инициализация нужных типов и настройка окна
            {
                if (!accessWindow.isManager)
                {
                    bankWorker = new Consultant();
                    workerEditMode = new Consultant();
                    mainWindow.Title = "Консультант";
                    passportColumn.Visibility = Visibility.Hidden;
                    dgClientsList.ItemsSource = (bankWorker as Consultant).Clients;
                }
                else
                { 
                    bankWorker = new Manager();
                    workerEditMode = new Manager();
                    mainWindow.Title = "Менеджер";
                    dgClientsList.ItemsSource = (bankWorker as Manager).Clients;
                }

            }

           
        }

        private void SaveBtnClick(object sender, RoutedEventArgs e)
        {
            bankWorker.SaveToFile();
        }

        private void ChangeBtnClick(object sender, RoutedEventArgs e)
        {

           workerEditMode.EditClientData(dgClientsList.SelectedItem as Client);

            bankWorker.SaveToFile();
        }
        private void AddBtnClick(object sender, RoutedEventArgs e)
        {
            
            if (bankWorker is Manager)
            {
                AddClientWindow addClientWindow = new AddClientWindow();
                addClientWindow.ShowDialog();
                (bankWorker as Manager).Clients.Add(addClientWindow.client);
               
                
            }
        }
        private void DeleteBtnClick(object sender, RoutedEventArgs e)
        {
            if (bankWorker is Manager)
            {
                (bankWorker as Manager).DeleteClient(dgClientsList.SelectedItem as Client);
                
            }
        }

        private void dgClientsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgClientsList.SelectedIndex!=-1)
            {
                Client client = dgClientsList.SelectedItem as Client;

                tbInfo.Text = client.ChangeInfo;
            }
            

        }
    }
}
