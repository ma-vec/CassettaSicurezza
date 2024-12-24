using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Chiavi: OggettoSegreto
    {
        private bool isDigitalKey;

        public bool IsDigitalKey
        {
            get { return isDigitalKey; }
            set { isDigitalKey = value; }
        }

        public override double ValoreAssicurato => Valore * 1000;
        public double CalcolaValoreAssicurato()
        {
            return Valore * 1000;
        }

        public Chiavi(string identificatore, double valore, bool isDigitalKey) : base(identificatore, valore)
        {
            this.isDigitalKey = isDigitalKey;
        }
    }
}
