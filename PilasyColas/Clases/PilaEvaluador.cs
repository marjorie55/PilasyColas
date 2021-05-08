using System;
using System.Collections.Generic;
using System.Text;

namespace PilasyColas.Clases
{
    class PilaEvaluador
    {
        //evaluar las expresiones
        public static double evaluar(String infija)
        {
            String posfija = convertir(infija);//convierte la expresion infija a posfija 
            Console.WriteLine("expresion: " + posfija);
            return PosfijaCheck(posfija);

        }

        //convertir expresion 
        private static String convertir(String infija)
        {
            //convertir expresion infija
            String posfija = "";
            PilaLineal pila = new PilaLineal();


            for (int i = 0; i < infija.Length; i++)
            {

                char letra = infija[i];

                if (Esoperador(infija[i]))
                {

                    if (pila.pilavacia())
                    {
                        pila.insertar(letra);
                    }
                    else
                    {
                        int pe = PrioridadExpre(letra);
                        int pp = PrioridadPila((char)pila.cimaPila());
                        if (pe > pp)
                        {
                            pila.insertar(letra); //apilamos la letra
                        }
                        else
                        {

                            posfija += pila.quitarChar();
                            pila.insertar(letra);
                        }
                    }
                }
                else
                {
                    posfija += letra;
                }
            }

            while (!pila.pilavacia())
            {
                posfija += pila.quitarChar();
            }
            return posfija;
        }

        private static double PosfijaCheck(String Posfija)
        {
            PilaLineal pila = new PilaLineal();

            for (int i = 0; i < Posfija.Length; i++)
            {
                char letra = Posfija[i];

                if (!Esoperador(letra))
                {
                    double num = Convert.ToDouble(letra + "");
                    pila.insertar(num);
                }
                else
                {
                    double num2 = (double)pila.quitarChar();
                    double num1 = (double)pila.quitarChar();
                    double num3 = Operacion(letra, num1, num2);
                    pila.insertar(num3);
                }
            }
            return (double)pila.cimaPila();
        }


        //para devolver la prioridad
        private static int PrioridadExpre(char Operador)
        {
            //Expresion infija prioridades
            if (Operador == '^') return 4;
            if (Operador == '*' || Operador == '/') return 2;
            if (Operador == '+' || Operador == '-') return 1;
            if (Operador == '(') return 5;
            return 0;
        }

        private static int PrioridadPila(char Operador)
        {
            //prioridad en pila
            if (Operador == '^') return 3;
            if (Operador == '*' || Operador == '/') return 2;
            if (Operador == '+' || Operador == '-') return 1;
            if (Operador == '(') return 0;
            return 0;
        }

        //para saber si es un operador
        private static bool Esoperador(char letra)
        {
            if (letra == '*' || letra == '/' || letra == '+' || letra == '-' || letra == '(' || letra == ')' || letra == '^')
            {
                return true;
            }
            return false;

        }

        private static double Operacion(char letra, double num, double num2)
        {
            if (letra == '*') return num * num2;
            if (letra == '/') return num / num2;
            if (letra == '+') return num + num2;
            if (letra == '-') return num - num2;
            if (letra == '^') return Math.Pow(num2, num2);
            return 0;
        }

        
        
    }
}
