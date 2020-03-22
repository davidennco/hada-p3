using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENUsuario
    {
        private string pnif;
        private string pnombre;
        private int pedad;

        public string nif {
            get => pnif;
            set
            {
                pnif = value;
            }
        }
        public string nombre
        {
            get => pnombre;
            set
            {
                pnombre = value;
            }
        }
        public int edad {
            get => edad;
            set {
                if(value>=0)
                    edad = value;                    
            }
        }
        public ENUsuario() {
            nif = null;
            nombre = null;
            edad = 0;
        }
        public ENUsuario(string nif, string nombre, int edad){
            this.nif = nif;
            this.nombre = nombre;
            this.edad = edad;
        }
        public bool createUsuario() { return false; }
        public bool readUsuario() { return false; }
        public bool readFirstUsuario() {
            this=
            return false; }
        public bool readNextUsuario() { return false; }
        public bool readPrevUsuario() { return false; }
        public bool updateUsuario() { return false; }
        public bool deleteUsuario() { return false; }
    }
}
