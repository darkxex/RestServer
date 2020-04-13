using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
            if (rutw.IndexOf("-") == -1)
            { return "Por favor ingrese el Guión del dígito verificador (ej: 12345678-9)."; }
            //sustrae el rut sin el digito verificador a un entero.
            int rut = Int32.Parse(rutw.Substring(0,(rutw.IndexOf("-"))));
            
            string dv = rutw.Substring(rutw.IndexOf("-")+ 1,1);
           
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
                return "El Rut es Valido.";
            }
            else
            {
                return "El Rut NO ES Valido.";
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
