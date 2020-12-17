using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilas
{
    class Pila
    {
        private Nodo top;

        public Nodo Top
        {
            get 
            { 
                return top; 
            }
            set 
            { 
                top = value; 
            }
        }
        
        public int Count
        {
            get
            {
                int c = 0;
                Nodo t = top;
                while (top != null)
                {
                    c++;
                    t = t.Siguiente;
                }
                return c;
            }
        }

        public Pila()
        {
            top = null;
        }

        //operaciones
        
        public void Push(Nodo n)
        {
            n.Siguiente = top;
            top = n;
        }

        public Nodo Pop()
        {
            Nodo regreso = null;
            if (top != null)
            {
                top = top.Siguiente;
            }
            return regreso;
        }
    }
}
