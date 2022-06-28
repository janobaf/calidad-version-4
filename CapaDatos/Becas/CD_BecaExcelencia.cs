using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad.Alumno;
using CapaEntidad.Becas;
using CapaDatos.Alumnos;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos.Becas
{
    public class CD_BecaExcelencia
    {
        //!SEGUNDO CASO DE USO 
        #region Singleton
        private static readonly CD_BecaExcelencia _instancia = new CD_BecaExcelencia();
        public static CD_BecaExcelencia Instancia
        {
            get { return CD_BecaExcelencia._instancia; }
        }

        #endregion
        #region metodos


        //!Funcion para modificar la pension del alumno de la beca por excelencia 
        //@param dni de tipo string recibida por la funcion
        // ?El dnni deve de ser string con unos 8 digitos y deve ser numerico
        private int id_automatico()
        {
            // !se declara null el sqlcomand 
            int id = 0;
            bool validar = false;
            SqlCommand cmd = null;
            try
            {
                //!Se llama a la Conexion dentro de CapaDatos 
                //!La clase Conexion nos devuelve una instancia y se guarda en la variable cn

                SqlConnection cn = Conexion.Instancia.Conectar();
                // @param sql  de tipo string guarda la consulta que se quiera hacer al sql

                string Consulta_sql = "select max(BecaPorPromedio_id) BecaPorPromedio_id from BecaPorPromedio ";
                cmd = new SqlCommand(Consulta_sql, cn);
                // ! Se abre la conexion

                cn.Open();
                // !Se ejecuta la consulta 

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr["BecaPorPromedio_id"].ToString() != "") validar = true;
                    if (validar ) id = int.Parse(dr["BecaPorPromedio_id"].ToString());
                }
            }
            catch (Exception ) { throw ; }
            finally
            {
                cmd.Connection.Close();

            }
            return id + 1 ;
        }

        private E_Alumno Beca_por_promedio(string dni)
        {
            E_Alumno alumno = new E_Alumno();
            SqlCommand cmd = null;
            try
            {
                //!Se llama a la Conexion dentro de CapaDatos 
                //!La clase Conexion nos devuelve una instancia y se guarda en la variable cn

                SqlConnection cn = Conexion.Instancia.Conectar();
                // @param sql  de tipo string guarda la consulta que se quiera hacer al sql

                string Consulta_sql = "select Alum_Nombre,Alum_ApellidoPaterno,Alum_ApellidoMaterno ,Alum_DNI from Alumno where Alum_DNI =";
                Consulta_sql += dni;
                cmd = new SqlCommand(Consulta_sql, cn);
                // ! Se abre la conexion

                cn.Open();
                // !Se ejecuta la consulta 

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    alumno.Alumn_nombre = dr["Alum_Nombre"].ToString();
                    alumno.Alumn_ApellidoPaterno = dr["Alum_ApellidoPaterno"].ToString();
                    alumno.Alumn_ApellidoMaterno = dr["Alum_ApellidoMaterno"].ToString();
                    alumno.Alumn_dni = dr["Alum_DNI"].ToString();

                }
            }
            catch (Exception ) { throw ; }
            finally
            {
                cmd.Connection.Close();

            }

            return alumno != null ? alumno : null;

        }
        private void enlazar_beca(string dni)
        {

            SqlCommand cmd = null;

            try
            {
                //!Se llama a la Conexion dentro de CapaDatos 
                //!La clase Conexion nos devuelve una instancia y se guarda en la variable cn

                // @param sql  de tipo string guarda la consulta que se quiera hacer al sql


                int id = this.id_automatico();
                if (id >=0)
                {
                    E_Alumno alumno = this.Beca_por_promedio(dni);
                    if(alumno != null )
                    {
                      
                        SqlConnection cn = Conexion.Instancia.Conectar();

                        cmd = new SqlCommand("EnlazarBeca", cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        // ! Se abre la conexion
                        cmd.Parameters.AddWithValue("@ID", id);
                        cmd.Parameters.AddWithValue("@dni", dni);
                        cmd.Parameters.AddWithValue("@Nombre", alumno.Alumn_nombre);
                        cmd.Parameters.AddWithValue("@ApellidoMaterno", alumno.Alumn_ApellidoMaterno);
                        cmd.Parameters.AddWithValue("@ApellidoPaterno", alumno.Alumn_ApellidoPaterno);
                        
                        cn.Open();
                        // !Se ejecuta la consulta 
                        cmd.ExecuteNonQuery();
                    }
                   
                }

            }
            catch (Exception ) { throw ; }
            finally { cmd.Connection.Close(); } //!Cerramos la conexion
        }

    
        public bool modificar_pension_alumno(string dni)
        {
            // !se declara null el sqlcomand 

            SqlCommand cmd = null;
            // !Declaramos una variable bool por defecto en false 
            bool validar = false;

            /* !
             * Se llama a la funcion dentro de la capaDatos.Alumno
             * La funcion nos retorna si es true o false
             * Si es true entra en el if
            */
            
                try
                {
                    //!Se llama a la Conexion dentro de CapaDatos 
                    //!La clase Conexion nos devuelve una instancia y se guarda en la variable cn

                    SqlConnection cn = Conexion.Instancia.Conectar();
                // @param sql  de tipo string guarda la consulta que se quiera hacer al sql

               
                   string  sql ="update Alumno set Alum_Pension=Alum_Pension -(Alum_Pension *0.6) where Alum_DNI =";
                    sql += dni;
                cmd = new SqlCommand(sql, cn);
                    // ! Se abre la conexion

                    cn.Open();
                    // !Se ejecuta la consulta 
                    int i = cmd.ExecuteNonQuery();
                    //!Si se ejecuto con exito deve de devolver una valor entero mayor a 0
                    if (i > 0) { validar = true; this.enlazar_beca(dni); } //!Cambiamos el bool a true 
                }
                catch (Exception ) { throw ; }
                finally { cmd.Connection.Close(); } //!Cerramos la conexion
            
            //!Retornar el resultado final
            return validar;


    
        }

        public bool verificar_Alumno_Beca(string dni)
        {
            SqlCommand cmd = null;
            bool validar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                string sql_consuilta = "select p.Alum_DNI from Alumno a inner join BecaPorPromedio p on a.BeccaPorPromedio_id=p.BecaPorPromedio_id  where a.Alum_DNI = ";
                sql_consuilta += dni;
                cmd = new SqlCommand(sql_consuilta, cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string aux = dr.GetString(0);
                   if (aux != null)
                    {
                        validar = true;
                    }
                }
            }
            catch(Exception ) { throw ; }
            finally { cmd.Connection.Close(); }
            return validar;
        }
        public bool modificar_Beca(string dni)
        {
            bool validar = false;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("modificar_Beca", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dni", dni);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                //!Si se ejecuto con exito deve de devolver una valor entero mayor a 0
                if (i > 0) { validar = true;  }
            }
            catch (Exception ) { throw ; }
            finally { cmd.Connection.Close(); }
            return validar;
        }
        public E_Alumno Obtener_Alumno_Exelencia(string dni)
        {
            SqlCommand cmd = null;
            E_Alumno aux = new E_Alumno();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                string sql_consulta = "select a.Alum_Nombre,a.Alum_ApellidoMaterno , a.Alum_ApellidoPaterno,a.Alum_DNI,a.Alum_Correo,a.Alum_Telefono from Alumno a inner join BecaPorPromedio b on a.BeccaPorPromedio_id = b.BecaPorPromedio_id ";
                sql_consulta += "where a.Alum_DNI= " + dni ;
                cmd = new SqlCommand(sql_consulta, cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    aux.Alumn_nombre = dr.GetString(0);
                    aux.Alumn_ApellidoMaterno = dr.GetString(1);
                    aux.Alumn_ApellidoPaterno = dr.GetString(2);
                    aux.Alumn_dni = dr.GetString(3);
                    aux.Alum_Correo = dr.GetString(4);
                    aux.Alum_Telefono = dr.GetString(5);

                }
            }
            catch (Exception ) { throw ; }
            finally { cmd.Connection.Close(); }
            return aux != null ? aux : null;

        }

        public List<E_BecaPorPromedio> ListaDeBeca()
        {

            List<E_BecaPorPromedio> lista = new List<E_BecaPorPromedio>();
            SqlConnection connection = Conexion.Instancia.Conectar();
            connection.Open();
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT BecaPorPromedio_Id, BecaPorPromedio_Nombre, BecaPorPromedio_ApellidoPaterno, BecaPorPromedio_ApellidoMaterno FROM BecaPorPromedio";
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    E_BecaPorPromedio alumn = new E_BecaPorPromedio();
                    alumn.BecaPorPromedio_id = reader.GetInt32(0);
                    alumn.BecaPorPromedioNombre = reader.GetString(1);
                    alumn.BecaPorPromedioApellido_Paterno = reader.GetString(2);
                    alumn.BecaPorPromedioApellido_Materno = reader.GetString(3);
                    lista.Add(alumn);
                }
                reader.Close();
            }
            return lista;

        }

     
        #endregion metodos
    }
}
