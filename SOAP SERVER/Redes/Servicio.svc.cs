using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Globalization;

namespace Redes
{
    
    public class Servicio : IServicio
    {
        public string Rut(string r)
        {
            try
            {
                r = r.Replace("k", "K");
                r = r.Replace(".", "");
                string[] rut = r.Split('-');

                r = rut[0];


                int suma = 0;
                for (int x = r.Length - 1; x >= 0; x--)
                    suma += int.Parse(char.IsDigit(r[x]) ? r[x].ToString() : "0") * (((r.Length - (x + 1)) % 6) + 2);
                int numericDigito = (11 - suma % 11);
                string digito = numericDigito == 11 ? "0" : numericDigito == 10 ? "K" : numericDigito.ToString();

                if (digito == rut[1])
                {
                    return "El Rut es Valido.";
                }
                else
                {
                    return "El Rut NO ES Valido.";
                }
            }
            catch
            { return "El Rut NO ES Valido."; }


        }

        public string Nombre(string NOMBRES, string AP_PATERNO, string AP_MATERNO, string G)
        {

            string saludo = NOMBRES+" "+AP_PATERNO+" "+AP_MATERNO;
            string filtro = new CultureInfo("en-US", false).TextInfo.ToTitleCase(saludo);

            if (G == "M")
            {
                return "Saludos Sr. " + filtro;
            }
            else
            {
                return "Saludos Sra. " + filtro;
            }
        }



    }
}
