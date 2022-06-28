using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Alumnos;
using CapaEntidad.Curso;
namespace CapaLogica.Curso
{
    public class CL_Curso
    {
        #region Singleton

        private static readonly CL_Curso _instancia = new CL_Curso();

        public static CL_Curso Instancia
        {
            get { return CL_Curso._instancia; }
        }

        #endregion
        #region metodos
        public bool crear_Curso(E_Curso curso)
        {

            return CD_Curso.Instancia.Crear_curso(curso) ;
        }

        public List<E_Curso> listar_cursos()
        {
            return CD_Curso.Instancia.listar_cursos();
        }

        public bool Enalazar_Curso_Alumno(string dni, int Curso_ID)
        {
            return CD_Curso.Instancia.Enalazar_Curso_Alumno(dni, Curso_ID) ;
        }

        public List<E_Curso> listar_curso_estado()
        {
            return CD_Curso.Instancia.listar_curso_estado();
        }

        public bool Verificar_curso_ID(int Curso_id)
        {
            return CD_Curso.Instancia.buscar_curso(Curso_id);
        }
        #endregion metodos
    }
}
