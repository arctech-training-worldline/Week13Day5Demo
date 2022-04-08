using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
using Week13Day5Demo.Annotations;
using Week13Day5Demo.BusinessLogic;

namespace Week13Day5Demo
{
    /// <summary>
    /// Interaction logic for WindowBank.xaml
    /// </summary>
    public partial class WindowBank : Window, INotifyPropertyChanged
    {
        public double Principle { get; set; }
        public int NoOfMonths { get; set; }
        //public int NoOfYears { get; set; }
        public double RateOfInterest { get; set; }

        public int SimpleInterest { get; set; }

        public int Emi { get; set; }

        public WindowBank()
        {
            InitializeComponent();

            DataContext = this;

            Principle = 100000;
            NoOfMonths = 36;
            //NoOfYears = 3;
            RateOfInterest = 18.5;
        }

        private void ButtonSimpleInterest_OnClick(object sender, RoutedEventArgs e)
        {
            var interestService = new InterestService();
            SimpleInterest = interestService.SimpleInterest(Principle, NoOfMonths, RateOfInterest);
            //SimpleInterest = interestService.SimpleInterest(Principle, NoOfYears, RateOfInterest);
            Emi = 0;

            OnPropertyChanged(nameof(SimpleInterest));
            OnPropertyChanged(nameof(Emi));
        }

        private void ButtonEmi_OnClick(object sender, RoutedEventArgs e)
        {
            var interestService = new InterestService();
            Emi = interestService.GetEmi(Principle, NoOfMonths, RateOfInterest);
            //Emi = interestService.GetEmi(Principle, NoOfYears, RateOfInterest);
            SimpleInterest = 0;

            OnPropertyChanged(nameof(SimpleInterest));
            OnPropertyChanged(nameof(Emi));
        }

        #region INotifyPropertyChanged Methods
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
