using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicios
{
    public partial class Ejercicio_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            Int32 distancia = Convert.ToInt32(txtDistanica.Text);
            Int32 dias = Convert.ToInt32(txtDias.Text);
            Int32 valor = 0;
            Int32 valorPorcentaje = 0;

            if (distancia > 1000 && dias > 7)
            {
                Int32 valorParcial = distancia * 35;
                valorPorcentaje = (valorParcial / 300) * 100;
                valor = valorParcial - valorPorcentaje;
            }
            else
            {
                valor = distancia * 35;
            }
            lblValor.Text = "   Total Valor Viaje: "+ Convert.ToString(valor);
        }
    }
}