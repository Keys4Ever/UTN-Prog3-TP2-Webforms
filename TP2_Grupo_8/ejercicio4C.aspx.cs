﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_Grupo_8
{
    public partial class Ejercicio4b : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string nombre;
            nombre = Request.QueryString["User"];
            lblMensaje.Text += nombre;
        }
    }
}