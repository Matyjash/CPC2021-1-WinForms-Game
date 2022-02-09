using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaciejLendzionLab1ZadDom
{
    public class Shop
    {
        //Współczynnik wzorstu cen
        private double increaseFactor = 1.2;
        //cena robaczka
        private int wormPrice = 10;
        //cena haczyka
        private int hookPrice = 10;
        //cena żyłki
        private int linePrice = 10;
        //cena siatki
        private int netPrice = 10;
        //cema zanęty
        private int baitPrice = 10;
        /// <summary>
        /// Zwraca cenę robaczka
        /// </summary>
        /// <returns></returns>
        public int getWormPrice()
        {
            return wormPrice;
        }
        /// <summary>
        /// Ziększenie ceny robaczka poprzez pomznożenie jej przez współczynnik wzrostu cen
        /// </summary>
        public void increaseWormPrice()
        {
            wormPrice = (int)(wormPrice * increaseFactor);
        }
        /// <summary>
        /// Zwraca cenę haczyka
        /// </summary>
        /// <returns></returns>
        public int getHookPrice()
        {
            return hookPrice;
        }
        /// <summary>
        /// Ziększenie ceny robaczka poprzez pomznożenie jej przez współczynnik wzrostu cen
        /// </summary>
        public void increaseHookPrice()
        {
            hookPrice = (int)(hookPrice * increaseFactor);
        }
        /// <summary>
        /// Zwraca cenę żyłki
        /// </summary>
        /// <returns></returns>
        public int getLinePrice()
        {
            return linePrice;
        }
        /// <summary>
        /// Ziększenie ceny robaczka poprzez pomznożenie jej przez współczynnik wzrostu cen
        /// </summary>
        public void increaseLinePrice()
        {
            linePrice = (int)(linePrice * increaseFactor);
        }
        /// <summary>
        /// Zwraca cenę siatki
        /// </summary>
        /// <returns></returns>
        public int getNetPrice()
        {
            return netPrice;
        }
        /// <summary>
        /// Ziększenie ceny robaczka poprzez pomznożenie jej przez współczynnik wzrostu cen
        /// </summary>
        public void increaseNetPrice()
        {
            netPrice = (int)(netPrice * increaseFactor);
        }
        /// <summary>
        /// Zwraca ilość zanęty
        /// </summary>
        /// <returns></returns>
        public int getBaitPrice()
        {
            return baitPrice;
        }
        /// <summary>
        /// Ziększenie ceny robaczka poprzez pomznożenie jej przez współczynnik wzrostu cen
        /// </summary>
        public void increaseBaitPrice()
        {
            baitPrice = (int)(baitPrice * increaseFactor);
        }
    }
}
