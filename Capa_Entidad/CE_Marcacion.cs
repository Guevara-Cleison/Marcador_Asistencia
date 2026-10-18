using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class CE_Marcacion
    {
        public string Dia { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan? HoraIngreso { get; set; }
        public TimeSpan? HoraSalida { get; set; }
    }
}
