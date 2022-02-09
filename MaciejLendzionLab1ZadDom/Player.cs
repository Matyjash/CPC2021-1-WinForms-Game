using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaciejLendzionLab1ZadDom
{
    public class Player
    {
        //pieniądze gracza
        private int money = 300;
        //poziom robaczka
        private int wormLvl = 1;
        //poziom haczyka
        private int hookLvl = 1;
        //poziom żyłki
        private int lineLvl = 1;
        //poziom siatki
        private int netLvl = 1;
        //poziom zanęty
        private int baitLvl = 1;  

        public Equipment equipment= new Equipment();
        /// <summary>
        /// Zwraca ilość pieniędzy którą ma gracz
        /// </summary>
        /// <returns></returns>
        public int getMoney()
        {
            return money;
        }
        /// <summary>
        /// Dodaje podaną kwotę do pieniędzy gracza
        /// </summary>
        /// <param name="amount"></param>
        public void addMoney(int amount)
        {
            money += amount;
        }
        /// <summary>
        /// Odejmuje podaną kwotę od pieniędzy gracza jeżeli ten ma wystarczająco pieniędzy, w przeciwnym razie zwraca false
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public bool subMoney(int amount)
        {
            if (money - amount >= 0)
            {
                money -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Zwraca poziom robaczka
        /// </summary>
        /// <returns></returns>
        public int getWormLvl()
        {
            return wormLvl;
        }/// <summary>
        /// Inkrementuje poziom robaczka
        /// </summary>
        public void increaseWormLvl()
        {
            wormLvl++;
        }
        /// <summary>
        /// Zwraca poziom haczyka
        /// </summary>
        /// <returns></returns>
        public int getHookLvl()
        {
            return hookLvl;
        }
        /// <summary>
        /// Inkrementuje poziom haczyka
        /// </summary>
        public void increaseHookLvl()
        {
            hookLvl++;
        }
        /// <summary>
        /// Zwraca poziom żyłki
        /// </summary>
        /// <returns></returns>
        public int getLineLvl()
        {
            return lineLvl;
        }
        /// <summary>
        /// inkrementuuje poziom żyłki
        /// </summary>
        public void increaseLineLvl()
        {
            lineLvl++;
        }
        /// <summary>
        /// Zwraca poziom zanęty
        /// </summary>
        /// <returns></returns>
        public int getBaitLvl()
        {
            return baitLvl;
        }
        /// <summary>
        /// Inkrementuje poziom zanęty
        /// </summary>
        public void increaseBaitLvl()
        {
            baitLvl++;
        }
        /// <summary>
        /// Zwraca poziom siatki
        /// </summary>
        /// <returns></returns>
        public int getNetLvl()
        {
            return netLvl;
        }
        /// <summary>
        /// Inkrementuje poziom siatki
        /// </summary>
        public void increaseNetLvl()
        {
            netLvl++;
        }
      

    }
}
