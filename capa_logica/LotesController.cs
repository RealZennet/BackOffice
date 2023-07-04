using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capa_datos;

namespace capa_logica
{
    public static class LotesController
    {
        public static void Crear(int CantidadProductoLote)
        {
            DateTime FechaCreacion = DateTime.Now;
            ModelLotes lote = new ModelLotes();
            lote.FechaActual = FechaCreacion; ; // - > Fecha de creacion del lote
            lote.CantidadProductoLote = CantidadProductoLote;
            lote.Save();
        }

        public static DataTable Obtener()
        {
            ModelLotes LotsTableModel = new ModelLotes();
            List<ModelLotes> lotes = LotsTableModel.TodosLosItems();
            DataTable table = new DataTable();
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("Fecha de creacion", typeof(string));
            table.Columns.Add("Cantidad de productos en lote", typeof(string));

            foreach (ModelLotes lote in lotes)
            {
                DataRow row = table.NewRow();
                row["id"] = lote.Id;
                row["Fecha de creacion"] = lote.FechaActual;
                row["Cantidad de productos en lote"] = lote.CantidadProductoLote;
                table.Rows.Add(row);
            }
            return table;
        }
        public static void EliminarLote(int id)
        {
            ModelLotes lote = new ModelLotes();
            lote.Id = id;
            lote.Delete();
        }
    }
}
