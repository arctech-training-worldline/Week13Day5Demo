using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Interaction logic for WindowStaDemo.xaml
    /// </summary>
    public partial class WindowStaDemo : Window
    {
        public WindowStaDemo()
        {
            InitializeComponent();
        }

        private void WindowStaDemo_OnLoaded(object sender, RoutedEventArgs e)
        {
            var thread = new Thread(DoSomeWorkWithInvoke);
            thread.Start();
        }

        private void DoSomeWorkWithInvoke()
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            do
            {
                var elapsedSeconds = stopWatch.Elapsed.Seconds;

                //ButtonTest.Content = $"This is not clicked yet since {elapsedSeconds} seconds" // Not allowed
                Dispatcher.Invoke(() =>
                {
                    ButtonTest.FontSize++;
                    ButtonTest.Content = $"This is not clicked yet since {elapsedSeconds} seconds";
                });

                //Dispatcher.BeginInvoke((Action)(() =>
                //{
                //    ButtonTest.FontSize++;
                //    ButtonTest.Content = $"This is not clicked yet since {elapsedSeconds} seconds";
                //}));

                Thread.Sleep(1000);

            } while (true);
        }
    }
}
