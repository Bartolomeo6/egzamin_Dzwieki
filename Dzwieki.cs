using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dzwieki_egz
{
    public class Dzwieki
    {
        private String wykonawca;
        private String tytulAlbum;
        private String liczbaUtworow;
        private String rokWydania;
        private String liczbaPobran;

        public Dzwieki(string wykonawca, string tytulAlbum, String liczbaUtworow, String rokWydania, String liczbaPobran)
        {
            this.wykonawca = wykonawca;
            this.tytulAlbum = tytulAlbum;
            this.liczbaUtworow = liczbaUtworow;
            this.rokWydania = rokWydania;
            this.liczbaPobran = liczbaPobran;
        }

    }
}
