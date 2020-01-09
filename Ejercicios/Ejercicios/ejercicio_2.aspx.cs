using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicios
{
    public partial class ejercicio_2 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btningresar_Click(object sender, EventArgs e)
        {
            Int32 capacidaCarga = 18000;
            Int32 pesoBulto = Convert.ToInt32(txtPeso.Text);
            Int32 pesoTotal = Convert.ToInt32(lblTotalPesoBultos.Text);
            Int32 totalBultos = Convert.ToInt32(lblTotalCantidad.Text); ;
            Int32 bultopesado = Convert.ToInt32(lblBultoPesado.Text); ;
            Int32 bultolivinano = Convert.ToInt32(lblBultoLiviano.Text); ;
            Int32 pesopromedio = Convert.ToInt32(lblPromedioBultos.Text); ;
            Int32 costoTotalPesos = Convert.ToInt32(lblPesos.Text); ;
            Int32 costoTotalDolares = Convert.ToInt32(lblDolares.Text); ;

            if (pesoTotal <= capacidaCarga)
            {
                if (pesoBulto < capacidaCarga && pesoBulto <= 500)
                {
                    if ((pesoBulto + pesoTotal) < capacidaCarga)
                    {
                        if (pesoBulto > 0 && pesoBulto <= 25)
                        {
                            pesoTotal = pesoTotal + pesoBulto;
                            totalBultos = totalBultos + 1;
                            pesopromedio = (pesoTotal / totalBultos);

                            if (pesoBulto > bultopesado)
                            {
                                bultopesado = pesoBulto;
                            }
                            if (bultolivinano == 0)
                            {
                                bultolivinano = pesoBulto;
                            }
                            else
                            {
                                if (pesoBulto < bultolivinano)
                                {
                                    bultolivinano = pesoBulto;
                                }
                            }
                        }
                        else
                        {
                            if (pesoBulto >= 26 && pesoBulto <= 300)
                            {
                                Int32 costobulto = 0;
                                pesoTotal = pesoTotal + pesoBulto;
                                totalBultos = totalBultos + 1;
                                pesopromedio = (pesoTotal / totalBultos);
                                costobulto = (pesoBulto * 1500);
                                costoTotalPesos = costoTotalPesos + costobulto;
                                if (pesoBulto > bultopesado)
                                {
                                    bultopesado = pesoBulto;
                                }
                                if (bultolivinano == 0)
                                {
                                    bultolivinano = pesoBulto;
                                }
                                else
                                {
                                    if (pesoBulto < bultolivinano)
                                    {
                                        bultolivinano = pesoBulto;
                                    }
                                }
                            }
                            else
                            {
                                if (pesoBulto >= 301 && pesoBulto <= 500)
                                {
                                    Int32 costobulto = 0;
                                    pesoTotal = pesoTotal + pesoBulto;
                                    totalBultos = totalBultos + 1;
                                    pesopromedio = (pesoTotal / totalBultos);
                                    costobulto = (pesoBulto * 2500);
                                    costoTotalPesos = costoTotalPesos + costobulto;
                                    if (pesoBulto > bultopesado)
                                    {
                                        bultopesado = pesoBulto;
                                    }
                                    if (bultolivinano == 0)
                                    {
                                        bultolivinano = pesoBulto;
                                    }
                                    else
                                    {
                                        if (pesoBulto < bultolivinano)
                                        {
                                            bultolivinano = pesoBulto;
                                        }
                                    }

                                }
                            }
                        }
                        lblTotalCantidad.Text = Convert.ToString(totalBultos);
                        lblTotalPesoBultos.Text = Convert.ToString(pesoTotal);
                        lblBultoPesado.Text = Convert.ToString(bultopesado);
                        lblBultoLiviano.Text = Convert.ToString(bultolivinano);
                        lblPromedioBultos.Text = Convert.ToString(pesopromedio);
                        lblPesos.Text = Convert.ToString(costoTotalPesos);
                        if (costoTotalPesos > 0)
                        {
                            costoTotalDolares = costoTotalPesos / 3000;
                        }
                        lblDolares.Text = Convert.ToString(costoTotalDolares);

                    }
                    else
                    {
                        lblMessage.Text = "Excede la capacidad de carga del avion";
                    }
                }
            }
            else
            {
                if (pesoBulto > capacidaCarga)
                {
                    lblMessage.Text = "Excede la capacidad de carga del avion";
                }
                else
                {
                    if (pesoBulto > 500 && pesoBulto < capacidaCarga)
                    {
                        lblMessage.Text = "Excede los 500 Kg";
                    }
                    else
                    {
                        if (pesoBulto >= capacidaCarga)
                        {
                            lblMessage.Text = "Excede la capacidad de carga del avion";
                        }
                    }
                }

            }
        }
    }
}