using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassettaDiSicurezza
{
    internal class Chiavi : OggettoSegreto
    {
        private string tipoSpecifico;
       public Chiavi(string id, double valoreDichiarato) : base(id, valoreDichiarato)
        {

        }
        public Chiavi(string id, double valoreDichiarato, string tipoSpecifico) : base(id, valoreDichiarato)
        {
            this.tipoSpecifico = tipoSpecifico;
        }
        public override double Calcolo_ValoreAssicurata()
        {
            return ValoreDichiarato * 1000;
        }
    }
}
