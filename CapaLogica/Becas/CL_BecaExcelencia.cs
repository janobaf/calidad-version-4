using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad.Alumno;
using CapaEntidad.Calificaciones;
using CapaEntidad.Becas;
using CapaDatos.Alumnos;
using CapaDatos.Becas;
using CapaDatos.Calificaciones;
namespace CapaLogica.Becas
{
    public class CL_BecaExcelencia
    {

        #region Singleton

        private static readonly CL_BecaExcelencia _instancia = new CL_BecaExcelencia();

        public static CL_BecaExcelencia Instancia
        {
            get { return CL_BecaExcelencia._instancia; }
        }

        #endregion
        #region metodos

        public bool Beca_exelencia(E_Alumno ea)
        {
            bool verificado = false;
            if (CD_Calificacines.Instancia.mostrar_calificaciones_dni(ea.Alumn_dni) != null)
            {
                E_Calificaciones calificaciones = CD_Calificacines.Instancia.mostrar_calificaciones_dni(ea.Alumn_dni);
                if (calificaciones.Califi_Promedio >= 16 && CD_BecaExcelencia.Instancia.modificar_pension_alumno(ea.Alumn_dni))
                {
                
                        verificado = true;
                }
            }
            return verificado;
        }
        public bool verificar_Alumno_Beca(string dni)
        {
            return CD_BecaExcelencia.Instancia.verificar_Alumno_Beca(dni);
        }
        public List<E_BecaPorPromedio> ListarBecas()
        {
            return CD_BecaExcelencia.Instancia.ListaDeBeca() != null ? CD_BecaExcelencia.Instancia.ListaDeBeca() : null;
        }

        public E_Alumno Mostrar_Alumno_Exelencia(string dni)
        {
            E_Alumno aux = new E_Alumno();
            if (CD_Alumno.Instancia.validar_dni(dni) && CD_BecaExcelencia.Instancia.Obtener_Alumno_Exelencia(dni) != null)
                    aux = CD_BecaExcelencia.Instancia.Obtener_Alumno_Exelencia(dni);
            return aux != null ? aux : null;
        }
        #endregion metodos
    }
}
