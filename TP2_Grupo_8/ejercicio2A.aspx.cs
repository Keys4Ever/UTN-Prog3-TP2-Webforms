using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_Grupo_8
{
	public partial class ejercicio2 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void btnResumen_Click(object sender, EventArgs e)
        {
			lblErrorApellido.Text = "";

			if (txBxApellido.Text.Trim() == "")
			{
				lblErrorApellido.Text = "Ingrese el apellido.";
			}

            lblErrorNombre.Text = "";

            if (txBxNombre.Text.Trim() == "")
            {
                lblErrorNombre.Text = "Ingrese el nombre.";
            }

            string ciudad =DropDownList1.SelectedValue;

            string temas="";
            foreach (ListItem item in chboxTemas.Items)
            {
                if(item.Selected)
                {
                    temas+=item.Text+",";
                }
            }

            temas =temas.TrimEnd(',');

            Response.Redirect("ejercicio2b.aspx?Nombre="+txBxNombre.Text+"&Apellido="
                +txBxApellido.Text+"&ciudad="+ciudad+"&temas="+temas);
        }

        protected void txBxApellido_TextChanged(object sender, EventArgs e)
        {

        }
    }
}