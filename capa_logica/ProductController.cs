using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capa_datos;

namespace capa_logica
{
    public static class ProductController
    {
        public static void Crear(string nombre,  int pesoproducto, int cantidadproducto, string descripcion)
        {
            ModelProduct producto = new ModelProduct();
            producto.NombreProducto = nombre;
            producto.PesoProducto = pesoproducto;
            producto.CantidadProducto = cantidadproducto;
            producto.DescripcionProducto = descripcion;
            producto.Save();
        }

        public static DataTable Obtener()
        {
            ModelProduct ProductTableModel = new ModelProduct();
            List<ModelProduct> productos = ProductTableModel.GetAllItems();

            DataTable table = new DataTable();
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("nombre", typeof(string));
            table.Columns.Add("Descripcion", typeof(string));
            table.Columns.Add("Peso producto", typeof(int));
            table.Columns.Add("Cantidad Producto", typeof(int));

            foreach (ModelProduct producto in productos)
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
            ModelProduct producto = new ModelProduct();
            producto.Id = id;
            producto.Delete();
        }
    }
}
