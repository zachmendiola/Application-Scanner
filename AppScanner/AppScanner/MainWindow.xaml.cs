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
using System.IO;

namespace AppScanner
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
        string[] read;
        Dictionary<string, int> words = new Dictionary<string, int>();
        string temp = "";
        string temp1 = "";
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            temp = "";
            foreach (KeyValuePair<string, int> pair in words)
            {
                
                if (pair.Value >= 2)
                {
                    temp1 = pair.ToString();
                    temp = temp + temp1 + "\n";
                }
            }
            Output.Text = temp;
            words.Clear();
        }

        public void Button_Click_1(object sender, RoutedEventArgs e)
        {
            words.Clear();
            Output.Text = "";
            string read1 = Input.Text.ToLower();
            read = read1.Split(" ");
            for (int i = 0; i < read.Length; i++)
            {
                if (words.ContainsKey(read[i]))
                {
                    words[read[i]] += 1;
                }
                if (!words.ContainsKey(read[i]))
                {
                    words.Add(read[i], 1);
                }
            }

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Output_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Input.Text = "";
            Output.Text = "";
        }

    }
}
