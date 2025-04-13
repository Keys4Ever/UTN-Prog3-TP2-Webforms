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

            int indexRam = ddlMemorias.SelectedIndex;

            switch (indexRam)
            {
                case 0:
                    //2gb de ram
                    precioFinal += 200;
                    break;
                case 1:
                    //4gb de ram
                    precioFinal += 375;
                    break;
                case 2:
                    //6gb de ram
                    precioFinal += 500;
                    break;
                default:
                    precioFinal += 0;
                    break;
            }

            int i = 0;
            foreach (ListItem item in chkbxAccesorios.Items)
            {
                if (item.Selected)
                {
                    switch (i)
                    {
                        case 0:
                            // monitor lcd
                            precioFinal += 2000.50;
                            break;
                        case 1:
                            // HD 500 gb
                            precioFinal += 550.50;
                            break;
                        case 2:
                            // grabadora dvd
                            precioFinal += 1200;
                            break;
                        default:
                            precioFinal += 0;
                            break;
                    }
                }
                i++;
            }

            textoPrecio = "El precio final es de: " + precioFinal.ToString() + "$";
            lblPrecioFinal.Text += textoPrecio;

        }
    }
}