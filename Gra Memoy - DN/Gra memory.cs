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
        }

        private void UstawKontrolki()
        {
            panelKarty.Width = _settings.Bok * _settings.Kolumny;
            panelKarty.Height = _settings.Bok * _settings.Wiersze;

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
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
