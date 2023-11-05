using System;
using Телефонна_книга.DoMain;
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
using Телефонна_книга.Новая_папка;

namespace Телефонна_книга
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ListUsers list;

        public MainWindow()
        {
            list = new ListUsers();
            
            InitializeComponent();
            list.AddUser(new Новая_папка.User("https://www.w3schools.com/w3images/avatar2.png", "rgbfvedc", "tbgrvf", "ntbgrvf"));
            list.AddUser(new Новая_папка.User("https://www.w3schools.com/w3images/avatar2.png", "rgbfvedc", "tbgrvf", "ntbgrvf"));
            list.AddUser(new Новая_папка.User("https://www.w3schools.com/w3images/avatar2.png", "rgbfvedc", "tbgrvf", "ntbgrvf"));
            list.AddUser(new Новая_папка.User("https://www.w3schools.com/w3images/avatar2.png", "rgbfvedc", "tbgrvf", "ntbgrvf"));
            list.AddUser(new Новая_папка.User("https://www.w3schools.com/w3images/avatar2.png", "rgbfvedc", "tbgrvf", "ntbgrvf"));
            list.AddUser(new Новая_папка.User("https://www.w3schools.com/w3images/avatar2.png", "rgbfvedc", "tbgrvf", "ntbgrvf"));
            list.AddUser(new Новая_папка.User("https://www.w3schools.com/w3images/avatar2.png", "rgbfvedc", "tbgrvf", "ntbgrvf"));
            list.AddUser(new Новая_папка.User("https://www.w3schools.com/w3images/avatar2.png", "rgbfvedc", "tbgrvf", "ntbgrvf"));
            list.AddUser(new Новая_папка.User("https://www.w3schools.com/w3images/avatar2.png", "rgbfvedc", "tbgrvf", "ntbgrvf"));
            list.AddUser(new Новая_папка.User("https://www.w3schools.com/w3images/avatar2.png", "rgbfvedc", "tbgrvf", "ntbgrvf"));
            list.AddUser(new Новая_папка.User("https://www.w3schools.com/w3images/avatar2.png", "rgbfvedc", "tbgrvf", "ntbgrvf"));
            list.AddUser(new Новая_папка.User("https://www.w3schools.com/w3images/avatar2.png", "rgbfvedc", "tbgrvf", "ntbgrvf"));
            LVMain.ItemsSource = list.users;
        }

        public void StackPanel_MouseDown(object sender, MouseEventArgs e)
        {
            var user = (sender as StackPanel).DataContext as User;
            MessageBox.Show(user.Name + " " + user.Phone + " " + user.Adress);
            MainWindow mainWindow = new MainWindow();
        }
    }
}
