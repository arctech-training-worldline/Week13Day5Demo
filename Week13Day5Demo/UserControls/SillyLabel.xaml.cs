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

namespace Week13Day5Demo.UserControls
{
    /// <summary>
    /// Interaction logic for SillyLabel.xaml
    /// </summary>
    public partial class SillyLabel : UserControl
    {
        public string Text { get; set; }

        public Brush DrawingColor { get; set; }

        public Brush FillColor { get; set; }

        public SillyLabel()
        {
            InitializeComponent();
            DataContext = this;
        }
    }
}
