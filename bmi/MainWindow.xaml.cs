using System.Reflection.Emit;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace bmi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int liczba;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (wzrost.Text != String.Empty && masa.Text != String.Empty)
            {       
                float m = Int32.Parse(masa.Text.ToString());
                float w = Int32.Parse(wzrost.Text.ToString());
                float wynik = (m / (w*w)) *100*100 ; ///  
                label.Content = "twoje bmi wynosi: "+ wynik;
                if(wynik>= 16 && wynik < 18.5)
                {
                    label1.Content = "Niedowaga";
                    Grid.Background = Brushes.Blue;

                }else if(wynik>=18.5 && wynik < 25)
                {
                    label1.Content = "Normalna waga";
                    Grid.Background = Brushes.Green;
                }
                else if (wynik >= 25 && wynik < 30)
                {
                    label1.Content = "Nadwaga";
                    Grid.Background = Brushes.Orange;
                }
                else if (wynik >= 30 && wynik < 40)
                {
                    label1.Content = "Otyłość";
                    Grid.Background = Brushes.Red;
                }
                else
                {
                   label1.Content = "Nienormalna waga";
                   Grid.Background = Brushes.Gray;
                }
            }
            

        }
    }
}