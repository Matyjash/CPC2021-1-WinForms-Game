using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaciejLendzionLab1ZadDom
{
    public class CatchEvent
    {
        /// <summary>
        /// Losowanie czy ryba została złapana
        /// </summary>
        /// <param name="player"></param>
        /// <param name="isBaitCasted"></param>
        /// <returns></returns>
        public bool tryToCatchFish(Player player, bool isBaitCasted)
        {
            Random randomFactor = new Random();
            //losujemy liczbe z podanego przedziału
            int rolledNumber = randomFactor.Next(0, 100);
            //sprawdzamy czy zantęta został rzucona
            if (isBaitCasted)                                                  
            {
                //uwzgledniamy jakosć przynęty i sprawdzamy czy wylosowana liczba jest wieksza od progu, jeżeli tak to ryba została złapana
                if (rolledNumber > (80 - player.getBaitLvl()))                      
                {
                    return true;
                }
                else return false;
            }
            //jeżeli przynęta nie została rzucona to nie uwzględniamy jej w progu
            else
            {
                if (rolledNumber > 80)                                              
                {
                    return true;
                }
                else return false;
            }
        }
        /// <summary>
        /// Losowanie czy linka zostala przerwana
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public bool wasLineDestroyed(Player player)
        {
            Random randomFactor = new Random();
            //losujemy liczbe z podanego przedziału
            int rolledNumber = randomFactor.Next(0, 100);
            //jeżeli liczba przekroczyła próg to linka została zerwana, w progu uwzględniamy jakość linki
            if (rolledNumber > 80 + player.getLineLvl())
            {
                return true;
            }
            else return false;
        }
        /// <summary>
        /// Sprawdzamy czy ryba uciekła
        /// </summary>
        public bool fishSlippedOut(Player player)
        {
            Random randomFactor = new Random();
            //losujemy liczbe z podanego przedziału
            int rolledNumber = randomFactor.Next(0, 100);                     
            //sprawdzamy czy liczba przekroczyła próg, jeżeli tak to ryba mooże uciec
            if(rolledNumber > 95)
            {
                //jeżeli gracz ma siatke to ryba nie ucieka
                if (player.equipment.getNetNumber() > 0)                        
                {
                    //zmniejszamy liczbe siatek gracza
                    player.equipment.decreaseNetNumber();
                    return false;
                }
                else return true;
            }
            //jeżeli liczba nie przekroczyła progu to tyba nie uciekła
            else
            {
                return false;
            }
        }
    
    }
}
