using Capa_Datos;
using Capa_Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class CN_Empleado
    {

        public List<CE_Huella_Empleado> ListarEmpleado()
        {
            List<CE_Huella_Empleado> lstEmpleado = new List<CE_Huella_Empleado>();

            CD_Empleado cdEmpleado = new CD_Empleado();
            lstEmpleado = cdEmpleado.ListarEmpleados();

            return lstEmpleado;
        }

        public List<CE_Marcacion> ListarMarcaciones(CE_Huella_Empleado empleado)
        {
            List<CE_Marcacion> lstMarcacion = new List<CE_Marcacion>();
            CD_Empleado cdEmpleado = new CD_Empleado();
            lstMarcacion = cdEmpleado.ListarMarcaciones(empleado);

            return lstMarcacion;
        }
        

    }
}
