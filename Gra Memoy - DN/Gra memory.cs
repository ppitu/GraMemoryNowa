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

        MemoryCard _pierwsza = null;
        MemoryCard _druga = null;

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
            lblPunkty.Text = "0";
            lblCzasGry.Text = "60";

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

                    b.Click += BtnClicked;

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
            lblStartInfo.Visible = true;
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

                panelKarty.Enabled = true;

                timerCzasPodgladu.Stop();

                timerCzasGry.Start();
            }
        }

        private void BtnClicked(object sender, EventArgs e)
        {
            MemoryCard btn = (MemoryCard)sender;


            if (_pierwsza == null)
            {
                _pierwsza = btn;

                _pierwsza.Odkryj();
            }else
            {
                _druga = btn;

                _druga.Odkryj();

                panelKarty.Enabled = false;

                if (_pierwsza.Id == _druga.Id)
                {
                    _settings.AktualnePunkty++;

                    lblPunkty.Text = _settings.AktualnePunkty.ToString();

                    _pierwsza = null;
                    _druga = null;

                    panelKarty.Enabled = true;

                }
                else
                {
                    timerZakrywacz.Start();
                }
            }


        }

        private void timerZakrywacz_Tick(object sender, EventArgs e)
        {
            _pierwsza.Zakryj();
            _druga.Zakryj();

            _pierwsza = null;
            _druga = null;

            panelKarty.Enabled = true;

            timerZakrywacz.Stop();
        }

        private void timerCzasGry_Tick(object sender, EventArgs e)
        {
            _settings.CzasGry--;

            lblCzasGry.Text = _settings.CzasGry.ToString();

            if(_settings.CzasGry <= 0 || _settings.MaxPunkty == _settings.AktualnePunkty)
            {
                timerCzasGry.Stop();
                timerZakrywacz.Stop();

                var yesNo = MessageBox.Show($"Zdobyte punkty: {_settings.AktualnePunkty}. Grasz dalej?",
                    "Koniec Gry", MessageBoxButtons.YesNo);

                if(yesNo == DialogResult.Yes)
                {
                    _settings.UstawStartowe();

                    GenerujKarty();
                    UstawKontrolki();

                    timerCzasPodgladu.Start();
                } else
                {
                    Application.Exit();
                }

            }
        }
    }
}
