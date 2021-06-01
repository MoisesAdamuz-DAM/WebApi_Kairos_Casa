using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPi_Kairos.Entities {
    public class Login {

        public int Id { get; set; }
        public string nombreUsuario { get; set; }
        public string claveUsuario { get; set; }
    }
}
