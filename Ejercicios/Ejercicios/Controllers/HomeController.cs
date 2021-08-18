using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
  
namespace Ejercicios.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Ejercicio1()
        {
            ViewBag.Message = "Your application description page.";

            return View("Ejercicio1");
        }
        public ActionResult Ejercicio2()
        {
            ViewBag.Message = "Your application description page.";

            return View("Ejercicio2");
        }

        public string  SimplificarDivision( string NroDiv)
        {

            string resultado = "";
            int numerador = Convert.ToInt32(NroDiv.Split('/')[0]);
            int denominador = Convert.ToInt32(NroDiv.Split('/')[1]);
            int divisor = 2;
            while (divisor <= numerador && divisor <= denominador)
            {
                if ((numerador % divisor == 0) && (denominador % divisor == 0))
                {

                    numerador = numerador / divisor;
                    denominador = denominador / divisor;
                    divisor = 2;

                }
                else
                {
                    divisor++;

                }

            }
            if(denominador==1)
               resultado = numerador.ToString();
            else
                resultado = numerador.ToString() + "/" + denominador.ToString();

            return resultado;
        }

        public string[] ArregloPalabraInicial(string[] nombreCompletoS)
        {
            string[] resultado = new string[nombreCompletoS.Length];
            string palabra = "";
             for( int i=0; i< nombreCompletoS.Length;i++)
             {
                palabra = nombreCompletoS[i];
                if (palabra[0].ToString() == palabra[0].ToString().ToUpper())
                {

                    if ((palabra.Length<=2) && (palabra[palabra.Length-1]=='.'))
                        resultado[i] = "INICIAL";
                    else if((palabra.Length >= 2)&& (palabra[palabra.Length - 1] != '.'))
                        resultado[i] = "COMPLETA";
                    else
                        resultado[i] = "NINGUNO";

                }
                else
                {
                    resultado[i] = "NINGUNO";

                }

            }
            return resultado; 
         }
        public bool ValidarNombre(string NombreCompleto)
        {
            bool resultado = true;
            string[] nombreCompletoS = NombreCompleto.Split(' ');
            string[] TipoPalabra = ArregloPalabraInicial(nombreCompletoS);
            int longitud = nombreCompletoS.Length;

            bool isTipo = true;
          
            if ((longitud >= 2 && longitud <= 3) && isTipo)
            {

                if (longitud == 2)
                {

                    if (TipoPalabra[0] != "NINGUNO" && TipoPalabra[1] != "NINGUNO")
                    {
                        if (TipoPalabra[1] != "COMPLETA")
                        {
                            resultado = false;
                        }
                    }
                    else
                        resultado = false;


                }
                else if (longitud == 3)
                {
                    if (TipoPalabra[0] != "NINGUNO" && TipoPalabra[1] != "NINGUNO" && TipoPalabra[2] != "NINGUNO")
                    {
                        if (TipoPalabra[2] != "COMPLETA")
                        {
                            resultado = false;
                        }

                        if ((TipoPalabra[0] == "INICIAL") && (TipoPalabra[1] == "COMPLETA"))
                        {
                            resultado = false;
                        }
                    }
                    else {
                        resultado = false;

                    }
                }



            }
            else
            {
                resultado = false;
            }

            return resultado;
        }

    }
}