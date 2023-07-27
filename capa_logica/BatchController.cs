using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capa_datos;

namespace capa_logica
{
    public static class BatchController
    {
        public static void Crear(int CantidadProductoLote)
        {
            DateTime FechaCreacion = DateTime.Now;
            ModelBatch lote = new ModelBatch();
            lote.FechaActual = FechaCreacion; ; // - > Fecha de creacion del lote
            lote.ProductsAmount = CantidadProductoLote;
            lote.Save();
        }

        public static DataTable Obtener()
        {
            ModelBatch LotsTableModel = new ModelBatch();
            List<ModelBatch> lotes = LotsTableModel.TodosLosItems();
            DataTable table = new DataTable();
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("Fecha de creacion", typeof(string));
            table.Columns.Add("Cantidad de productos en lote", typeof(string));

            foreach (ModelBatch lote in lotes)
            {
                DataRow row = table.NewRow();
                row["id"] = lote.Id;
                row["Fecha de creacion"] = lote.FechaActual;
                row["Cantidad de productos en lote"] = lote.ProductsAmount;
                table.Rows.Add(row);
            }
            return table;
        }
        public static void EliminarLote(int id)
        {
            ModelBatch lote = new ModelBatch();
            lote.Id = id;
            lote.Delete();
        }
    }
}
