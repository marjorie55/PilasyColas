using System;
using System.Collections.Generic;
using System.Text;

namespace PilasyColas.Clases
{
    class PListaSimple
    {
        public Nodo primero;
        int longi;

        //constructor 
        public PListaSimple()
        {
            primero = null;
        }

        //aqui inseertamos datos a la lista
        public void insertar(Object dato)
        {
            Nodo nuevo = new Nodo(dato);
            if (ListaVacia())
            {
                primero = nuevo;
            }
            else
            {
                nuevo.enlace = primero;
                primero = nuevo;
            }
            longi++;
        }

        //verifica si la lista esta vacia 
        public bool ListaVacia()
        {
            if (primero == null)
            {
                return true;
            }else
            {
                return false;
            }
        }

        public void Verinverso()
        {
            Nodo actual = primero;
            while (actual != null)
            {
                Console.WriteLine(actual.dato);
                actual = actual.enlace;
            }
        }

        //aqui eliminamos palindromos
        public Object PalindromoDelete()
        {
            char aux;
            if (ListaVacia())
            {
                throw new Exception("Pila Vacia!");
            }
            else
            {
                aux = (char)primero.dato;
                primero = primero.enlace;
                longi--;
                return aux;
            }

            
        }

        public object Delete()
        {
            char aux;
            if (ListaVacia())
            {
                throw new Exception("Pila Vacia!");
            }
            aux = (char)primero.dato;
            primero = primero.enlace;
            longi--;
            return aux;
        }

        public void LimpiarPila()
        {
            longi = -1;

        }
    }
}
