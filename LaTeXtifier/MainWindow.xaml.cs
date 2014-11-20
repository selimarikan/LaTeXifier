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

namespace LaTeXtifier
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

        string plainText, latexText;
        char[] plainTextArray;
        List<char> charlist = new List<char>();

        private void Window_MouseEnter(object sender, MouseEventArgs e)
        {
            
        }

        private void Window_MouseLeave(object sender, MouseEventArgs e)
        {
            
        }

        private void Donustur_Click(object sender, RoutedEventArgs e)
        {
            if (tbDuz.Text != "")
            {
                plainText = tbDuz.Text;
                plainTextArray = new char[plainText.Length];
                plainTextArray = plainText.ToCharArray();
                charlist = plainTextArray.ToList();
                
                for (int i = 0; i < charlist.Count(); i++)
                {
                    if (charlist[i] == 231) // ç
                    {
                        charlist.RemoveAt(i);
                        charlist.Insert(i, '\\');
                        charlist.Insert(i+1, 'c');
                        charlist.Insert(i+2, '{');
                        charlist.Insert(i+3, 'c');
                        charlist.Insert(i+4, '}');
                    }

                    if (charlist[i] == 305) // ı
                    {
                        charlist.RemoveAt(i); //{\i}
                        charlist.Insert(i, '{');
                        charlist.Insert(i + 1, '\\');
                        charlist.Insert(i + 2, 'i');
                        charlist.Insert(i + 3, '}');
                    }

                    if (charlist[i] == 287) // ğ
                    {
                        charlist.RemoveAt(i);
                        charlist.Insert(i, '\\');
                        charlist.Insert(i + 1, 'u');
                        charlist.Insert(i + 2, '{');
                        charlist.Insert(i + 3, 'g');
                        charlist.Insert(i + 4, '}');
                    }

                    if (charlist[i] == 252) // ü
                    {
                        charlist.RemoveAt(i);
                        charlist.Insert(i, '\\');
                        charlist.Insert(i + 1, '"');
                        charlist.Insert(i + 2, '{');
                        charlist.Insert(i + 3, 'u');
                        charlist.Insert(i + 4, '}');
                    }

                    if (charlist[i] == 246) // ö
                    {
                        charlist.RemoveAt(i);
                        charlist.Insert(i, '\\');
                        charlist.Insert(i + 1, '"');
                        charlist.Insert(i + 2, '{');
                        charlist.Insert(i + 3, 'o');
                        charlist.Insert(i + 4, '}');
                    }

                    if (charlist[i] == 351) // ş
                    {
                        charlist.RemoveAt(i);
                        charlist.Insert(i, '\\');
                        charlist.Insert(i + 1, 'c');
                        charlist.Insert(i + 2, '{');
                        charlist.Insert(i + 3, 's');
                        charlist.Insert(i + 4, '}');
                    }

                    if (charlist[i] == 199) // Ç
                    {
                        charlist.RemoveAt(i);
                        charlist.Insert(i, '\\');
                        charlist.Insert(i + 1, 'c');
                        charlist.Insert(i + 2, '{');
                        charlist.Insert(i + 3, 'C');
                        charlist.Insert(i + 4, '}');
                    }

                    if (charlist[i] == 304) // İ
                    {
                        charlist.RemoveAt(i);
                        charlist.Insert(i, '\\');
                        charlist.Insert(i + 1, '.');
                        charlist.Insert(i + 2, '{');
                        charlist.Insert(i + 3, 'I');
                        charlist.Insert(i + 4, '}');
                    }

                    if (charlist[i] == 286) // Ğ
                    {
                        charlist.RemoveAt(i);
                        charlist.Insert(i, '\\');
                        charlist.Insert(i + 1, 'u');
                        charlist.Insert(i + 2, '{');
                        charlist.Insert(i + 3, 'G');
                        charlist.Insert(i + 4, '}');
                    }

                    if (charlist[i] == 220) // Ü
                    {
                        charlist.RemoveAt(i);
                        charlist.Insert(i, '\\');
                        charlist.Insert(i + 1, '"');
                        charlist.Insert(i + 2, '{');
                        charlist.Insert(i + 3, 'U');
                        charlist.Insert(i + 4, '}');
                    }

                    if (charlist[i] == 214) // Ü
                    {
                        charlist.RemoveAt(i);
                        charlist.Insert(i, '\\');
                        charlist.Insert(i + 1, '"');
                        charlist.Insert(i + 2, '{');
                        charlist.Insert(i + 3, 'O');
                        charlist.Insert(i + 4, '}');
                    }

                    if (charlist[i] == 350) // ş
                    {
                        charlist.RemoveAt(i);
                        charlist.Insert(i, '\\');
                        charlist.Insert(i + 1, 'c');
                        charlist.Insert(i + 2, '{');
                        charlist.Insert(i + 3, 'S');
                        charlist.Insert(i + 4, '}');
                    }
                }
                latexText = string.Join("", charlist.ToArray());
                tbLatex.Text = latexText;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }

       
    }
}
