using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App9
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
                                    
        }

       
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
            var b = (Button) sender;
            if (b.Content != null) tvWynik.Text += b.Content.ToString();
        }

        private void Result_click(object sender, RoutedEventArgs e)
        {
            try
            {
                Result();
            }
            catch (Exception)
            {
                obokWyniku.Text = "Błąd!!";
            }
        }

        private void Result()
        {
            int iOp = 0;
            if (tvWynik.Text.Contains("+"))
            {
                iOp = tvWynik.Text.IndexOf("+");
            }
            else if (tvWynik.Text.Contains("-"))
            {
                iOp = tvWynik.Text.IndexOf("-");
            }
            else if (tvWynik.Text.Contains("*"))
            {
                iOp = tvWynik.Text.IndexOf("*");
            }
            else if (tvWynik.Text.Contains("/"))
            {
                iOp = tvWynik.Text.IndexOf("/");
            }

            string op = tvWynik.Text.Substring(iOp, 1);
            double op1 = Convert.ToDouble(tvWynik.Text.Substring(0, iOp));
            double op2 = Convert.ToDouble(tvWynik.Text.Substring(iOp + 1, tvWynik.Text.Length - iOp - 1));

            if (op == "+")
            {
                tvWynik.Text += "=" + (op1 + op2);
            }
            else if (op == "-")
            {
                tvWynik.Text += "=" + (op1 - op2);
            }
            else if (op == "*")
            {
                tvWynik.Text += "=" + (op1 * op2);
            }
            else if (op == "/")
            {
                tvWynik.Text += "=" + (op1/op2);
            }
        }

        private void bclean_Click(object sender, RoutedEventArgs e)
        {
            tvWynik.Text = "";
        }

/*
        private void R_click(object sender, RoutedEventArgs e)
        {
            if (tvWynik.Text.Length > 0)
            {
                tvWynik.Text = tvWynik.Text.Substring(0, tvWynik.Text.Length - 1);
            }
        }
*/

    }
}
