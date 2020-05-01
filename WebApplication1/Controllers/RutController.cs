using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RutController : ControllerBase
    {
       

        // GET: api/18828818/9
        
       
        [HttpGet("{rutw}", Name = "GetRut")]
        public string Get(string rutw)
        {
            string msgValido = "Rut invalido.";
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);
            try
            {
               
               

                if (rutw.IndexOf("-") == -1)
                {
                    msgValido = "Por favor ingrese el Guión del dígito verificador(ej: 12345678 - 9).";
                    using (JsonWriter writer = new JsonTextWriter(sw))
                    {
                        writer.Formatting = Formatting.Indented;

                        writer.WriteStartObject();
                        writer.WritePropertyName("msgValido");
        
                        writer.WriteValue(msgValido);


                        writer.WriteEndObject();
                    }


                    return sb.ToString();


                }
                //sustrae el rut sin el digito verificador a un entero y elimina los "."
                int rut = Int32.Parse(rutw.Substring(0, (rutw.IndexOf("-"))).Replace(".", ""));

                string dv = rutw.Substring(rutw.IndexOf("-") + 1, 1);

                int Digito;
                int Contador;
                int Multiplo;
                int Acumulador;
                string RutDigito;

                Contador = 2;
                Acumulador = 0;

                while (rut != 0)
                {
                    Multiplo = (rut % 10) * Contador;
                    Acumulador = Acumulador + Multiplo;
                    rut = rut / 10;
                    Contador = Contador + 1;

                    if (Contador == 8)
                    {
                        Contador = 2;
                    }
                }




                Digito = 11 - (Acumulador % 11);
                RutDigito = Digito.ToString().Trim();
                if (Digito == 10)
                {
                    RutDigito = "K";
                }
                if (Digito == 11)
                {
                    RutDigito = "0";
                }


                // Si el código verificador coincide con el rut, será Valido
                //de forma contraria, se mostrará como NO Valido.
                if (RutDigito.ToString() == dv.ToString())
                {
                    msgValido = "El Rut es Valido.";
                  
                }
                else
                {
                    msgValido = "El Rut NO ES Valido.";
                }

                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    writer.Formatting = Formatting.Indented;

                    writer.WriteStartObject();
                    writer.WritePropertyName("msgValido");

                    writer.WriteValue(msgValido);


                    writer.WriteEndObject();
                }

                return sb.ToString();
            }
            catch (Exception e)
            {
                msgValido = "El Rut NO ES Valido.";
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    writer.Formatting = Formatting.Indented;

                    writer.WriteStartObject();
                    writer.WritePropertyName("msgValido");

                    writer.WriteValue(msgValido);


                    writer.WriteEndObject();
                }

                return sb.ToString();
            }
        }

        // POST: api/Rut
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Rut/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
