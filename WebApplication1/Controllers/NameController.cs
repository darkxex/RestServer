using System;
using System.Collections.Generic;
using System.Globalization;
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
    public class NameController : ControllerBase
    {

        // GET: api/Name/angel de jesús/toloza/gonzalez/M
        [HttpGet("{nombres}/{paterno}/{materno}/{genero}", Name = "GetName")]
        public string Get(string nombres, string paterno, string materno, string genero)
        {
            nombres = nombres.ToLower();
            paterno = paterno.ToLower();
            materno = materno.ToLower();

            String msgSaludo = "";
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);

            //Si el Género recibido es M, se asume que es masculino, cualquier otra cosa, se asume que es femenino.
            if (genero == "M")
            {
                msgSaludo = "Sr. " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nombres) +" " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(paterno) + " " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(materno);

               

                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    writer.Formatting = Formatting.Indented;

                    writer.WriteStartObject();
                    writer.WritePropertyName("msgSaludo");
                    writer.WriteValue(msgSaludo);
                   
                  
                    writer.WriteEndObject();
                }

            }
            else
            {
                msgSaludo = "Sra. " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nombres) + " " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(paterno) + " " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(materno);

                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    writer.Formatting = Formatting.Indented;

                    writer.WriteStartObject();
                    writer.WritePropertyName("msgSaludo");
                    writer.WriteValue(msgSaludo);


                    writer.WriteEndObject();
                }


            }
            return sb.ToString();

        }

        // POST: api/Name
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Name/5
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
