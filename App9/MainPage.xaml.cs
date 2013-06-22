using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

namespace App9
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
                                    
        }

        private double num1;
        private double num2;
        private string cal;
        private bool inputstatus = true;
        

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (inputstatus)
            {
                tvWynik.Text += b1.Content;
            }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (inputstatus)
            {
                tvWynik.Text += b2.Content;
            }
           
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            if (inputstatus)
            {
                tvWynik.Text += b3.Content;
            }
        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            if (inputstatus)
            {
                tvWynik.Text += b4.Content;
            }
        }
        private void b5_Click(object sender, RoutedEventArgs e)
        {
            if (inputstatus)
            {
                tvWynik.Text += b5.Content;
            }
        }
        private void b6_Click(object sender, RoutedEventArgs e)
        {
            if (inputstatus)
            {
                tvWynik.Text += b6.Content;
            }
        }
        private void b7_Click(object sender, RoutedEventArgs e)
        {
            if (inputstatus)
            {
                tvWynik.Text += b7.Content;
            }
        }
        private void b8_Click(object sender, RoutedEventArgs e)
        {
            if (inputstatus)
            {
                tvWynik.Text += b8.Content;
            }
        }
        private void b9_Click(object sender, RoutedEventArgs e)
        {
            if (inputstatus)
            {
                tvWynik.Text += b9.Content;
            }
        }
        private void b0_Click(object sender, RoutedEventArgs e)
        {
            if (inputstatus)
            {
                tvWynik.Text += b0.Content;
            }
        }

        private void bclean_Click(object sender, RoutedEventArgs e)
        {
            tvWynik.Text = "";
        }

        private void b0_Click_1(object sender, RoutedEventArgs e)
        {
            tvWynik.Text += b0.Content;
        }

        private void bplus_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
