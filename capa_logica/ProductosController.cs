using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capa_datos;

namespace capa_logica
{
    public static class ProductosController
    {
        public static void Crear(string nombre,  int pesoproducto, int cantidadproducto, string descripcion)
        {
            ModelProductos producto = new ModelProductos();
            producto.NombreProducto = nombre;
            producto.PesoProducto = pesoproducto;
            producto.CantidadProducto = cantidadproducto;
            producto.DescripcionProducto = descripcion;
            producto.Save();
        }

        public static DataTable Obtener()
        {
            ModelProductos ProductTableModel = new ModelProductos();
            List<ModelProductos> productos = ProductTableModel.TodosLosItems();

            DataTable table = new DataTable();
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("nombre", typeof(string));
            table.Columns.Add("Descripcion", typeof(string));
            table.Columns.Add("Peso producto", typeof(int));
            table.Columns.Add("Cantidad Producto", typeof(int));

            foreach (ModelProductos producto in productos)
            {
                DataRow row = table.NewRow();
                row["id"] = producto.Id;
                row["nombre"] = producto.NombreProducto;
                row["Descripcion"] = producto.DescripcionProducto;
                row["Peso producto"] = producto.PesoProducto;
                row["Cantidad producto"] = producto.CantidadProducto;
                table.Rows.Add(row);
            }
            return table;
        }
        public static void EliminarProducto(int id)
        {
            ModelProductos producto = new ModelProductos();
            producto.Id = id;
            producto.Delete();
        }
    }
}
