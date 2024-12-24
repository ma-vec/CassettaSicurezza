using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Documenti: OggettoSegreto
    {
        private string tipo;

        

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public double CalcolaValoreAssicurato()
        {
            if (Valore >= 100)
                return Valore;
            else
                return 50;
        }
        public override double ValoreAssicurato => CalcolaValoreAssicurato();

        public Documenti(string identificatore, double valore, string tipo) : base(identificatore, valore)
        {
            this.tipo = tipo;
        }
    }
}
