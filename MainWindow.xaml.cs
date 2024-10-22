using System.IO;
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

namespace dzwieki_egz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Dzwieki> dzwieki = new List<Dzwieki>();
        int licznik_pobran = 0;
        int aktualny = 0;
        public MainWindow()
        {
            InitializeComponent();
            przygDane();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            aktualny--;
            if(aktualny < 0 )
            {
                aktualny = dzwieki.Count - 1;
            }
            wykonawca_name.Text = dzwieki[aktualny].getWykonawca();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        void przygDane()
        {
            StreamReader streamReader = new StreamReader("../../../Data.txt");
            string wykonawca = streamReader.ReadLine(); 
            string tytul = streamReader.ReadLine(); 
            string liczba_ut = streamReader.ReadLine(); 
            string rok_wyd = streamReader.ReadLine(); 
            string liczba_pob = streamReader.ReadLine();
            
            for(int i = 0; i<dzwieki.Count; i++)
            {
                if(streamReader.ReadLine() == null)
                {
                    i++;
                }
                else
                {
                    dzwieki.Add(new Dzwieki(wykonawca,tytul,liczba_ut,rok_wyd,liczba_pob));
                }

                wykonawca = streamReader.ReadLine();
                tytul = streamReader.ReadLine();
                liczba_ut = streamReader.ReadLine();
                rok_wyd = streamReader.ReadLine();
                liczba_pob = streamReader.ReadLine();
            }

            streamReader.Close();
        }

        //zwiększ licznik pobrań po kliknięciu przycisku Pobierz
        //dodaj karuzelę
    }
}