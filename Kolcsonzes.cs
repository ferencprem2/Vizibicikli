using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Kolcsonzes
    {
        private string nev;
        private int jazon;
        private DateOnly eora;
        private DateOnly eperc;
        private DateOnly vora;
        private DateOnly vperc;

        public string Nev { get => Nev; set => Nev = value; }
        public int Jazon { get => jazon; set => jazon = value; }
        public DateOnly Eora { get => eora; set => eora = value; }
        public DateOnly Eperc { get => eperc; set => eperc = value; }
        public DateOnly Vora { get => vora; set => vora = value; }
        public DateOnly Vperc { get => vperc; set => vperc = value; }
    }
}
