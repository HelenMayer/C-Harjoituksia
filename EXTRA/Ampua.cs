using System;

namespace EXTRA
{
    public class Ampua{
        int ammupiste;
        public string Ampu(int pelajadistance, int distance, Terveys kaupunki, Terveys lohikäärme){
            
            string tulos="";
           
            if (pelajadistance==distance)
            {
                tulos="Osuma!";
                lohikäärme.TerveysArvoVenhempaa(ammupiste);
            }
            if (Math.Abs(pelajadistance-distance)<10 && distance!=pelajadistance)
            {
                tulos="Tähtäys oli lähella! Osuma jäi vajaaksi";
                kaupunki.TerveysArvoVenhempaa(1);
            }
            if (pelajadistance-distance>10)
            {
                tulos="Tähtäys oli liian pitkä ja osuma ylitti kohteen.";
                kaupunki.TerveysArvoVenhempaa(1);
            }
            if (pelajadistance-distance<-10)
            {
                tulos="Tähtäys oli liian lyhyt ja osuma jäi vajaaksi.";
                kaupunki.TerveysArvoVenhempaa(1);
            }

            return tulos;
        }

        public int Ampuarvo(int i){
            if (i%3==0 && i%5==0)
                {
                    ammupiste=10;
                }
                if (i%3==0 | i%5==0)
                {
                    ammupiste=3;
                }
                else
                {
                    ammupiste=1;
                }
                return ammupiste;
        } 
        
        
    }
}