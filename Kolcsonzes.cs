using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Kolcsonzes
    {
        private string nev;
        private char jazon;
        private int eora;
        private int eperc;
        private int vora;
        private int vperc;

        public int IdoHossz()
        {
            return (vora * 60) + vperc - (eora * 60) + eperc;
        }

        public Kolcsonzes(string csvSor)
        {
            var lines = csvSor.Split(';');

            this.nev = lines[0];
            this.jazon = lines[1][0];
            this.eora = int.Parse(lines[2]);
            this.eperc = int.Parse(lines[3]);
            this.vora = int.Parse(lines[4]);
            this.vperc = int.Parse(lines[5]);

        }
        public Kolcsonzes(string nev, char jazon, int eora, int eperc, int vora, int vperc) {
            this.nev = nev;
            this.jazon = jazon;
            this.eora = eora;
            this.eperc = eperc;
            this.vora = vora;
            this.vperc = vperc;
        }
        public string Nev { get => nev; set => nev = value; }
        public char Jazon { get => jazon; set => jazon = value; }
        public int Eora { get => eora; set => eora = value; }
        public int Eperc { get => eperc; set => eperc = value; }
        public int Vora { get => vora; set => vora = value; }
        public int Vperc { get => vperc; set => vperc = value; }
    }
}
