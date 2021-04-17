using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gra_Memoy___DN
{
    class MemoryCard : Label
    {
        public Guid Id;
        public Image Tyl;
        public Image Obrazek;

        public MemoryCard(Guid id, string tyl, string obrazek)
        {
            Id = id;
            Tyl = Image.FromFile(tyl);
            Obrazek = Image.FromFile(obrazek);
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        public void Odkryj()
        {
            BackgroundImage = Obrazek;
            Enabled = false;
        }

        public void Zakryj()
        {
            BackgroundImage = Tyl;
            Enabled = true;
        }
    }
}
