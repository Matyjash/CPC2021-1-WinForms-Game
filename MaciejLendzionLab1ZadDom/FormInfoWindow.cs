using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaciejLendzionLab1ZadDom
{
    public partial class FormInfoWindow : Form
    {

        public FormInfoWindow()
        { 
            InitializeComponent();
        }

        /// <summary>
        /// Przycisk zamykajacy okno i sprzedacjacy rybe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSell_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// metoda ładująca dane o rybie z odpowiedniego obiektu
        /// </summary>
        public void loadInfo(Fish fish)
        {
            labelWeight.Text = "Waga: " + fish.getWeight().ToString()+" kg";
            labelType.Text = "Gatunek: " + fish.getName().ToString();
            labelSize.Text = "Rozmiar: " + fish.getSize().ToString()+" cm";
            labelPrice.Text = "Cena: " + fish.getPrice().ToString()+" $";
        }

    }
}
