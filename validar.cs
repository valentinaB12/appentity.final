using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace appEntity1
{
    class validar
    {
        string texto;
        int tex;
        public Boolean numero(string texto)
        {
            Regex formato = new Regex("^[0-9,$]*$");

            if (formato.IsMatch(texto))
            {
                return true;


            }

            else;
            {
                Console.ForegroundColor = ConsoleColor.Red; Console.SetCursorPosition(50,23); Console.WriteLine("el valor debe ser numerico  ");
                Console.ReadLine();
                return false;

            }
            Console.ReadKey();
        }  







        public Boolean Vacio(string texto)
        {
            if (texto.Equals(" "))
            {

                Console.ForegroundColor = ConsoleColor.Red; Console.SetCursorPosition(50, 23); Console.WriteLine(" el espacio no debe ser vacio");
                Console.ReadLine();
                return true;
            }
            else

            {

                return false;


            }
            Console.ReadKey();
        }
        public Boolean TipoTexto(string texto)
        {
            Regex formato = new Regex("^[a-zA-Z]*$");

            if (formato.IsMatch(texto))
            {
                return true;
            }
            else
            {

                Console.ForegroundColor = ConsoleColor.Red; Console.SetCursorPosition(50, 23); Console.WriteLine("el valor debe ser de texto");
                Console.ReadLine();
                return false;
            }
            Console.ReadKey();
        }
        public Boolean correo(string texto)
        {
            Regex formato = new Regex(@"\A(\w+\.?\w*\@\w+\.)(com)\Z");

            if (formato.IsMatch(texto))
            {
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red; Console.SetCursorPosition(50, 23);Console.WriteLine(" el valor debe tener @");
                Console.ReadLine();
                return false;
            }
            Console.ReadKey();
        }

        public Boolean NumeroDesimal(string texto)
        {
            Regex formato = new Regex("^[0-9]([.,][0-9]{1,3})?$");

            if (formato.IsMatch(texto))
            {
                return true;
            }
            else
            {
                Console.WriteLine(" el valor debe ser decimal");
                return false;
            }
        }
    }
}
