﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_Grupo_8
{
	public partial class paginaPrincipal : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}


        protected void btnEjercicio1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ejercicio1.aspx");
        }

        protected void btnEjercicio2_Click(object sender, EventArgs e)
        {
            Response.Redirect("ejercicio2A.aspx");
        }

        protected void btnEjercicio3_Click(object sender, EventArgs e)
        {
            Response.Redirect("ejercicio3.aspx");
        }

        protected void btnEjercicio4_Click(object sender, EventArgs e)
        {
            Response.Redirect("ejercicio4.aspx");
        }
        protected void btnEjercicio5_Click(object sender, EventArgs e)
        {
            Response.Redirect("ejercicio5.aspx");
        }
    }
}