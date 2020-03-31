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
            ENUsuario enu = new ENUsuario();
            enu.nif = NIF.Text;
            if (enu.readUsuario())
            {
                NIF.Text = enu.nif;
                Nombre.Text = enu.nombre;
                Edad.Text = enu.edad.ToString();
            }
            else
            {
                label1.Text = "Error, no se encuentra al usuario.";
            }
        }

        protected void Leer_Primero_Click(object sender, EventArgs e)
        {
            ENUsuario enu = new ENUsuario();
            if (enu.readFirstUsuario())
            {
                NIF.Text = enu.nif;
                Nombre.Text = enu.nombre;
                Edad.Text = enu.edad.ToString();
            }
            else
            {
                label1.Text = "Error, la base de datos está vacía";
            }
        }

        protected void Leer_Siguiente_Click(object sender, EventArgs e)
        {
            ENUsuario enu = new ENUsuario();
            enu.nif = NIF.Text;
            if (enu.readNextUsuario())
            {
                NIF.Text = enu.nif;
                Nombre.Text = enu.nombre;
                Edad.Text = enu.edad.ToString();
            }
            else
            {
                label1.Text = "Error, la base de datos está vacía";
            }
        }
        protected void Leer_Anterior_Click(object sender, EventArgs e)
        {
            ENUsuario enu = new ENUsuario();
            enu.nif = NIF.Text;
            if (enu.readPrevUsuario())
            {
                NIF.Text = enu.nif;
                Nombre.Text = enu.nombre;
                Edad.Text = enu.edad.ToString();
            }
            else
            {
                label1.Text = "Error, la base de datos está vacía";
            }
        }
        protected void Crear_Click(object sender, EventArgs e)
        {
            if (NIF.Text=="" || Nombre.Text=="" || Edad.Text=="")
            {
                label1.Text = "Completa todos los campos antes de crear un usuario por favor";
            }
            else 
            {
                ENUsuario enu = new ENUsuario();
                enu.nif = NIF.Text;
                enu.nombre = Nombre.Text;
                enu.edad = int.Parse(Edad.Text);
                if (enu.createUsuario()) {
                    label1.Text = "Creado usuario.";
                }
                else
                {
                    label1.Text = "Error, no se ha podido crear.";
                }
            }
        }
        protected void Actualizar_Click(object sender, EventArgs e)
        {
            ENUsuario enu = new ENUsuario();
            enu.nif = NIF.Text;
            enu.nombre = Nombre.Text;
            enu.edad = int.Parse(Edad.Text);
            if(enu.updateUsuario()){
                label1.Text = "Actualizado usuario.";
            }
            else
            {
                label1.Text = "Error, no se ha podido actualizar.";
            }
}
        protected void Borrar_Click(object sender, EventArgs e)
        {
            ENUsuario enu = new ENUsuario();
            enu.nif = NIF.Text;
            if (enu.deleteUsuario()) { 
                NIF.Text = "";
                Nombre.Text = "";
                Edad.Text = "";
                label1.Text = "Eliminado usuario.";
            }
            else
            {
                label1.Text = "Error, no se ha podido eliminar.";
            }
        }
    }
}