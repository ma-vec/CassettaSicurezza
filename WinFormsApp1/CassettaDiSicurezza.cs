using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class CassettaDiSicurezza
    {
        
        private string id;
        private string produttore;
        private string codiceSegreto;
        private string codiceSblocco;
        private bool vuoto;
        private bool isOpen;
        private double valore;
        OggettoSegreto oggettoContenuto;
        
        public OggettoSegreto OggettoContenuto
        {
            get { return oggettoContenuto; }
        }
        

        public string Id
        {
            get { return id; }
        }
        public string Produttore
        {
            get { return produttore; }
        }
        public bool Vuoto
        {
            get { return vuoto; }
        }
        public bool IsOpen { get { return isOpen; } }
        public double Valore { get { return valore; } }


        public void Aggiungi(OggettoSegreto oggetto, string codice)
        {
            if(oggetto==null || codice!=codiceSegreto)
                return;
            oggettoContenuto = oggetto;
            vuoto = false;
            valore = oggetto.Valore;
        }

        public void Rimuovi(string codice)
        {
            if (oggettoContenuto == null || codice != codiceSegreto) //concettualmente elimina un oggetto solo se contenuto
                return;
            oggettoContenuto = null;
            vuoto=true;
            valore = 10; //valore generico della cassetta se vuota
        }

        public bool ModificaPin (string codice, string codiceNuovo)
        {

            if (codice == null || codice != codiceSblocco)
                return false;
            else
            {
                codiceSegreto = codiceNuovo;
                return true;
            }
        }

        public void Apri(string codice)
        {
            if(codice!= codiceSegreto)
                return ;
            isOpen = true;
        }
        public void Chiudi(string codice)
        {
            if (codice != codiceSegreto)
                return;
            isOpen = false;
        }

        public virtual double getValoreAssicurato()
        {
            return OggettoContenuto.ValoreAssicurato;
        }

        public string getTipologia()
        {
            if (!vuoto)
            {
                if (oggettoContenuto is Chiavi) return "Chiave";
                else if (oggettoContenuto is Documenti) return "Documento";
                else if (oggettoContenuto is Gioielli) return "Gioello";
                else if (oggettoContenuto is OggettoSegreto) return "Oggetto generico";
                else return "Mistero";
            }
            else return "vuoto";
        }

    


        public CassettaDiSicurezza(string id, string produttore, string codiceSegreto, string codiceSblocco, bool vuoto, bool isOpen)
        {
            this.id = id;
            this.produttore = produttore;
            this.codiceSegreto = codiceSegreto;
            this.codiceSblocco = codiceSblocco;
            this.vuoto = vuoto;
            this.isOpen = isOpen;
        }


    }
}
