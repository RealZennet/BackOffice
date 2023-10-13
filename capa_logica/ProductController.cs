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
        public static void Crear(int productweight,  int productvolume, string street, int doornumber, string corner, string customer, bool activeproduct)
        {
            try
            {

            ModelProduct product = new ModelProduct();
            product.ProductWeight = productweight;
            product.Volume = productvolume;
            product.DoorNumber = doornumber;
            product.Corner = corner;
            product.Customer = customer;
            product.ActivatedProduct = activeproduct;
            product.Save();
            }
            catch(Exception ex)
            {
                throw new Exception("Error");
            }
        }

        public static DataTable Obtener()
        {
            ModelProduct ProductTableModel = new ModelProduct();
            List<ModelProduct> products = ProductTableModel.GetAllProducts();

            DataTable table = new DataTable();
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("Peso", typeof(int));
            table.Columns.Add("Volumen", typeof(int));
            table.Columns.Add("Numero puerta", typeof(int));
            table.Columns.Add("Esquina", typeof(string));
            table.Columns.Add("Cliente", typeof(string));
            table.Columns.Add("Activo", typeof(bool));

            foreach (ModelProduct product in products)
            {
                DataRow row = table.NewRow();
                row["id"] = product.IDProduct;
                row["Peso"] = product.ProductWeight;
                row["Volumen"] = product.Volume;
                row["Numero puerta"] = product.DoorNumber;
                row["Esquina"] = product.Corner;
                row["Cliente"] = product.Customer;
                row["Activo"] = product.ActivatedProduct;
                table.Rows.Add(row);
            }
            return table;
        }
        public static void EliminarProducto(int id)
        {
            ModelProduct producto = new ModelProduct();
            producto.IDProduct = id;
            producto.Delete();
        }
    }
}
