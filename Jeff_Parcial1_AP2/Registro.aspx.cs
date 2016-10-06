using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;

namespace Jeff_Parcial1_AP2
{
    public partial class Registro : System.Web.UI.Page
    {
        Registros registro = new Registros();
        int id = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[2] { new DataColumn("Material"), new DataColumn("Cantidad") });
                
            }
        }

        private void Limpiar()
        {
            ((TextBox)IdTextBox).Text = string.Empty;
            ((TextBox)RazonTextBox).Text = string.Empty;
            ((TextBox)MaterialTextBox).Text = string.Empty;
            ((TextBox)CantidadTextBox).Text = string.Empty;
            MaterialesGridView.DataSource = null;
        }

        private void ObtenerValores()
        {
            int.TryParse(RazonTextBox.Text, out id);
            registro.RegistroId = id;
            registro.Razon = RazonTextBox.Text;
            foreach (GridViewRow var in MaterialesGridView.Rows)
            {
                
            }
        }

        private void DevolverValores()
        {
            IdTextBox.Text = registro.RegistroId.ToString();
            RazonTextBox.Text = registro.Razon.ToString();
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            try
            {
                ObtenerValores();
                if (IdTextBox.Text =="")
                {
                    Response.Write("<script>alert('Debe insertar un Id')</script>");
                }
                else
                {
                    if (registro.Buscar(registro.RegistroId))
                    {
                        DevolverValores();
                    }
                    else
                    {
                        Response.Write("<script>alert('Error al buscar')</script>");
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void AgregarButton_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            try
            {
                ObtenerValores();
                if (IdTextBox.Text=="")
                {
                    if (RazonTextBox.Text != "")
                    {
                        if (registro.Insertar())
                        {
                            Response.Write("<script>alert('Insertado correctamente')</script>");
                            Limpiar();
                        }
                        else
                        {
                            Response.Write("<script>alert('Error al insertar')</script>");
                        }
                    }
                    else
                    {
                        Response.Write("<script>alert('Debe llenar la razon')</script>");
                    }
                }
                else
                {
                    if (RazonTextBox.Text != "")
                    {
                        if (registro.Editar())
                        {
                            Response.Write("<script>alert('Modificado correctamente')</script>");
                            Limpiar();
                        }
                        else
                        {
                            Response.Write("<script>alert('Error al Modificar')</script>");
                        }
                    }
                    else
                    {
                        Response.Write("<script>alert('Debe llenar la razon')</script>");
                    }
                }
                    
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            try
            {
                ObtenerValores();
                if (IdTextBox.Text == "")
                {
                    Response.Write("<script>alert('Debe insertar un Id')</script>");
                }
                else
                {
                    if (registro.Eliminar())
                    {
                        Response.Write("<script>alert('Eliminado correctamente')</script>");
                        Limpiar();
                    }
                    else
                    {
                        Response.Write("<script>alert('Error al eliminar')</script>");
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}