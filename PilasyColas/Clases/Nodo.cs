using System;
using System.Collections.Generic;
using System.Text;

namespace PilasyColas.Clases
{
    class Nodo
    {
        public Object dato;
        public Nodo enlace;
        //constructor
        public Nodo(Object x)
        {
            dato = x;
            enlace = null;//primer nodo creado, no tiene sucesor   
        }
        public Nodo(Object x, Nodo n)
        {
            dato = x;
            enlace = n;
        }

        //Metodos para que nos devuelva la informacion
        public Object getDato()
        { //Para que nos devuelva el dato
            return dato;
        }
        public Nodo getEnlace()
        { //Para que nos devuelva el enlace
            return enlace;
        }
        public void setEnlace(Nodo enlace)
        {
            this.enlace = enlace;
        }
    }
}

