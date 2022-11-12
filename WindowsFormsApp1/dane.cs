using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Dane
    {
        public float promien1 { get; set; }
        public float promien2 { get; set; }
        public float odleglosc { get; set; }

        public Dane()
        {

        }
        public Dane(float promien1, float promien2, float odleglosc)
        {
            this.promien1 = promien1;
            this.promien2 = promien2;
            this.odleglosc = odleglosc;
        }
    }
}
