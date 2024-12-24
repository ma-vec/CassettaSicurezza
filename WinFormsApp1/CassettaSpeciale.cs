using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class CassettaSpeciale : CassettaDiSicurezza
    {
        OggettoSegreto oggetto;
        public CassettaSpeciale(string codiceUnivoco, string produttore, string codiceSegreto, string codiceSblocco, bool vuoto, bool isOpen) : base(codiceUnivoco, produttore, codiceSegreto, codiceSblocco, vuoto, isOpen) { }

        public override double getValoreAssicurato()
        {
            if (oggetto is Gioielli)
                return oggetto.ValoreAssicurato * 0.90; 
            else if (oggetto is Documenti)
                return oggetto.ValoreAssicurato * 0.80;
            else if (oggetto is Chiavi)
                return oggetto.ValoreAssicurato * 0.70;
            else
                return base.getValoreAssicurato(); //valore assicurato base di un oggetto generico
        }
    }
}
