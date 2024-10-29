using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfApp1
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
            odczytajDane();
            getDane(aktualny);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            licznik_pobran++;
            dzwieki[aktualny].setLiczPob(1);
            getDane(aktualny);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            aktualny++;
            if(aktualny > dzwieki.Count-1)
            {
                aktualny = 0;
            }
            getDane(aktualny);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            aktualny--;
            if (aktualny < 0)
            {
                aktualny = dzwieki.Count - 1;
            }

            getDane(aktualny);
        }

        void getDane(int a)
        {
            wykonawca_name.Text = dzwieki[a].getWykonawca();
            tytul_album.Text = dzwieki[a].getTytulAlb();
            liczba_utw.Text = dzwieki[a].getliczUt().ToString()+" utworów";
            rok_wydania.Text = dzwieki[a].getRokWyd().ToString();
            liczba_pobran.Content = dzwieki[a].getLiczPob().ToString();
        }
        

        void odczytajDane()
        {
            StreamReader streamReader = new StreamReader("../../../Data.txt");
            string wykonawca, tytul;
            int liczba_ut, rok_wyd, liczba_pob;

            while((wykonawca = streamReader.ReadLine()) != null)
            {
                tytul = streamReader.ReadLine();
                liczba_ut = int.Parse(streamReader.ReadLine());
                rok_wyd = int.Parse(streamReader.ReadLine());
                liczba_pob = int.Parse(streamReader.ReadLine());
                streamReader.ReadLine();
                dzwieki.Add(new Dzwieki(wykonawca, tytul, liczba_ut, rok_wyd, liczba_pob));
            }

            streamReader.Close();
        }
    }
}
