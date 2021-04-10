using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_Memoy___DN
{
    public class GameSettings
    {
        public int CzasGry;
        public int CzasPodgladu;
        public int MaxPunkty;
        public int Wiersze;
        public int Kolumny;
        public int Bok;
        public int AktualnePunkty;

        public string PlikLogo = $@"{AppDomain.CurrentDomain.BaseDirectory}\img\logo.jpg";
        public string FolderObrazki = $@"{AppDomain.CurrentDomain.BaseDirectory}\img\memory";

        public GameSettings()
        {
            UstawStartowe();
        }

        public void UstawStartowe()
        {
            CzasGry = 60;
            CzasPodgladu = 5;
            MaxPunkty = 0;
            Wiersze = 6;
            Kolumny = 4;
            Bok = 150;
            AktualnePunkty = 0;
        }

    }
}
