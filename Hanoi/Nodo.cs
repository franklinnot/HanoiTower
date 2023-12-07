using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanoi
{
    public class Nodo
    {
        // Variables
        private int digit;
        private Nodo? siguiente;

        // Constructor
        public Nodo()
        {
            digit = 0;
            siguiente = null;
        }

        // Propiedades
        public int Digit
        {
            get { return digit; }
            set { digit = value; }
        }
        public Nodo? Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
    }
}
