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
        }

        protected void txBxApellido_TextChanged(object sender, EventArgs e)
        {

        }
    }
}