﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_Grupo_8
{
	public partial class ejercicio5 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
			
			
			txtBxClave.Attributes["value"] = txtBxClave.Text;
        }

        protected void BtnValidar_Click(object sender, EventArgs e)
        {
			string usuarioRegistrado = "claudio";
			string contrasenaRegistrado = "casas";

			if(txtBxUsuario.Text != usuarioRegistrado 
				&& txtBxClave.Text != contrasenaRegistrado)
			{
                Response.Redirect("ejercicio4B.aspx");
            }

            Response.Redirect("ejercicio4C.aspx?User=" + txtBxUsuario.Text + "&Code=" + txtBxClave.Text);
        }
    }
}