﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_Grupo_8
{
	public partial class ejercicio3 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
			lblTextoColoreado.ForeColor = System.Drawing.Color.Red;
        }
    }
}