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

namespace Week13Day5Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            List<ToDoItem> toDoItems = new()
            {
                new ToDoItem { Title = "Introduction to WPF", Completion = 40 },
                new ToDoItem { Title = "Learn C#", Completion = 75 },
                new ToDoItem { Title = "Go Shopping", Completion = 0 }
            };

            ItemsControlToDo.ItemsSource = toDoItems;
        }
    }

    public class ToDoItem
    {
        public string Title { get; set; }
        public int Completion { get; set; }
    }
}
