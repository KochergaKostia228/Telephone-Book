using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Телефонна_книга.Новая_папка;

namespace Телефонна_книга.DoMain
{
    public class ListUsers : INotifyPropertyChanged
    {
        public List<User>? users = null;
        private User selectedUser;

        public User SelectedUser
        {
            get { return selectedUser; }
            set
            {
                selectedUser = value;
                OnPropertyChanged("User");
            }
        }

        public ListUsers()
        {
            users = new List<User>();
        }

        public void AddUser(User user)
        {
            users?.Add(user);
        }

        public void RemoveUsers(User user)
        {
            users?.Remove(user);

        }

        public void RemoveUsers(int it)
        {
            users?.RemoveAt(it);

        }

        public void RemoveAllUsers()
        {
            users?.Clear();

        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
