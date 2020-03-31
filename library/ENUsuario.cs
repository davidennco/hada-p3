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
            get { return pnif; }
            set
            {
                pnif = value;
            }
        }
        public string nombre
        {
            get { return pnombre; }
            set
            {
                pnombre = value;
            }
        }
        public int edad {
            get { return pedad; }
            set {
                if (value > 0)
                    pedad = value;
                else
                    pedad = 0;
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
            CADUsuario cad = new CADUsuario();
            if (cad.readUsuario(this))
                return false; 
            else
                return cad.createUsuario(this);
        }
        public bool readUsuario() {
            CADUsuario cad = new CADUsuario();
            return cad.readUsuario(this);
        }
        public bool readFirstUsuario() {
            CADUsuario cad = new CADUsuario();
            return cad.readFirstUsuario(this); 
        }
        public bool readNextUsuario() {
            CADUsuario cad = new CADUsuario();
            return cad.readNextUsuario(this);
        }
        public bool readPrevUsuario() {
            CADUsuario cad = new CADUsuario();
            return cad.readPrevUsuario(this);
        }
        public bool updateUsuario() {
            CADUsuario cad = new CADUsuario();
            return cad.updateUsuario(this); 
        }
        public bool deleteUsuario() {
            CADUsuario cad = new CADUsuario();
            return cad.deleteUsuario(this); 
        }
    }
}
