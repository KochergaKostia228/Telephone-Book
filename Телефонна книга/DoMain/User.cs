using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Телефонна_книга.Новая_папка
{
    public class User : INotifyPropertyChanged
    {
        private string ?_photo;
        private string ?_name;
        private string ?_adress;
        private string ?_phone;

        public string? Phone
        {
            get => _phone;
            set
            {
                _phone = value;
                OnPropertyChanged("Phone");
            }
        }

        public string? Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        public string? Photo
        {
            get { return _photo; }
            set
            {
                _photo = value;
                OnPropertyChanged("Photo");
            }
        }

        public string? Adress
        {
            get { return _adress; }
            set
            {
                _adress = value;
                OnPropertyChanged("Adress");
            }
        }

        public User(string? photo, string? name, string? adress, string? phone)
        {
            Photo = photo;
            Name = name;
            Adress = adress;
            Phone = phone;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
