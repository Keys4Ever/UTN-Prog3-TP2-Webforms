using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_Grupo_8
{
	public partial class ejercicio1 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void txtBxProducto1_TextChanged(object sender, EventArgs e)
		{
			

		}
        protected void txtBxProducto2_TextChanged(object sender, EventArgs e)
        {


        }

        protected void txtBxCantidad1_TextChanged(object sender, EventArgs e)
        {
			string cantidad = txtBxCantidad1.Text;

			for(int i =0;i<cantidad.Length;)
			{
				char c = cantidad[i];

				if(c < '0' || c > '9')
				{
					cantidad = cantidad.Remove(i, 1);
				}
				else
				{
					i++;
				}
			}

			txtBxCantidad1.Text = cantidad;
        }

        protected void txtBxCantidad2_TextChanged(object sender, EventArgs e)
        {
            string cantidad = txtBxCantidad2.Text;

            for (int i = 0; i < cantidad.Length;)
            {
                char c = cantidad[i];

                if (c < '0' || c > '9')
                {
                    cantidad = cantidad.Remove(i, 1);
                }
                else
                {
                    i++;
                }
            }
            txtBxCantidad2.Text = cantidad;
        }
    }
}