using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Gioielli : OggettoSegreto
    {
        private string tipo;

        public string Tipo
        { 
            get { return tipo; }
            set { tipo = value; }
        }
        public override double ValoreAssicurato => CalcolaValoreAssicurato();
        public double CalcolaValoreAssicurato()
        {
            return Valore * 5;
        }
        public Gioielli(string identificatore, double valore, string tipo) : base(identificatore, valore)
        {
            this.tipo = tipo;
        }
    }
}
