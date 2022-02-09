using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaciejLendzionLab1ZadDom
{
    /// <summary>
    /// Klasa przechowująca ilości danych przedmiotów, oprócz zmiennych głównie zbiór getterów i setterów
    /// </summary>
    public class Equipment
    {
        private int wormNumber = 0;     //liczba robaków  w ekwipunku
        private int hookNumber = 0;     //liczba kaczyków w ekwipunku
        private int lineNumber = 0;     //liczba żyłek w ekwipunku
        private int netNumber = 0;      //liczba siatek w ekwipunku
        private int baitNumber = 0;     //liczba zanęt w ekwipunku
        /// <summary>
        /// Zwraca ilość robaków w ekwipunku
        /// </summary>
        /// <returns></returns>
        public int getWormNumber()
        {
            return wormNumber;
        }
        /// <summary>
        /// Inkrementuje liczbe robaków w ekwipunku
        /// </summary>
        public void increaseWormNumber()
        {
            wormNumber++;
        }
        /// <summary>
        /// Dekrementuje liczbe robakow w ekwipunku jeżeli jest ich >0
        /// </summary>
        /// <returns></returns>
        public bool decreaseWormNumber()
        {
            if (wormNumber != 0)
            {
                wormNumber--;
                return true;
            }
            else return false;
        }
        /// <summary>
        /// Zwraca ilośc haczyków w ekwipunku
        /// </summary>
        /// <returns></returns>
        public int getHookNumber()
        {
            return hookNumber;
        }
        /// <summary>
        /// Inkrementuje ilość haczyków w ekwipunku
        /// </summary>
        public void increaseHookNumber()
        {
            hookNumber++;
        }
        /// <summary>
        /// Dekrementuje ilość haczyków w ekwipunku jeżeli jest ich >0
        /// </summary>
        /// <returns></returns>
        public bool decreaseHookNumber()
        {
            if (hookNumber != 0)
            {
                hookNumber--;
                return true;
            }
            else return false;
        }
        /// <summary>
        /// Zwraca ilość żyłek w ekwipunku
        /// </summary>
        /// <returns></returns>
        public int getLineNumber()
        {
            return lineNumber;
        }
        /// <summary>
        /// Inkrementuje ilość żylek w ekwipunku
        /// </summary>
        public void increaseLineNumber()
        {
            lineNumber++;
        }
        /// <summary>
        /// Dekrementuje ilość żylek w ekwipunku jeżeli jest ich >0
        /// </summary>
        /// <returns></returns>
        public bool decreaseLineNumber()
        {
            if (lineNumber != 0)
            {
                lineNumber--;
                return true;
            }
            else return false;
        }
        /// <summary>
        /// Zwraca ilość zanęty w ekwipunku
        /// </summary>
        /// <returns></returns>
        public int getBaitNumber()
        {
            return baitNumber;
        }
        /// <summary>
        /// Inkrementuje ilość zanęty w ekwipunku
        /// </summary>
        public void increaseBaitNumber()
        {
            baitNumber++;
        }
        /// <summary>
        /// Dekrementuje ilość zanęty w ekwipunku jeżeli jest jej >0
        /// </summary>
        /// <returns></returns>
        public bool decreaseBaitNumber()
        {
            if (baitNumber != 0)
            {
                baitNumber--;
                return true;
            }
            else return false;
        }
        /// <summary>
        /// Zwraca ilość siatek w ekwipunku
        /// </summary>
        /// <returns></returns>
        public int getNetNumber()
        {
            return netNumber;
        }
        /// <summary>
        /// Inkrementuje ilość siatek w ekwipunku
        /// </summary>
        public void increaseNetNumber()
        {
            netNumber++;
        }
        /// <summary>
        /// Dekrementuj ilość siatek w ekwipunku jeżeli jesy ich >0
        /// </summary>
        /// <returns></returns>
        public bool decreaseNetNumber()
        {
            if (netNumber != 0)
            {
                netNumber--;
                return true;
            }
            else return false;
        }
    }
}
