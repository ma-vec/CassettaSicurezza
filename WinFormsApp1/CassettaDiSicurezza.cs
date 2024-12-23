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
        OggettoSegreto oggettoContenuto;
        

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


        public void Aggiungi(OggettoSegreto oggetto, string codice)
        {
            if(oggetto==null || codice!=codiceSegreto)
                return;
            oggettoContenuto = oggetto;
            vuoto = false;
        }

        public void Rimuovi(string codice)
        {
            if (oggettoContenuto == null || codice != codiceSegreto) //concettualmente elimina un oggetto solo se contenuto
                return;
            oggettoContenuto = null;
        }

        public void ModificaPin (string codice, string codiceNuovo)
        {

            if (codice == null || codice != codiceSblocco)
                return;
            codiceSegreto = codiceNuovo;
        }

        public void SetVuoto()
        {
            vuoto = true;
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

        public virtual double getValoreAssicurato(OggettoSegreto oggetto)
        {
            return oggetto.ValoreAssicurato;
        }

        public string getTipologia()
        {
            return oggettoContenuto.GetType().ToString();
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
