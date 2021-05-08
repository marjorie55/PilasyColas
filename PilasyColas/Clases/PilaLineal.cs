using System;
using System.Collections.Generic;
using System.Text;

namespace PilasyColas.Clases
{
    class PilaLineal
    {
        private static int TAMPILA = 49;//tamano de la pila
        private int cima; //el elemento que esta en la cima
        private Object[] ListaPila;//escoge cualquier tipo de dato


        //constructor
        public PilaLineal()
        {
            cima = -1;//condicion pila vacia
            ListaPila = new Object[TAMPILA];//se inicializa
                        
        }

        public bool pilallena()
        {
            return cima == TAMPILA - 1;//quiere decir que la pila esta llena
        }

        //operaciones que modifica la pila
        //insercion
        public void insertar(Object elemento)
        {
            if (pilallena())
            {
                throw new Exception("Desbordamiento de pila Stack Overflow");
            }
            //incrementar puntero cima y vamos a insertar el elemento
            cima++;
            ListaPila[cima] = elemento;
        }

        public bool pilavacia()
        {
            return cima == -1;
        }

        //retorna un tipo char
        public Object quitarChar()
        {
            object aux;
            if (pilavacia())
            {
                throw new Exception("Pila vacia, no hay data");
            }
            aux = (object)ListaPila[cima];
            cima--;
            return aux;
        }

        //extraer elemento de la pila(pop)
        public Object quitar()
        {
            int aux;
            if (pilavacia())
            {
                throw new Exception("La pila esta vacia, no se puede sacar Underflow");
            }
            //guarda el elemento en la cima
            aux = (int)ListaPila[cima];
            //decrementar el valor de cima y retornar elemento
            cima--;
            return aux;

        }

        public void LimpiarPila()
        {
            cima = -1;
        }

        //operacion de acceso a la pila
        public Object cimaPila()
        {
            if (pilavacia())
            {
                throw new Exception("Pila vacia");
            }
            return ListaPila[cima];
        }
    }
}
