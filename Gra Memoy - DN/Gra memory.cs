using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gra_Memoy___DN
{
    public partial class Form1 : Form
    {
        private GameSettings _settings;

        public Form1()
        {
            InitializeComponent();
            _settings = new GameSettings();
            UstawKontrolki();
            GenerujKarty();

            timerCzasPodgladu.Start();
        }

        private void UstawKontrolki()
        {
            panelKarty.Width = _settings.Bok * _settings.Wiersze;
            panelKarty.Height = _settings.Bok * _settings.Kolumny;
            //Test
            Width = panelKarty.Width + 40;
            Height = panelKarty.Height + 100;
        }
        private void GenerujKarty()
        {
            string[] memories = Directory.GetFiles(_settings.FolderObrazki);

            _settings.MaxPunkty = memories.Length;

            var buttons = new List<MemoryCard>();

            foreach(var img in memories)
            {
                Guid id = Guid.NewGuid();

                var b1 = new MemoryCard(id, _settings.PlikLogo, img);

                buttons.Add(b1);

                var b2 = new MemoryCard(id, _settings.PlikLogo, img);

                buttons.Add(b2);
            }

            Random random = new Random();

            panelKarty.Controls.Clear();

            for(int x =0; x < _settings.Wiersze; x++)
            {
                for(int y = 0; y < _settings.Kolumny; y++)
                {
                    var index = random.Next(0, buttons.Count);

                    var b = buttons[index];

                    int margines = 2;

                    b.Location = new Point((x * _settings.Bok) + (margines * x), (y * _settings.Bok) + (margines * y));

                    b.Width = _settings.Bok;
                    b.Height = _settings.Bok;

                    b.Odkryj();

                    panelKarty.Controls.Add(b);

                    buttons.Remove(b);
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timerCzasPodgladu_Tick(object sender, EventArgs e)
        {
            _settings.CzasPodgladu--;

            lblStartInfo.Text = $"Początek gry za {_settings.CzasPodgladu}";

            if(_settings.CzasPodgladu <= 0)
            {
                lblStartInfo.Visible = false;

                foreach(var konrolka in panelKarty.Controls)
                {
                    MemoryCard card = (MemoryCard)konrolka;

                    card.Zakryj();
                }


                timerCzasPodgladu.Stop();

                timerCzasGry.Start();
            }
        }
    }
}
