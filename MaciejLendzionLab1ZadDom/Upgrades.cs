using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaciejLendzionLab1ZadDom
{
    public class Upgrades
    {
        //współczynnik wzrostu cen po każdym uleszeniu
        private const double increaseFactor = 1.5;
        //cena ulepszenia robaczka
        private int wormUpgradePrice = 100;
        //cena ulepszenia haczyka
        private int hookUpgradePrice = 100;
        //cena ulepszenia haczyka
        private int lineUpgradePrice = 100;
        //cena ulepszenia żyłki
        private int netUpgradePrice = 100;
        //cena ulepszenia sieci
        private int baitUpgradePrice = 100;
        //cena ulepszenia zanęty
        /// <summary>
        /// Zwraca cenę ulepszenia robaczka
        /// </summary>
        /// <returns></returns>
        public int getWormUpgradePrice()
        {
            return wormUpgradePrice;
        }
        /// <summary>
        /// Ziększenie ceny ulepszenia robaczka poprzez pomznożenie jej przez współczynnik wzrostu cen
        /// </summary>
        public void increaseWormUpgradePrice()
        {
            wormUpgradePrice = (int)(wormUpgradePrice * increaseFactor);
        }
        /// <summary>
        /// Zwraca cenę ulepszenia haczyka
        /// </summary>
        /// <returns></returns>
        public int getHookUpgradePrice()
        {
            return hookUpgradePrice;
        }
        /// <summary>
        /// Ziększenie ceny ulepszenia haczyka poprzez pomznożenie jej przez współczynnik wzrostu cen
        /// </summary>
        public void increaseHookUpgradePrice()
        {
            hookUpgradePrice = (int)(hookUpgradePrice * increaseFactor);
        }
        /// <summary>
        /// Zwraca cenę ulepszenia żyłki
        /// </summary>
        /// <returns></returns>
        public int getLineUpgradePrice()
        {
            return lineUpgradePrice;
        }
        /// <summary>
        /// Ziększenie ceny ulepszenia żyłki poprzez pomznożenie jej przez współczynnik wzrostu cen
        /// </summary>
        public void increaseLineUpgradePrice()
        {
            lineUpgradePrice = (int)(lineUpgradePrice * increaseFactor);
        }
        /// <summary>
        /// Zwraca cenę ulepszenia siatki
        /// </summary>
        /// <returns></returns>
        public int getNetUpgradePrice()
        {
            return netUpgradePrice;
        }
        /// <summary>
        /// Ziększenie ceny ulepszenia siatki poprzez pomznożenie jej przez współczynnik wzrostu cen
        /// </summary>
        public void increaseNetUpgradePrice()
        {
            netUpgradePrice = (int)(netUpgradePrice * increaseFactor);
        }
        /// <summary>
        /// Zwraca cenę ulepszenia zanęty
        /// </summary>
        /// <returns></returns>
        public int getBaitUpgradePrice()
        {
            return baitUpgradePrice;
        }
        /// <summary>
        /// Ziększenie ceny ulepszenia zanęty poprzez pomznożenie jej przez współczynnik wzrostu cen
        /// </summary>
        public void increaseBaitUpgradePrice()
        {
            baitUpgradePrice = (int)(baitUpgradePrice * increaseFactor);
        }
    }
}
