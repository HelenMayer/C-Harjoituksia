using System;

namespace EXTRA{

    public class Terveys{
        int tervearvo;
        public void TerveusArvo(int terve){
            tervearvo=terve;
        }

        public int TerveysArvoVenhempaa(int ampuarvo){
            tervearvo=tervearvo-ampuarvo;
            return tervearvo;
        }

        public int PrintTerveArvo(){
            return tervearvo;
        }
    }
}
