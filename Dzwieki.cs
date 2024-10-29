using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Dzwieki
    {
        private String wykonawca { get; set; }
        private String tytulAlbum { get; set; }
        private int liczbaUtworow { get; set; }
        private int rokWydania { get; set; }
        private int liczbaPobran { get; set; }

        public Dzwieki(string wykonawca, string tytulAlbum, int liczbaUtworow, int rokWydania, int liczbaPobran)
        {
            this.wykonawca = wykonawca;
            this.tytulAlbum = tytulAlbum;
            this.liczbaUtworow = liczbaUtworow;
            this.rokWydania = rokWydania;
            this.liczbaPobran = liczbaPobran;
        }

        public String getWykonawca()
        {
            return this.wykonawca;
        }

        public String getTytulAlb()
        {
            return this.tytulAlbum;
        }

        public int getliczUt()
        {
            return this.liczbaUtworow;
        }
        public int getRokWyd()
        {
            return this.rokWydania;
        }
        public int getLiczPob()
        {
            return this.liczbaPobran;
        }

        public int setLiczPob(int a)
        {
            this.liczbaPobran += a;
            return this.liczbaPobran;
        }

    }
}
