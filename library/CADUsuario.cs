using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class CADUsuario
    {
        private string constring;
        public CADUsuario() {
            constring = null; 
        }
        public bool createUsuario(ENUsuario en) {
            return false;
        }
        public bool readUsuario(ENUsuario en) { 
             
        }
        public bool readFirstUsuario(ENUsuario en) { 
            return false; 
        }
        public bool readNextUsuario(ENUsuario en) { 
            return false; 
        }
        public bool readPrevUsuario(ENUsuario en) { 
            return false;
        }
        public bool updateUsuario(ENUsuario en) { 
            return false;
        }
        public bool deleteUsuario(ENUsuario en) {
            SqlConnection conn = null;
            string comando = "Delete from Usuario where nif = " + en.nif;
            try
            {
                conn = new SqlConnection(constring);
                conn.Open();
                SqlCommand cmd = new SqlCommand(comando, conn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                conn.Close();
                return false;
            }
            finally {
                conn.Close();
            }
        }
    }
}
