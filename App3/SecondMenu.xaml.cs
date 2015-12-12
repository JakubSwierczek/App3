using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App3
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SecondMenu : Page
    {
        public SecondMenu()
        {
            this.InitializeComponent();
        }

        private void andButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AND));
        }

        private void orButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(OR));
        }

        private void nandButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(NAND));
        }

        private void norButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(NOR));
        }

        private void notButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(NOT));
        }

        private void xorButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(XOR));
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.GoBack();
        }
    }
}
