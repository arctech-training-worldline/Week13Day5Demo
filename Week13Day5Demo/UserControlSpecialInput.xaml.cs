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
using System.Windows.Xps.Serialization;

namespace Week13Day5Demo
{
    /// <summary>
    /// Interaction logic for UserControlSpecialInput.xaml
    /// </summary>
    public partial class UserControlSpecialInput : UserControl
    {
        public bool Multiline
        {
            get => TextBoxInput.AcceptsReturn;
            set
            {
                TextBoxInput.AcceptsReturn = value;
                TextBoxInput.TextWrapping = value ? TextWrapping.Wrap : TextWrapping.NoWrap;
                TextBoxInput.VerticalScrollBarVisibility = value ? ScrollBarVisibility.Visible : ScrollBarVisibility.Hidden;
            }
        }

        public bool IsNumeric { get; set; }
        public string InputLabel { get; set; }
        public int InputMaxLength { get; set; }

        public UserControlSpecialInput()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void TextBoxInput_OnKeyDown(object sender, KeyEventArgs e)
        {
            if (IsNumeric)
            {
                switch (e.Key)
                {
                    case Key.D0 or Key.NumPad0:
                    case Key.D1 or Key.NumPad1:
                    case Key.D2 or Key.NumPad2:
                    case Key.D3 or Key.NumPad3:
                    case Key.D4 or Key.NumPad4:
                    case Key.D5 or Key.NumPad5:
                    case Key.D6 or Key.NumPad6:
                    case Key.D7 or Key.NumPad7:
                    case Key.D8 or Key.NumPad8:
                    case Key.D9 or Key.NumPad9:
                        break;
                    default:
                        e.Handled = true;
                        break;
                }
            }
        }
    }
}
