using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPi_Kairos.Entities {
    public class Persona {

        public int Id { get; set; }
        public string nombrePersona { get; set; }
        public string paisOrigen { get; set; }
        public string ubicacionPersona { get; set; }
        public string necesidadPersona { get; set; }
        public string historialPersona { get; set; }
    }
}
