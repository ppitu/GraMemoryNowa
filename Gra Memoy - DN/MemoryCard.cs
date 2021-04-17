using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_Memoy___DN
{
    class MemoryCard : System.Windows.Forms.Label
    {
        public Guid Id;
        public string Tyl;
        public string Obrazek;

        public MemoryCard(Guid id, string tyl, string obrazek)
        {
            Id = id;
            Tyl = tyl;
            Obrazek = obrazek;
        }

        public void Odkryj()
        {
            //BackgroundImage = Obrazek;
            Enabled = false;
        }

        public void Zakryj()
        {
            //BackgroundImage = Tyl;
            Text = Tyl;
            Enabled = true;
        }
    }
}
