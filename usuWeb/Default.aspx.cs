using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;

namespace usuWeb
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Leer_Click(object sender, EventArgs e)
        {
            ENUsuario enu = (ENUsuario)sender;
            enu.nif = NIF.Text;
            enu.nombre = Nombre.Text;
            enu.edad = int.Parse(Edad.Text);
            enu.readUsuario();
        }

        protected void Leer_Primero_Click(object sender, EventArgs e)
        {
            ENUsuario enu = (ENUsuario)sender;
            enu.nif = NIF.Text;
            enu.nombre = Nombre.Text;
            enu.edad = int.Parse(Edad.Text);
            enu.readFirstUsuario();
        }

        protected void Leer_Siguiente_Click(object sender, EventArgs e)
        {
            ENUsuario enu = (ENUsuario)sender;
            enu.nif = NIF.Text;
            enu.nombre = Nombre.Text;
            enu.edad = int.Parse(Edad.Text);
            enu.readNextUsuario();
        }
        protected void Leer_Anterior_Click(object sender, EventArgs e)
        {
            ENUsuario enu = (ENUsuario)sender;
            enu.nif = NIF.Text;
            enu.nombre = Nombre.Text;
            enu.edad = int.Parse(Edad.Text);
            enu.readPrevUsuario();
        }
        protected void Crear_Click(object sender, EventArgs e)
        {
            ENUsuario enu = (ENUsuario)sender;
            enu.nif = NIF.Text;
            enu.nombre = Nombre.Text;
            enu.edad = int.Parse(Edad.Text);
            enu.createUsuario();
        }
        protected void Actualizar_Click(object sender, EventArgs e)
        {
            ENUsuario enu = (ENUsuario)sender;
            enu.nif = NIF.Text;
            enu.nombre = Nombre.Text;
            enu.edad = int.Parse(Edad.Text);
            enu.updateUsuario();
        }
        protected void Borrar_Click(object sender, EventArgs e)
        {
            ENUsuario enu = (ENUsuario)sender;
            enu.nif = NIF.Text;
            enu.nombre = Nombre.Text;
            enu.edad = int.Parse(Edad.Text);
            enu.deleteUsuario();
        }
    }
}