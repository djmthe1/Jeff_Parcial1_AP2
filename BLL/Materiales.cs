using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Materiales
    {
        public int Id { get; set; }
        public int RegistroId { get; set; }
        public string Material { get; set; }
        public int Cantidad { get; set; }

        public Materiales(int registroId, string material, int cantidad)
        {
            this.RegistroId = registroId;
            this.Material = material;
            this.Cantidad = cantidad;
        }

        public Materiales()
        {

        }
    }
}
