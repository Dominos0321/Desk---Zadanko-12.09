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

namespace Zadanie
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(text1.Text!="")
            {
                string x = text1.Text;

                if (float.TryParse(x ,out float bok))
                {
                    if (bok>0)
                    {
                        text2.Text = (bok * bok).ToString();
                        text3.Text = (bok * 4).ToString();
                    }
                }
            }

            else if(text1.Text =="")
            {
                text2.Text = "";
                text3.Text = "";
            }
        }

        private void text2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            text1.Text = "";
            text2.Text = "";
            text3.Text = "";
        }

        private void text3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
