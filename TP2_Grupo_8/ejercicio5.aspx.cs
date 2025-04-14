using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_Grupo_8
{
    public partial class Ejercicio5real : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
            }
        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            double precioFinal = 0;
            string textoPrecio;

            if (ddlMemorias.SelectedIndex >= 0 && double.TryParse(ddlMemorias.SelectedItem.Value, out double result)) precioFinal += result;


            foreach (ListItem item in chkbxAccesorios.Items)
            {
                if (item.Selected && Double.TryParse(item.Value, out double pA)) precioFinal += pA;
            }
            textoPrecio = "El precio final es de: " + precioFinal.ToString() + "$";
            lblPrecioFinal.Text = textoPrecio;

        }
    }
}