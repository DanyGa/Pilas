using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilas
{
    public class Nodo
    {
        private int dato;

        public int Dato
        {
            get 
            { 
                return dato; 
            }
            set 
            { 
                dato = value; 
            }
        }

        private Nodo siguiente;

        public Nodo Siguiente
        {
            get 
            {
                return siguiente; 
            }
            set 
            { 
                siguiente = value; 
            }
        }

        public Nodo()
        {
            dato = 0;
            siguiente = null;
        }

        public Nodo(int d)
        {
            dato = d;
            siguiente = null;
        }

        public Nodo(int d, Nodo s)
        {
            dato = d;
            siguiente = s;
        }

        public Nodo(Nodo n)
        {
            dato = n.dato;
            siguiente = n.siguiente;
        }

        public override string ToString()
        {
            return dato + "";
        }
    }
}
