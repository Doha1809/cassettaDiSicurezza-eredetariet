using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassettaDiSicurezza
{
    internal class DocumentoLegale :OggettoSegreto
    {
        private string tipoSpecifico;
        DocumentoLegale(string id, double valoreDichiarato) : base(id, valoreDichiarato)
        {

        }
        public DocumentoLegale(string id, double valoreDichiarato, string tipoSpecifico) : base(id, valoreDichiarato)
        {
            this.tipoSpecifico = tipoSpecifico;
        }
        override public double Calcolo_ValoreAssicurata()
        {
            if (ValoreDichiarato >= 100)
            {
                return ValoreDichiarato;
            }
            else
                return 50.0;
        }
    }
}
