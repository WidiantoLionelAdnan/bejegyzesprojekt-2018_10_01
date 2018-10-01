using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BejegyzesProjekt
{
    class Bejegyzes
    {
        private String szerzo;
        private String tartalom;
        private int likeok;
        private DateTime letrejott;
        private DateTime szerkesztve;

        public Bejegyzes(string szerzo, string tartalom)
        {
            this.szerzo = szerzo;
            this.tartalom = tartalom;
            this.likeok = 0;
            this.letrejott = DateTime.Now;
            this.szerkesztve = letrejott;
        }

        public String Szerzo
        {
            get { return szerzo; }
        }
        public String Tartalom
        {
            get { return tartalom; }
            set { tartalom = value;
                  szerkesztve = DateTime.Now;
                 }
        }
        public int Likeok
        {
            get { return likeok; }
        }
        public DateTime Szerkesztve
        {
            get { return szerkesztve; }
        }
        public DateTime Letrejott
        {
            get { return letrejott; }
        }
      
        public void Like()
        {
            likeok += 1;
        }

        public void Kiir()
        {
            Console.WriteLine("Szerző " + szerzo + "-" + "Likeok " + likeok + "-" + "Létrejött " + letrejott);
            Console.WriteLine("Szerkesztve: " + szerkesztve);
            Console.WriteLine(tartalom);
        }
    }
}
