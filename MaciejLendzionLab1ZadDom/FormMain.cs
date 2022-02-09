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
    public partial class FormMain : Form
    {
        //obiekt reprezentujacy gracza i jego statystyki wlacznie z ekwipunkiem
        Player player = new Player();
        //obiekt wykorzystywny do losowania zdarzen
        CatchEvent catchEvent = new CatchEvent();
        //obiekt przechowujacy ceny przedmiotow i aktualizujacy je
        Shop shop = new Shop();
        //obiekt przechowujący ceny ulepszeń i aktualizujący je
        Upgrades upgrades = new Upgrades();
        //czy jest zarzucona wędka
        bool fishing = false;
        //czy została rzucona zanęta
        bool isBaitCasted = false;
        //okno pokazujące dane na temat złapanej ryby
        FormInfoWindow infoWindow;                  
        /// <summary>
        /// Konstruktor okna, inicjalizuje komponentu, ładuje etykiety i tło, włącza timer
        /// </summary>
        public FormMain()
        {
            InitializeComponent(); 
            //włączamy zegar
            timer1.Start();
            //aktualizujemy dane etykiet
            updateLabels();
            //ładujemy tlo
            this.BackgroundImage = Properties.Resources.background2;
        }

        /// <summary>
        /// Instrukcje wykonywane co 1 cykl zegara
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            //jeżeli gracz zarzucił wędkę
            if (fishing)
            {
                //jeżeli złapano rybe
                if (catchEvent.tryToCatchFish(player, isBaitCasted))
                {
                    //jeżeli ryba nie uciekła
                    if (!catchEvent.fishSlippedOut(player))
                    {
                        //Tworzymy obiekt ryby
                        Fish fish = new Fish(player);
                        //Wedka nie jest już zarzucona
                        fishing = false;
                        //Resetujemy stan przynęty
                        isBaitCasted = false;
                        //Okno pokazujące informacje o rybie
                        infoWindow = new FormInfoWindow();
                        //ładujemy dane do okna
                        infoWindow.loadInfo(fish);
                        //pokazujemy okno
                        infoWindow.Show();
                        //dodajemy graczowi pieniadze pozyskane ze sprzedaży ryby
                        player.addMoney(fish.getPrice());
                        //aktualizujemy etykiety
                        updateLabels();
                    }
                    //jeżeli ryba uciekła
                    else
                    {
                        //resetujemy stan przynety
                        isBaitCasted = false;
                        //Wędka nie jest już zarzucona
                        fishing = false;
                        //Wyświetlamy indormację w oknie
                        MessageBox.Show("Ryba uciekła przy brzegu gdy próbowałeś ją wyciągnąć!");
                    }
                    //zmieniamy tło sugerujące że wędka nie jest zarzucona
                    this.BackgroundImage = Properties.Resources.background2;
                }
                //jeżeli żyłka zostala przerwana
                else if (catchEvent.wasLineDestroyed(player))
                {
                    //Wędka nie jest już zarzucona
                    fishing = false;
                    //dekrementujemy ilość haczykow w ekwipunku
                    player.equipment.decreaseHookNumber();
                    //dekrementujemy ilość żyłek w ekwipunku
                    player.equipment.decreaseLineNumber();
                    //dekrementujemy ilość robaków w ekwipunku
                    player.equipment.decreaseWormNumber();
                    //wyświetlamy informację
                    MessageBox.Show("Zerwała się żyłka i wszystko co na niej było!");
                    //aktualizujem stan przynęty
                    isBaitCasted = false;
                    //aktualizujemy etykiety
                    updateLabels();
                    //zmieniamy tło sugerujące że wędka nie jest zarzucona
                    this.BackgroundImage = Properties.Resources.background2;
                }
            }

        }
        /// <summary>
        /// Aktualizacja etykiet i napisów na przyciskach
        /// </summary>
        private void updateLabels()
        {
            //przypisanie etykietom poziomów ulepszeń odpowiednich wartości
            buttonWormUpgrade.Text = player.getWormLvl().ToString();                 
            buttonHookUpgrade.Text = player.getHookLvl().ToString();
            buttonLineUpgrade.Text = player.getLineLvl().ToString();
            buttonNetUpgrade.Text = player.getNetLvl().ToString();
            buttonBaitUpgrade.Text = player.getBaitLvl().ToString();

            //przypisanie etykietom ilości przedmiotów odpowiednich wartości
            labelWormNumber.Text = player.equipment.getWormNumber().ToString(); 
            labelHookNumber.Text = player.equipment.getHookNumber().ToString();
            labelLineNumber.Text = player.equipment.getLineNumber().ToString();
            labelNetNumber.Text = player.equipment.getNetNumber().ToString();
            labelBaitNumber.Text = player.equipment.getBaitNumber().ToString();

            //przypisanie etykiecie posiadanych pieniedzy odpowiedniej wartości
            labelOwnedMoney.Text = player.getMoney().ToString();

            //przypisanie etykietom kosztów ulepszeń odpowiednich wartości
            labelWormUpgradeCost.Text = upgrades.getWormUpgradePrice().ToString(); 
            labelHookUpgradeCost.Text = upgrades.getHookUpgradePrice().ToString();
            labelLineUpgradeCost.Text = upgrades.getLineUpgradePrice().ToString();
            labelNetUpgradeCost.Text = upgrades.getNetUpgradePrice().ToString();
            labelBaitUpgradeCost.Text = upgrades.getBaitUpgradePrice().ToString();
        }
        /// <summary>
        /// Przycisk umożliwiający zakup/dodanie robaków
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddWorm_Click(object sender, EventArgs e)
        {
            //jeżeli gracz ma wystarczającą ilość funduszy na zakup to odejmujemy cene
            if (player.subMoney(shop.getWormPrice()))     
            {
                // dodajemy robaczka
                player.equipment.increaseWormNumber();
                // i aktualizujamy etykiety  
                updateLabels();                         
            }
            //jeżeli gracz nie ma tyle pieniędzy
            else
            {
                //wyświetlamy informację w oknie
                MessageBox.Show("Nie masz wystarczających środków na zakup!");
            }

        }

        /// <summary>
        /// Przycisk umożliwiający zakup/dodanie haczyków
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddHook_Click(object sender, EventArgs e)
        {
            //jeżeli gracz ma wystarczającą ilość funduszy na zakup to odejmujemy cene
            if (player.subMoney(shop.getHookPrice()))   
            {
                // dodajemy robaczka
                player.equipment.increaseHookNumber();
                // i aktualizujamy etykiety  
                updateLabels();                         
            }
            //jeżeli gracz nie ma tyle pieniędzy
            else
            {
                //wyświetlamy informację w oknie
                MessageBox.Show("Nie masz wystarczających środków na zakup!");
            }
        }

        /// <summary>
        /// Przycisk umożliwiający zakup/dodanie żyłek
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddLine_Click(object sender, EventArgs e)
        {
            //jeżeli gracz ma wystarczającą ilość funduszy na zakup to odejmujemy cene
            if (player.subMoney(shop.getLinePrice()))   
            {
                //i dodajemy żyłkę
                player.equipment.increaseLineNumber();
                // aktualizujamy etykiety  
                updateLabels();                        
            }
            //jeżeli gracz nie ma tyle pieniędzy
            else
            {
                //wyświetlamy informację w oknie
                MessageBox.Show("Nie masz wystarczających środków na zakup!");
            }
        }

        /// <summary>
        /// Przycisk umożliwiający zakup/dodanie siatek
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddNet_Click(object sender, EventArgs e)
        {
            //jeżeli gracz ma wystarczającą ilość funduszy na zakup to odejmujemy cene
            if (player.subMoney(shop.getNetPrice()))   
            {
                // dodajemy siatke
                player.equipment.increaseNetNumber();
                // i aktualizujamy etykiety  
                updateLabels();                        
            }
            //jeżeli gracz nie ma tyle pieniędzy
            else
            {
                //wyświetlamy informację w oknie
                MessageBox.Show("Nie masz wystarczających środków na zakup!");
            }
        }

        /// <summary>
        /// Przycisk umożliwiający zakup/dodanie zanęty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddBait_Click(object sender, EventArgs e)
        {
            //jeżeli gracz ma wystarczającą ilość funduszy na zakup to odejmujemy cene
            if (player.subMoney(shop.getBaitPrice()))   
            {
                //i dodajemy zanętę
                player.equipment.increaseBaitNumber();
                //aktualizujamy etykiety  
                updateLabels();                         
            }
            //jeżeli gracz nie ma tyle pieniędzy
            else
            {
                //wyświetlamy informację w oknie
                MessageBox.Show("Nie masz wystarczających środków na zakup!");
            }
        }

        /// <summary>
        /// Przycisk umożliwiający ulepszenie robaków
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWormUpgrade_Click(object sender, EventArgs e)
        {
            //jeżeli gracz ma wystarczającą ilość funduszy na zakup ulepszenia
            if (player.subMoney(upgrades.getWormUpgradePrice()))   
            {
                //to zwiększamy poziom ulepszenia
                player.increaseWormLvl();
                //zwiększamy cenę następnego ulepszenia
                upgrades.increaseWormUpgradePrice();
                //zwiększamy cenę przedmiotu
                shop.increaseWormPrice();
                //oraz aktualizujamy etykiety  
                updateLabels();                                    
            }
            //jeżeli gracz nie ma tyle pieniędzy
            else
            {
                //wyświetlamy informację w oknie
                MessageBox.Show("Nie masz wystarczających środków na zakup ulepszenia!");
            }
        }

        /// <summary>
        /// Przycisk umożliwiający ulepszenie haczyków
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHookUpgrade_Click(object sender, EventArgs e)
        {
            //jeżeli gracz ma wystarczającą ilość funduszy na zakup ulepszenia
            if (player.subMoney(upgrades.getHookUpgradePrice()))   
            {
                //to zwiększamy poziom ulepszenia
                player.increaseHookLvl();
                //zwięszamy cenę następnego ulepszenia
                upgrades.increaseHookUpgradePrice();
                //zwiększamy cenę przedmiotu
                shop.increaseHookPrice();
                //oraz aktualizujamy etykiety  
                updateLabels();                                    
            }
            //jeżeli gracz nie ma tyle pieniędzy
            else
            {
                //wyświetlamy informację w oknie
                MessageBox.Show("Nie masz wystarczających środków na zakup ulepszenia!");
            }
        }

        /// <summary>
        /// Przycisk umożliwiający ulepszenie żyłki
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLineUpgrade_Click(object sender, EventArgs e)
        {
            //jeżeli gracz ma wystarczającą ilość funduszy na zakup ulepszenia
            if (player.subMoney(upgrades.getLineUpgradePrice()))   
            {
                //to zwiększamy poziom ulepszenia
                player.increaseLineLvl();
                //to zwiększamy poziom ulepszenia
                upgrades.increaseLineUpgradePrice();
                //zwiększamy cenę następnego ulepszenia
                shop.increaseLinePrice();
                //zwiększamy cenę przedmiotu
                updateLabels();
                //oraz aktualizujamy etykiety 
            }
            //jeżeli gracz nie ma tyle pieniędzy
            else
            {
                //wyświetlamy informację w oknie
                MessageBox.Show("Nie masz wystarczających środków na zakup ulepszenia!");
            }
        }

        /// <summary>
        /// Przycisk umożliwiający ulepszenie siatek
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNetUpgrade_Click(object sender, EventArgs e)
        {
            //jeżeli gracz ma wystarczającą ilość funduszy na zakup ulepszenia
            if (player.subMoney(upgrades.getNetUpgradePrice()))   
            {
                //to zwiększamy poziom ulepszenia
                player.increaseNetLvl();
                //zwiększamy cenę następnego ulepszenia
                upgrades.increaseNetUpgradePrice();
                //zwiększamy cenę przedmiotu
                shop.increaseNetPrice();
                //oraz aktualizujamy etykiety 
                updateLabels();                                    
            }
           
            else
            {
                //wyświetlamy informację w oknie
                MessageBox.Show("Nie masz wystarczających środków na zakup ulepszenia!");
            }
        }

        /// <summary>
        /// Przycisk umożliwiający ulepszenie zanęty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBaitUpgrade_Click(object sender, EventArgs e)
        {
            //jeżeli gracz ma wystarczającą ilość funduszy na zakup ulepszenia
            if (player.subMoney(upgrades.getBaitUpgradePrice()))   
            {
                //to zwiększamy poziom ulepszenia
                player.increaseBaitLvl();
                //zwiększamy cenę następnego ulepszenia
                upgrades.increaseBaitUpgradePrice();
                //zwiększamy cenę przedmiotu
                shop.increaseBaitPrice();
                //oraz aktualizujamy etykiety 
                updateLabels();                                    
            }
            //jeżeli gracz nie ma tyle pieniędzy
            else
            {
                //wyświetlamy informację w oknie
                MessageBox.Show("Nie masz wystarczających środków na zakup ulepszenia!");
            }
        }

        /// <summary>
        /// Przycisk umożliwiający zarzucenie wędki
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCastFishingRod_Click(object sender, EventArgs e)
        {
            
            //jeżeli gracz nie ma zarzuconej wędki
            if (fishing == false )
            {
                // jeżeli gracz ma potrzebne do wędkowania przedmioty to może zarzucic wędkę
                if (player.equipment.getHookNumber() > 0 && player.equipment.getLineNumber() > 0 && player.equipment.getWormNumber() > 0)
                {
                    //ustawiamy tło które sugeruje że węka jest zarzucona
                    this.BackgroundImage = Properties.Resources.background;
                    //wędka jest zarzucona
                    fishing = true;
                }
                // jeżeli gracz nie ma potrzebnych rzeczy
                else
                {
                    //wyświetlamy informację w oknie
                    MessageBox.Show("Nie masz potrzebnych przedmiotów aby łowić ryby!");
                }
            }
            //w przeciwnym razie nie może tego zrobić lub przerywamy łowienie ryb
            else
            {
                //ustawiamy tło które sugeruje że węka nie jest zarzucona
                this.BackgroundImage = Properties.Resources.background2;
                //wędka nie zarzucona
                fishing = false;
            }
        }

        /// <summary>
        /// Przycisk umożliwiający użycie zanęty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUseBait_Click(object sender, EventArgs e)
        {
            //jeżeli gracz ma zanętę
            if (player.equipment.getBaitNumber() > 0)
            {
                //dekremetujemy ilość zanęty w ekwipunku
                player.equipment.decreaseBaitNumber();
                //zmieniamy stan zanęty
                isBaitCasted = true;
                //aktualizujemy etykiety
                updateLabels();
            }
            //jeżeli gracz nie ma zanęty
            else
            {
                //wyświetlamy informację w oknie
                MessageBox.Show("Nie masz zanęty!");
            }
        }

    }
}
