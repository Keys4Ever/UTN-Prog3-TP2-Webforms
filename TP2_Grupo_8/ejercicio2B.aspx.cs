using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_Grupo_8
{
    public partial class ejercicio2B : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String nombre;
            String apellido;
            String ciudad;
            String temas;
            string totalTemas = "";

            nombre = Request.QueryString["nombre"];
            apellido = Request.QueryString["apellido"];
            ciudad = Request.QueryString["ciudad"];
            temas = Request.QueryString["temas"];
      
            string[] temasArray = temas.Split(',');
            foreach (String tema in temasArray)
            {
                totalTemas += tema + "</br>";
            }
           
            txtApellido.Text = apellido;
            txtNombre.Text = nombre;
            txtCiudad.Text = ciudad;
            txtTemas.Text = totalTemas;



        }
    }
}