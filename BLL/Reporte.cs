using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Reporte
    {
        

        public int idReporte { get; set; }
        public int idInfractor { get; set; }
      
        public string funcionarioResponsable { get; set; }
       
        public string centroOperativo { get; set; }
       
        public string codigoPresupuestario { get; set; }
       
        public int viatico { get; set; }
        public string horaInicio { get; set; }
        public string lugaresRecorridos { get; set; }
        public string horaFinalizacion { get; set; }
        public string numeroOficio { get; set; }
        public string accionDesarrollada { get; set; }
        public string fechaReporte { get; set; }
        public string recomendacion { get; set; }
        public string observacion { get; set; }
        public string matricula { get; set; }
        public int combustible { get; set; }
        public string kilometroInicio { get; set; }
        public string kilometroFinal { get; set; }
        public string placa { get; set; }

        public int estado { get; set; }

    }
}
