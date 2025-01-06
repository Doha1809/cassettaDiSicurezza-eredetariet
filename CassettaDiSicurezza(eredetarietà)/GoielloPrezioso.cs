using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassettaDiSicurezza
{
    internal class GoielloPrezioso : OggettoSegreto
    {
        private string tipoSpecifico;
        public GoielloPrezioso(string id, double valoreDichiarato) : base(id, valoreDichiarato)
        {
        }
       public  GoielloPrezioso(string id, double valoreDichiarato, string tipoSpecifico) : base(id, valoreDichiarato)
        {
            this.tipoSpecifico=tipoSpecifico;
        }
        public override double Calcolo_ValoreAssicurata()
        {
            return ValoreDichiarato * 5;
        }
    }
}
