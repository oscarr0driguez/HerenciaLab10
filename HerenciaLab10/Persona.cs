using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerenciaLab10
{
    public class Persona
    {
        public int Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNacimiento  { get; set; }

        public string Edad { get; set; }

        public Persona()
        {
            
        }
    }
}
