﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion
    {
        public static readonly Conexion _instancia = new Conexion();
        public static Conexion Instancia
        {
            get { return Conexion._instancia; }
        }

        public SqlConnection Conectar()
        {
            SqlConnection conect = new SqlConnection();
            conect.ConnectionString = "Server=DESKTOP-LC3JB16\\MSQLSERVER; Database=Calidad_grupo_01;integrated security =True;";

            return conect;
        }   
    }
}
