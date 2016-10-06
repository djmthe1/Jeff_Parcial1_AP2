using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class Registros : ClaseMaestra
    {
        public int RegistroId { get; set; }
        public string Razon { get; set; }
        public List<Materiales> materiales { get; set; }

        public Registros(int id, string razon)
        {
            this.RegistroId = id;
            this.Razon = razon;
        }

        public Registros()
        {
            materiales = new List<Materiales>();
        }

        public void AgregarMateriales(int registroId, string material, int cantidad)
        {
            materiales.Add(new Materiales (registroId, material, cantidad));
        }

        public override bool Insertar()
        {
            ConexionDb conexion = new ConexionDb();
            int retorno = 0;
            object Identity;
            try
            {
                Identity = conexion.ObtenerValor(string.Format("INSERT INTO Registros (Razon) VALUES ('{0}') SELECT @@Identity", this.Razon));
                int.TryParse(Identity.ToString(), out retorno);
                if (retorno > 0)
                {
                    foreach (var material in materiales)
                    {
                        conexion.Ejecutar(string.Format("INSERT INTO Materiales VALUES (RegistroId, Material, Cantidad)", retorno, material.Material, material.Cantidad));
                    }
                }
                return retorno > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override bool Editar()
        {
            ConexionDb conexion = new ConexionDb();
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(string.Format("UPDATE Registros SET Razon='{0}' WHERE RegistroId={1}", this.Razon, this.RegistroId));
                if (retorno)
                {
                    conexion.Ejecutar(string.Format("DELETE FROM Materiales WHERE RegistroId={0}", this.RegistroId));
                    foreach (var material in materiales)
                    {
                        conexion.Ejecutar(string.Format("INSERT INTO Materiales VALUES (RegistroId, Material, Cantidad)", RegistroId, material.Material, material.Cantidad));
                    }
                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override bool Eliminar()
        {
            ConexionDb conexion = new ConexionDb();
            bool retorno;
            try
            {
                retorno = conexion.Ejecutar(string.Format("DELETE FROM Registros WHERE RegistroId={0}", this.RegistroId));
                if (retorno)
                {
                    conexion.Ejecutar(string.Format("DELETE FROM Materiales WHERE RegistroId={0}", this.RegistroId));
                }
                return retorno;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override bool Buscar(int IdBuscado)
        {
            ConexionDb conexion = new ConexionDb();
            DataTable dt = new DataTable();
            DataTable dtMateriales = new DataTable();

            try
            {
                dt = conexion.ObtenerDatos(string.Format("SELECT * FROM Registros WHERE RegistroId={0}", this.RegistroId));
                if (dt.Rows.Count > 0)
                {
                    this.RegistroId = (int)dt.Rows[0]["RegistroId"];
                    this.Razon = dt.Rows[0]["Razon"].ToString();

                    dtMateriales = conexion.ObtenerDatos(string.Format("SELECT * FROM Materiales WHERE RegistroId={0}", this.RegistroId));
                    foreach (DataRow var in dtMateriales.Rows)
                    {
                        this.AgregarMateriales((int)var["RegistroId"], var["Material"].ToString(), (int)var["Cantidad"]);
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return dt.Rows.Count > 0;
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            ConexionDb conexion = new ConexionDb();
            throw new NotImplementedException();
        }
    }
}
