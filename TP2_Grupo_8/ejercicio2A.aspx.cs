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
			lblError.Text = "";

			if (txBxApellido.Text.Trim() == "")
			{
				lblError.Text = "Ingrese el apellido.";
			}
        }
    }
}