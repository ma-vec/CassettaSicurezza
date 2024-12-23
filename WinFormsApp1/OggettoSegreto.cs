using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class OggettoSegreto
    {
        private string identificatore;
        private double valore;
        private double valoreAssicurato;

        public string Identificatore
        {
            get { return identificatore; }
        }
        public double Valore
        {
            get { return valore; }
        } 
        public double ValoreAssicurate
        {
            get { return valoreAssicurato;}
        }
        public OggettoSegreto (string identificatore, double valore)
        {
            this.identificatore = identificatore;
            this.valore = valore;
        }
        public virtual double ValoreAssicurato => Valore;
    }

}
