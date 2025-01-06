using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassettaDiSicurezza
{
    internal class OggettoSegreto
    {
        private string id;
        public string Id
        {
            get { return id; }
        }
        private double valoreDichiarato;
        public double ValoreDichiarato
        {
            get { return valoreDichiarato; }
        }
        private double valoreAssicurato;
        public double ValoreAssicurato
        {
            get { return valoreAssicurato; }
        }
        public OggettoSegreto(string id, double valoreDichiarato)
        {
            this.id = id;
            this.valoreDichiarato= valoreDichiarato;
        }
        /*public OggettoSegreto(string id, double valoreDichiarato, double valoreAssicurato, string tipoSpecifico) : this(id, valoreDichiarato, valoreAssicurato, "GoielloPrezioso")
        {
        }*/

        virtual public double Calcolo_ValoreAssicurata()
        {
            return valoreAssicurato;
        }

    }
}
