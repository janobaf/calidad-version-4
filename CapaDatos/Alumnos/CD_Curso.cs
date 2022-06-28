﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad.Curso;
namespace CapaDatos.Alumnos
{
    public class CD_Curso
    {
        
        #region Singleton
        private static readonly CD_Curso _instancia = new CD_Curso();
        public static CD_Curso Instancia
        {
            get { return CD_Curso._instancia; }
        }
        #endregion
        #region metodos

        private int id_automatico()
        {
            int id = 0;
            SqlCommand cmd = null;
            bool validar = false;
            try
            {
              
                SqlConnection cn = Conexion.Instancia.Conectar();

                string Consulta_sql = "select max(Curso_ID) Curso_ID from Curso ";
                cmd = new SqlCommand(Consulta_sql, cn);

                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr["Curso_ID"].ToString() != "") validar = true;
                    if (validar) id = int.Parse(dr["Curso_ID"].ToString());
                }
            }

            catch { throw; }
            finally { cmd.Connection.Close(); }
            return validar ? id+1:-1 ;
        }
        public bool Crear_curso (E_Curso curso )
        {
            bool validar = false;
            SqlCommand cmd = null;
            try
            {
                int id = this.id_automatico();
                if (id != -1)
                {
                    curso.Curso_ID = id;
                    SqlConnection cn = Conexion.Instancia.Conectar();
                    cmd = new SqlCommand("Crear_Curso", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Curso_ID", curso.Curso_ID);
                    cmd.Parameters.AddWithValue("@Curso_Nombre", curso.Curso_Nombre);
                    cmd.Parameters.AddWithValue("@Curso_Estado", curso.Curso_Estado);
                    cmd.Parameters.AddWithValue("@Curso_FechInscrip", curso.Curso_FecInscripcion);
                    cmd.Parameters.AddWithValue("@Curso_Descripcion", curso.Curso_Descripcion);
                    cn.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0) validar = true;
                }

            }
            catch{ throw; }
            finally{ cmd.Connection.Close(); }
            return validar;
        }
       
        public List <E_Curso> listar_cursos()
        {
            List<E_Curso> listar_c = new List<E_Curso>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                string sql = "select Curso_ID , Curso_Nombre , Curso_Estado , Curso_FechInscrip ,Curso_Descripcion from Curso";
                cmd = new SqlCommand(sql, cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    E_Curso curso = new E_Curso();
                    curso.Curso_ID = int.Parse(dr["Curso_ID"].ToString());
                    curso.Curso_Nombre = dr["Curso_Nombre"].ToString();
                    curso.Curso_Estado = dr["Curso_Estado"].ToString();
                    curso.Curso_FecInscripcion = DateTime.Parse(dr["Curso_FechInscrip"].ToString());
                    curso.Curso_Descripcion = dr["Curso_Descripcion"].ToString();
                    listar_c.Add(curso);

                     
                }
            }
            catch { throw; }
            finally
            {
                cmd.Connection.Close();

            }
            return listar_c != null ? listar_c : null;
        }

        public bool buscar_curso(int Curso_ID)
        {
            bool validar = false;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                string consulta_sql = "select Curso_ID from Curso where Curso_ID =" + Curso_ID;
                cmd = new SqlCommand(consulta_sql, cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    if (dr["Curso_ID"].ToString() != null) validar = true;
                }
            }
            catch  { throw; }
            finally { cmd.Connection.Close(); }

            return validar;
        }
        public List<E_Curso> listar_curso_estado ()
        {
            List<E_Curso> listar = new List<E_Curso>();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                string consulta_sql = "select Curso_id,Curso_Nombre,Curso_Estado,Curso_FechInscrip,Curso_Descripcion from Curso where Curso_Estado ="+ "'true' ";
                cmd = new SqlCommand(consulta_sql, cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    E_Curso aux = new E_Curso();
                    aux.Curso_ID = int.Parse(dr["Curso_id"].ToString());
                    aux.Curso_Nombre = dr.GetString(1);
                    aux.Curso_Estado = dr.GetString(2);
                    aux.Curso_FecInscripcion = DateTime.Parse(dr["Curso_FechInscrip"].ToString());
                    aux.Curso_Descripcion = dr.GetString(4);    
                    listar.Add(aux);
                }
            }
            catch{ throw ; }
            finally { cmd.Connection.Close(); }

            return listar != null ? listar : null;
        }

        public bool Enalazar_Curso_Alumno(string dni , int Curso_ID)
        {
            bool validar = false;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                string consulta_sql = "update c set c.Alum_ID = a.Alum_ID ,c.Curso_Estado='false' from Alumno a ,Curso c where a.Alum_DNI=" + dni + " and c.Curso_ID =";
                consulta_sql += Curso_ID;
                cmd = new SqlCommand(consulta_sql, cn);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) validar = true;

            }
            catch  { throw ; }
            finally { cmd.Connection.Close(); }
            return validar;
        } 
            #endregion metodos
    }
}
