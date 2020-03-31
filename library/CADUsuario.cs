using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace library
{
    public class CADUsuario
    {
        private string constring;
        public CADUsuario() {
            constring = ConfigurationManager.ConnectionStrings["Database"].ToString();
        }
        public bool createUsuario(ENUsuario en) {
            SqlConnection conn = new SqlConnection(constring);
            string comando = "Insert Into [dbo].[Usuarios] (nif, nombre, edad) " + "VALUES ('" + en.nif + "', '" + en.nombre + "', " + en.edad + ")";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(comando, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                conn.Close();
                Console.WriteLine("Error: " + e);
                return false;
            }
            return true;
        }
        public bool readUsuario(ENUsuario en) {
            SqlConnection conn= new SqlConnection(constring);
            String comando = "select * from [dbo].[Usuarios] where nif='" + en.nif + "'";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(comando, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr["nif"].ToString() == en.nif)
                {
                    en.nombre = dr["nombre"].ToString();
                    en.nif = dr["nif"].ToString();
                    en.edad = int.Parse(dr["edad"].ToString());
                    dr.Close();
                    conn.Close();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                conn.Close();
                return false;
            }
        }
        public bool readFirstUsuario(ENUsuario en) {
            SqlConnection conn = new SqlConnection(constring);
            string comando = "SELECT * " + "FROM [dbo].[Usuarios]";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(comando, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                en.edad = int.Parse(dr["edad"].ToString());
                en.nombre = dr["nombre"].ToString();
                en.nif = dr["nif"].ToString();
                conn.Close();
                return true;
            }
            catch (Exception)
            {
                conn.Close();
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public bool readNextUsuario(ENUsuario en) {
            SqlConnection conn = new SqlConnection(constring);
            string comando = "SELECT * " + "FROM [dbo].[Usuarios]";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(comando, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                bool encontrado = false;
                while (dr.Read())
                {
                    if (encontrado)
                    {
                        en.edad = int.Parse(dr["edad"].ToString());
                        en.nombre = dr["nombre"].ToString();
                        en.nif = dr["nif"].ToString();
                        conn.Close();
                        return true;
                    }
                    else if (dr["nif"].ToString() == en.nif)
                    {
                        encontrado = true;
                    }
                }
            }
            catch (Exception)
            {
                conn.Close();
                return false;
            }
            finally
            {
                conn.Close();
            }

            return false;
        }
        public bool readPrevUsuario(ENUsuario en) {
            SqlConnection conn = new SqlConnection(constring);
            string comando = "SELECT * " + "FROM [dbo].[Usuarios]";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(comando, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                ENUsuario enaux = new ENUsuario();
                while (dr.Read())
                {
                    if (dr["nif"].ToString() == en.nif.ToString())
                    {
                        en.edad = enaux.edad;
                        en.nombre = enaux.nombre;
                        en.nif = enaux.nif;
                        return true;
                    }
                    else {
                        enaux.edad = int.Parse(dr["edad"].ToString());
                        enaux.nombre = dr["nombre"].ToString();
                        enaux.nif = dr["nif"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                conn.Close();
                return false;
            }
            finally
            {
                conn.Close();
            }

            return false;
        }
        public bool updateUsuario(ENUsuario en) {
            SqlConnection conn = new SqlConnection(constring);
            string comando = "UPDATE [dbo].[Usuarios] " + "SET nombre = '" + en.nombre + "',  edad = " + en.edad + "where nif ='" + en.nif+"'";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(comando, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                conn.Close();
                return false;
            }
            finally
            {
                conn.Close();
            }

            return true;
        }
        public bool deleteUsuario(ENUsuario en) {
            SqlConnection conn = new SqlConnection(constring); ;
            string comando = "Delete from [dbo].[Usuarios] where nif = '" + en.nif +"'";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(comando, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                conn.Close();
                return false;
            }
            finally {
                conn.Close();
            }
            return true;
        }
    }
}
