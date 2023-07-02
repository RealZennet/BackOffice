using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_datos
{
    class ModelProductos:DataBaseControl
    {
        public string NombreProducto { get; set; }
        public int PesoProducto { get; set; }
        public int CantidadProducto { get; set; }
        public string DescripcionProducto { get; set; }

        public void Save()
        {
            this.Command.CommandText = $"INSERT INTO producto(nombre, precio) VALUES(" +
                $"'{this.NombreProducto}', " +
                $"{this.PesoProducto}, " +
                $"{this.CantidadProducto}, " +
                $"'{this.DescripcionProducto}')";
            this.Command.ExecuteNonQuery();
        }
    }
}
