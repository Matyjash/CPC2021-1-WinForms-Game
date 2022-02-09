using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaciejLendzionLab1ZadDom
{
    public class Fish
    {
        private double weight=0;        //waga ryby
        private string name = "Okoń";   //nazwa ryby
        private double size = 0;        //rozmiar ryby
        private int price = 0;          //cena ryby

        public Fish(Player player)
        {
            generateProperties(player);
        }
        /// <summary>
        /// Generowanie parametrów złapanej ryby
        /// </summary>
        private void generateProperties(Player player)
        {
            Random randomFactor = new Random();
            //losujemy zmienną typu int która będzie skalowała wagę ryby
            int scale = randomFactor.Next(5, 15);
            //obliczamy wagę ryby na podstawie skali, poziomu haczyka i poziomu robaka
            weight = 0.01*scale*(3 * player.getHookLvl()+1 + player.getWormLvl());
            //losujemy kolejna liczbe reprezentujaca skale tym razem dla rozmiaru
            scale = randomFactor.Next(8, 12);
            //obliczamy rozmiar ryby na podstawie skali, poziomu haczyka i poziomu robaka
            size= 0.2 * scale * (5 * player.getHookLvl() + 2* player.getWormLvl());
            //obliczamy cenę ryby na podstawie jej wagi i wielkości
            price = (int)(10*weight + size);
        }
        /// <summary>
        /// Zwraca wage ryby
        /// </summary>
        /// <returns></returns>
        public double getWeight()
        {
            return weight;
        }
        /// <summary>
        /// Zwraca nazwe ryby
        /// </summary>
        /// <returns></returns>
        public string getName()
        {
            return name;
        }
        /// <summary>
        /// Zwraca rozmiar ryby
        /// </summary>
        /// <returns></returns>
        public double getSize()
        {
            return size;
        }
        /// <summary>
        /// Zwraca cene ryby
        /// </summary>
        /// <returns></returns>
        public int getPrice()
        {
            return price;
        }
    }
}
