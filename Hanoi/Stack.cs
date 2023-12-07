using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanoi
{
    public class Stack
    {
        private Nodo? Everest;
        public Stack()
        {
            Everest = null;
        }

        public int Pop()
        {
            // Eliminar el elemento que está en la parte superior de la pila y retornarlo.
            if (Everest == null)
            {
                throw new InvalidOperationException("La pila está vacía.");
            }
            int valor = Everest.Digit;
            Everest = Everest.Siguiente;
            return valor;
        }

        public void Push(int valor)
        {
            // Agregar un elemento a la parte superior de la pila
            Nodo Nuevo = new Nodo();
            Nuevo.Digit = valor;
            Nuevo.Siguiente = Everest;
            Everest = Nuevo;
        }

        public int Peek()
        {
            if (Everest == null) throw new InvalidOperationException("La pila está vacía.");
            return Everest.Digit;
        }

        public void Mostrar(ListBox listBox)
        {
            listBox.Items.Clear();
            Nodo? Temp = Everest;
            while (Temp != null)
            {
                listBox.Items.Add(Temp.Digit);
                Temp = Temp.Siguiente;
            }
        }

        public void ValidarIngreso(Stack torre, int nDestino, int nLocal)
        {
            if (torre.isEmpty())
            {
                torre.Push(Pop());
                return;
            }
            if (Peek() > torre.Peek())
            {
                MessageBox.Show($"El último elemento de la torre {nDestino} es menor \n" +
                                $"que el elemento que intentas mover de la torre {nLocal}.\n" +
                                $"                        {Peek()} > {torre.Peek()}\n" +
                                $"Vuelve a intentarlo con otra torre.");
            }
            else
            {
                torre.Push(Pop());
            }
        }

        public void Comparar()
        {
            Nodo? Temp = Everest;
            Random random = new Random();

            while (Temp != null)
            {
                Nodo? Second = Temp.Siguiente;
                bool same = false;

                while (Second != null)
                {
                    if (Second.Digit == Temp.Digit)
                    {
                        int num = random.Next(1, 100);
                        while (num == Temp.Digit)
                        {
                            num = random.Next(1, 100);
                        }
                        Second.Digit = num;
                        same = true;
                    }
                    Second = Second.Siguiente;
                }
                if (!same) Temp = Temp.Siguiente;
                else Temp = Everest;
            }
        }

        public bool Win()
        {
            if (Everest == null || Everest.Siguiente == null) return false;
            Nodo? Back = Everest;
            Nodo? Actual = Everest.Siguiente;
            int count = 1;
            while (Actual != null)
            {
                if (Back.Digit > Actual.Digit) return false;
                count++;
                Back = Actual;
                Actual = Actual.Siguiente;
            }
            if (count == 10) return true;
            else return false;
        }

        public void Clear()
        {
            Everest = null;
        }

        public bool isEmpty()
        {
            if (Everest == null) return true;
            return false;
        }
    }
}
