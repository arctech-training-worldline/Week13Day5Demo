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
using System.Windows.Shapes;

namespace Week13Day5Demo
{
    /// <summary>
    /// Interaction logic for WindowUserControlDemo.xaml
    /// </summary>
    public partial class WindowUserControlDemo : Window
    {
        //public string InputLabel { get; set; } = "Enter Name";
        //public int InputMaxLength { get; set; } = 20;

        //public string InputLabelAge { get; set; } = "Enter Age";
        //public int InputMaxLengthAge { get; set; } = 3;

        public WindowUserControlDemo()
        {
            InitializeComponent();
            //DataContext = this;
        }
    }
}
