using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassettaDiSicurezza
{
    internal class CassettaSpeciale :CassettaSicurezza
    {
        public CassettaSpeciale(string codiceSeriale, string codiceSblocco, string produttore, string pin):base (codiceSeriale, codiceSblocco,produttore,pin) { }
        public override double ValoreAssicurata()
        {
          if(Tipo==typeof(GoielloPrezioso))
          {
                return OggettoSegreto.ValoreDichiarato * 0.90;
          }
          if (Tipo == typeof(DocumentoLegale))
          {
                return OggettoSegreto.ValoreDichiarato * 0.80;
          }
          if (Tipo == typeof(Chiavi))
          {
                return OggettoSegreto.ValoreDichiarato * 0.70;
          }

            return 0;
        }
    }
    
}
