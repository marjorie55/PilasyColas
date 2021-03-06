using PilasyColas.Clases;
using System;
using System.Text;
using System.Text.RegularExpressions;

namespace PilasyColas
{
    class Program
    {
        static void ejemploPilaLineal()
        {
            PilaLineal pila;
            int x;
            int CLAVE = -1;

            PListaSimple listaEnla = new PListaSimple();

            Console.WriteLine("Ingrese numeros y para terminar -1");
            try
            {
                pila = new PilaLineal();
                do
                {
                    x = Convert.ToInt32(Console.ReadLine());
                    if (x != -1)
                    {

                        listaEnla.insertar(x);
                    }

                } while (x != CLAVE);

                int pausa;
                pausa = 0;

                Console.WriteLine("DATOS DE LA PILA LISTA ENLAZADA: ");
                listaEnla.Verinverso();


            }
            catch (Exception error)
            {
                Console.WriteLine("Error= " + error.Message);
            }

            //Console.WriteLine("Ingrese numeros, y para terminar -1");
            //try
            //{
            //    //instanciando la pila
            //    pila = new PilaLineal();//crea pila
            //    do
            //    {
            //        x = Convert.ToInt32(Console.ReadLine());
            //        if ( x!= -1) 
            //        {
            //            pila.insertar(x);
            //        }

            //    } while (x != CLAVE);
            //    Console.WriteLine("Estos son los elementos de la pila: ");

            //    //desapilar
            //    while (!pila.pilavacia())
            //    {
            //        x = (int)(pila.quitar());
            //        Console.WriteLine($"elemento: {x}");
            //    }
            //    pila.insertar(993);
            //}
            //catch(Exception error)
            //{
            //    Console.WriteLine("Error" + error.Message);
            //}
        }
        static void espalindromo()
        {
            PilaLineal pilaChar;
            bool esPalindromo;
            String pal;
            PListaSimple listaEn = new PListaSimple();

            try
            {
                pilaChar = new PilaLineal();
                Console.WriteLine("Teclee una palabra para ver si es ");
                pal = Console.ReadLine();

                //PARTE MODIFICADA
                string remplazar = Regex.Replace(pal, @"\s", "");
                string convertida = remplazar.ToLower();
                Regex reg = new Regex("[^a-zA-Z0-9]");
                string TxtNormalizado = convertida.Normalize(NormalizationForm.FormD);
                string texto = reg.Replace(TxtNormalizado, "");// aqui tenemos el texto sin acento
                //

                //creamos la pila con los chars
                for (int i = 0; i < texto.Length;)
                {
                    Char c;
                    c = texto[i++];
                    listaEn.insertar(c);
                }

                Console.WriteLine("Orden en inverso: ");
                listaEn.Verinverso();
                //comprueba si es palindromo
                esPalindromo = true;

                int pausa;
                pausa = 0;

                for (int j = 0; esPalindromo && !listaEn.ListaVacia();)
                {
                    Char c;
                    c = (Char)listaEn.Delete();
                    esPalindromo = texto[j++] == c; //evalua si la pos es igual 
                }
                listaEn.LimpiarPila();
                if (esPalindromo)
                {
                    Console.WriteLine($"La palabra {pal} es palindromo");
                }
                else
                {
                    Console.WriteLine($"Nel, no es ");
                }


            }
            catch (Exception error)
            {
                Console.WriteLine($"ups error {error.Message}");
            }


        }
        /*static void pilindromo()
        {
            PilaLineal pilaChar;
            bool esPalindromo;
            String pal;

            
           try
           {
                pilaChar = new PilaLineal();
                Console.WriteLine("Teclee una palabra para ver si es palindromo");
                pal = Console.ReadLine();

                //creamos la pila con los chars
                for (int i=0; i < pal.Length;)
                {
                    Char c;
                    c = pal[i++];
                    pilaChar.insertar(c);
                }
                //comprueba si es palindromo
                esPalindromo = true;
                for (int j =0; esPalindromo&& !pilaChar.pilavacia();)
                {
                    Char c;
                    c = (Char)pilaChar.quitarChar();
                    esPalindromo = pal[j++] == c;// evalua si la pos es igual
                }
                pilaChar.LimpiarPila();
                if (esPalindromo)
                {
                    Console.WriteLine($"La palabra {pal} es palindromo");
                }
                else
                {
                    Console.WriteLine($"Nel, no es ");
                }


            }catch(Exception error)
            {
                Console.WriteLine($"ups error {error.Message}");
            }
        }*/

        static void EjemploPilaLista()
        {
            //PilaLineal pl = new PilaLineal();
            //pl.insertar(1);
            //pl.insertar(5);
            //pl.insertar(16);
            //pl.insertar(217);
            //pl.insertar(41);
            //pl.insertar(19);

            //var xx = pl.quitar();

            PListaSimple listaEnla = new PListaSimple();
            PilaLista pilaLista = new PilaLista();
            PilaLineal pilaLineal = new PilaLineal();

            listaEnla.insertar(1);
            listaEnla.insertar(5);
            listaEnla.insertar(16);
            listaEnla.insertar(217);
            listaEnla.insertar(41);
            listaEnla.insertar(19);


            Console.WriteLine("Los datos son:");
            listaEnla.Verinverso();
            int pausa;
            pausa = 0;
        }

        /*static void evaluar()
        {
            string expresion;
            PilaEvaluador eq = new PilaEvaluador();
            Console.Write("****| Por favor, ingrese una expresión matematica: \n");
            expresion = Console.ReadLine();
            try
            {
                Console.WriteLine("RESULTADO: " + eq.chequear(expresion));
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
            }
        }*/

        static void Expresion()
        {
            //PilaEvaluador obj = new PilaEvaluador();
            //String infija;
            //Console.WriteLine("escriba la funcion: ");
            //infija = Console.ReadLine();
            //obj.evaluar(infija);
            string Infija;
            Console.WriteLine("Teclee una expresion matematica: ");
            Infija = Console.ReadLine();

            Console.WriteLine("Expresion resuelta" + PilaEvaluador.evaluar(Infija));
        }
    static void Main(string[] args)
        {
            //ejemploPilaLineal();
            //EjemploPilaLista();
            //PilaEvaluador();
            //espalindromo();
            Expresion();

           

        }
    }
}
