using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilliardPoints
{
    class spillEgenskaper
    {
        public int spillNr { get; set; }
        public string spillerTilAaSpre { get; set; }
        public string spillVunnetSpillerA { get; set; }
        public string spillVunnetSpillerB { get; set; }



        public spillEgenskaper oppdaterEgenskaper(List<Hendelse> hendelsesListe, List<string> spillere)
        {
            int _spillNr = 0;
            int _poengSpillerA = 0;
            int _poengSpillerB = 0;
            string _spillVunnetSpillerA = "";
            string _spillVunnetSpillerB = "";

            int i = 0;


            foreach (var currHendelse in hendelsesListe)
            {
                

                if (currHendelse.spillStart)
                {
                    _spillNr++;
                }
                if (currHendelse.vinnSpillerA)
                {
                    i++;
                    _poengSpillerA++;
                    _spillVunnetSpillerA += "," + i.ToString();
                }
                if (currHendelse.vinnSpillerB)
                {
                    i++;
                    _poengSpillerB++;
                    _spillVunnetSpillerA += "," + i.ToString();
                }

                this.spillVunnetSpillerA = _spillVunnetSpillerA.TrimStart(',');
                this.spillVunnetSpillerB = _spillVunnetSpillerB.TrimStart(',');

            }


            return this;
        }

    }
}
