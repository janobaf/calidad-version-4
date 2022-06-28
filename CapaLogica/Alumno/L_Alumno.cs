using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Inscripcion;
using CapaDatos.Alumnos;
using CapaEntidad.Alumno;
namespace CapaLogica
{
    public class L_Alumno
    {
        #region Singleton
        private static readonly L_Alumno _instancia = new L_Alumno();
        public static L_Alumno Instancia
        {
            get { return L_Alumno._instancia; }
        }
        #endregion
        #region metodos
        private bool verificaciones_datos (E_Alumno ea)
        {
            int aux;
            bool auxiliar = false;
            bool resultado = Int32.TryParse(ea.Alumn_dni, out aux);
            if (resultado && ea.Alumn_dni.Length == 8 && ea.Alum_Telefono.Length == 9)
            {
              
                string correo = ea.Alum_Correo;
                int posicion = 0;
                int posicion_final = 0;
                if (!correo[0].Equals("@"))
                {
                    for (int i = 0; i < correo.Length; i++)
                    {
                        if (correo[i].ToString().Equals("@"))
                        {
                            posicion = i;
                        }
                        if (correo[i].ToString().Equals(".")) posicion_final = i;
                    }
                    StringBuilder dirrecion = new StringBuilder();
                    for (int i = posicion+1; i < posicion_final; i++) dirrecion.Append( correo[i]);
                    if (dirrecion.Equals("hotmail") || dirrecion.Equals("gmail")) auxiliar = true;
                }

            }

            return auxiliar; 
        }
        public bool crear_alumno(E_Alumno ea )
        {
            ea.Alum_ID = CD_Alumno.Instancia.id_automatico();
            if (verificaciones_datos(ea) &&  !CD_Alumno.Instancia.validar_dni(ea.Alumn_dni) && D_Crear_Inscripcion.Instancia.Crear_Alumnos_Inscripcion(ea))
                        return true;

             return false;

        }
        public bool modificar_alumno(E_Alumno ea)
        {
            if (D_Crear_Inscripcion.Instancia.Modificar_Alumnos_Inscripcion(ea))
                return true;

            return false;
        }
        public E_Alumno listar_alumno_dni(string dni)
        {
           E_Alumno aux = new E_Alumno();
            if (D_Crear_Inscripcion.Instancia.Listar_alumnos_DNI(dni) != null)
                aux = D_Crear_Inscripcion.Instancia.Listar_alumnos_DNI(dni);
            return aux !=null ? aux : null;
        }
        public List<E_Alumno> listar_alumnos()
        {
            List<E_Alumno> lista = D_Crear_Inscripcion.Instancia.Listar_alumnos_Inscripcion();
            return lista.Count > 0 ? lista : null;

        }

        public bool verificar_existencia_alumno(string dni)
        {
            return CD_Alumno.Instancia.validar_dni(dni);
        }
        #endregion metodos

        /*
         *      if null retorna  null si no retorna lista 
         * */
    }
}
