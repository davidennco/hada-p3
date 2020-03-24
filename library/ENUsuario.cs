using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENUsuario
    {
        private CADUsuario cad = new CADUsuario();
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
        public bool createUsuario() {
            return cad.createUsuario(this);
        }
        public bool readUsuario() {
            return cad.readUsuario(this);
        }
        public bool readFirstUsuario() {
            return cad.readFirstUsuario(this); 
        }
        public bool readNextUsuario() { 
            return cad.readNextUsuario(this);
        }
        public bool readPrevUsuario() { 
            return cad.readPrevUsuario(this);
        }
        public bool updateUsuario() { 
            return cad.updateUsuario(this); 
        }
        public bool deleteUsuario() { 
            return cad.deleteUsuario(this); 
        }
    }
}
