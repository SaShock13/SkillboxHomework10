using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SkillboxHomework10_1
{
    internal class Client: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; OnPropertyChanged("LastName"); }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged("Name"); }
        }

        private string surName;

        public string SurName
        {
            get { return surName; }
            set { surName = value; OnPropertyChanged("SurName"); }
        }
        private long phoneNumber;

        public long PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; OnPropertyChanged("PhoneNumber"); }
        }
        private string passport;

        public string Passport
        {
            get 
            { return passport;
            }
            set { passport = value; OnPropertyChanged("Passport"); }
        }
       
        public Client()
        {
            LastName = "Иванов";
            Name = "Иван";
            SurName = "Иванович";
            PhoneNumber = 777777;
            Passport = "3605-487856";
        }
        public Client(string lastName, string name, string surName, long phoneNumber, string passport)
        {
            LastName = lastName;
            Name = name;
            SurName = surName;
            PhoneNumber = phoneNumber;
            Passport = passport;
            
        }


        public override string ToString()
        {
            return $"{LastName} {Name} {SurName} , телефон: {PhoneNumber}, паспотные данные: {Passport}";
        }
    }
}