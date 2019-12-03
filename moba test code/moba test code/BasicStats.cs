using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moba_test_code
{
    class BasicStats
    {
        enum heroStat {agilityHero, strengthHero, intelligenceHero }

        int level;
        double health;
        double mana;

        double healthReg;
        double manaReg;

        int low_Damage;
        int max_Damage;
        //Random damageDealer = new Random();
        //int Damage = damageDealer.Next(low_Damage, max_damage);


        int movementSpeed;

        


        /*if ( heroStat == agilityHero){
            lowdamage = lowdamage + agilityamplifier * level;
            maxdamage = maxdamage + agilityamplifier * level;
       }*/

       /* if (heroStat == strengthHero){
          lowdamage = lowdamage + strengthamplifier * level;
          maxdamage = maxdamage + strengtamplifier * level;
        }*/

        /* if (heroStat == intelligenceHero){
          lowdamage = lowdamage + intelligenceamplifier * level;
          maxdamage = maxdamage + intelligenceamplifier * level;
          }*/
    }
}
