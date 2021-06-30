using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace SistemaDatos
{
    public class Conexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private bool Seguridad;
        private static Conexion Con = null;

        private Conexion()
        {
            this.Base = "BibliotecaNCAPAS02";
            this.Servidor = "192.168.0.2";
            this.Usuario = "sa";
            this.Clave = "M0nic@linda01";
            this.Seguridad = true; //seguridad de windows
        }

        public SqlConnection CrearConexion()
        {
            SqlConnection Cadena = new SqlConnection();
            try
            {
                Cadena.ConnectionString = "Server=" + this.Servidor + "; Database=" + this.Base + ";";
                if (this.Seguridad)
                {
                    Cadena.ConnectionString = Cadena.ConnectionString + "Integrated Security= SSPI";
                }
                else
                {
                    Cadena.ConnectionString = Cadena.ConnectionString + "User ID=" + this.Usuario + "; Password=" + this.Clave + ";";
                }
            }
            catch (Exception e)
            {
                Cadena = null;
                throw e;
            }
            return Cadena;
        }

       

        public static Conexion getInstancia()
        {
            if (Con == null)
            {
                Con = new Conexion();
            }
            return Con; 
        }
    }
}