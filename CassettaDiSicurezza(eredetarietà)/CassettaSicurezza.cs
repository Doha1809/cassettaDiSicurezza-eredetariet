using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassettaDiSicurezza
{
    internal class CassettaSicurezza
    {
        private OggettoSegreto oggettoSegreto;
        public OggettoSegreto OggettoSegreto
        {
            get { return oggettoSegreto; }
        }
        private string codiceSeriale;
        public string CodiceSeriale
        {
            get { return codiceSeriale; }
        }
        private string produttore;
        public string Produttore
        {
            get { return produttore; }
        }
        private string codiceSblocco;
        public string Codicesblocco 
        {
            get { return codiceSblocco; }
        }
        private string pin;
        private bool stato;
        public bool Stato
        {
            get { return stato; }
        }
        private Type tipo;
        public Type Tipo
        {
            get { return tipo; }
        }
        
        public void Aggiungere(string pin, OggettoSegreto oggettosegreto)
        {
            if(this.pin== pin&&stato==false)
            {
                Console.WriteLine("Il PIN inserito è corretto e la cassa è vuota. Oggetto INSERITO con successo");
                    stato = true;
                this.oggettoSegreto = oggettosegreto;
            }
            else
                if (stato == true)
                {
                    Console.WriteLine("La cassetta è già occupata!!!");
                }
                else
                    if (this.pin != pin)
                        Console.WriteLine("PIN non corretto");
                   

        }
        public void Rimuovere(string pin)
        {
            if (this.pin == pin && stato == true)
            {
                Console.WriteLine("Il PIN inserito è corretto. Ora puoi rimuovere l' oggetto");
                stato = false;
                oggettoSegreto = null;
            }
            else
                if (stato == false)
                {
                    Console.WriteLine("La cassetta è già vuota!!!");
                }
                else
                     if (this.pin != pin)
                        Console.WriteLine("PIN non corretto");
        }
        public void ModificaPin(string codiceSblocco)
        {
            if (this.codiceSblocco == codiceSblocco)
            {
                Console.WriteLine("Codicesblocco di sblocco corretto. Ora puoi modificare il PIN");
                pin = Console.ReadLine();
            }
            else
                Console.WriteLine("Codice di sblocco non corretto");
        }
        virtual public double ValoreAssicurata()
        {
            if (stato == true)
                return oggettoSegreto.ValoreDichiarato;
            else
                return 0;

        }
        public void StatoCassa()
        {
            if(stato == true)
            {
                Console.WriteLine("La cassa è occupata");
            }
            else
                Console.WriteLine("La cassa è vuota");
        }
       public CassettaSicurezza(string codiceSeriale, string codiceSblocco, string produttore,string pin)
        {
            this.codiceSeriale = codiceSeriale;
            this.codiceSblocco = codiceSblocco;
            this.produttore = produttore;
            this.pin = pin;
        }
        public void Tipologia_Oggettosegreto()
        {
            if (oggettoSegreto != null)
            {
                if (oggettoSegreto.GetType() == typeof(GoielloPrezioso))
                {
                    tipo = typeof(GoielloPrezioso);
                    Console.WriteLine("La cassetta contiene un GOIELLO PREZIOSO");
                }
                else
                    if (oggettoSegreto.GetType() == typeof(Chiavi))
                {
                    tipo = typeof(Chiavi);
                    Console.WriteLine("La cassetta contiene una CHIAVE ");
                }
                else
                    if (oggettoSegreto.GetType() == typeof(DocumentoLegale))
                {
                    tipo = typeof(DocumentoLegale);
                    Console.WriteLine("La cassetta contiene un DOCUMENTO LEGALE ");
                }
                else
                    Console.WriteLine("oggetto non riconosciuto!!");
            }
            else
                Console.WriteLine("Non c'è nessun oggetto");
            return ;

        }
        public double ValoreAsssicurata_oggetto()
        {
            if (oggettoSegreto != null)
                return oggettoSegreto.Calcolo_ValoreAssicurata();
            else
                return 0;

        }
        public double ValoreDichiarato_oggetto()
        {
            if (oggettoSegreto != null)
                return oggettoSegreto.ValoreDichiarato;
            else
                return 0;
        }
    }
}
