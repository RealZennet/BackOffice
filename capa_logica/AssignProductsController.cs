using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capa_datos;

namespace capa_logica
{
    public class AssignProductsController
    {
        public static void Crear(int IdProduct, int IdBatch)
        {
            AssignProductsModel assignedProduct = new AssignProductsModel();
            assignedProduct.IDProduct = IdProduct;
            assignedProduct.IDBatch = IdBatch;
            assignedProduct.Save();
        }

        public static DataTable Obtener()
        {
            AssignProductsModel AssignedProductsTableModel = new AssignProductsModel();
            List<AssignProductsModel> lotes = AssignedProductsTableModel.TodosLosItems();
            DataTable table = new DataTable();
            table.Columns.Add("Lote ID", typeof(int));
            table.Columns.Add("Producto ID", typeof(string));

            foreach (AssignProductsModel AssignedProducts in lotes)
            {
                DataRow row = table.NewRow();
                row["Lote ID"] = AssignedProducts.IDBatch;
                row["Producto ID"] = AssignedProducts.IDProduct;
                table.Rows.Add(row);
            }
            return table;
        }
        public static void DeleteAssignedProduct(int id)
        {
            AssignProductsModel AssignedProduct = new AssignProductsModel();
            AssignedProduct.IDBatch = id; 
            AssignedProduct.Delete();
        }
    }
}
