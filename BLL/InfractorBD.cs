using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class InfractorBD
    {
        public string nombreResponsable { get; set; }
        public string cedulaResponsable { get; set; }
        public string tipoResponsable { get; set; }
        public Boolean estado { get; set; }

        public int actividadIlegal { get; set; }
    }
}