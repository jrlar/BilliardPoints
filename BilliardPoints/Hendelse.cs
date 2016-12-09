using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilliardPoints
{
    class Hendelse
    {
        public bool spillStart { get; set; }
        public bool spillReStart { get; set; }
        public bool spillPause { get; set; }
        public bool vinnSpillerA { get; set; }
        public bool vinnSpillerB { get; set; }
        public DateTime tidspunkt { get; set; }

        private void setDefault()
        {
            this.spillStart = false;
            this.spillReStart = false;
            this.spillPause = false;
            this.vinnSpillerA = false;
            this.vinnSpillerB = false;
            this.tidspunkt = DateTime.Now;
        }


        public Hendelse spillStartHendelse()
        {
            setDefault();
            this.spillStart = true;
            return this;
        }

        public Hendelse spillReStartHendelse()
        {
            setDefault();
            this.spillReStart = true;
            return this;
        }


        public Hendelse spillPauseHendelse()
        {
            setDefault();
            this.spillPause = true;
            return this;
        }

        public Hendelse vinnSpillerAHendelse()
        {
            setDefault();
            this.vinnSpillerA = true;
            return this;
        }

        public Hendelse vinnSpillerBHendelse()
        {
            setDefault();
            this.vinnSpillerB = true;
            return this;
        }
    }
}
