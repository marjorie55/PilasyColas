using System;
using System.Collections.Generic;
using System.Text;

namespace PilasyColas.Clases
{
    class PilaEvaluador
    {
        //evaluar las expresiones
        public  double evaluar(String Infija)
        {
            String Posfija = Convertir(Infija);//convierte la expresion infija a posfija
            Console.WriteLine("La expresion es: " + Posfija);
            return PosfijaCheck(Posfija);
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


        private static double PosfijaCheck(String Posfija)
        {
            PilaLineal Pila = new PilaLineal();
            for (int i = 0; i < Posfija.Length; i++)
            {
                char letra = Posfija[i];
                if (!Esoperador(letra))
                {
                    double num = Convert.ToDouble(letra + "");
                    Pila.insertar(num);

                }
                else
                {
                    double num1 = (double)Pila.quitarChar();
                    double num2 = (double)Pila.quitarChar();
                    double num3 = Operacion(letra, num2, num1);
                    Pila.insertar(num3);
                }
            }
            return (double)Pila.cimaPila();
        }

        //para saber si es un operador
        private static bool Esoperador(char letra)
        {
            if (letra == '*' || letra == '/' || letra == '-' || letra == '+' || letra == '(' || letra == ')' || letra == '^') ;
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

        //convertir expresion 
        private static String Convertir(String Infija)
        {
            //convertir expresion infija
            String Posfija = "";
            PilaLineal pila = new PilaLineal();
            for (int i =0; i < Infija.Length; i++)
            {
                char letra = Infija[i];
                if (Esoperador(Infija[i]))
                {
                    if (pila.pilavacia())
                    {
                        pila.insertar(letra);
                    }
                    else
                    {
                        int Pex = PrioridadExpre(letra);
                        int Pp = PrioridadPila((char)pila.cimaPila());
                        if (Pex > Pp)
                        {
                            pila.insertar(letra);
                        }
                        else
                        {

                        }
                    }
                }

                else
                {
                    Posfija += letra;
                }
            }
            while (!pila.pilavacia())
            {
                Posfija += pila.quitarChar();
            }
            return Posfija;
        }
    }
}
